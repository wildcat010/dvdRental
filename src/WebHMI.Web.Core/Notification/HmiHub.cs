using System.Threading.Tasks;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.RealTime;
using Microsoft.AspNetCore.SignalR;

namespace WebHMI.Notification
{
	public class HmiHub : OnlineClientHubBase
	{
		public HmiHub(IOnlineClientManager onlineClientManager, IOnlineClientInfoProvider clientInfoProvider)
			: base(onlineClientManager, clientInfoProvider)
		{
		}

		public override async Task OnConnectedAsync()
		{
			await base.OnConnectedAsync();
			await Clients.Client(Context.ConnectionId).SendAsync("connected", Context.ConnectionId);
		}

		public async Task GetConnectionId()
		{
			await Clients.Client(Context.ConnectionId).SendAsync("connected", Context.ConnectionId);
		}

		public async Task AddToGroup(string group)
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, group);
		}

		public void Register()
		{
			Logger.Debug("A client is registered: " + Context.ConnectionId);
		}
	}
}

