using System.Threading.Tasks;
using WebHMI.Configuration.Dto;

namespace WebHMI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}


