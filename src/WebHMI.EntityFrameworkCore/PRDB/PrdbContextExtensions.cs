using Abp.Domain.Entities;
using Abp.UI;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}
