using Abp.Domain.Entities;
using Abp.UI;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Material;

namespace WebHMI.PRDB
{
	public static class PrdbContextExtensions
	{
		public static async Task<VMatStructEntry> GetMaterialEntryStruct(this PrdbContext prdbContext, MaterialKey key) =>
			key.MatType switch
			{
				"OR" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enormeid == key.MeId),
				"LO" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enlomeid == key.MeId),
				"PH" => await prdbContext.VMatStructEntries.FirstOrDefaultAsync(x => x.Enphmeid == key.MeId),
				_ => null
			};
	}
}
