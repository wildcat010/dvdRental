using Abp;
using Abp.Dependency;
using Abp.Json;
using Abp.RealTime;

using Castle.Core.Logging;

using Microsoft.AspNetCore.SignalR;

using System;
using System.Linq;
using System.Threading.Tasks;

using WebHMI.API.Core.Notifications;

namespace WebHMI.API.Notifications
{
    public class SignalRNotifier : ITransientDependency, ISignalRNotifier
    {
        /// <summary>
        /// Reference to the logger.
        /// </summary>
        public ILogger Logger { get; set; }

        private readonly IOnlineClientManager _onlineClientManager;

        private readonly IHubContext<HmiHub> _hubContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalRNotifier"/> class.
        /// </summary>
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

        /// <inheritdoc/>
        public async Task BroadcastToAllClientsAsync<T>(T input, string methodName)
        {
            try
            {
                Logger.Debug($"Broadcasting to all clients: methodName:{methodName},data:{input.ToJsonString()}");
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

                var onlineClients = _onlineClientManager.GetAllByUserId(userIdentifier);
                foreach (var onlineClient in onlineClients)
                {
                    var signalRClient = _hubContext.Clients.Client(onlineClient.ConnectionId);
                    if (signalRClient == null)
                    {
                        Logger.Debug("Can not get user with connectionId " + onlineClient.ConnectionId + " from SignalR hub!");
                        continue;
                    }

                    //		userNotification.Notification.EntityType = null; // Serialization of System.Type causes SignalR to disconnect. See https://github.com/aspnetboilerplate/aspnetboilerplate/issues/5230
                    await signalRClient.SendAsync("getNotification", input);
                }
            }
            catch (Exception ex)
            {
                //	Logger.Warn("Could not send notification to user: " + userNotification.ToUserIdentifier());
                Logger.Warn(ex.ToString(), ex);
            }

        }
        public async Task BroadcastToUserClientAsync<T>(T input, string hmiClientId, string methodName)
        {
            try
            {
                Logger.Debug($"Processing \"{methodName}\" to client:{hmiClientId}");
                foreach (var onlineClient in _onlineClientManager.GetAllClients())
                {
                    if (onlineClient.ConnectionId == hmiClientId)
                    {
                        var signalRClient = _hubContext.Clients.Client(onlineClient.ConnectionId);
                        if (signalRClient == null)
                        {
                            Logger.Debug("Can not get user  with connectionId " + onlineClient.ConnectionId + " from SignalR hub!");
                            continue;
                        }

                        Logger.Debug($"Sending Signal: MethodName:\"{methodName}\", Data:{input.ToJsonString()}");
                        await signalRClient.SendAsync(methodName, input);
                    }
                }
            }
            catch (Exception ex)
            {
                //	Logger.Warn("Could not send notification to user: " + userNotification.ToUserIdentifier());
                Logger.Error(ex.ToString());
            }
        }
    }
}

