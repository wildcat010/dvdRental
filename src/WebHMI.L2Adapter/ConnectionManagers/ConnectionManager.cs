using Abp;
using Abp.Dependency;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Listeners;
using WebHMI.L2Adapter.Senders;
using WebHMI.L2Adapter.Services.EspHmi;
using WebHMI.L2Adapter.Watchdogs;
using XIDL;

namespace WebHMI.L2Adapter.ConnectionManagers
{
    internal class ConnectionManager : IConnectionManager, IDisposable
    {
        private readonly ILogger _logger;
        private readonly PlatformListener _platformListener;
        private readonly AlarmListener _alarmListener;
        private readonly EspHmi _espHmi;

        private bool _disposed = false;

        public static bool IsL2CommunicationRunning { get; private set; }

        public ConnectionManager(
            ILogger logger,
            PlatformListener platformListener,
            EspHmi espHmi,
            AlarmListener alarmListener)
        {
            _logger = logger;
            _platformListener = platformListener;
            _alarmListener = alarmListener;
            _espHmi = espHmi;

            StartL2ReconnectionLoop();
        }

        private void StartL2ReconnectionLoop()
        {
            Task.Factory.StartNew(() =>
            {
                if (_disposed)
                {
                    _logger.Info("[CAPPA] Skipped L2 communication initialization, because it was disposed");
                    return;
                }

                StartL2Communication();

                if (!_disposed)
                {
                    _logger.Warn("[CAPPA] L2 communication failed, but it was not diposed");
                    return;
                }

                _logger.Info("[CAPPA] L2 communication disposed, exiting connection task...");
            }, TaskCreationOptions.LongRunning)
                .ContinueWith(t =>
                {
                    foreach (var innerException in t.Exception.Flatten().InnerExceptions)
                        _logger.Error("Exception occured while running L2 communication", innerException);
                }, TaskContinuationOptions.OnlyOnFaulted);
        }

        private void StartL2Communication()
        {
            _logger.Info($"{nameof(StartL2Communication)} started");

            try
            {
                int result = EventLoop.Run("AppHmiServer", InitL2Objects, 0);
                IsL2CommunicationRunning = false;
                _logger.Info($"{nameof(EventLoop.Run)} returned: {result}");
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

                var espHmiSkeleton = new IEspHmiSkeleton(_espHmi);
                new Servant("espHmi", espHmiSkeleton);

                var alarmListenerSkeleton = new IAlarmListenerSkeleton(_alarmListener);
                new Servant("alarmListener", alarmListenerSkeleton);

                // Initialize stubs
                IocManager.Instance.Resolve<IL2CommunicationHandler>();
                IocManager.Instance.Resolve<WatchdogStatusService>().InitializeWatchdogs();

                _logger.Info($"L2 Communication items created");
                IsL2CommunicationRunning = true;
            }
            catch (System.Exception e)
            {
                _logger.Error("Error while creating L2 communication objects", e);
            }
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            _logger.Info("Disposing L2 communication");
            EventLoop.Stop();

            _disposed = true;
        }
    }
}
