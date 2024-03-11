using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus.Handlers;
using Castle.Core.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.EventBus;
using WebHMI.Message;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.Alarm
{
	internal class BroadcastAlarmService : IAsyncEventHandler<EventWrapper<AlarmInfo>>, ITransientDependency
	{
		private readonly ILogger _logger;
		private readonly ISignalRNotifier _signalRNotifier;
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private List<LogIndex> _logIndices;
		private List<LogFormat> _logFormats;

		public BroadcastAlarmService(
			ILogger logger,
			ISignalRNotifier signalRNotifier,
			IDbContextProvider<PrdbContext> prdbContextProvider)
		{
			_logger = logger;
			_signalRNotifier = signalRNotifier;
			_prdbContextProvider = prdbContextProvider;
		}

		public async Task HandleEventAsync(EventWrapper<AlarmInfo> eventData)
		{
			if (eventData?.Data != null)
				await ProcessMessage(eventData.Data);
		}

		public async Task ProcessMessage(AlarmInfo alarmInfo)
		{
			try
			{
				if (!short.TryParse(alarmInfo.AlarmType, out var logIndexId))
					return;

					var ctx = await _prdbContextProvider.GetDbContextAsync();

				_logIndices ??= await ctx.LogIndices.ToListAsync();
				_logFormats ??= await ctx.LogFormats.ToListAsync();

				var logIndex = _logIndices.Single(x => x.Id == logIndexId);
				var logFormats = _logFormats.Where(z => z.Id == logIndexId);

				foreach (LogFormat format in logFormats)
				{
					await _signalRNotifier.BroadcastToAllClientsAsync(GenerateMessage(alarmInfo, format, logIndex), "NewMessage");
				}
			}
			catch (System.Exception ex)
			{
				_logger.Error($"[Messages] Cannot register L2 message {alarmInfo.AlarmType}", ex);
			}
		}

		private FlattenedMessage GenerateMessage(
			AlarmInfo l2Message,
			LogFormat format,
			LogIndex logIndex)
		{
			return new FlattenedMessage
			{
				Code = logIndex.Descr,
				Level = (SeverityLevel)logIndex.Level,

				Language = format.Lang,
				Value = format.Format,

				//Id = logDatum?.Entryid,
				//ConfirmedAt = logDatum?.Confirmedat,
				//ConfirmedBy = logDatum?.Confirmedby,
				Description = l2Message.Parameters,
				//LogIndexId = logDatum.Id,

				UserData1 = l2Message.HostName,
				UserData2 = l2Message.ExtId,
				UserData3 = l2Message.Parameters,
				CreationTime = l2Message.TimestampCome,
				Owner = l2Message.AppName,

				MessageSource = MessageSource.Prdb
			};
		}
	}
}
