using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace WebHMI
{
    public class WebHMIAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(Permissions.Pages_Users);

            context.CreatePermission(Permissions.Pages_Roles);

            context.CreatePermission(Permissions.Pages_Audit);

            context.CreatePermission(Permissions.Pages_SystemStatus);

            var rollData = context.CreatePermission(Permissions.Pages_RollData);
            rollData.CreateChildPermission(Permissions.Pages_RollData_Edit);
            rollData.CreateChildPermission(Permissions.Pages_RollData_Delete);

            var limits = context.CreatePermission(Permissions.Pages_Limits);
            limits.CreateChildPermission(Permissions.Pages_Limits_Edit);
            limits.CreateChildPermission(Permissions.Pages_Limits_Delete);

            var parameters = context.CreatePermission(Permissions.Pages_Parameters);
            parameters.CreateChildPermission(Permissions.Pages_Parameters_Edit);
            
            var setpointsRm = context.CreatePermission(Permissions.Pages_Setpoints_RM);
            setpointsRm.CreateChildPermission(Permissions.Pages_Setpoints_RM_Edit);
            setpointsRm.CreateChildPermission(Permissions.Pages_Setpoints_RM_Delete);

            var productionSchedule = context.CreatePermission(Permissions.Pages_ProductionSchedule);
            productionSchedule.CreateChildPermission(Permissions.Pages_ProductionSchedule_Edit);
            productionSchedule.CreateChildPermission(Permissions.Pages_ProductionSchedule_Delete);

        }
    }
}


