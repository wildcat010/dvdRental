using Abp;
using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using Abp.Json;
using Abp.RealTime;
using Castle.Core.Logging;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Events;
using WebHMI.EventWrapper;
using WebHMI.L2Adapter.Watchdogs.Dto;


namespace WebHMI.Notification
{
	public class SignalRNotifier : ITransientDependency, IEventHandler<EventWrapper<HmiRefreshDto>>,
        IEventHandler<EventWrapper<(DateTime, string)>>, IEventHandler<EventWrapper<WatchdogDto>>, ISignalRNotifier
	{
		public ILogger Logger { get; set; }

		private readonly IOnlineClientManager _onlineClientManager;
		private readonly IHubContext<HmiHub> _hubContext;
        private readonly IHubContext<TwmHub> _twmHubContext;

        public SignalRNotifier(
				IOnlineClientManager onlineClientManager,
				IHubContext<HmiHub> hubContext,
                IHubContext<TwmHub> twmHubContext)
		{
			_onlineClientManager = onlineClientManager;
			_hubContext = hubContext;
            _twmHubContext = twmHubContext;
            Logger = NullLogger.Instance;
		}

		public async Task SendHmiRefresh<T>(string key, T payload)
		{
			try
			{
				await _hubContext.Clients.All.SendAsync("HmiRefresh", new { key, payload });
			}
			catch (Exception ex)
			{
				Logger.Warn($"[SendHmiRefresh] Cannot send HMI refresh with key {key} and payload of {payload?.GetType()}", ex);
			}
		}

		public async Task BroadcastToAllClientsAsync<T>(T input, string methodName)
		{
			try
			{
				await _hubContext.Clients.All.SendAsync(methodName, input);
			}
			catch (Exception ex)
			{
				Logger.Warn("Broadcasting to all clients failed, method name: '" + methodName + "'.", ex);
			}
		}

		public async Task BroadcastToClientAsync<T>(T input, IUserIdentifier userIdentifier, string methodName)
		{
			try
			{
				var onlineClients = await _onlineClientManager.GetAllByUserIdAsync(userIdentifier);
				foreach (var onlineClient in onlineClients)
				{
					var signalRClient = _hubContext.Clients.Client(onlineClient.ConnectionId);
					if (signalRClient == null)
					{
						Logger.Warn("Can not get user with connectionId " + onlineClient.ConnectionId + " from SignalR hub!");
						continue;
					}

					await signalRClient.SendAsync("getNotification", input);
				}
			}
			catch (Exception ex)
			{
				Logger.Error("Could not send notification to user: " + userIdentifier.ToUserIdentifier(), ex);
			}
		}

		public async Task BroadcastToUserClientAsync<T>(T input, string hmiClientId, string methodName)
		{
			try
			{
				foreach (var onlineClient in await _onlineClientManager.GetAllClientsAsync())
				{
					if (onlineClient.ConnectionId == hmiClientId)
					{
						var signalRClient = _hubContext.Clients.Client(onlineClient.ConnectionId);
						if (signalRClient == null)
						{
							Logger.Debug("Can not get user with connectionId " + onlineClient.ConnectionId + " from SignalR hub!");
							continue;
						}

						await signalRClient.SendAsync(methodName, input);
					}
				}
			}
			catch (Exception ex)
			{
				Logger.Error("Could not send notification to hmiClientId: " + hmiClientId, ex);
			}
		}

        public async Task BroadcastTwmToAllClientsAsync(HmiTwmDataDto input, string methodName = "TwmData")
        {
            try
            {
                Logger.Debug($"Broadcasting TWM data to all clients, methodName: {methodName}, " +
                    $"data: {input.ToJsonString(new JsonSerializerOptions()
                    {
                        NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals,
                        WriteIndented = false,
                    })}");
                await _twmHubContext.Clients.All.SendAsync(methodName, input);
            }
            catch (Exception ex)
            {
                Logger.Warn("Broadcasting TWM data to all clients failed, method name: '" + methodName + "'.", ex);
            }
        }

        public void HandleEvent(EventWrapper<HmiRefreshDto> eventData)
        {
            Logger.Debug(eventData.Data.EventKey[0]);
            BroadcastToAllClientsAsync(eventData.Data, "HmiRefreshData");
        }

        public void HandleEvent(EventWrapper<(DateTime, string)> eventData)
        {
            BroadcastToAllClientsAsync(DateTime.UtcNow, "L2WatchdogStatusRefresh");
        }

        public void HandleEvent(EventWrapper<WatchdogDto> eventData)
        {
            BroadcastToAllClientsAsync(eventData.Data, "SystemStatusUpdate");
        }
    }
}

