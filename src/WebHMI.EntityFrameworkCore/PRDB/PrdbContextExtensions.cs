using Abp.Domain.Entities;
using Abp.UI;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                "OR" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enormeid == meId),
                "LO" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enlomeid == meId),
                "PH" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enphmeid == meId),
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

        public static TEntity CreateEntity<TEntity>(
        VMatStructEntry entryMatStruct,
        string source)
        where TEntity : class, IMaterialIdType, new()
        {
            var entity = new TEntity();
            entity.Source = source;

            switch (entity)
            {
                case IMaterialIdTypeOrder:
                    entity.Meid = entryMatStruct.Enormeid;
                    entity.Mesid = entryMatStruct.Enormesid ?? 1;
                    entity.Mecreator = entryMatStruct.Enorcreator;
                    break;
                case IMaterialIdTypeLogical:
                    entity.Meid = entryMatStruct.Enlomeid;
                    entity.Mesid = entryMatStruct.Enlomesid ?? 1;
                    entity.Mecreator = entryMatStruct.Enlocreator;
                    break;
                case IMaterialIdTypePhysical:
                    entity.Meid = entryMatStruct.Enphmeid;
                    entity.Mesid = entryMatStruct.Enphmesid ?? 1;
                    entity.Mecreator = entryMatStruct.Enphcreator;
                    break;
                default:
                    throw new InvalidOperationException("Entity must implement only one material id type interface");
            }

            return entity;
        }
    }
}
