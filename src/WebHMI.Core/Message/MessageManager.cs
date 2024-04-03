using Abp.Dependency;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Notification;

namespace WebHMI.Message
{
    public class MessageManager : DomainService, ITransientDependency
    {
        private readonly MessagesCache _messageStorage;
        private readonly ISignalRNotifier _signalRNotifier;

        public MessageManager(
            MessagesCache messageStorage, 
            ISignalRNotifier signalRNotifier)
        {
            _messageStorage = messageStorage;
            _signalRNotifier = signalRNotifier;
        }

        public async Task RegisterL2Messages(List<FlattenedMessage> flattenedMessages)
        {
            foreach (var flattenedMessage in flattenedMessages)
            {
                _messageStorage.Add(flattenedMessage);
                await NotifyNewMessage(flattenedMessage);
            }
        }

        private async Task NotifyNewMessage(FlattenedMessage notification)
        {
            await _signalRNotifier.BroadcastToAllClientsAsync(notification, "NewMessage");
        }
    }
}
