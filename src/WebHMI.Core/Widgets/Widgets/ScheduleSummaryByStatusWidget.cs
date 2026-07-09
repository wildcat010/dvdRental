using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Core.Widget.Models;
using WebHMI.PRDB;
using WebHMI.Notification;

namespace WebHMI.Core.Widget.Widgets
{
    public class ScheduleSummaryByStatusWidget : BaseWidget<ScheduleSummaryWidgetData>/*, IEventHandler<EventWrapper<HmiRefresh>>*/, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
		private readonly List<string> eventKeysForUpdate = new() { "PRIMD", "COILS", "SETPC2" };
		private bool requiresAdditionalUpdate;
		public ScheduleSummaryByStatusWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdScheduleSummary;
		}
		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult();

			return base.Initialize();
		}
		//public void HandleEvent(EventWrapper<HmiRefresh> eventData) =>
		//	requiresAdditionalUpdate = eventKeysForUpdate.Contains(eventData.Data.eventKey);

		public override bool RequiresUpdate() =>
			requiresAdditionalUpdate || base.RequiresUpdate();

		[UnitOfWork]
		public override async Task Update()
		{
			try
			{
				ReadData();
			}
			catch (Exception ex)
			{
				Data.Status = WidgetCalculationStatus.Error;
				Logger.Error($"Calculate widget {Data.WidgetId} error", ex);
				throw;
			}
			requiresAdditionalUpdate = false;
			await base.Update();

		}
		protected override long GetRefreshPeriodInSeconds() => 300;

		private Task ReadData()
		{
			var context = _dbContextProvider.GetDbContext();
			Data.AllGood = context.HmiVProdsequenceCompletes
				.Where(t => t.Simmat == 0 && t.Setpointspc2ok == 1 && t.Setpointscsok == 1 && t.Pdistatus == 1) //t.creator != \"SI
                .Count();
			Data.SetpointsInvalid = context.HmiVProdsequenceCompletes
                .Where(t => t.Simmat == 0 && t.Pdistatus == 1 && t.Setpointscsok != 1 || t.Pdistatus == 1 && t.Setpointspc2ok != 1)
				.Count();
			Data.PrimaryDataInvalid = context.HmiVProdsequenceCompletes
                .Where(t => t.Simmat == 0 && t.Pdistatus != 1)
				.Count();

			return Task.CompletedTask;

		}
	}
}
