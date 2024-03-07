using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Events.Bus.Handlers;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.EventBus;
using XIDL;

namespace WebHMI.Alarm
{
	internal class BroadcastAlarmService : IAsyncEventHandler<EventWrapper<AlarmInfo>>, ITransientDependency
	{
		private readonly ILogger _logger;

		public BroadcastAlarmService(ILogger logger)
		{
			_logger = logger;
		}

		public async Task HandleEventAsync(EventWrapper<AlarmInfo> eventData)
		{
			if (eventData.Data != null)
				await ProcessMessage(eventData.Data);
		}

		public async Task ProcessMessage(AlarmInfo alarmInfo)
		{
			try
			{
				// TODO: flatten and send with signalR

				//await _signalRNotifier.BroadcastToAllClientsAsync(notification, "NewMessage"); 
			}
			catch (System.Exception ex)
			{
				_logger.Error($"[Messages] Cannot register L2 message {alarmInfo.AlarmType}", ex);
			}
		}
	}
}
