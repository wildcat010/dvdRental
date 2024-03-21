using Abp.Domain.Entities;
using Abp.UI;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.API.Prdb.Abstract;
using WebHMI.PRDB.Dbo;

namespace WebHMI.PRDB
{
    public static class PrdbContextExtensions
    {
        public static async Task<VMatStructEntry> GetMaterialEntryStruct(this PrdbContext prdbContext, long meId, string matType) =>
            matType switch
            {
                "OR" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.EnOrMeId == meId),
                "LO" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.EnLoMeId == meId),
                "PH" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.EnPhMeId == meId),
                _ => null
            };

        public static TEntity InsertIfNull<TEntity>(
            this PrdbContext prdbContext,
            TEntity entity,
            VMatStructEntry entryMatStruct,
            string source = "M")
            where TEntity : class, IMaterialIdType, new()
        {
            if (entity is not null)
                return entity;

            entity = CreateEntity<TEntity>(entryMatStruct, source);
            return prdbContext.Add(entity).Entity;
        }

        private static TEntity CreateEntity<TEntity>(
        VMatStructEntry entryMatStruct,
        string source)
        where TEntity : class, IMaterialIdType, new()
        {
            var entity = new TEntity();
            entity.Source = source;

            switch (entity)
            {
                case IMaterialIdTypeOrder:
                    entity.MeId = entryMatStruct.EnOrMeId;
                    entity.MesId = entryMatStruct.EnOrMesId ?? 1;
                    entity.MeCreator = entryMatStruct.EnOrCreator;
                    break;
                case IMaterialIdTypeLogical:
                    entity.MeId = entryMatStruct.EnLoMeId;
                    entity.MesId = entryMatStruct.EnLoMesid ?? 1;
                    entity.MeCreator = entryMatStruct.EnLoCreator;
                    break;
                case IMaterialIdTypePhysical:
                    entity.MeId = entryMatStruct.EnPhMeId;
                    entity.MesId = entryMatStruct.EnPhMesId ?? 1;
                    entity.MeCreator = entryMatStruct.EnPhCreator;
                    break;
                default:
                    throw new InvalidOperationException($"Entity must implement only one metrial id type interface");
            }

            return entity;
        }
    }
}
