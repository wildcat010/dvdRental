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
using System.Threading.Tasks;
using System.Timers;
using WebHMI.Application.Dtos.Roll;
using WebHMI.Dtos;
using WebHMI.Dtos.Roll;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.Mapping.Extensions;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

#pragma warning disable RS0030

namespace WebHMI.Services
{
    public class RollAppService : ApplicationServiceBase
    {
        private static readonly Timer _cooldownTimerRefresh = new(500);
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IL2CommunicationHandler _l2Sender;
        private readonly ISignalRNotifier _signalRNotifier;

        public RollAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IL2CommunicationHandler l2Sender,
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
            bool rollDataExist = await _prdbContext.Rolldata.AsNoTracking().AnyAsync(x => x.Rollid == rollDto.Rollid && x.Planttype == rollDto.Planttype);

            if (rollDataExist)
                throw new UserFriendlyException("The roller already exists. Please use a unique name.");

            if (rollDto.Rollid.Length < 6)
                throw new UserFriendlyException("Invalid parameter 'Rollid' (min. 6 characters required)");

            var rollData = rollDto.ToRollDetailsEntity();

            try
            {
                _prdbContext.Rolldata.Add(rollData);
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while Roll creation:", ex);
                throw new UserFriendlyException("An error occurred while generating/saving roll data in the database." + ex.Message);
            }

