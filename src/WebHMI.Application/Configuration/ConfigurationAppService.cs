using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WebHMI.Configuration.Dto;

namespace WebHMI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebHMIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}


