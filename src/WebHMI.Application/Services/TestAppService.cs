using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.Runtime.Caching;
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
using WebHMI.Material;
using WebHMI.PRDB;
using WebHMI.WebHMI;

namespace WebHMI.Services
{
	public class TestAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private readonly IDbContextProvider<WebHMIDbContext> _hmiContextProvider;
		private readonly ITypedCache<MaterialKeyDto, VMatStructEntry> _matEntryCache;
		private readonly MatStructEntryService _matStructEntryService;

		public TestAppService(
			IDbContextProvider<PrdbContext> prdbContextProvider,
			IDbContextProvider<WebHMIDbContext> hmiContextProvider,
			ICacheManager cacheManager,
			MatStructEntryService matStructEntryService)
		{
			_matEntryCache = cacheManager.GetCache<MaterialKeyDto, VMatStructEntry>(nameof(VMatStructEntry));

			_prdbContextProvider = prdbContextProvider;
			_hmiContextProvider = hmiContextProvider;
			_matStructEntryService = matStructEntryService;
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

		// Test PRDB view and caching

		public async Task<VMatStructEntry> GetMaterial(MaterialKeyDto key)
		{
			return await _matEntryCache.GetAsync(key, async () =>
			{
				var context = await _prdbContextProvider.GetDbContextAsync();
				return await _matStructEntryService.GetMaterialEntryStruct(key);
			});
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

		public async Task FlushAllCaches()
		{
			await _matEntryCache.ClearAsync();
		}

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
