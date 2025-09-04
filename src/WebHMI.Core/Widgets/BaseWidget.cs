using System;
using System.Threading.Tasks;
using Abp.ObjectMapping;
using Castle.Core.Logging;
using WebHMI.Core.Widget.Models;
using WebHMI.Notification;

namespace WebHMI.Core.Widget
{
    public abstract class BaseWidget<T> : IWidget<T> where T : BaseWidgetData, new()
    {
        protected readonly ISignalRNotifier _signalRNotifier;
        protected T Data { get; set; } = new();
        public ILogger Logger { get; set; }
        public int GetWidgetId() => Data.WidgetId;
        public T GetData() => Data;

        protected BaseWidget(ISignalRNotifier signalRNotifier)
        {
            _signalRNotifier = signalRNotifier;
            Data.Status = WidgetCalculationStatus.NotInitialized;
        }

        public virtual Task Initialize()
        {
            Data.Status = WidgetCalculationStatus.Initialized;
			return Task.CompletedTask;
		}

        public virtual async Task Update()
        {
            Data.LastCalculation = DateTime.UtcNow;

             await _signalRNotifier.SendHmiRefresh("WidgetDataChanged", GetWidgetId());

            Data.Status = WidgetCalculationStatus.Ok;

		}

		public virtual bool RequiresUpdate() =>
			Data == null || (DateTime.UtcNow - Data.LastCalculation).TotalSeconds > GetRefreshPeriodInSeconds();

		public Type GetDataType()
        {
            return typeof(T);
        }

        protected abstract long GetRefreshPeriodInSeconds();
    }
}
