using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
	public class ProdSequenceThicknessWidthWidget : BaseWidget<ProdSequenceThicknessWidthData>, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;

		public ProdSequenceThicknessWidthWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdThicknessWidth;
		}

		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult(); // test

			return base.Initialize();
		}

		[UnitOfWork]
		public override async Task Update()
		{
			Logger.Debug($"Calculating widget ProdSequenceThicknessWidthWidget.");
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

        public async Task<string> GetActualSequenceId()
        {
            var context = _dbContextProvider.GetDbContext();

            var seq = (await context.HmiVProdsequences
                .Select(x => new { x.SequenceId, x.Next })
                .FirstOrDefaultAsync(x => x.Next == 1));

            if (seq is null)
                return "-1";

            return seq.SequenceId;
        }

        private async Task ReadData()
		{
			var context = _dbContextProvider.GetDbContext();

            var actualSeqId = await GetActualSequenceId();

            var prodSequences = context.HmiVProdsequences
                .OrderBy(x => x.SequenceId)
                .AsEnumerable()
                .Where(x => x.SequenceId == actualSeqId);

			var result = new List<KeyValuePair<string, SingleProdSequenceThicknessWidth>>();

			foreach (var el in prodSequences)
			{
				result.Add(new KeyValuePair<string, SingleProdSequenceThicknessWidth>(
					el.EnOrExtId,
					new SingleProdSequenceThicknessWidth
					{
						EntryThickness = el.HEntry,
						ExitThickness = el.HExit,
						Width = el.WExit,
						HeatId = el.HeatId
                    }));
			}

			Data.ProductionDistributionData = result;
		}
	}
}
