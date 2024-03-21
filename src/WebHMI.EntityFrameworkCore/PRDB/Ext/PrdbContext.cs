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

			// You can modify generated entities here, example:

			//modelBuilder.Entity<LogDatum>(entity =>
			//{
			//	entity.HasKey(e => e.Entryid);
			//});
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
            var addedEdordentMeids = ChangeTracker.Entries<EdOrdEnt>()
                .Where(e => e.State == EntityState.Added && e.Entity.Source == "M")
                .Select(e => e.Entity.MeId);

            var addedEdlogentMeids = ChangeTracker.Entries<EdLogEnt>()
                .Where(e => e.State == EntityState.Added && e.Entity.Source == "M")
                .Select(e => e.Entity.MeId);

            var addedEdphyentMeids = ChangeTracker.Entries<EdPhyEnt>()
                .Where(e => e.State == EntityState.Added && e.Entity.Source == "M")
                .Select(e => e.Entity.MeId);

            var matStructs = await VMatStructEntries
                .Where(e =>
                    addedEdordentMeids.Contains(e.EnOrMeId) ||
                    addedEdlogentMeids.Contains(e.EnLoMeId) ||
                    addedEdphyentMeids.Contains(e.EnPhMeId))
                .ToListAsync(ct);

            foreach (var matStruct in matStructs)
            {
                if (!addedEdordentMeids.Contains(matStruct.EnOrMeId) && !await EdOrdEnts.AnyAsync(t => t.MeId == matStruct.EnOrMeId && t.Source == "M", ct))
                    await EdOrdEnts.AddAsync(PrdbContextExtensions.CreateEntity<EdOrdEnt>(matStruct, "M"), ct);

                if (!addedEdlogentMeids.Contains(matStruct.EnLoMeId) && !await EdOrdEnts.AnyAsync(t => t.MeId == matStruct.EnLoMeId && t.Source == "M", ct))
                    await EdLogEnts.AddAsync(PrdbContextExtensions.CreateEntity<EdLogEnt>(matStruct, "M"), ct);

                if (!addedEdphyentMeids.Contains(matStruct.EnPhMeId) && !await EdOrdEnts.AnyAsync(t => t.MeId == matStruct.EnPhMeId && t.Source == "M", ct))
                    await EdPhyEnts.AddAsync(PrdbContextExtensions.CreateEntity<EdPhyEnt>(matStruct, "M"), ct);
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
