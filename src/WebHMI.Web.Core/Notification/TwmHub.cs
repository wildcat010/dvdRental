using Abp.AspNetCore.SignalR.Hubs;
using Abp.RealTime;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebHMI.Notification
{
    public class TwmHub : OnlineClientHubBase
    {
        public TwmHub(
            IOnlineClientManager onlineClientManager,
            IOnlineClientInfoProvider clientInfoProvider)
            : base(onlineClientManager, clientInfoProvider)
        {
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            await Clients.Client(Context.ConnectionId).SendAsync("connected", Context.ConnectionId);
        }
    }
}
