using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.AggregateDtos;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Mapping.Extensions.Strategy;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMIApplication.Dtos.Filters;

namespace WebHMI.API.Services.StrategyServices
{
    public class AggregateService : ApplicationServiceBase
    {
        private readonly IL2CommunicationHandler _l2CommunicationHandler;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;


        public AggregateService(IDbContextProvider<PrdbContext> prdbContextProvider,
            IL2CommunicationHandler l2CommunicationHandler)
        {
            _prdbContextProvider = prdbContextProvider;
            _l2CommunicationHandler = l2CommunicationHandler;
        }

        /// <summary>
        /// Creates aggregate. RecId will be calculated automatically
        /// </summary>
        /// <returns>Created aggregate</returns>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<AggregateSelectionDto> Create(AggregateSelectionDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            var lastRecId = await context.AggregateSelections
                .OrderByDescending(x => x.RecId)
                .Select(x => x.RecId)
                .FirstOrDefaultAsync();

            var entity = input.ToEntity(lastRecId);
            await context.AggregateSelections.AddAsync(entity);

            await context.SaveChangesAsync();
            //notifying LDS about changed strategy assignments
            _l2CommunicationHandler.UpdateConfig(String.Empty);

            return entity.MapToDto();
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<AggregateSelectionDto> Get(int recId, int active, string aggregate)
        {
            var context = _prdbContextProvider.GetDbContext();

            var result = await context.AggregateSelections
            .FirstOrDefaultAsync(x => x.Active == active && x.RecId == recId && x.Aggregate == aggregate)
            ?? throw new UserFriendlyException("Entity for given key not found.");

            return result.MapToDto();
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<PagedResultDto<AggregateSelectionDto>> GetAll(AggregateFilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            var query = context.AggregateSelections.AsQueryable();
            query = ApplyAggregateFilter(input, query);
            return await ApplyFilter(query, input, AggregateSelectionMapper.MapToDto);
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<List<string>> GetApsKeys()
        {
            var context = _prdbContextProvider.GetDbContext();

            return await context.ApsRefs
                .Select(x => x.ApsKey)
                .Distinct()
                .ToListAsync();
        }

        /// <summary>
        /// Updates aggregate entry found by given recId
        /// </summary>
        /// <returns>Updated aggregate</returns>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<AggregateSelectionDto> Update(AggregateSelectionDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.AggregateSelections
                .SingleOrDefaultAsync(x => x.Active == input.Active && x.RecId == input.RecId && x.Aggregate == input.Aggregate)
                ?? throw new UserFriendlyException("Aggregate not found for given id");

            entity.MapFromDto(input);
            await context.SaveChangesAsync();
            //notifying LDS about changed strategy assignments
            _l2CommunicationHandler.UpdateConfig(String.Empty);

            return entity.MapToDto();
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(int recId, int active, string aggregate)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.AggregateSelections
                .SingleOrDefaultAsync(x => x.Active == active && x.RecId == recId && x.Aggregate == aggregate)
                ?? throw new UserFriendlyException("Aggregate not found for a given id");

            context.AggregateSelections.Remove(entity);
            await context.SaveChangesAsync();
            //notifying LDS about changed strategy assignments
            _l2CommunicationHandler.UpdateConfig(String.Empty);

        }
        private static IQueryable<AggregateSelection> ApplyAggregateFilter(AggregateFilteredRequestDto input, IQueryable<AggregateSelection> query)
        {
            var entityType = typeof(AggregateSelection);

            if (input.FromToFilters?.PropName.Any() ?? false)
            {
                var propNameCount = input.FromToFilters.PropName.Count();
                var valueCount = input.FromToFilters.Value.Count();

                if (propNameCount != valueCount)
                {
                    throw new UserFriendlyException("Number of PropNames and Values parameters of FromTo should be equal.");
                }

                for (int i = 0; i < propNameCount; i++)
                {
                    string fromPropertyName = $"{input.FromToFilters.PropName[i]}from";
                    string toPropertyName = $"{input.FromToFilters.PropName[i]}to";

                    var fromPropertyInfo = entityType.GetProperty(fromPropertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    var toPropertyInfo = entityType.GetProperty(toPropertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

                    if (fromPropertyInfo is null || toPropertyInfo is null)
                        throw new UserFriendlyException($"Columns '{fromPropertyName}' and '{toPropertyName}' for provided '{nameof(input.FromToFilters.PropName)}' don't exist");

                    string fromCondition = $"{fromPropertyName} == null || {fromPropertyName} <= @0";
                    string toCondition = $"{toPropertyName} == null || {toPropertyName} > @0";
                    string combinedCondition = $"({fromCondition}) AND ({toCondition})";

                    query = query.Where(combinedCondition, input.FromToFilters.Value[i]);
                }
            }

            if (input.PlanFilter?.PropNames.Any() ?? false)
            {
                List<string> planCondition = new();

                foreach (var planPropName in input.PlanFilter.PropNames)
                {
                    var planPropertyInfo = entityType.GetProperty(planPropName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    if (planPropertyInfo is null)
                        throw new UserFriendlyException($"Column '{planPropName}' provided in '{nameof(AggregatePlanFilter.PropNames)}' collection don't exist");

                    planCondition.Add($"{planPropName} == {input.PlanFilter.Value}");
                }

                string combinedPlanCondition = string.Join(" || ", planCondition);
                query = query.Where(combinedPlanCondition, input.PlanFilter.Value);
            }

            return query;
        }
    }
}
