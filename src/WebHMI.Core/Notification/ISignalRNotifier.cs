using Abp;
using System.Threading.Tasks;
using WebHMI.Events;

namespace WebHMI.Notification
{
	public interface ISignalRNotifier
	{
		Task SendHmiRefresh<T>(string key, T payload);
		Task BroadcastToAllClientsAsync<T>(T input, string methodName);
		Task BroadcastToClientAsync<T>(T input, IUserIdentifier userId, string methodName);
		Task BroadcastToUserClientAsync<T>(T input, string userId, string methodName);
        Task BroadcastTwmToAllClientsAsync(HmiTwmDataDto input, string methodName = "TwmData");
    }
}

