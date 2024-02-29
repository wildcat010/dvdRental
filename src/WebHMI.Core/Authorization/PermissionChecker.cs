using Abp.Authorization;
using WebHMI.Authorization.Roles;
using WebHMI.Authorization.Users;

namespace WebHMI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}


