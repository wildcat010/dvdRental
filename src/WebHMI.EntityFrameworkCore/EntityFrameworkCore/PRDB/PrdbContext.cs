using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WebHMI.Authorization.Roles;
using WebHMI.Authorization.Users;
using WebHMI.MultiTenancy;
using Abp.EntityFrameworkCore;

namespace WebHMI.EntityFrameworkCore.PRDB
{
	public partial class PrdbContext : AbpDbContext
	{
		public PrdbContext(DbContextOptions<PrdbContext> options)
			: base(options)
		{
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}

