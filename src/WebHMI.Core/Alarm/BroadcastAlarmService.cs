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
    public class BroadcastAlarmService : IAsyncEventHandler<EventWrapper<AlarmInfo>>, ISingletonDependency
    {
        private readonly ILogger _logger;
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly MessageManager _messageManager;
        private List<LogIndex> _logIndices;
        private List<LogFormat> _logFormats;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public BroadcastAlarmService(
            ILogger logger,
            ISignalRNotifier signalRNotifier,
            IDbContextProvider<PrdbContext> prdbContextProvider,
            MessageManager messageManager,
            IUnitOfWorkManager unitOfWorkManager)
        {
            _logger = logger;
            _signalRNotifier = signalRNotifier;
            _prdbContextProvider = prdbContextProvider;
            _messageManager = messageManager;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task HandleEventAsync(EventWrapper<AlarmInfo> eventData)
        {
            if (eventData?.Data != null)
                await ProcessMessage(eventData.Data);
        }

        public async Task ProcessMessage(AlarmInfo alarmInfo)
        {
            using var unitOfWork = _unitOfWorkManager.Begin();

            try
            {
                if (!short.TryParse(alarmInfo.AlarmType, out var logIndexId))
                    return;

                var ctx = _prdbContextProvider.GetDbContext();

                _logIndices ??= await ctx.LogIndices.ToListAsync();
                _logFormats ??= await ctx.LogFormats.ToListAsync();

                var logIndex = _logIndices.SingleOrDefault(x => x.Id == logIndexId);
                var logFormats = _logFormats.Where(z => z.Id == logIndexId);

                List<FlattenedMessage> flattenedMessages = [];

                foreach (LogFormat format in logFormats)
                {
                    flattenedMessages.Add(GenerateMessage(alarmInfo, format, logIndex));
                }

                await _messageManager.RegisterL2Messages(flattenedMessages);
            }
            catch (System.Exception ex)
            {
                _logger.Error("Processing message failed", ex);
            }
            finally
            {
                unitOfWork.Complete();
            }
        }

        private FlattenedMessage GenerateMessage(
            AlarmInfo l2Message,
            LogFormat format,
            LogIndex logIndex)
        {
            return new FlattenedMessage
            {
                Code = logIndex?.Descr,
                Level = MapAlarmLevel(logIndex?.Severity),

                Language = format.Lang,
                Value = format.Format,

                //Id = logDatum?.Entryid,
                //ConfirmedAt = logDatum?.Confirmedat,
                //ConfirmedBy = logDatum?.Confirmedby,
                //LogIndexId = logDatum?.Id,

                Description = l2Message?.Parameters,
                UserData1 = l2Message?.HostName,
                UserData2 = l2Message?.ExtId,
                UserData3 = l2Message?.Parameters,
                CreationTime = l2Message?.TimestampCome ?? default,
                Owner = l2Message?.AppName,

                MessageSource = MessageSource.Prdb
            };
        }

        private static SeverityLevel MapAlarmLevel(short? severity) => severity switch
        {
            161 => SeverityLevel.Error,
            162 => SeverityLevel.Warning,
            163 => SeverityLevel.Info,
            _ => SeverityLevel.Info
        };
    }
}
