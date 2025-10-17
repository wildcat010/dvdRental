using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Runtime.Caching;
using AutoMapper.Internal.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Limit;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

#pragma warning disable RS0030

namespace WebHMI.Services
{
    public class LimitAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly ITypedCache<LimitKeyDto, LimitDto> _cache;
        private readonly IL2CommunicationHandler _l2Sender;

        public LimitAppService(
            ICacheManager cacheManager,
            IL2CommunicationHandler l2CommunicationHandler,
            IDbContextProvider<PrdbContext> prdbContextProvider)
        {
            _cache = cacheManager.GetCache<LimitKeyDto, LimitDto>(nameof(LimitDto));
            _l2Sender = l2CommunicationHandler;
            _prdbContextProvider = prdbContextProvider;
        }

        /// <summary>
        /// Function to get all plant limits
        /// </summary>
        /// <returns></returns>
        [AbpAuthorize(Permissions.Pages_Limits)]
        public async Task<PagedResultDto<LimitDto>> GetAll(FilteredRequestDto input)
        {
            var result = await ApplyFilter<PlantLimit, LimitDto>(
                _prdbContext.PlantLimits.OrderByDescending(t => t.Toc),
                input, LimitMapper.MapToDto);

            return result;
        }

        /////// <summary>
        /////// Function to get single limit by given Id
        /////// </summary>
        /////// <param name="id"></param>
        /////// <returns></returns>
        ////[AbpAuthorize(Permissions.Pages_Limits)]
        ////public async Task<List<LimitDto>> GetByIds(List<LimitKeyDto> ids)
        ////{
        ////    LimitKeyDto[] x = ids.ToArray();
        ////    var limit = await _cache.GetAsync(x,
        ////         async (key) =>
        ////            ObjectMapper.Map<LimitDto>(await _prdbContext.PlantLimits
        ////            .FirstOrDefaultAsync(x => x.LimitName == key.Limitname && x.PlantType == key.Planttype.ToString()))
        ////        );

        ////    return limit.ToList();
        ////}
        /// <summary>
        /// Function to get single limit by given Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 


        [AbpAuthorize(Permissions.Pages_Limits)]
        public async Task<List<LimitDto>> GetByIds(List<string> limitNames, List<string> plantTypes)
        {
            if (limitNames.Count != plantTypes.Count)
                throw new Abp.UI.UserFriendlyException("All parameters must be provided.");

            var context = _prdbContextProvider.GetDbContext();
            var cacheKeys = new List<string>();
            var result = new List<LimitDto>();

            for (int i = 0; i < limitNames.Count; i++)
            {
                var cacheKey = new LimitKeyDto(limitNames[i], plantTypes[i]);
                var limitName = limitNames[i];
                var plantType = plantTypes[i];

                var item = await _cache.GetAsync(cacheKey,
                    async () =>
                    {
                        var limit = await context.PlantLimits
                            .Where(x => x.LimitName == limitNames[i] && x.PlantType == plantTypes[i])
                            .FirstOrDefaultAsync();

                        return limit?.MapToDto();
                    });

                if (item != null)
                    result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Create single limit async method
        /// </summary>
        /// <param name="limitDto"></param>
        /// <returns></returns>
        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_Limits_Edit)]
        public async Task<LimitDto> CreateAsync(LimitDto limitDto)
        {
            var plantlimit = limitDto.MapToDbo();
            _prdbContext.PlantLimits.Add(plantlimit);
            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.Limit, limitDto.Planttype);

            return plantlimit.MapToDto();
        }

        /// <summary>
        /// Update single limit async method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_Limits_Edit)]
        public async Task<LimitDto> UpdateAsync(LimitDto input)
        {
            var cacheKey = new LimitKeyDto(input.LimitName, input.PlantType);
            _cache.Remove(cacheKey);

            var plantLimit = await _prdbContext.PlantLimits.FirstOrDefaultAsync(x => x.LimitName == input.LimitName && x.PlantType == input.PlantType);

            plantLimit.CType = input.CType;
            plantLimit.Description = input.Description;
            plantLimit.LowerLimit = input.LowerLimit;
            plantLimit.Moddescr = input.Moddescr;
            plantLimit.SortOrder = input.SortOrder;
            plantLimit.Unit = input.Unit;
            plantLimit.UpperLimit = input.UpperLimit;

            var limitDto = plantLimit.MapToDto();
            await _cache.SetAsync(cacheKey, limitDto);

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.Limit, input.Planttype);

            return limitDto;
        }

        /// <summary>
        /// Delete single limit async method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_Limits_Delete)]
        public async Task DeleteAsync(DeleteLimitDto input)
        {
            _cache.Remove(new LimitKeyDto(input.Limitname, input.Planttype));

            var limits = _prdbContext.PlantLimits.Where(x => x.LimitName == input.Limitname && x.PlantType == input.Planttype.ToString());
            _prdbContext.PlantLimits.RemoveRange(limits);
            await CurrentUnitOfWork.SaveChangesAsync();

           // _l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.Limit, input.Planttype);
        }
    }
}
