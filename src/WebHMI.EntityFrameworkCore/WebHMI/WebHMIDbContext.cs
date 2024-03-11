using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.Auditing;
using WebHMI.WebHMI.Dbo;

namespace WebHMI.WebHMI
{
	public class WebHMIDbContext : AbpZeroDbContext<Tenant, Role, User, WebHMIDbContext>
	{
		public WebHMIDbContext(DbContextOptions<WebHMIDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<AuditLog>()
				.Property(e => e.Parameters)
				.HasMaxLength(int.MaxValue);

			modelBuilder.Entity<AuditLog>()
				.Property(e => e.ReturnValue)
				.HasMaxLength(int.MaxValue);
		}
	}
}

