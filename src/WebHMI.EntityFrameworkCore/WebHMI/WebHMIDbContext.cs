using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.Auditing;
using WebHMI.WebHMI.Dbo;
using System;

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

            TreatDatabaseDateAsUtc(modelBuilder);

            modelBuilder.Entity<AuditLog>()
				.Property(e => e.Parameters)
				.HasMaxLength(int.MaxValue);

			modelBuilder.Entity<AuditLog>()
				.Property(e => e.ReturnValue)
				.HasMaxLength(int.MaxValue);
		}

        private static void TreatDatabaseDateAsUtc(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime))
                    {
                        modelBuilder.Entity(entityType.ClrType)
                         .Property<DateTime>(property.Name)
                         .HasConversion(
                          v => v.ToUniversalTime(),
                          v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
                    }
                    else if (property.ClrType == typeof(DateTime?))
                    {
                        modelBuilder.Entity(entityType.ClrType)
                         .Property<DateTime?>(property.Name)
                         .HasConversion(
                          v => v.HasValue ? v.Value.ToUniversalTime() : v,
                          v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v);
                    }
                }
            }
        }
    }
}

