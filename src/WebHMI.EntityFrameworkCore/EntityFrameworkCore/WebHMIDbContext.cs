using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WebHMI.Authorization.Roles;
using WebHMI.Authorization.Users;
using WebHMI.MultiTenancy;

namespace WebHMI.EntityFrameworkCore
{
    public class WebHMIDbContext : AbpZeroDbContext<Tenant, Role, User, WebHMIDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebHMIDbContext(DbContextOptions<WebHMIDbContext> options)
            : base(options)
        {
        }
    }
}


