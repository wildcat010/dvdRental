using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebHMI.Core.Widget.Models;
using WebHMI.Notification;
using WebHMI.PRDB;


namespace WebHMI.Core.Widget.Widgets
{
    public class ProdSequenceByAlloyCodeWidget : BaseWidget<StandardDistributionWidgetData>, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;

		public ProdSequenceByAlloyCodeWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdProdSummaryByAlloyCode;
		}


		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult(); // test

			return base.Initialize();
		}

		[UnitOfWork]
		public override async Task Update()
		{
			Logger.Debug($"Calculating widget ProdSummaryByAlloyCodeWidget");
			try
			{
				await ReadData();
			}
			catch (Exception ex)
			{
				Data.Status = WidgetCalculationStatus.Error;
				Logger.Error($"Calculate widget {Data.WidgetId} error", ex);
				throw;
			}

			await base.Update();
		}

		protected override long GetRefreshPeriodInSeconds() => 60;

		private async Task ReadData()
		{
			List<StadnardDistributionOneItem> result = new List<StadnardDistributionOneItem>();

			var context = _dbContextProvider.GetDbContext();	
			var res = await context.HmiVProdsequenceCompletes
				.GroupBy(d => d.Alloycode)
					.Select(
					   d => new
					   {
						   AggregatedWeight = d.Sum(g => (double)g.Weightentry),
						   CountProducts = d.Count(),
						   Alloycode = d.Key
					   })
					.OrderByDescending(d => d.AggregatedWeight)
			.ToListAsync();

			foreach (var el in res)
			{
				result.Add(new StadnardDistributionOneItem { Key = el.Alloycode, Value = el.AggregatedWeight });
			}
			Data.ProductionDistributionData = result;
		}
	}
}
