using Abp;
using Abp.Dependency;
using Abp.Json;
using Abp.RealTime;
using Castle.Core.Logging;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;


namespace WebHMI.Notification
{
	public class SignalRNotifier : ITransientDependency, ISignalRNotifier
	{
		public ILogger Logger { get; set; }

		private readonly IOnlineClientManager _onlineClientManager;
		private readonly IHubContext<HmiHub> _hubContext;

		public SignalRNotifier(
				IOnlineClientManager onlineClientManager,
				IHubContext<HmiHub> hubContext)
		{
			_onlineClientManager = onlineClientManager;
			_hubContext = hubContext;
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
	}
}

