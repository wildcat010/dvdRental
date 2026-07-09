using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Helpers;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.PRDB.Dbo.Ext.Interfaces;

namespace WebHMI.Services.StrategyServices
{
    public abstract class StdRampService<TEntity, TDto, TRampEntity, TRampDto> : ApplicationServiceBase
        where TEntity : class, IStd, new()
        where TDto : StdItemDto, new()
        where TRampEntity : class, IRampStd, new()
        where TRampDto : StdRampDto, new()
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly StdService<TEntity, TDto> _stdService;

        private readonly Func<TRampEntity, TRampDto> _toDto;
        private readonly Action<TRampEntity, TRampDto> _mapEntity;

        public abstract string AggregateName { get; }

        public StdRampService(
            Func<TEntity, TDto> toDto,
            Action<TEntity, TDto> mapEntity,
            Func<TRampEntity, TRampDto> toRampDto,
            Action<TRampEntity, TRampDto> mapRampEntity)
        {
            _dbContextProvider = IocManager.Instance.ResolveAsDisposable<IDbContextProvider<PrdbContext>>().Object;
            _stdService = new StdService<TEntity, TDto>(toDto, mapEntity);
            //_stdService.UnitOfWorkManager = IocManager.Instance.ResolveAsDisposable<IUnitOfWorkManager>().Object;
            _stdService.AggregateName = AggregateName;
            _stdService.IsLastService = false;

            _toDto = toRampDto;
            _mapEntity = mapRampEntity;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<StdRampSetsDto<TDto, TRampDto>> Create(StdRampSetsDto<TDto, TRampDto> input)
        {
            ValidateInput(input);

            var context = _dbContextProvider.GetDbContext();

            input.Std.Nodes = (short)input.RampSets.StdRamps.Count();
            var std = await _stdService.Create(input.Std);

            bool rampsExist = await context.Set<TRampEntity>().AnyAsync(x =>
                x.Planno == input.RampSets.PlanNo);

            if (rampsExist)
                throw new EntityNotFoundException("Ramps already exist for given key");

            var ramps = new List<TRampEntity>();

            if (input.RampSets.StdRamps.Count == 0)
                ramps.Add(new TRampEntity() { Rampno = 0, Planno = input.Std.PlanNo });

            foreach (var ramp in input.RampSets.StdRamps)
            {
                var entity = new TRampEntity();
                _mapEntity(entity, ramp);
                ramps.Add(entity);
            }

            await context.Set<TRampEntity>().AddRangeAsync(ramps);

            await context.SaveChangesAsync();
            var result = new StdRampSetsDto<TDto, TRampDto>()
            {
                Std = std,
                RampSets = new StdRampSetDto<TRampDto>
                {
                    PlanNo = input.RampSets.PlanNo,
                    StdRamps = ramps.Select(x => _toDto(x))
                        .OrderBy(x => x.RampNo)
                        .ToList()
                }
            };

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<StdRampSetsDto<TDto, TRampDto>> Get(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            var ramps = await context.Set<TRampEntity>().Where(x =>
                x.Planno == planNo && x.Planno != 0 && x.Activeflag == 1 && x.Rampno == 1)
                .ToListAsync();

            return new StdRampSetsDto<TDto, TRampDto>()
            {
                Std = await _stdService.Get(planNo),
                RampSets = new StdRampSetDto<TRampDto>
                {
                    PlanNo = planNo,
                    StdRamps = ramps.Select(x => _toDto(x))
                        .OrderBy(x => x.RampNo)
                        .ToList()
                }
            };
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<PagedResultDto<StdItemDto>> GetAvailablePlans(StdFilteredRequestDto input)
        {
            var context = _dbContextProvider.GetDbContext();
            var query = context.Set<TRampEntity>().AsQueryable().Where(x => x.Activeflag == 1 && x.Rampno == 1);

            if (input.NotAssignedPlans)
            {
                var usedPlanNumbers = await context.Aggregateselections
                    .Where(x => x.Aggregate == AggregateName)
                    .Select(x => new { x.PlannoInd0, x.PlannoInd1, x.PlannoInd2, x.PlannoInd3 })
                    .ToArrayAsync();

                var usedUniquePlanNumbers = usedPlanNumbers
                    .SelectMany(x => new[] { x.PlannoInd0, x.PlannoInd1, x.PlannoInd2, x.PlannoInd3 })
                    .Distinct()
                    .Where(x => x.HasValue);

                query = query.Where(x => !usedUniquePlanNumbers.Contains(x.Planno));
            }

            return await ApplyFilterRamp(query.OrderBy(x => x.Planno), input, MapItem);

            StdItemDto MapItem(TRampEntity entity) => new()
            {
                PlanNo = entity.Planno,
                ActiveFlag = entity.Activeflag,
                Description = entity.Description,
                LastModified = entity.Tom
            };
           // return await _stdService.GetAvailablePlans(input);
        }

        //[AbpAuthorize(Permissions.Pages_Strategies)]
        //public async Task<PagedResultDto<StdItemDto>> GetAssignablePlans(StdFilteredRequestDto input)
        //{
        //    return await _stdService.GetAssignablePlans(input);
        //}

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<StdRampKeySetDto<TDto, TRampDto>> GetAll()
        {
            var context = _dbContextProvider.GetDbContext();
            var ramps = await context.Set<TRampEntity>()
                .Where(x => x.Planno != 0)
                .OrderBy(x => x.Rampno)
                .ToListAsync();

            var result = new StdRampKeySetDto<TDto, TRampDto>();

            foreach (var ramp in ramps)
            {
                var passDto = _toDto(ramp);

                var keyPassSet = result.StdKeyRampSets.FirstOrDefault(x => x.PlanNo == ramp.Planno);
                if (keyPassSet is null)
                {
                    var newSet = new StdRampSetDto<TRampDto>
                    {
                        PlanNo = ramp.Planno,
                        StdRamps = new List<TRampDto>() { passDto }
                    };

                    result.StdKeyRampSets.Add(newSet);
                }
                else
                {
                    keyPassSet.StdRamps.Add(passDto);
                }
            }

            var stdDtos = await _stdService.GetAll();
            result.Stds = stdDtos.Stds;

            return result;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<StdRampSetsDto<TDto, TRampDto>> Update(StdRampSetsDto<TDto, TRampDto> input)
        {
            ValidateInput(input);

            if (input.RampSets.StdRamps.Count < 1)
                throw new UserFriendlyException("Strategy need to have at least one node");

            var context = _dbContextProvider.GetDbContext();
            context.Set<TRampEntity>().RemoveRange(context.Set<TRampEntity>().Where(x =>
                x.Planno == input.RampSets.PlanNo && x.Activeflag == 1).ToList());

            await context.SaveChangesAsync();

            var ramps = new List<TRampEntity>();

            for (int i = 0; i < input.RampSets.StdRamps.Count; i++)
            //foreach (var dto in input.RampSets.StdRamps)
            {
                var dto = input.RampSets.StdRamps[i];
                //dto.RampNo = i;
                var entity = new TRampEntity();
                _mapEntity(entity, dto);
                ramps.Add(entity);
            }

            await context.Set<TRampEntity>().AddRangeAsync(ramps);

            await context.SaveChangesAsync();

            var result = new StdRampSetsDto<TDto, TRampDto>()
            {
                Std = await _stdService.Update(input.Std),
                RampSets = new StdRampSetDto<TRampDto>
                {
                    PlanNo = input.RampSets.PlanNo,
                    StdRamps = ramps.Select(x => _toDto(x))
                        .OrderBy(x => x.RampNo)
                        .ToList()
                }
            };

            return result;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<List<StdRampSetsDto<TDto, TRampDto>>> UpdateAll(List<StdRampSetsDto<TDto, TRampDto>> inputs)
        {
            var context = _dbContextProvider.GetDbContext();
            List<StdRampSetsDto<TDto, TRampDto>> updatedDtos = new();

            foreach (var input in inputs)
            {
                ValidateInput(input);

                context.Set<TRampEntity>().RemoveRange(context.Set<TRampEntity>().Where(x =>
                    x.Planno == input.RampSets.PlanNo && x.Activeflag == 1).ToList());

                var ramps = new List<TRampEntity>();

                foreach (var dto in input.RampSets.StdRamps)
                {
                    var entity = new TRampEntity();
                    _mapEntity(entity, dto);
                    ramps.Add(entity);
                }

                await context.Set<TRampEntity>().AddRangeAsync(ramps);

                var result = new StdRampSetsDto<TDto, TRampDto>()
                {
                    Std = await _stdService.Update(input.Std),
                    RampSets = new()
                    {
                        PlanNo = input.RampSets.PlanNo,
                        StdRamps = ramps.Select(x => _toDto(x))
                            .OrderBy(x => x.RampNo)
                            .ToList()
                    }
                };

                updatedDtos.Add(result);
            }

            await context.SaveChangesAsync();

            return updatedDtos;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            await _stdService.Delete(planNo);

            context.Set<TRampEntity>().RemoveRange(context.Set<TRampEntity>().Where(x =>
                x.Planno == planNo && x.Activeflag == 1).ToList());

            await context.SaveChangesAsync();
        }

        /// <inheritdoc cref="StdService{TEntity, TPrimaryKey, TDto}.IsStdKeyValid(StdKeyDto)" />
        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<bool> IsStdKeyValid(int planNo)
        {
            return await _stdService.IsStdKeyValid(planNo);
        }

        private static void ValidateInput(StdRampSetsDto<TDto, TRampDto> input)
        {
            if (input.Std.PlanNo == 0)
                throw new UserFriendlyException("Plan 0 (default) is not editable");

            if (input.Std.PlanNo != input.RampSets.PlanNo)
                throw new UserFriendlyException("Std and passes keys don't match");

            foreach (var ramp in input.RampSets.StdRamps)
            {
                if (ramp.PlanNo != input.RampSets.PlanNo)
                {
                    string msg = $"Pass with key '{nameof(input.RampSets.PlanNo)} = {ramp.PlanNo} does not match the key";
                    throw new UserFriendlyException(msg);
                }
            }

            var RampNos = input.RampSets.StdRamps.Select(x => x.RampNo).ToList();
            bool arePassesUnique = RampNos.Distinct().Count() == RampNos.Count();
            if (!arePassesUnique)
                throw new UserFriendlyException("Pass numbers must be unique");
        }
    }
}
