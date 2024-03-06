using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Authorization.Users;
using WebHMI.Dtos;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.WebHMI;

namespace WebHMI.Services
{
	public class TestAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private readonly IDbContextProvider<WebHMIDbContext> _hmiContextProvider;

		public TestAppService(
			IDbContextProvider<PrdbContext> prdbContextProvider,
			IDbContextProvider<WebHMIDbContext> hmiContextProvider)
		{
			_prdbContextProvider = prdbContextProvider;
			_hmiContextProvider = hmiContextProvider;
		}

		// Test CRUD PRDB database

		[Audited]
		public async Task<Stddirdccoiler> Create(int planNo)
		{
			var context = await _prdbContextProvider.GetDbContextAsync();

			var record = new Stddirdccoiler
			{
				Planno = planNo,
				Description = "hmi core test"
			};

			await context.Stddirdccoilers.AddAsync(record);
			await CurrentUnitOfWork.SaveChangesAsync();
			return record;
		}

		public async Task<PagedResultDto<Stddirdccoiler>> GetAll(FilteredRequestDto filter)
		{ 
			var context = await _prdbContextProvider.GetDbContextAsync();
			return await ApplyFilterWithoutMapping(context.Stddirdccoilers.AsQueryable(), filter);
		}

		[Audited]
		public async Task<Stddirdccoiler> Update(int planNo, string newDescription)
		{
			if (string.IsNullOrWhiteSpace(newDescription))
				throw new UserFriendlyException("Description can't be empty");

			var context = await _prdbContextProvider.GetDbContextAsync();

			var record = await context.Stddirdccoilers.FirstOrDefaultAsync(x => x.Planno == planNo);
			record.Description = newDescription;

			await CurrentUnitOfWork.SaveChangesAsync();
			return record;
		}

		[Audited]
		public async Task Delete(int planNo)
		{
			var context = await _prdbContextProvider.GetDbContextAsync();

			var record = await context.Stddirdccoilers.FirstOrDefaultAsync(x => x.Planno == planNo);

			if (record is null)
				throw new EntityNotFoundException("Plan not found");

			context.Stddirdccoilers.Remove(record);
		}

		// Test PRDB View

		public async Task<VMatStructEntry> GetMaterial(int meid, string matType)
		{
			var context = await _prdbContextProvider.GetDbContextAsync();
			return await context.GetMaterialEntryStruct(meid, matType);
		}

		public async Task<List<MeCodeDto>> GetMeCodes()
		{
			var context = await _prdbContextProvider.GetDbContextAsync();

			return (await context.VMatStructEntries.ToListAsync())
				.Select(x => x.ToMeCodeDto())
				.ToList();
		}

		// Test Hmi database

		public async Task<List<User>> GetHmiUsers()
		{
			var context = await _hmiContextProvider.GetDbContextAsync();

			var records = await context.Users.ToListAsync();
			return records;
		}

		// Others

		public TestDto GetTestDto(TestDto ignoredInput)
		{
			return new TestDto();
		}

		public class TestDto
		{
			/// <summary>
			/// Example description
			/// </summary>
			public TimeSpan Duration { get; set; } = TimeSpan.FromSeconds(213742069);
		}
	}
}
