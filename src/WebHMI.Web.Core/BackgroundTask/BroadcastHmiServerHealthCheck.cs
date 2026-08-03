using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using System;
using WebHMI.Notification;

namespace WebHMI.API.BackgroundTask
{
    [UnitOfWork]
    public class BroadcastHmiServerHealthCheck : PeriodicBackgroundWorkerBase , ITransientDependency
    {
        private readonly ISignalRNotifier _notifier;

        public BroadcastHmiServerHealthCheck(AbpTimer timer, ISignalRNotifier notifier)
           : base(timer)
        {
            _notifier = notifier;
            Timer.Period = 5000;
        }

        protected override void DoWork()
        {
            _notifier.BroadcastToAllClientsAsync(DateTime.UtcNow, "HmiHealthCheck");
        }
    }
}
