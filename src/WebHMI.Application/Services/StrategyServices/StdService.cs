using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy;
using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.PRDB.Dbo.Interfaces;

namespace WebHMI.Services.StrategyServices
{
    public class StdService<TEntity, TDto> : ApplicationServiceBase
        where TEntity : class, IStd, new()
        where TDto : StdItemDto, new()
    {

        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly IL2CommunicationHandler _l2CommunicationHandler;
        private readonly Func<TEntity, TDto> _toDto;
        private readonly Action<TEntity, TDto> _mapEntity;

        public virtual string AggregateName { get; set; }
        public bool IsLastService { get; set; } = true;

        public StdService(
            Func<TEntity, TDto> toDto,
            Action<TEntity, TDto> mapEntity)
        {
            _dbContextProvider = IocManager.Instance.ResolveAsDisposable<IDbContextProvider<PrdbContext>>().Object;
            _l2CommunicationHandler = IocManager.Instance.ResolveAsDisposable<IL2CommunicationHandler>().Object;

            _toDto = toDto;
            _mapEntity = mapEntity;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<TDto> Create(TDto dto)
        {
            if (dto.PlanNo == 0)
                throw new EntityNotFoundException("Cannot create strategy with plan number 0");
            dto.ActiveFlag = 1; //force active flag to be 1 on create
            var context = _dbContextProvider.GetDbContext();
            bool stdExist = await context.Set<TEntity>().AnyAsync(x =>
                x.PlanNo == dto.PlanNo);

            if (stdExist)
                throw new EntityNotFoundException("Std already exists for given key");

            var entity = new TEntity();
            _mapEntity(entity, dto);

            await context.Set<TEntity>().AddAsync(entity);

            await context.SaveChangesAsync();

            return _toDto(entity);
        }


        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<TDto> Get(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            var entity = await context.Set<TEntity>().FirstOrDefaultAsync(x =>
                x.PlanNo == planNo && x.ActiveFlag == 1);

            if (entity is null)
                throw new EntityNotFoundException("Std for given key not found");

            var dto = _toDto(entity);
            dto.AssignmentsCount = context.AggregateSelections
                .Where(x => x.Aggregate == AggregateName && (x.PlanNoInd0 == dto.PlanNo || x.PlanNoInd1 == dto.PlanNo || x.PlanNoInd2 == dto.PlanNo || x.PlanNoInd3 == dto.PlanNo))
                .Count();
            return dto;
        }

        public async Task<PagedResultDto<StdItemDto>> GetAvailablePlans(StdFilteredRequestDto input)
        {
            var context = _dbContextProvider.GetDbContext();
            var query = context.Set<TEntity>().AsQueryable().Where(x => x.ActiveFlag == 1);

            if (input.NotAssignedPlans)
            {
                var usedPlanNumbers = await context.AggregateSelections
                    .Where(x => x.Aggregate == AggregateName)
                    .Select(x => new { x.PlanNoInd0, x.PlanNoInd1, x.PlanNoInd2, x.PlanNoInd3 })
                    .ToArrayAsync();

                var usedUniquePlanNumbers = usedPlanNumbers
                    .SelectMany(x => new[] { x.PlanNoInd0, x.PlanNoInd1, x.PlanNoInd2, x.PlanNoInd3 })
                    .Distinct()
                    .Where(x => x.HasValue);

                query = query.Where(x => !usedUniquePlanNumbers.Contains(x.PlanNo));
            }

            return await ApplyFilter(query.OrderBy(x=>x.PlanNo), input, MapItem);

            StdItemDto MapItem(TEntity entity) => new()
            {
                PlanNo = entity.PlanNo,
                ActiveFlag = entity.ActiveFlag,
                Description = entity.Description,
                LastModified = entity.Tom
            };
        }

        //[AbpAuthorize(Permissions.Pages_Strategies)]
        //public async Task<PagedResultDto<StdItemDto>> GetAssignablePlans(StdFilteredRequestDto input)
        //{
        //    var context = _dbContextProvider.GetDbContext();
        //    var query = context.Set<TEntity>().AsQueryable();

        //    if (input.NotAssignedPlans)
        //    {
        //        var usedPlanNumbers = await context.AggregateSelections
        //            .Where(x => x.Aggregate == AggregateName)
        //            .Select(x => new { x.PlanNoInd0, x.PlanNoInd1, x.PlanNoInd2, x.PlanNoInd3 })
        //            .ToArrayAsync();

        //        var usedUniquePlanNumbers = usedPlanNumbers
        //            .SelectMany(x => new[] { x.PlanNoInd0, x.PlanNoInd1, x.PlanNoInd2, x.PlanNoInd3 })
        //            .Distinct()
        //            .Where(x => x.HasValue);

        //        query = query.Where(x => !usedUniquePlanNumbers.Contains(x.PlanNo));
        //    }

        //    return await ApplyFilter(query, input, MapItem);

        //    StdItemDto MapItem(TEntity entity) => new()
        //    {
        //        PlanNo = entity.PlanNo,
        //        ActiveFlag = entity.ActiveFlag,
        //        //Description = entity.Description,
        //        LastModified = entity.Tom
        //    };
        //}

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<StdListDto<TDto>> GetAll()
        {
            var context = _dbContextProvider.GetDbContext();
            var result = await context.Set<TEntity>().OrderByDescending(x=>x.PlanNo).ToListAsync();
            return new StdListDto<TDto>() { Stds = result.Select(x => _toDto(x)) };
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<TDto> Update(TDto dto)
        {
            if (dto.PlanNo == 0)
                throw new EntityNotFoundException("Plan number cannot have value 0");

            var context = _dbContextProvider.GetDbContext();
            var entity = await context.Set<TEntity>().FirstOrDefaultAsync(x =>
                x.PlanNo == dto.PlanNo && x.ActiveFlag == 1);

            if (entity is null)
                throw new EntityNotFoundException("Std for given key not found");

            _mapEntity(entity, dto);

            await context.SaveChangesAsync();

            _l2CommunicationHandler.UpdateConfig(AggregateName);

            return _toDto(entity);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<List<TDto>> UpdateAll(List<TDto> dtos)
        {
            if (dtos.Any(x => x.PlanNo == 0))
                throw new EntityNotFoundException("Plan number cannot have value 0");

            var context = _dbContextProvider.GetDbContext();
            if (dtos is null || !dtos.Any())
                throw new UserFriendlyException("Input list is empty or null");

            List<TDto> updatedDtos = new();

            foreach (var dto in dtos)
            {
                // Can't fetch all because LINQ can't translate this query
                //var entitiesToUpdate = await _stdRepository.GetAll()
                //    .Where(entity => keys.Any(key => entity.Planno == key.PlanNo && entity.Activeflag == key.ActiveFlag))
                //    .ToListAsync();

                var entity = await context.Set<TEntity>().FirstOrDefaultAsync(x =>
                    x.PlanNo == dto.PlanNo && x.ActiveFlag == 1);

                if (entity is null)
                {
                    Logger.Warn($"Entity not found for PlanNo: {dto.PlanNo}. Skipping update.");
                    continue;
                }

                _mapEntity(entity, dto);

                updatedDtos.Add(_toDto(entity));
            }

            await context.SaveChangesAsync();

            _l2CommunicationHandler.UpdateConfig(AggregateName);

            return updatedDtos;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(int planNo)
        {
            if (planNo == 0)
                throw new EntityNotFoundException("Cannot delete strategy with plan number 0");

            var context = _dbContextProvider.GetDbContext();
            var entity = await context.Set<TEntity>().FirstOrDefaultAsync(x =>
                x.PlanNo == planNo && x.ActiveFlag == 1);

            if (entity is null)
                throw new EntityNotFoundException("Std for given key not found");

            var aggregateSortIdsUsingThisPlan = await context.AggregateSelections
                .Where(x => x.Aggregate == AggregateName)
                .Where(x =>
                    x.PlanNoInd0 == planNo ||
                    x.PlanNoInd1 == planNo ||
                    x.PlanNoInd2 == planNo ||
                    x.PlanNoInd3 == planNo)
                .Select(x => x.SortId)
                .ToListAsync();

            if (aggregateSortIdsUsingThisPlan.Any())
                throw new UserFriendlyException($"Can't delete, because this plan is used in " +
                    $"'{nameof(AggregateSelection)}' with '{nameof(AggregateSelection.SortId)}': [{string.Join(", ", aggregateSortIdsUsingThisPlan)}]");

            context.Set<TEntity>().Remove(entity);

            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Checks if STD key already exists.
        /// Works both for STD and STDPASS, because they must exist in both tables.
        /// </summary>
        /// <param name="key">STD key</param>
        /// <returns>True if valid, false otherwise</returns>
        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<bool> IsStdKeyValid(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            if (planNo == 0)
                return false;
            bool exist = await context.Set<TEntity>().AnyAsync(x => x.PlanNo == planNo);
            return !exist;
        }
    }
}
