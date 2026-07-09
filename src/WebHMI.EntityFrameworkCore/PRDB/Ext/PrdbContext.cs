using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;

namespace WebHMI.PRDB
{
	public partial class PrdbContext : AbpDbContext
	{
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{
			TreatDatabaseDateAsUtc(modelBuilder);

            modelBuilder.Entity<Lppass>(entity =>
            {
                entity.Property(e => e.Passno).ValueGeneratedNever();
            });
        }

		public override async Task<int> SaveChangesAsync(CancellationToken ct = default)
		{
            await EnsureAllEdTablesInserted(ct);

            return await base.SaveChangesAsync(ct);
		}

        /// <summary>
        /// Ensures that all newly inserted materials in ED tables have their counterparts in other ED tables
        /// </summary>
        private async Task EnsureAllEdTablesInserted(CancellationToken ct)
        {
            var addedEdordentMeids = ChangeTracker.Entries<Edordent>()
                .Where(e => e.State == EntityState.Added && e.Entity.Source == "M")
                .Select(e => e.Entity.Meid);

            var addedEdlogentMeids = ChangeTracker.Entries<Edlogent>()
                .Where(e => e.State == EntityState.Added && e.Entity.Source == "M")
                .Select(e => e.Entity.Meid);

            var addedEdphyentMeids = ChangeTracker.Entries<Edphyent>()
                .Where(e => e.State == EntityState.Added && e.Entity.Source == "M")
                .Select(e => e.Entity.Meid);

            var matStructs = await VMatStructEntries
                .Where(e =>
                    addedEdordentMeids.Contains(e.Enormeid) ||
                    addedEdlogentMeids.Contains(e.Enlomeid) ||
                    addedEdphyentMeids.Contains(e.Enphmeid))
                .ToListAsync(ct);

            foreach (var matStruct in matStructs)
            {
                if (!addedEdordentMeids.Contains(matStruct.Enormeid) && !await Edordents.AnyAsync(t => t.Meid == matStruct.Enormeid && t.Source == "M", ct))
                    await Edordents.AddAsync(PrdbContextExtensions.CreateEntity<Edordent>(matStruct, "M"), ct);

                if (!addedEdlogentMeids.Contains(matStruct.Enlomeid) && !await Edlogents.AnyAsync(t => t.Meid == matStruct.Enlomeid && t.Source == "M", ct))
                    await Edlogents.AddAsync(PrdbContextExtensions.CreateEntity<Edlogent>(matStruct, "M"), ct);

                if (!addedEdphyentMeids.Contains(matStruct.Enphmeid) && !await Edphyents.AnyAsync(t => t.Meid == matStruct.Enphmeid && t.Source == "M", ct))
                    await Edphyents.AddAsync(PrdbContextExtensions.CreateEntity<Edphyent>(matStruct, "M"), ct);
            }
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
