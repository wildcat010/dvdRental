using Abp.Domain.Entities;
using Abp.UI;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.PRDB
{
	public static class PrdbContextExtensions
	{
		public static async Task<VMatStructEntry> GetMaterialEntryStruct(this PrdbContext prdbContext, long meid, string matType)
		{
			var result = matType switch
			{
				"OR" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enormeid == meid),
				"LO" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enlomeid == meid),
				"PH" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enphmeid == meid),
				_ => throw new UserFriendlyException($"Material type unknown. Use ['OR', 'LO', 'PH']")
			};

			return result ?? throw new EntityNotFoundException($"Material with meid '{meid}' and matType '{matType}' not found");
		}
	}
}
