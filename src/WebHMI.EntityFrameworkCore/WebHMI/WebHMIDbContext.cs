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
				.HasColumnType("CLOB"); // largest 'string' in Oracle

			modelBuilder.Entity<AuditLog>()
				.Property(e => e.ReturnValue)
				.HasColumnType("CLOB"); // largest 'string' in Oracle
		}
	}
}

