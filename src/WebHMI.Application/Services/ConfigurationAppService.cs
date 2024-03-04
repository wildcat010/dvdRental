using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WebHMI.Configuration;
using WebHMI.Dtos.Configuration;
using WebHMI.Helpers;

namespace WebHMI.Services
{
	[AbpAuthorize]
	public class ConfigurationAppService : WebHMIAppServiceBase
	{
		public async Task ChangeUiTheme(ChangeUiThemeInput input)
		{
			await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
		}
	}
}


