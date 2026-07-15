using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.ApsRef;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions.Strategy;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.API.Services.StrategyServices
{
    public class ApsRefService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;

        public ApsRefService(IDbContextProvider<PrdbContext> prdbContextProvider)
        {
            _prdbContextProvider = prdbContextProvider;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<ApsRefDto> Create(ApsRefDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var exist = await context.ApsRefs
                .AnyAsync(x => x.KeyName == input.KeyName && input.KeyType == x.KeyType);

            if (exist)
                throw new UserFriendlyException($"Record with unique key " +
                    $"({nameof(ApsRefDto.KeyName)} = '{input.KeyName}' and " +
                    $"{nameof(ApsRefDto.KeyType)} = '{input.KeyType}') " +
                    $"already exists");

            var entity = input.ToEntity();
            context.ApsRefs.Add(entity);

            return entity.MapToDto();
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<ApsRefDto> Get(string keyName, string keyType)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.ApsRefs
                .FirstOrDefaultAsync(x => x.KeyName == keyName && x.KeyType == keyType);

            if (entity is null)
                throw new EntityNotFoundException("Aps ref for given key not found");

            return entity.MapToDto();
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<PagedResultDto<ApsRefDto>> GetAll(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var query = context.ApsRefs.AsQueryable();

            return await ApplyFilter(query, input, ApsRefMapper.MapToDto);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<ApsRefDto> Update(ApsRefDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.ApsRefs
                .SingleOrDefaultAsync(x => x.KeyName == input.KeyName && x.KeyType == input.KeyType);

            if (entity is null)
                throw new EntityNotFoundException(
                    $"Aps not found for given {nameof(ApsRefDto.KeyName)} and {nameof(ApsRefDto.KeyType)}");

            entity.MapFromDto(input);

            return entity.MapToDto();
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(string keyName, string keyType)
        {
            var context = _prdbContextProvider.GetDbContext();

            var entity = await context.ApsRefs
                .SingleOrDefaultAsync(x => x.KeyName == keyName && x.KeyType == keyType);

            if (entity is null)
                throw new EntityNotFoundException("Aps ref for given key not found");

            context.ApsRefs.Remove(entity);
        }
    }
}
