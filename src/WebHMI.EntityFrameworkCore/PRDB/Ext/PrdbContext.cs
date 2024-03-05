using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHMI.PRDB
{
	public partial class PrdbContext : AbpDbContext
	{
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{
			TreatDatabaseDateAsUtc(modelBuilder);

			// You can modify generated entities here, example:

			//modelBuilder.Entity<LogDatum>(entity =>
			//{
			//	entity.HasKey(e => e.Entryid);
			//});
		}

		public override async Task<int> SaveChangesAsync(CancellationToken ct = default)
		{
			// You can override EF methods and modify them

			return await base.SaveChangesAsync(ct);
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
