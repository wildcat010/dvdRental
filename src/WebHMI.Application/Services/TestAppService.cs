using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus;
using Abp.Events.Bus.Handlers;
using Abp.Runtime.Caching;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.EventBus;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.Material;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.WebHMI;
using WebHMI.WebHMI.Dbo;

namespace WebHMI.Services
{
	public class TestAppService : ApplicationServiceBase, IAsyncEventHandler<EventWrapper<string>>
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private readonly IDbContextProvider<WebHMIDbContext> _hmiContextProvider;
		private readonly ITypedCache<MaterialKeyDto, VMatStructEntry> _matEntryCache;
		private readonly MatStructEntryService _matStructEntryService;
		private readonly IL2Sender _l2CommHandler;
		private readonly IEventBus _eventBus;
		private readonly ISignalRNotifier _signalRNotifier;

		public TestAppService(
			IDbContextProvider<PrdbContext> prdbContextProvider,
			IDbContextProvider<WebHMIDbContext> hmiContextProvider,
			ICacheManager cacheManager,
			MatStructEntryService matStructEntryService,
			IL2Sender l2CommHandler,
			IEventBus eventBus,
			ISignalRNotifier signalRNotifier)
		{
			_matEntryCache = cacheManager.GetCache<MaterialKeyDto, VMatStructEntry>(nameof(VMatStructEntry));

			_prdbContextProvider = prdbContextProvider;
			_hmiContextProvider = hmiContextProvider;
			_matStructEntryService = matStructEntryService;
			_l2CommHandler = l2CommHandler;
			_eventBus = eventBus;
			_signalRNotifier = signalRNotifier;
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

			if (newDescription == "1")
				throw new EntityNotFoundException("not found");

			if (newDescription == "2")
				throw new Exception("server exception");

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

		public async Task SendHmiRefresh(string msg)
		{
			await _eventBus.TriggerAsync(new EventWrapper<string>(msg));
		}

		[RemoteService(false)] // not visible endpoint
		public async Task HandleEventAsync(EventWrapper<string> eventData)
		{
			if (string.IsNullOrEmpty(eventData?.Data))
				return;

			await _signalRNotifier.SendHmiRefresh(eventData.Data, eventData.EventTime);
		}

		public void CallL2(string msg)
		{
			_l2CommHandler.SendTestMessage(msg);
		}

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
