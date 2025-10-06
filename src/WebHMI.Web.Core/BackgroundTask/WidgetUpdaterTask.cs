using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using WebHMI.Core.Widget;

namespace WebHMI.WebCore.BackgroundTask
{
    public class WidgetUpdaterTask : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IWidgetService _widgetService;

        public WidgetUpdaterTask(AbpTimer timer, IWidgetService widgetService) : base(timer)
        {
            _widgetService = widgetService;
            Timer.Period = 5000;
        }

        protected override void DoWork()
        {
            foreach (var widget in _widgetService.GetWidgets())
            {
                try
                {
                    if (widget.RequiresUpdate())
                    {
                        widget.Update();
                    }
                }
                catch (System.Exception e)
                {
                    Logger.Error($"Error while updating widget {widget.GetWidgetId()}");
                }
            }
        }
    }
}