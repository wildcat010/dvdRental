using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Material;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Helpers
{
	public class MatStructEntryService : ITransientDependency
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;

		public MatStructEntryService(IDbContextProvider<PrdbContext> prdbContextProvider)
		{
			_prdbContextProvider = prdbContextProvider;
		}

		public async Task<VMatStructEntry> GetMaterialEntryStruct(MaterialKeyDto key)
		{
			var context = await _prdbContextProvider.GetDbContextAsync();
			var result = await context.GetMaterialEntryStruct(key.MeId, key.MatType);
			return result ?? throw new EntityNotFoundException($"Material with meid '{key.MeId}' and matType '{key.MatType}' not found");
		}
	}
}
