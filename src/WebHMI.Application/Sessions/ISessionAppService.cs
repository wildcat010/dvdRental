using System.Threading.Tasks;
using Abp.Application.Services;
using WebHMI.Sessions.Dto;

namespace WebHMI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}


