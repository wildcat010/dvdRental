using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
	public class ProdSequenceByThicknessWidget : BaseWidget<StandardDistributionWidgetData>, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
		public ProdSequenceByThicknessWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdProdSummaryByThickness;
		}


		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult(); // test

			return base.Initialize();
		}

		[UnitOfWork]
		public override async Task Update()
		{
			Logger.Debug($"Calculating widget ProdSummaryByThicknessWidget");
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

			var res = await context.HmiVProdsequences
				.GroupBy(d => d.HExit)
					.Select(
					   d => new
					   {
						   AggregatedWeight = d.Sum(g => (double)g.WeightEntry),
						   CountProducts = d.Count(),
						   ExitThickness = d.Key
					   })
					.OrderByDescending(d => d.AggregatedWeight)
					 .ToListAsync();

			foreach (var el in res)
			{
				var nfi = new NumberFormatInfo { NumberDecimalSeparator = "." };
				result.Add(new StadnardDistributionOneItem { Key = Math.Round(el.ExitThickness ?? 0.0, 5).ToString(nfi), Value = el.AggregatedWeight });
			}

			Data.ProductionDistributionData = result;
		}
	}
}