            return await GetRollDetailsById(rollDto.Rollid, rollDto.Planttype);
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<SingleRollDataCoreDto>> GetAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.HmiVRollInventories
                    .OrderByDescending(t => t.Rollid),
                input,
                RollMapper.ToRollDataCoreDto);
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<SingleRollDetailsDto> GetRollDetailsById(string rollId, string planttype)
        {
            SingleRollDetailsDto result = new();

            try
            {
                var rollInventory = await _prdbContext.HmiVRollInventories.FirstOrDefaultAsync(x => x.Rollid == rollId && x.Planttype == planttype.ToString());

                if (rollInventory is null)
                    throw new UserFriendlyException("Roll not found in database");

                result = rollInventory.ToRollDetailsDto();

                // Map shape coefficients
                result.ShapeCoeffArray = [];
                var shapeCoeffData = await _prdbContext.Rollshapecoeffs.FirstOrDefaultAsync(x => x.Shapecode == rollInventory.Shapecode);

                if (shapeCoeffData is not null)
                {
                    result.ShapeDescription = shapeCoeffData.Description;
                    result.ShapeType = shapeCoeffData.Shapetype;
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex1 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex2 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex3 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex4 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex5 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex6 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex7 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex8 ?? 0.0);
                    result.ShapeCoeffArray.Add(shapeCoeffData.Shapex9 ?? 0.0);
                }

                var rollClass = await _prdbContext.Rollclasses.FirstOrDefaultAsync(x => x.Rollclass1 == rollInventory.Rollclass);
                if (rollClass is not null)
                    result.RollClassName = rollClass.Description;

                var rollProperty = await _prdbContext.Rollproperties.FirstOrDefaultAsync(x => x.Rollpropertyclass == rollInventory.Rollpropertyclass);
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
            var rollData = await _prdbContext.Rolldata.FirstOrDefaultAsync(x => x.Rollid == rollDto.Rollid && x.Planttype == rollDto.Planttype.ToString());
            if (rollData is not null && rollData.Stat == "I")
                throw new UserFriendlyException("It is not permitted to change the properties of installed rollers.");

            rollData.Rollid = rollDto.Rollid;
            rollData.Rolltype = rollDto.Rolltype;
            rollData.Planttype = rollDto.Planttype;
            rollData.Diameter = rollDto.Diameter;
            rollData.Rollclass = rollDto.Rollclass;
            rollData.Rollpropertyclass = rollDto.RollPropertyClass;
            rollData.Roughness = rollDto.Roughness;
            rollData.Rollshapecode = rollDto.ShapeCode;
            rollData.Grinding = rollDto.Grinding;
            rollData.Rollpos = rollDto.Rollpos;
            rollData.Rollchamfercode = rollDto.RollChamferClassId;
            rollData.Stat = rollDto.Stat;
            rollData.Shimm = rollDto.Shimm;
            //rollData.DismountTime = dto.Dismounttime;
            rollData.Relatedrollid = rollDto.RelatedRollid;

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
            var rollData = await _prdbContext.Rolldata.FirstOrDefaultAsync(x => x.Rollid == rollId && x.Planttype == planttype.ToString());
            if (rollData is not null && rollData.Stat == "I")
                throw new UserFriendlyException("It is not permitted to delete the properties of installed rollers.");

            try
            {
                _prdbContext.Rolldata.Remove(rollData);
                await CurrentUnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error($"[RollData] Exception while deleting roll:", ex);
                throw new UserFriendlyException($"An exception occurred while creating roll data in the database. {ex.Message}");
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
            bool rollClassExist = await _prdbContext.Rollclasses.AnyAsync(t => t.Rollclass1 == rollClassDto.RollClass);

            if (rollClassExist)
                throw new UserFriendlyException("The specified ID is already in use.");

            if (rollClassDto.Description.Length < 3)
                throw new UserFriendlyException("The description must be at least 3 characters long.");

            var rollClass = rollClassDto.ToRollClassEntity();
            _prdbContext.Rollclasses.Add(rollClass);

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
            var rollClass = await _prdbContext.Rollclasses.FirstOrDefaultAsync(x => x.Rollclass1 == id);

            if (rollClass is null)
                throw new EntityNotFoundException(typeof(Rollclass), id);

            return rollClass.ToRollClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollClassDto>> GetRollClassAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.Rollclasses
                    .OrderBy(t => t.Rollclass1),
                input,
                RollMapper.ToRollClassDto);
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollClassDto> UpdateRollClass(RollClassDto rollClassDto)
        {
            if (rollClassDto.Description.Length < 3)
                throw new UserFriendlyException("The description must be at least 3 characters long.");

            var rollClass = await _prdbContext.Rollclasses.FirstOrDefaultAsync(x => x.Rollclass1 == rollClassDto.RollClass);

            if (rollClass is null)
                throw new EntityNotFoundException(typeof(Rollclass), rollClassDto.RollClass);

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
            var rollData = await _prdbContext.Rollclasses.Where(x => x.Rollclass1 == input).ToListAsync();

            if (!rollData.Any())
                throw new UserFriendlyException("The given class is linked to an existing roller and cannot be deleted.");

            _prdbContext.Rollclasses.RemoveRange(rollData);
        }

        #endregion

        #region Roll Chamfer

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollChamferDto> CreateRollChamfer(RollChamferDto rollChamferDto)
        {
            bool rollChamferExist = await _prdbContext.Rollchamfers.AnyAsync(t => t.Rollchamferclass == rollChamferDto.Rollchamferclass);

            if (rollChamferExist)
                throw new UserFriendlyException("The specified ID is already in use.");

            var rollChamfer = rollChamferDto.ToRollChamferEntity();
            _prdbContext.Rollchamfers.Add(rollChamfer);

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
            var rollChamfer = await _prdbContext.Rollchamfers.FirstOrDefaultAsync(x => x.Rollchamferclass == id);

            if (rollChamfer is null)
                throw new EntityNotFoundException(typeof(Rollchamfer), id);

            return rollChamfer.ToRollChamferDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollChamferDto>> GetRollChamferAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.Rollchamfers
                    .OrderBy(t => t.Rollchamferclass),
                input,
                RollMapper.ToRollChamferDto);
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollChamferDto> UpdateRollChamfer(RollChamferDto rollClassDto)
        {
            var rollChamfer = await _prdbContext.Rollchamfers.FirstOrDefaultAsync(x => x.Rollchamferclass == rollClassDto.Rollchamferclass);

            if (rollChamfer is null)
                throw new EntityNotFoundException(typeof(Rollchamfer), rollClassDto.Rollchamferclass);

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
            var rollData = await _prdbContext.Rollchamfers.Where(x => x.Rollchamferclass == id).ToListAsync();

            if (!rollData.Any())
                throw new UserFriendlyException("The given class is linked to an existing roller and cannot be deleted.");

            _prdbContext.Rollchamfers.RemoveRange(rollData);
        }

        #endregion

        #region Roll Property

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollPropertyClassDto> CreateRollPropertyClass(RollPropertyClassDto rollPropertyClassDto)
        {
            var rollProperty = await _prdbContext.Rollproperties.FirstOrDefaultAsync(t => t.Rollpropertyclass == rollPropertyClassDto.RollPropertyClass);

            if (rollProperty is not null)
                throw new UserFriendlyException("Given id is already in use");

            if (rollPropertyClassDto.RollType is not null && rollPropertyClassDto.RollType.Length > 3)
                throw new UserFriendlyException("RollType can have maximum 3 characters");

            var newRollProperty = rollPropertyClassDto.ToRollPropertyEntity();

             _prdbContext.Rollproperties.Add(newRollProperty);
            await CurrentUnitOfWork.SaveChangesAsync();

            return newRollProperty.ToRollPropertyClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<RollPropertyClassDto> GetRollPropertyClassById(int id)
        {
            var rollPropertyClass = await _prdbContext.Rollproperties.FirstOrDefaultAsync(x => x.Rollpropertyclass == id);

            if (rollPropertyClass is null)
                throw new EntityNotFoundException(typeof(RollPropertyClassDto), id);

            return rollPropertyClass.ToRollPropertyClassDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollPropertyClassDto>> GetRollPropertyClassAll(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.Rollproperties
                    .OrderBy(t => t.Rollpropertyclass),
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

            var rollProperty = await _prdbContext.Rollproperties.FirstOrDefaultAsync(t => t.Rollpropertyclass == rollPropertyClassDto.RollPropertyClass);

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
            var rollData = await _prdbContext.Rolldata.FirstOrDefaultAsync(x => x.Rollpropertyclass == input);

            if (rollData is not null)
                throw new UserFriendlyException("Given Rollpropertyclass has reference in RollData table and was not deleted");

            _prdbContext.Rollproperties.RemoveRange(_prdbContext.Rollproperties.Where(x => x.Rollpropertyclass == input));
        }

        #endregion

        #region Roll Shape Coeff

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollShapeCoeffDto> CreateRollShapeCoeff(RollShapeCoeffDto dto)
        {
            var context = _prdbContextProvider.GetDbContext();

            bool exist = await context.Rollshapecoeffs.AnyAsync(x => x.Shapecode == dto.ShapeCode);

            if (exist)
                throw new UserFriendlyException($"Roll shape coeff with shape code = '{dto.ShapeCode}' already exist");

            var rollcoeff = dto.ToRollShapeCoeffEntity();

            await context.Rollshapecoeffs.AddAsync(rollcoeff);

            return rollcoeff.ToRollShapeCoeffDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<RollShapeCoeffDto> GetRollShapeCoeff(int shapeCode)
        {
            var context = _prdbContextProvider.GetDbContext();

            var shape = await context.Rollshapecoeffs
                .FirstOrDefaultAsync(x => x.Shapecode == shapeCode)
                ?? throw new EntityNotFoundException($"Roll shape coeff with shape code = '{shapeCode}' doesn't exist");

            return shape.ToRollShapeCoeffDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollShapeCoeffDto>> GetShapeCodeAll(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(
                context.Rollshapecoeffs
                    .OrderBy(t => t.Shapecode),
                input,
                RollMapper.ToRollShapeCoeffDto);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollShapeCoeffDto> UpdateRollShapeCoeff(RollShapeCoeffDto dto)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.Rollshapecoeffs
                .FirstOrDefaultAsync(x => x.Shapecode == dto.ShapeCode);

            if (entity is null)
                throw new EntityNotFoundException($"Roll shape coeff with shape code = '{dto.ShapeCode}' doesn't exist");

            entity.Description = dto.Description;
            entity.Shapetype = dto.ShapeType;
            entity.Shapex1 = dto.ShapeX1;
            entity.Shapex2 = dto.ShapeX2;
            entity.Shapex3 = dto.ShapeX3;
            entity.Shapex4 = dto.ShapeX4;
            entity.Shapex5 = dto.ShapeX5;
            entity.Shapex6 = dto.ShapeX6;
            entity.Shapex7 = dto.ShapeX7;
            entity.Shapex8 = dto.ShapeX8;
            entity.Shapex9 = dto.ShapeX9;
            entity.Standrange = dto.StandRange;
            entity.Shapecurvecode = dto.ShapeCurveCode;

            return entity.ToRollShapeCoeffDto();
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Delete)]
        public async Task DeleteRollShapeCoeff(int shapeCode)
        {
            var context = _prdbContextProvider.GetDbContext();

            var shape = await context.Rollshapecoeffs
                .FirstOrDefaultAsync(x => x.Shapecode == shapeCode)
                ?? throw new EntityNotFoundException($"Roll shape coeff with shape code = '{shapeCode}' doesn't exist");

            context.Rollshapecoeffs.Remove(shape);
        }

        #endregion

        #region Custom Roll Shape Curve

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<CustomRollShapeCurveDto> GetCustomRollShapeCurve(int shapeCurveCode)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.Rollshapecurvecustoms
                .FirstOrDefaultAsync(x => x.Shapecurvecode == shapeCurveCode);

            if (entity is null)
                throw new EntityNotFoundException($"Custom roll shape curve with shape curve code = '{shapeCurveCode}' doesn't exist");

            return entity.ToCustomRollShapeCurve();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<CustomRollShapeCurveItem>> GetCustomRollShapeCurveList(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(
                context.Rollshapecurvecustoms
                .OrderBy(x => x.Shapecurvecode),
                input,
                RollMapper.ToCustomRollShapeCurveItem);
        }

        #endregion

        /// <param name="rollId">Unique Roll Id </param>
        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<SingleRollDataCoreDto> GetRollDataCoreById(string rollId, string planttype)
        {
            try
            {
                var rollData = await _prdbContext.Rolldata.FirstOrDefaultAsync(x => x.Rollid == rollId && x.Planttype == planttype);
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
                throw new UserFriendlyException("All parameters 'standId', 'plantType', 'rollType', 'rollStatus' und 'rollPos' must be provided.");

            SingleRollDataCoreDto result = new SingleRollDataCoreDto();
            try
            {
                HmiVRollInventory rollData = await _prdbContext.HmiVRollInventories.FirstOrDefaultAsync(x => x.Planttype == plantType && x.Standid == standId && x.Rolltype == rollType && x.Rollpos == rollPos && x.Stat == rollStatus);
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
        public Task<PagedResultDto<SingleRollDataCoreDto>> GetAvailableRolls(FilteredRequestDto input, string plantType, string rollType)
        {
            List<SingleRollDataCoreDto> dto = new List<SingleRollDataCoreDto>();
            try
            {

                return ApplyFilter(
                    _prdbContext.HmiVRollInventories
                       .Where(z => z.Planttype == plantType && z.Rolltype == rollType && z.Stat != "I")
                       .OrderByDescending(t => t.Rollid),
                   input,
                   RollMapper.ToRollDataCoreDto);

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
                throw new UserFriendlyException("The “rollType” parameter is invalid.");

            if ((rollPos != "U" && rollPos != "L" && rollPos != "O" && rollPos != "D") || rollPos is null)
                throw new UserFriendlyException("The “rollPos” parameter is invalid.");

            try
            {
                //clear any previous planned roll on this position
                var rollDataCheck = await _prdbContext.Rolldata.FirstOrDefaultAsync(x => x.Planttype == plantType.ToString() && x.Rolltype == rollType && x.Standid == standId && x.Rollpos == rollPos && x.Stat == "P");
                if (rollDataCheck is not null)
                {
                    rollDataCheck.Stat = null;
                    Logger.Info($"Roll {rollDataCheck.Rollid} has been cleared from Planned status.");
                }

                if (!string.IsNullOrWhiteSpace(rollId))
                {
                    var rollData = await _prdbContext.Rolldata.FirstOrDefaultAsync(x => x.Rollid == rollId && x.Planttype == plantType.ToString());
                    if (rollData is null)
                        throw new UserFriendlyException("Unknown roller.");

                    if (rollData.Stat == "I")
                        throw new UserFriendlyException("It is not permitted to change the properties of installed rollers.");

                    rollData.Stat = "P";
                    rollData.Standid = standId;
                    rollData.Rollpos = rollPos;
                    rollData.Shimm = shimm;

                    if (diameter is not null)
                        rollData.Diameter = diameter.Value;

                    Logger.Info($"Roll {rollData.Rollid} has been Planned for next roll change.");
                }

                await _prdbContext.SaveChangesAsync();

                if (_cooldownTimerRefresh.Enabled)
                {
                    Logger.Info($"Refresh timer start suppressed, already started");
                }
                else
                {
                    await SendRollRefresh(plantType);
                }

                //read roll data from DB after update to initialize return DTO
                HmiVRollInventory rollDataAfterUpdate = await _prdbContext.HmiVRollInventories.FirstOrDefaultAsync(x => x.Rollid == rollId && x.Planttype == plantType.ToString());
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
        public async Task DoEmergencyRollChange(string connectionId, EmergencyRollChangeBaseDto input)
        {
            if (input?.RollChangeDtos is null || input.RollChangeDtos.Count == 0)
                throw new UserFriendlyException("Request is empty. Please provide valid input arguments");

            foreach (var dto in input.RollChangeDtos)
            {
                var l2Item = new RollChangeDto
                {
                    PlantType = input.PlantType,
                    StandNo = dto.StandNo,
                    ChangeWKR = dto.ChangeWKR,
                    ChangeBURu = dto.ChangeBURTop,
                    ChangeBURl = dto.ChangeBURBot,
                    ChangeIMR = 0,
                    ChangeEWR = 0,
                    ChangeSPT = 0,
                    ChangeZR0 = 0,
                    ChangeZR1 = 0,
                    SendL1 = 0
                };

                _l2Sender.RollChange(l2Item);
            }
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task SendActualStandData(SendActualStandDataDto input)
        {
            foreach (var id in input.StandIds)
                _l2Sender.SendRollData(input.PlantType, id);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task SendRollDataRequest(string rollId, string rollType, string plantType)
        { 
            _l2Sender.RequestRollData(plantType, rollId, -1, rollType);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        [UnitOfWork]
        public async Task SetRollChangeReason(string plantType, RollChangeReasonsDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            if (plantType != "HRM" && plantType != "HFM" && !(plantType is null || plantType == String.Empty))
                throw new UserFriendlyException("Specify valid parameter 'plantType'. Must be 'HFM' or 'HRM'.");

            if (input.Stands is null)
                throw new UserFriendlyException("Specify valid parameter (not null)");

            try
            {
                foreach (var stand in input.Stands)
                {
                    bool isValid = stand.StandId >= 0
                                   && stand.RollPos is { Length: 1 };

                    if (!isValid)
                        continue;

                    var rdRec = await context.Rolldata.FirstOrDefaultAsync(f =>
                        f.Standid == stand.StandId &&
                        f.Rollpos == stand.RollPos &&
                        f.Stat == "I" &&
                        f.Rolltype == stand.RollType &&
                        f.Planttype == plantType);

                    if (rdRec is null)
                        continue;

                    rdRec.Removereason = input.ReasonId;
                    rdRec.Remarks = input.OperatorRemarks;
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error("[SetRollChangeReason] Exception while setting roll change reasons:", ex);
                throw new UserFriendlyException($"Exception occured during setting roll change reasons. {ex.Message}");
            }

            return;
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

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<CalCurveDataDto> GetCalibrationCurves(int standId)
        {
            var context = _prdbContextProvider.GetDbContext();
            var result = new CalCurveDataDto
            {
                CalCurvesDataSet = new Dictionary<int, SingleCurveDataDto>()
            };

            // Reference curves
            var refCalData = await context.Caldsses
                .Where(x => x.Standno == standId)
                .OrderBy(o => o.Dssnumber)
                .ToListAsync();

            var refStandStretch = CreateCurve("Stand Stretch Reference");
            //var refTotalStretch = CreateCurve("Total Stretch Reference");

            result.CalCurvesDataSet.Add(1, refStandStretch);
            //result.CalCurvesDataSet.Add(2, refTotalStretch);

            if (refCalData?.Any() == true)
            {
                foreach (var el in refCalData)
                {
                    AddMeasuredValue(refStandStretch, el.Tom, el.Dssnumber, el.Fr ?? 0.0, el.Dss);
                    //AddMeasuredValue(refTotalStretch, el.Tom, el.Dssnumber, el.Fr ?? 0.0, el.Dss);
                }
            }

            // Actual curves
            var actCalData = await context.Caldssacts
                .Where(x => x.Standno == standId)
                .OrderBy(o => o.Dssnumber)
                .ToListAsync();

            var actStandStretch = CreateCurve("Stand Stretch Actual");
            //var actTotalStretch = CreateCurve("Total Stretch Actual");

            result.CalCurvesDataSet.Add(3, actStandStretch);
            //result.CalCurvesDataSet.Add(4, actTotalStretch);

            if (actCalData?.Any() == true)
            {
                foreach (var el in actCalData)
                {
                    AddMeasuredValue(actStandStretch, el.Tom, el.Dssnumber, el.Fr ?? 0.0, el.Dss);
                    //AddMeasuredValue(actTotalStretch, el.Tom, el.Dssnumber, el.Fr ?? 0.0, el.Dss);
                }
            }

            return result;
        }

        private SingleCurveDataDto CreateCurve(string name)
        {
            return new SingleCurveDataDto
            {
                CurveData = new MeasuredValueSetDto
                {
                    MVName = name,
                    MVArray = new List<MeasValElementDto>()
                }
            };
        }

        private void AddMeasuredValue(SingleCurveDataDto curve, DateTime? calibrationDate, int sampleId, double measuredValue, double? position)
        {
            curve.CalibrationDatetime = calibrationDate;
            curve.CurveData.MVArray.Add(new MeasValElementDto
            {
                SampleId = sampleId,
                MeasuredValue = measuredValue,
                Position = position
            });
        }

        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        [Audited]
        public async Task<bool> TakeOverCalibrationCurve(short standId)
        {
            //read actual calibration data
            var context = _prdbContextProvider.GetDbContext();

            List<Caldssact> actCalData = await context.Caldssacts
                .Where(x => x.Standno == standId)
                .OrderBy(o => o.Dssnumber)
                .ToListAsync();

            if (actCalData == null || actCalData.Count == 0)
            {
                throw new Abp.UI.UserFriendlyException("No valid calibration data available for the transfer.");
            }

            List<Calpadeact> actCalPade = await context.Calpadeacts
                .Where(x => x.Standno == standId)
                .ToListAsync();

            if (actCalPade == null || actCalPade.Count == 0)
            {
                throw new Abp.UI.UserFriendlyException($"No CalPadeAct for standId:{standId}");
            }

            var calPadesToRemove = await context.Calpades
                .Where(x => x.Standno == standId)
                .ToListAsync();

            context.Calpades.RemoveRange(calPadesToRemove);

            List<Calpade> newCalPades = new();

            foreach (var el in actCalPade)
            {
                newCalPades.Add(new Calpade()
                {
                    Curvetype = el.Curvetype,
                    Standno = el.Standno,
                    Padea0 = el.Padea0,
                    Padea1 = el.Padea1,
                    Padea2 = el.Padea2,
                    Padeb1 = el.Padeb1,
                    Mop = el.Mop,
                    Planttype = el.Planttype,
                    Toc = el.Toc,
                    Tom = el.Tom,
                });
            }

            await context.Calpades.AddRangeAsync(newCalPades);

            var calDssToRemove = await context.Caldsses
                .Where(x => x.Standno == standId)
                .ToListAsync();

            context.Caldsses.RemoveRange(calDssToRemove);


            List<Caldss> newCalDsses = new ();

            foreach (Caldssact el in actCalData)
            {
                newCalDsses.Add(new Caldss()
                {
                    Standno = el.Standno,
                    Dsframe = el.Dsframe,
                    Dss = el.Dss,
                    Dssnumber = el.Dssnumber,
                    Fr = el.Fr,
                    Mop = el.Mop,
                    Planttype = el.Planttype,
                    Toc = el.Toc,
                    Tom = el.Tom,
                });
            }

            await context.Caldsses.AddRangeAsync(newCalDsses);

            await context.SaveChangesAsync();

            _l2Sender.TakeoverActual4RevCurve(standId);

            return true;
        }
    }
}
