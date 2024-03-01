using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WebHMI.Authorization.Roles;
using WebHMI.Authorization.Users;
using WebHMI.MultiTenancy;

namespace WebHMI.EntityFrameworkCore.WebHMI
{
    public class WebHMIDbContext : AbpZeroDbContext<Tenant, Role, User, WebHMIDbContext>
    {
		public WebHMIDbContext(DbContextOptions<WebHMIDbContext> options)
            : base(options)
        {
        }
    }
}

