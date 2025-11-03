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
using WebHMI.Application.Dtos.Roll;
using WebHMI.Dtos;
using WebHMI.Dtos.Roll;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Senders;
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
            bool rollDataExist = await _prdbContext.RollData.AsNoTracking().AnyAsync(x => x.RollId == rollDto.Rollid && x.PlantType == rollDto.Planttype.ToString());

            if (rollDataExist)
                throw new UserFriendlyException("The roller already exists. Please use a unique name.");

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
                throw new UserFriendlyException("An error occurred while generating/saving roll data in the database." + ex.Message);
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
                throw new UserFriendlyException("It is not permitted to change the properties of installed rollers.");

            rollData.RollId = rollDto.Rollid;
            rollData.RollType = rollDto.Rolltype;
            rollData.PlantType = rollDto.Planttype;
            rollData.Diameter = rollDto.Diameter;
            rollData.RollClass = rollDto.Rollclass;
            rollData.RollPropertyClass = rollDto.RollPropertyClass;
            rollData.Roughness = rollDto.Roughness;
            rollData.RollShapeCode = rollDto.ShapeCode;
            rollData.Grinding = rollDto.Grinding;
            rollData.RollPos = rollDto.Rollpos;
            rollData.RollChamferCode = rollDto.RollChamferClassId;
            rollData.Stat = rollDto.Stat;
            rollData.Shimm = rollDto.Shimm;
            //rollData.DismountTime = dto.Dismounttime;
            rollData.RelatedRollId = rollDto.RelatedRollid;

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
                throw new UserFriendlyException("It is not permitted to delete the properties of installed rollers.");

            try
            {
                _prdbContext.RollData.Remove(rollData);
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
            bool rollClassExist = await _prdbContext.RollClasses.AnyAsync(t => t.RollClass1 == rollClassDto.RollClass);

            if (rollClassExist)
                throw new UserFriendlyException("The specified ID is already in use.");

            if (rollClassDto.Description.Length < 3)
                throw new UserFriendlyException("The description must be at least 3 characters long.");

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
                throw new UserFriendlyException("The description must be at least 3 characters long.");

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
                throw new UserFriendlyException("The given class is linked to an existing roller and cannot be deleted.");

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
                throw new UserFriendlyException("The specified ID is already in use.");

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
                throw new UserFriendlyException("The given class is linked to an existing roller and cannot be deleted.");

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
                throw new UserFriendlyException("Given id is already in use");

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

        #region Roll Shape Coeff

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollShapeCoeffDto> CreateRollShapeCoeff(RollShapeCoeffDto dto)
        {
            var context = _prdbContextProvider.GetDbContext();

            bool exist = await context.RollShapeCoeffs.AnyAsync(x => x.ShapeCode == dto.ShapeCode);

            if (exist)
                throw new UserFriendlyException($"Roll shape coeff with shape code = '{dto.ShapeCode}' already exist");

            var rollcoeff = dto.ToRollShapeCoeffEntity();

            await context.RollShapeCoeffs.AddAsync(rollcoeff);

            return rollcoeff.ToRollShapeCoeffDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<RollShapeCoeffDto> GetRollShapeCoeff(int shapeCode)
        {
            var context = _prdbContextProvider.GetDbContext();

            var shape = await context.RollShapeCoeffs
                .FirstOrDefaultAsync(x => x.ShapeCode == shapeCode)
                ?? throw new EntityNotFoundException($"Roll shape coeff with shape code = '{shapeCode}' doesn't exist");

            return shape.ToRollShapeCoeffDto();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<RollShapeCoeffDto>> GetShapeCodeAll(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(
                context.RollShapeCoeffs
                    .OrderBy(t => t.ShapeCode),
                input,
                RollMapper.ToRollShapeCoeffDto);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Edit)]
        public async Task<RollShapeCoeffDto> UpdateRollShapeCoeff(RollShapeCoeffDto dto)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.RollShapeCoeffs
                .FirstOrDefaultAsync(x => x.ShapeCode == dto.ShapeCode);

            if (entity is null)
                throw new EntityNotFoundException($"Roll shape coeff with shape code = '{dto.ShapeCode}' doesn't exist");

            entity.Description = dto.Description;
            entity.ShapeType = dto.ShapeType;
            entity.ShapeX1 = dto.ShapeX1;
            entity.ShapeX2 = dto.ShapeX2;
            entity.ShapeX3 = dto.ShapeX3;
            entity.ShapeX4 = dto.ShapeX4;
            entity.ShapeX5 = dto.ShapeX5;
            entity.ShapeX6 = dto.ShapeX6;
            entity.ShapeX7 = dto.ShapeX7;
            entity.ShapeX8 = dto.ShapeX8;
            entity.ShapeX9 = dto.ShapeX9;
            entity.StandRange = dto.StandRange;
            entity.ShapeCurveCode = dto.ShapeCurveCode;

            return entity.ToRollShapeCoeffDto();
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_RollData_Delete)]
        public async Task DeleteRollShapeCoeff(int shapeCode)
        {
            var context = _prdbContextProvider.GetDbContext();

            var shape = await context.RollShapeCoeffs
                .FirstOrDefaultAsync(x => x.ShapeCode == shapeCode)
                ?? throw new EntityNotFoundException($"Roll shape coeff with shape code = '{shapeCode}' doesn't exist");

            context.RollShapeCoeffs.Remove(shape);
        }

        #endregion

        #region Custom Roll Shape Curve

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<CustomRollShapeCurveDto> GetCustomRollShapeCurve(int shapeCurveCode)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.RollShapeCurveCustoms
                .FirstOrDefaultAsync(x => x.ShapeCurveCode == shapeCurveCode);

            if (entity is null)
                throw new EntityNotFoundException($"Custom roll shape curve with shape curve code = '{shapeCurveCode}' doesn't exist");

            return entity.ToCustomRollShapeCurve();
        }

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<PagedResultDto<CustomRollShapeCurveItem>> GetCustomRollShapeCurveList(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(
                context.RollShapeCurveCustoms
                .OrderBy(x => x.ShapeCurveCode),
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
                throw new UserFriendlyException("All parameters 'standId', 'plantType', 'rollType', 'rollStatus' und 'rollPos' must be provided.");

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
                throw new UserFriendlyException($"When parameter '{nameof(onlyPlannedByRS)}' true is, parameters '{nameof(standId)}' and '{nameof(rollPos)}' must be provided.");

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
                throw new UserFriendlyException("The “rollType” parameter is invalid.");

            if ((rollPos != "U" && rollPos != "L" && rollPos != "O" && rollPos != "D") || rollPos is null)
                throw new UserFriendlyException("The “rollPos” parameter is invalid.");

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
                        throw new UserFriendlyException("Unknown roller.");

                    if (rollData.Stat == "I")
                        throw new UserFriendlyException("It is not permitted to change the properties of installed rollers.");

                    rollData.Stat = "P";
                    rollData.StandId = standId;
                    rollData.RollPos = rollPos;
                    rollData.Shimm = shimm;

                    if (diameter is not null)
                        rollData.Diameter = diameter.Value;

                    Logger.Info($"Roll {rollData.RollId} has been Planned for next roll change.");
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
                throw new UserFriendlyException("Please specify a valid ‘plantType’ parameter. Must be ‘FM’ or ‘RM’ or left blank.");

            if (rollType != "WKR" && rollType != "BUR" && rollType != "EWR" && !(rollType is null || rollType == String.Empty))
                throw new UserFriendlyException("Please enter a valid ‘rollType’ parameter. Must be ‘WKR’, ‘BUR’, ‘EWR’ or left blank.");

            if (standId is not null && !validStands.Contains(standId ?? 0))
                //if (standId <0 || standId > 7 )
                throw new UserFriendlyException("Please enter a valid ‘standId’ parameter. Must be a value between 0 and 7 or 100, or left blank.");

            if (rollPosition != "L" && rollPosition != "U" && rollPosition != "D" && rollPosition != "O" && !(rollPosition is null || rollType == String.Empty))
                throw new UserFriendlyException("Please specify a valid ‘rollPosition’ parameter. Must have the value ‘L’, ‘U’, ‘D’, ‘O’ or left blank.");

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

        [AbpAuthorize(Permissions.Pages_RollData)]
        public async Task<CalCurveDataDto> GetCalibrationCurves(int standId)
        {
            var context = _prdbContextProvider.GetDbContext();
            var result = new CalCurveDataDto
            {
                CalCurvesDataSet = new Dictionary<int, SingleCurveDataDto>()
            };

            // Reference curves
            var refCalData = await context.CalDsses
                .Where(x => x.StandNo == standId)
                .OrderBy(o => o.DssNumber)
                .ToListAsync();

            var refStandStretch = CreateCurve("Stand Stretch Reference");
            var refTotalStretch = CreateCurve("Total Stretch Reference");

            result.CalCurvesDataSet.Add(1, refStandStretch);
            result.CalCurvesDataSet.Add(2, refTotalStretch);

            if (refCalData?.Any() == true)
            {
                foreach (var el in refCalData)
                {
                    AddMeasuredValue(refStandStretch, el.Tom, el.DssNumber, el.Fr ?? 0.0, el.DsFrame);
                    AddMeasuredValue(refTotalStretch, el.Tom, el.DssNumber, el.Fr ?? 0.0, el.Dss);
                }
            }

            // Actual curves
            var actCalData = await context.CalDssActs
                .Where(x => x.StandNo == standId)
                .OrderBy(o => o.DssNumber)
                .ToListAsync();

            var actStandStretch = CreateCurve("Stand Stretch Actual");
            var actTotalStretch = CreateCurve("Total Stretch Actual");

            result.CalCurvesDataSet.Add(3, actStandStretch);
            result.CalCurvesDataSet.Add(4, actTotalStretch);

            if (actCalData?.Any() == true)
            {
                foreach (var el in actCalData)
                {
                    AddMeasuredValue(actStandStretch, el.Tom, el.DssNumber, el.Fr ?? 0.0, el.DsFrame);
                    AddMeasuredValue(actTotalStretch, el.Tom, el.DssNumber, el.Fr ?? 0.0, el.Dss);
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
    }
}
