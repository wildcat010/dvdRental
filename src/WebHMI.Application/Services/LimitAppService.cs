using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Runtime.Caching;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos.Limit;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
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

   

        /// <summary>
        /// Get plant limit by Ids
        /// </summary>
        /// <param name="limitNames"></param>
        /// <param name="plantTypes"></param>
        /// <returns></returns>
        /// <exception cref="Abp.UI.UserFriendlyException"></exception>
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
            if(_prdbContext.PlantLimits.Any(x=>x.PlantType == limitDto.PlantType && x.LimitName == limitDto.LimitName))
                throw new Abp.UI.UserFriendlyException("A limit with the same name and plant type already exists.");

            var plantlimit = limitDto.MapToDbo();
            _prdbContext.PlantLimits.Add(plantlimit);
            await CurrentUnitOfWork.SaveChangesAsync();

            var callArguments = new ParamsDto()
            {
                PlantType = limitDto.PlantType,
                Name = limitDto.LimitName,
                DisplayName = limitDto.LimitName,
                UserName = "user",
                OldUValue = "",
                OldLValue = "",
                NewUValue = limitDto.UpperLimit.ToString(),
                NewLValue = limitDto.LowerLimit.ToString()
            };

            _l2Sender.SendProcessParametersUpdated(callArguments);

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

            var callArguments = new ParamsDto() 
            {
                PlantType = input.PlantType,
                Name = input.LimitName,
                DisplayName = input.LimitName,
                UserName = "user",
                OldUValue = plantLimit.UpperLimit.ToString(),
                OldLValue = plantLimit.LowerLimit.ToString(),
                NewUValue = input.UpperLimit.ToString(),
                NewLValue = input.LowerLimit.ToString()
            };

            plantLimit.CType = input.CType;
            plantLimit.Description = input.Description;
            plantLimit.LowerLimit = input.LowerLimit;
            plantLimit.Moddescr = input.Moddescr;
            plantLimit.SortOrder = input.SortOrder;
            plantLimit.Unit = input.Unit;
            plantLimit.UpperLimit = input.UpperLimit;

            var limitDto = plantLimit.MapToDto();
            await _cache.SetAsync(cacheKey, limitDto);

            _l2Sender.SendProcessParametersUpdated(callArguments);

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

            var callArguments = new ParamsDto()
            {
                PlantType = input.Planttype,
                Name = input.Limitname,
                DisplayName = "",
                UserName = "",
                OldUValue = "",
                OldLValue = "",
                NewUValue = "",
                NewLValue = ""
            };

            _l2Sender.SendProcessParametersUpdated(callArguments);
        }
    }
}

