using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebHMI.Core.Widget.Models;
using WebHMI.Notification;
using WebHMI.PRDB;

namespace WebHMI.Core.Widget.Widgets
{
	public class ProdSequenceByWidthWidget : BaseWidget<StandardDistributionWidgetData>, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;

		public ProdSequenceByWidthWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdProdSummaryByWidth;
		}

		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult(); // test

			return base.Initialize();
		}

		[UnitOfWork]
		public override async Task Update()
		{
			Logger.Debug($"Calculating widget ProdSequenceByWidthWidget");
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
              .GroupBy(d => d.WExit)
					.Select(
					   d => new
					   {
                           AggregatedWeight = d.Sum(g => (double)g.WeightEntry),
						   CountProducts = d.Count(),
						   WidthExit = d.Key
					   })
					.OrderByDescending(d => d.AggregatedWeight)
					 .ToListAsync();

			foreach (var el in res)
			{
				var nfi = new NumberFormatInfo { NumberDecimalSeparator = "." };
				result.Add(new StadnardDistributionOneItem { Key = Math.Round(el.WidthExit ?? 0.0, 3).ToString(nfi), Value = el.AggregatedWeight });
			}
			Data.ProductionDistributionData = result;
		}
	}
}
