using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace WebHMI.Authorization
{
    public class WebHMIAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(Permissions.Pages_Users);

            context.CreatePermission(Permissions.Pages_Roles);

            context.CreatePermission(Permissions.Pages_Audit);
        }
    }
}


