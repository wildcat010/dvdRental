using System.Threading.Tasks;
using Abp.Application.Services;
using WebHMI.Authorization.Accounts.Dto;

namespace WebHMI.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}


