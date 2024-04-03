using Abp;
using Abp.Dependency;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Listeners;
using XIDL;

namespace WebHMI.L2Adapter.ConnectionManagers
{
    internal class ConnectionManager : IConnectionManager, IDisposable
    {
        private readonly CancellationTokenSource _cts = new();
        private readonly ILogger _logger;
        private readonly PlatformListener _platformListener;
        private readonly AlarmListener _alarmListener;

        public ConnectionManager(
            ILogger logger,
            PlatformListener platformListener,
            AlarmListener alarmListener)
        {
            _logger = logger;
            _platformListener = platformListener;
            _alarmListener = alarmListener;

            Task.Factory.StartNew(StartL2CommunicationLoop, _cts.Token, TaskCreationOptions.None, TaskScheduler.Default);
        }

        private void StartL2CommunicationLoop()
        {
            _logger.Info($"{nameof(StartL2CommunicationLoop)} started");

            try
            {
                int result = EventLoop.Run("AppHmiServer", InitL2Objects, 0);
                _logger.Warn($"{nameof(EventLoop.Run)} returned: {result}");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"{nameof(EventLoop)} unexpected exception", ex);
            }
        }

        /// <summary>
        /// Inits all objects needed to communicate with L2.
        /// This method must be called before all outgoing/incoming L2 calls,
        /// otherwise exceptions will be thrown.
        /// </summary>
        private void InitL2Objects()
        {
            _logger.Info($"{nameof(InitL2Objects)} started");

            try
            {
                var hmiPaSkeleton = new IHmiPaSkeleton(_platformListener);
                new Servant("hmiPa", hmiPaSkeleton);

                var alarmListenerSkeleton = new IAlarmListenerSkeleton(_alarmListener);
                new Servant("alarmListener", alarmListenerSkeleton);

                _logger.Info($"L2 Communication items created");
            }
            catch (System.Exception e)
            {
                _logger.Error("Error while creating L2 communication objects", e);
            }
        }

        public void Dispose()
        {
            _logger.Info("Disposing L2 communication");
            EventLoop.Stop();
        }
    }
}
