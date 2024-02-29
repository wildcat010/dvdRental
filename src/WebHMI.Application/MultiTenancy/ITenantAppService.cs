using Abp.Application.Services;
using WebHMI.MultiTenancy.Dto;

namespace WebHMI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}



