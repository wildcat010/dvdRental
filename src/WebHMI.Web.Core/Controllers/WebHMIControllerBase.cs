using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace WebHMI.Controllers
{
    public abstract class WebHMIControllerBase: AbpController
    {
        protected WebHMIControllerBase()
        {
            LocalizationSourceName = WebHMIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}


