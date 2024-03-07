using Abp;
using Abp.Dependency;
using Abp.Notifications;
using Abp.RealTime;
using Castle.Core.Logging;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Notification
{
	public interface ISignalRNotifier
	{
		Task SendHmiRefresh<T>(string key, T payload);
		Task BroadcastToAllClientsAsync<T>(T input, string methodName);
		Task BroadcastToClientAsync<T>(T input, IUserIdentifier userId, string methodName);
		Task BroadcastToUserClientAsync<T>(T input, string userId, string methodName);
	}
}

