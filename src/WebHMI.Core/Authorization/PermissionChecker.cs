using Abp.Authorization;
using WebHMI.Authorization.Users;
using WebHMI.WebHMI.Dbo;

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


