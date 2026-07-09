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

            var seq = (await context.HmiVProdsequenceCompletes
                .Select(x => new { x.Sequenceid, x.Pnext })
                .FirstOrDefaultAsync(x => x.Pnext == 1));

            if (seq is null)
                return "-1";

            return seq.Sequenceid;
        }

        private async Task ReadData()
		{
			var context = _dbContextProvider.GetDbContext();

            //var actualSeqId = await GetActualSequenceId();

            var prodSequences = context.HmiVProdsequenceCompletes
                .OrderBy(x => x.Position)
                .AsEnumerable();
               // .Where(x => x.SequenceId == actualSeqId);

			var result = new List<KeyValuePair<string, SingleProdSequenceThicknessWidth>>();

			foreach (var el in prodSequences)
			{
				result.Add(new KeyValuePair<string, SingleProdSequenceThicknessWidth>(
					el.Enorextid,
					new SingleProdSequenceThicknessWidth
					{
						EntryThickness = el.Hentry,
						ExitThickness = el.Hexit,
						Width = el.Wexit,
						HeatId = el.Heatid,
						SeqId = el.Sequenceid,
						FlagNext = el.Pnext,
						Status = el.Enorstatus,
                    }));
			}

			Data.ProductionDistributionData = result;
		}
	}
}
