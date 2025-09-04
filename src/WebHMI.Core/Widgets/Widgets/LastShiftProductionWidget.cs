using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using WebHMI.Core.Widget.Models;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Core.Widget.Widgets
{
	public class LastShiftsProductionWidget : BaseWidget<ShiftAggregatedResultWidgetData>, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
		private readonly int _howManyShifts = 6;


		public LastShiftsProductionWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdLastShiftsProduction;
		}

		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult();

			return base.Initialize();
		}

		[UnitOfWork]
		public override async Task Update()
		{
			Logger.Info($"Calculating widget LastShiftsProductionWidget");
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

			await base.Update();
		}

		protected override long GetRefreshPeriodInSeconds() => 60;
		private string FormatShiftTime(DateTime? time)
		{
			return (time ?? DateTime.UtcNow).ToString("dd MM HH:mm");
		}

		private Task ReadData()
		{
			//var context = _dbContextProvider.GetDbContext();
			//var result = new List<SingleShiftAggregatedResultWidgetData>();
			//var shiftsFromCalender = context.ShiftCalenders
			//	.OrderByDescending(x => x.Id)
			//	.ToList();
			//for (int i = 0; i <= _howManyShifts; i++)
			//{
			//	var sc = shiftsFromCalender[i];
			//	var res = context.HmiVProductHistories
			//		.GroupBy(d => d.FkShiftCalOnProduced)
			//		.Select(
			//		   d => new
			//		   {
			//			   AggregatedWeight = d.Sum(g => g.Weight),
			//			   CountProducts = d.Count(),
			//			   FkShiftCalOnProduced = d.Key
			//		   })
			//		.Where(f => f.FkShiftCalOnProduced == sc.Id)
			//		.FirstOrDefault();

			//	var el = new SingleShiftAggregatedResultWidgetData();
			//	el.ShiftNo = sc.Id;
			//	el.ShiftInfo = $"{FormatShiftTime(sc.PlannedShiftStart)} - {FormatShiftTime(sc.PlannedShiftEnd)}"; 
			//	el.TotalProductsWeight = res?.AggregatedWeight ?? 0.0;
			//	el.CountProducts = res?.CountProducts ?? 0;
			//	result.Add(el);
			//}
			//Data.LastShiftsSummary = result;
			return Task.CompletedTask;

		}
	}
}
