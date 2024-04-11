using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WebHMI.Dtos;
using WebHMI.Dtos.Roll;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
    public class RollAppService : ApplicationServiceBase
    {
        private static readonly Timer _cooldownTimerRefresh = new(500);
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IL2Sender _l2Sender;
        private readonly ISignalRNotifier _signalRNotifier;

        public RollAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IL2Sender l2Sender,
            ISignalRNotifier signalRNotifier)
        {
            _prdbContextProvider = prdbContextProvider;
            _l2Sender = l2Sender;
            _signalRNotifier = signalRNotifier;
        }

        #region Roll

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<SingleRollDetailsDto> CreateRoll(SingleRollDetailsDto rollDto)
        {
            bool rollDataExist = await _prdbContext.RollData.AsNoTracking().AnyAsync(x => x.RollId == rollDto.Rollid && x.PlantType == rollDto.Planttype.ToString());

            if (rollDataExist)
                throw new UserFriendlyException("Die Walze existiert bereits. Bitte verwenden Sie einen eindeutigen Namen.");

            if (rollDto.Rollid.Length < 6)
                throw new UserFriendlyException("Invalid parameter 'Rollid' (min. 6 characters required)");

            var rollData = rollDto.ToRollDetailsEntity();

            try
            {
                _prdbContext.RollData.Add(rollData);
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while Roll creation:", ex);
                throw new UserFriendlyException("Bei der Erzeugung / Beim Speichern von Walzendaten in der Datenbank ist ein Fehler aufgetreten." + ex.Message);
            }

            return await GetRollDetailsById(rollDto.Rollid, rollDto.Planttype);
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<SingleRollDataCoreDto>> GetAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.HmiVRollInventories
                    .OrderByDescending(t => t.RollId),
                input,
                RollMapper.ToRollDataCoreDto);
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<SingleRollDetailsDto> GetRollDetailsById(string rollId, string planttype)
        {
            SingleRollDetailsDto result = new();

            try
            {
                var rollInventory = await _prdbContext.HmiVRollInventories.FirstOrDefaultAsync(x => x.RollId == rollId && x.PlantType == planttype.ToString());

                if (rollInventory is null)
                    throw new UserFriendlyException("Roll not found in database");

                result = rollInventory.ToRollDetailsDto();

                // Map shape coefficients
                result.ShapeCoeffArray = [];
                var shapeCoeffData = await _prdbContext.RollShapeCoeffs.FirstOrDefaultAsync(x => x.ShapeCode == rollInventory.Shapecode);

                if (shapeCoeffData is not null)
                {
                    result.ShapeDescription = shapeCoeffData.Description;
                    result.ShapeType = shapeCoeffData.ShapeType;
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX1 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX2 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX3 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX4 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX5 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX6 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX7 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX8 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.ShapeX9 ?? 0.0);
                }

                var rollClass = await _prdbContext.RollClasses.FirstOrDefaultAsync(x => x.RollClass1 == rollInventory.RollClass);
                if (rollClass is not null)
                    result.RollClassName = rollClass.Description;

                var rollProperty = await _prdbContext.RollProperties.FirstOrDefaultAsync(x => x.RollPropertyClass == rollInventory.RollPropertyClass);
                if (rollProperty is not null)
                    result.RollPropertyClassName = rollProperty.Description;
            }
            catch (Exception ex)
            {
                Logger.Error("GetRollDetailsById threw exception", ex);
                throw new UserFriendlyException($"Request GetRollDetailsById has thrown an exception. {ex.Message}");
            }

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<SingleRollDetailsDto> UpdateRoll(SingleRollDetailsDto rollDto)
        {
            var rollData = await _prdbContext.RollData.FirstOrDefaultAsync(x => x.RollId == rollDto.Rollid && x.PlantType == rollDto.Planttype.ToString());
            if (rollData is not null && rollData.Stat == "I")
                throw new UserFriendlyException("Es ist nicht erlaubt, die Eigenschaften von installierten Walze zu ändern.");

            rollData.MapRollDetailsEntity(rollDto);

            try
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while update of Roll data:", ex);
                throw new UserFriendlyException($"Exception occured druing updating Roll data in DB. {ex.Message}");
            }

            return await GetRollDetailsById(rollDto.Rollid, rollDto.Planttype);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Delete)]
        public async Task<bool> DeleteRoll(string rollId, string planttype)
        {
            var rollData = await _prdbContext.RollData.FirstOrDefaultAsync(x => x.RollId == rollId && x.PlantType == planttype.ToString());
            if (rollData is not null && rollData.Stat == "I")
                throw new UserFriendlyException("Es ist nicht erlaubt, die Eigenschaften von installierten Walze zu loeschen.");

            try
            {
                _prdbContext.RollData.Remove(rollData);
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while deleting roll:", ex);
                throw new UserFriendlyException($"Bei der Erstellung von Zylinderdaten in der Datenbank ist eine Ausnahme aufgetreten. {ex.Message}");
            }

            return true;
        }

        #endregion

        #region Roll Class

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollClassDto> CreateRollClass(RollClassDto rollClassDto)
        {
            bool rollClassExist = await _prdbContext.RollClasses.AnyAsync(t => t.RollClass1 == rollClassDto.RollClass);

            if (rollClassExist)
                throw new UserFriendlyException("Die angegebene ID ist bereits in Gebrauch");

            if (rollClassDto.Description.Length < 3)
                throw new UserFriendlyException("Die Beschreibung muss mindestens 3 Zeichen lang sein");

            var rollClass = rollClassDto.ToRollClassEntity();
            _prdbContext.RollClasses.Add(rollClass);

            try
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new UserFriendlyException($"{ex.Message} {ex.InnerException.Message}");
            }

            return rollClass.ToRollClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<RollClassDto> GetRollClassById(int id)
        {
            var rollClass = await _prdbContext.RollClasses.FirstOrDefaultAsync(x => x.RollClass1 == id);

            if (rollClass is null)
                throw new EntityNotFoundException(typeof(RollClass), id);

            return rollClass.ToRollClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollClassDto>> GetRollClassAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.RollClasses
                    .OrderBy(t => t.RollClass1),
                input,
                RollMapper.ToRollClassDto);
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollClassDto> UpdateRollClass(RollClassDto rollClassDto)
        {
            if (rollClassDto.Description.Length < 3)
                throw new UserFriendlyException("Die Beschreibung muss mindestens 3 Zeichen lang sein");

            var rollClass = await _prdbContext.RollClasses.FirstOrDefaultAsync(x => x.RollClass1 == rollClassDto.RollClass);

            if (rollClass is null)
                throw new EntityNotFoundException(typeof(RollClass), rollClassDto.RollClass);

            rollClass.MapRollClassEntity(rollClassDto);

            try
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new UserFriendlyException($"{ex.Message} {ex.InnerException.Message}");
            }

            return rollClass.ToRollClassDto();
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Delete)]
        public async Task DeleteRollClass(int input)
        {
            var rollData = await _prdbContext.RollClasses.Where(x => x.RollClass1 == input).ToListAsync();

            if (!rollData.Any())
                throw new UserFriendlyException("Die gegebene Klasse ist mit einer bestehenden Walzen verbunden und kann nicht gelöscht werden.");

            _prdbContext.RollClasses.RemoveRange(rollData);
        }

        #endregion

        #region Roll Chamfer

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollChamferDto> CreateRollChamfer(RollChamferDto rollChamferDto)
        {
            bool rollChamferExist = await _prdbContext.RollChamfers.AnyAsync(t => t.RollChamferClass == rollChamferDto.Rollchamferclass);

            if (rollChamferExist)
                throw new UserFriendlyException("Die angegebene ID ist bereits in Gebrauch");

            var rollChamfer = rollChamferDto.ToRollChamferEntity();
            _prdbContext.RollChamfers.Add(rollChamfer);

            try
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new UserFriendlyException($"{ex.Message} {ex.InnerException.Message}");
            }

            return rollChamfer.ToRollChamferDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<RollChamferDto> GetRollChamferById(int id)
        {
            var rollChamfer = await _prdbContext.RollChamfers.FirstOrDefaultAsync(x => x.RollChamferClass == id);

            if (rollChamfer is null)
                throw new EntityNotFoundException(typeof(RollChamfer), id);

            return rollChamfer.ToRollChamferDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollChamferDto>> GetRollChamferAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.RollChamfers
                    .OrderBy(t => t.RollChamferClass),
                input,
                RollMapper.ToRollChamferDto);
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollChamferDto> UpdateRollChamfer(RollChamferDto rollClassDto)
        {
            var rollChamfer = await _prdbContext.RollChamfers.FirstOrDefaultAsync(x => x.RollChamferClass == rollClassDto.Rollchamferclass);

            if (rollChamfer is null)
                throw new EntityNotFoundException(typeof(RollChamfer), rollClassDto.Rollchamferclass);

            rollChamfer.MapRollChamferEntity(rollClassDto);

            try
            {
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new UserFriendlyException($"{ex.Message} {ex.InnerException.Message}");
            }

            return rollChamfer.ToRollChamferDto();
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Delete)]
        public async Task DeleteRollChamfer(int id)
        {
            var rollData = await _prdbContext.RollChamfers.Where(x => x.RollChamferClass == id).ToListAsync();

            if (!rollData.Any())
                throw new UserFriendlyException("Die gegebene Klasse ist mit einer bestehenden Walzen verbunden und kann nicht gelöscht werden.");

            _prdbContext.RollChamfers.RemoveRange(rollData);
        }

        #endregion

        #region Roll Property

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollPropertyClassDto> CreateRollPropertyClass(RollPropertyClassDto rollPropertyClassDto)
        {
            var rollProperty = await _prdbContext.RollProperties.FirstOrDefaultAsync(t => t.RollPropertyClass == rollPropertyClassDto.RollPropertyClass);

            if (rollProperty is not null)
                throw new UserFriendlyException("Given id no already in use");

            if (rollPropertyClassDto.RollType is not null && rollPropertyClassDto.RollType.Length > 3)
                throw new UserFriendlyException("RollType can have maximum 3 characters");

            var newRollProperty = rollPropertyClassDto.ToRollPropertyEntity();

             _prdbContext.RollProperties.Add(newRollProperty);
            await CurrentUnitOfWork.SaveChangesAsync();

            return newRollProperty.ToRollPropertyClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<RollPropertyClassDto> GetRollPropertyClassById(int id)
        {
            var rollPropertyClass = await _prdbContext.RollProperties.FirstOrDefaultAsync(x => x.RollPropertyClass == id);

            if (rollPropertyClass is null)
                throw new EntityNotFoundException(typeof(RollPropertyClassDto), id);

            return rollPropertyClass.ToRollPropertyClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollPropertyClassDto>> GetRollPropertyClassAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.RollProperties
                    .OrderBy(t => t.RollPropertyClass),
                input,
                RollMapper.ToRollPropertyClassDto);
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollPropertyClassDto> UpdateRollPropertyClass(RollPropertyClassDto rollPropertyClassDto)
        {
            if (rollPropertyClassDto.RollType is not null && rollPropertyClassDto.RollType.Length > 3 || rollPropertyClassDto.PlantType is not null && rollPropertyClassDto.PlantType.Length > 3)
                throw new UserFriendlyException("RollType and PlantType can have maximum 3 characters");

            var rollProperty = await _prdbContext.RollProperties.FirstOrDefaultAsync(t => t.RollPropertyClass == rollPropertyClassDto.RollPropertyClass);

            if (rollProperty is null)
                throw new UserFriendlyException("Roll property not found");

            rollProperty.MapRollPropertyEntity(rollPropertyClassDto);
            await CurrentUnitOfWork.SaveChangesAsync();

            return rollProperty.ToRollPropertyClassDto();
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Delete)]
        public async Task DeleteRollPropertyClass(int input)
        {
            var rollData = await _prdbContext.RollData.FirstOrDefaultAsync(x => x.RollPropertyClass == input);

            if (rollData is not null)
                throw new UserFriendlyException("Given Rollpropertyclass has reference in RollData table and was not deleted");

            _prdbContext.RollProperties.RemoveRange(_prdbContext.RollProperties.Where(x => x.RollPropertyClass == input));
        }

        #endregion

        #region Roll Shape Code

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<ShapeCodeDto> GetShapeCodeById(int id)
        {
            var shape = await _prdbContext.RollShapeCoeffs.FirstOrDefaultAsync(x => x.ShapeCode == id);

            if (shape is null)
                throw new EntityNotFoundException(typeof(RollShapeCoeff), id);

            return shape.ToShapeCodeDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<ShapeCodeDto>> GetShapeCodeAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.RollShapeCoeffs
                    .OrderBy(t => t.ShapeCode),
                input,
                RollMapper.ToShapeCodeDto);
        }

        #endregion

        /// <param name="rollId">Unique Roll Id </param>
        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<SingleRollDataCoreDto> GetRollDataCoreById(string rollId, string planttype)
        {
            try
            {
                var rollData = await _prdbContext.RollData.FirstOrDefaultAsync(x => x.RollId == rollId && x.PlantType == planttype);
                if (rollData is null)
                    throw new UserFriendlyException("Roll data not found");

                return rollData.ToRollDataCoreDto();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while getting roll data:", ex);
                throw new UserFriendlyException($"Exception occured druing reading Roll data. {ex.Message}");
            }
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<SingleRollDataCoreDto> GetRollDataByPosition(string plantType, int standId, string rollType, string rollPos, string rollStatus)
        {
            if (plantType is null || rollType is null || rollPos is null)
                throw new UserFriendlyException("Die Parameter 'standId', 'plantType', 'rollType', 'rollStatus' und 'rollPos' müssen angegeben werden");

            SingleRollDataCoreDto result = new SingleRollDataCoreDto();
            try
            {
                HmiVRollInventory rollData = await _prdbContext.HmiVRollInventories.FirstOrDefaultAsync(x => x.PlantType == plantType && x.StandId == standId && x.RollType == rollType && x.RollPos == rollPos && x.Stat == rollStatus);
                if (rollData is not null)
                {
                    result = rollData.ToRollDataCoreDto();
                }
                else
                {
                    result.Standid = standId;
                    result.Rollpos = rollPos;
                    result.Rolltype = rollType;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("GetRollDataByPosition threw exception", ex);
                throw new UserFriendlyException($"Request GetRollDataByPosition has thrown an exception. {ex.Message}");
            }

            return result;
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public Task<PagedResultDto<SingleRollDataCoreDto>> GetAvailableRolls(FilteredRequestDto input, bool onlyPlannedByRS, string plantType, string rollType, int? standId, string rollPos)
        {
            if (onlyPlannedByRS == true && (standId is null || rollPos == string.Empty || rollPos is null))
                throw new UserFriendlyException($"Wenn der Parameter '{nameof(onlyPlannedByRS)}' true ist, dann müssen auch '{nameof(standId)}' und '{nameof(rollPos)}' angegeben werden");

            List<SingleRollDataCoreDto> dto = new List<SingleRollDataCoreDto>();
            try
            {
                if (onlyPlannedByRS == false)
                {
                    return ApplyFilter(
                        _prdbContext.HmiVRollInventories
                           .Where(z => z.PlantType == plantType && z.RollType == rollType && (z.Stat == null || z.Stat == "R"))
                           .OrderByDescending(t => t.RollId),
                       input,
                       RollMapper.ToRollDataCoreDto);

                    //if (availableRolls is not null)
                    //{
                    //    foreach (HmiVRollInventory roll in availableRolls)
                    //    {
                    //        SingleRollDataCoreDto oneRollDto = new SingleRollDataCoreDto();
                    //        ObjectMapper.Map(roll, oneRollDto);
                    //        dto.Add(oneRollDto);
                    //    }
                    //}
                    //return Task.FromResult(dto);
                }
                else
                {
                    return ApplyFilter(
                        _prdbContext.HmiVRollInventories
                            .Where(z => z.PlantType == plantType && z.RollType == rollType && (z.Stat == null || z.Stat == "R") && z.PlannedRollPos == rollPos && z.PlannedStandId == standId)
                            .OrderByDescending(t => t.RollId),
                        input,
                        RollMapper.ToRollDataCoreDto);

                    //List<HmiVRollInventory> availableRolls = _rollInventory
                    //       .GetAll().Where(z => z.Planttype == plantType && z.Rolltype == rollType && (z.Stat is null || z.Stat == "R") && z.Plannedrollpos == rollPos && z.Plannedstandid == standId)
                    //       .OrderBy(t => t.Rollid).ToList();

                    //if (availableRolls is not null)
                    //{
                    //    foreach (HmiVRollInventory roll in availableRolls)
                    //    {
                    //        SingleRollDataCoreDto oneRollDto = new SingleRollDataCoreDto();
                    //        ObjectMapper.Map(roll, oneRollDto);
                    //        dto.Add(oneRollDto);
                    //    }
                    //}
                    //return Task.FromResult(dto);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while getting roll data:", ex);
                throw new UserFriendlyException($"Exception occured druing reading Roll data. {ex.Message}");
            }
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<SingleRollDataCoreDto> ScheduleRollForRollNextChange(string rollId, [FromQuery] PlantType plantType, int standId, string rollType, string rollPos, float? diameter, float? shimm)
        {
            if ((rollType != "BUR" && rollType != "WKR" && rollType != "EWR") || rollType is null)
                throw new UserFriendlyException("Der Parameter 'rollType' ist ungültig.");

            if ((rollPos != "U" && rollPos != "L" && rollPos != "O" && rollPos != "D") || rollPos is null)
                throw new UserFriendlyException("Der Parameter 'rollPos' ist ungültig.");

            try
            {
                //clear any previous planned roll on this position
                var rollDataCheck = await _prdbContext.RollData.FirstOrDefaultAsync(x => x.PlantType == plantType.ToString() && x.RollType == rollType && x.StandId == standId && x.RollPos == rollPos && x.Stat == "P");
                if (rollDataCheck is not null)
                {
                    rollDataCheck.Stat = null;
                    Logger.Info($"Roll {rollDataCheck.RollId} has been cleared from Planned status.");
                }

                if (!string.IsNullOrWhiteSpace(rollId))
                {
                    var rollData = await _prdbContext.RollData.FirstOrDefaultAsync(x => x.RollId == rollId && x.PlantType == plantType.ToString());
                    if (rollData is null)
                        throw new UserFriendlyException("Unbekannte Walze.");

                    if (rollData.Stat == "I")
                        throw new UserFriendlyException("Es ist nicht erlaubt, die Eigenschaften von installierten Walze zu ändern.");

                    rollData.Stat = "P";
                    rollData.StandId = standId;
                    rollData.RollPos = rollPos;
                    rollData.Shimm = shimm;

                    if (diameter is not null)
                        rollData.Diameter = diameter.Value;

                    Logger.Info($"Roll {rollData.RollId} has been Planned for next roll change.");
                }

                await CurrentUnitOfWork.SaveChangesAsync();

                if (_cooldownTimerRefresh.Enabled)
                {
                    Logger.Info($"Refresh timer start suppressed, already started");
                }
                else
                {
                    await SendRollRefresh(plantType);
                }

                //read roll data from DB after update to initialize return DTO
                HmiVRollInventory rollDataAfterUpdate = await _prdbContext.HmiVRollInventories.FirstOrDefaultAsync(x => x.RollId == rollId && x.PlantType == plantType.ToString());
                return rollDataAfterUpdate?.ToRollDataCoreDto();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while setting status of a roll. ", ex);
                throw new UserFriendlyException($"Exception while setting status of a roll. {ex.Message}");
            }
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task DoEmergencyRollChange(string connectionId, EmergencyRollChangeDto input)
        {
            if (input?.PlantItemsToRollChange is null || input.PlantItemsToRollChange.Count == 0)
                throw new UserFriendlyException("Request is empty. Please provide valid input arguments");

            throw new NotImplementedException("L2 call not implemented");

            //foreach (var plantItem in input.PlantItemsToRollChange)
            //    _l2Sender.DoEmergencyRollChange(input.PlantType, plantItem, connectionId);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task SendActualStandData(string connectionId, SendActualStandDataDto input, short rollType)//rollType 0: installed ,rollType 1:planned
        {
            throw new NotImplementedException("L2 call not implemented");
            //foreach (var plantItem in input.PlantItemsToSend.Where(x => x.Status == 1))
            //    _l2Sender.SendActualStandData(input.PlantType, plantItem, rollType, connectionId);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task SendRollDataRequest(string connectionId, string rollId, string rollType, string plantType, string rollPosition, int? standId)
        {
            int[] validStands = { 0, 1, 2, 3, 4, 5, 6, 100 };
            if (plantType != "HRM" && plantType != "HFM" && !(plantType is null || plantType == String.Empty))
                throw new UserFriendlyException("Bitte geben Sie einen gültigen Parameter 'plantType' an. Muss 'FM' oder 'RM' sein oder leer bleiben.");

            if (rollType != "WKR" && rollType != "BUR" && rollType != "EWR" && !(rollType is null || rollType == String.Empty))
                throw new UserFriendlyException("Bitte geben Sie einen gültigen Parameter 'rollType' an. Muss 'WKR', 'BUR', 'EWR' sein oder leer bleiben.");

            if (standId is not null && !validStands.Contains(standId ?? 0))
                //if (standId <0 || standId > 7 )
                throw new UserFriendlyException("Bitte geben Sie einen gültigen Parameter 'standId' an. Muss ein Wert zwischen 0 und 7 oder 100 sein oder leer bleiben.");

            if (rollPosition != "L" && rollPosition != "U" && rollPosition != "D" && rollPosition != "O" && !(rollPosition is null || rollType == String.Empty))
                throw new UserFriendlyException("Bitte geben Sie einen gültigen Parameter 'rollPosition' an. Muss den Wert 'L','U','D','O' haben oder leer bleiben.");

            throw new NotImplementedException("L2 call not implemented");
            //_l2Sender.RollDataRequest(rollId, standId, rollType, rollPosition, plantType, connectionId);
        }

        /// <summary>
        /// Send roll refresh event to UI with cooldown timers
        /// </summary>
        private async Task SendRollRefresh(PlantType plantType)
        {
            string plantEvent = plantType switch
            {
                PlantType.HFM => "ROLLDFM",
                PlantType.HRM => "ROLLDRM",
                _ => throw new NotImplementedException("Plant type refresh not handled")
            };

            Logger.Info($"Refresh timer '{plantEvent}' started");
            _cooldownTimerRefresh.Elapsed += CooldownTimer;
            _cooldownTimerRefresh.Start();

            Logger.Info($"Sending refresh for a key '{plantEvent}'");
            await _signalRNotifier.BroadcastToAllClientsAsync(DateTime.UtcNow, plantEvent);
        }

        private void CooldownTimer(object sender, ElapsedEventArgs args)
        {
            _cooldownTimerRefresh.Stop();
            _cooldownTimerRefresh.Elapsed -= CooldownTimer;
        }
    }
}
