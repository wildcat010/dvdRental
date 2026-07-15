using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Core.Widget.Models;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Core.Widget.Widgets
{
	public class PrimaryDataDefectsWidget : BaseWidget<PrimaryDataDefectsWidgetData>, ISingletonDependency
	{
		private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
		private int MeId;
		private string MatType;

		public PrimaryDataDefectsWidget(ISignalRNotifier notifier,
			IDbContextProvider<PrdbContext> dbContextProvider) : base(notifier)
		{
			_dbContextProvider = dbContextProvider;
			Data.WidgetId = WidgetDefs.WidgetIdPrimaryDataDefects;
		}

		public override Task Initialize()
		{
			Data.Defects.Add(new DefectDto());

			Update().GetAwaiter().GetResult();
			return base.Initialize();
		}

		[UnitOfWork]
		public override async Task Update()
		{
			Logger.Info($"Calculating widget PrimaryDataDefectsWidget");
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

		protected override long GetRefreshPeriodInSeconds() => 3600;

		private int GetEnPhMeId(PrdbContext context) 
		{
			int enPhMeId = 0;
			switch (MatType)
			{
				case "OR":
					enPhMeId = context.VMatStructEntries
                     .Where(x => x.EnOrMeId == MeId)
						.Select(x => x.EnPhMeId)
						.FirstOrDefault();
					break;															  
				case "PH":
					enPhMeId = context.VMatStructEntries
                     .Where(x => x.EnPhMeId == MeId)
						.Select(x => x.EnPhMeId)
						.FirstOrDefault();
					break;															  
				case "LO":
					enPhMeId = context.VMatStructEntries
                     .Where(x => x.EnLoMeId == MeId)
						.Select(x => x.EnPhMeId)
						.FirstOrDefault();
					break;
			}

			return enPhMeId;
		}

		private Task ReadData()
		{
			var context = _dbContextProvider.GetDbContext();
			var defectDtos = new List<DefectDto>();

			var enPhMeId = GetEnPhMeId(context);

			if (enPhMeId != 0)
			{
               Data.Defects = context.Defects.Where(x => x.MeId == enPhMeId && x.MesId == 1).Select(x => new DefectDto()
				{
                   DefectStart = x.DefStart,
					DefectEnd = x.DefEnd,
					DefectIntensity = x.Intensity,
                 DefectType = x.DefType,
					DefectSide = x.DefSide,
					DefectClass = x.DefClass,
					Action = x.Action,
					No = x.Sid
				}).ToList();
			}

			return Task.CompletedTask;

		}

		public void SetMeIdMatType(int meId, string matType)
		{
			MeId = meId;
			MatType = matType;
		}
	}
}
