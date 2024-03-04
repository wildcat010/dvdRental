using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Prdb;
using WebHMI.PRDB;

namespace WebHMI.Services
{
	public class TestService : WebHMIAppServiceBase
	{
		private readonly PrdbContext _dbContext;

		public TestService(PrdbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<Spord1pc>> GetAll()
		{
			var records = await _dbContext.Spord1pcs.ToListAsync();
			return records;
		}
	}
}
