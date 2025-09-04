using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Abp.UI;
using WebHMI.Core.Widget.Models;

namespace WebHMI.Core.Widget
{
    public interface IWidgetService : IDomainService
    {
        BaseWidgetData GetWidgetData(int id);
        Task<BaseWidgetData> Refresh(int widgetId);
        IEnumerable<IWidget> GetWidgets();
        IWidget<BaseWidgetData> GetWidgetById(int id);
    }

    public class WidgetService : DomainService, IWidgetService
    {
        private readonly WidgetRegistry _widgetRegistry;

        public WidgetService(WidgetRegistry widgetRegistry)
        {
            _widgetRegistry = widgetRegistry;
        }

        public BaseWidgetData GetWidgetData(int id)
        {
            var widget = GetWidgetById(id);

            return widget.GetData();
        }

        public async Task<BaseWidgetData> Refresh(int widgetId)
        {
            var widget = GetWidgetById(widgetId);

            await widget.Update();

            return widget.GetData();
        }

        public IEnumerable<IWidget> GetWidgets()
        {
            return _widgetRegistry.GetWidgets();
        }

        public IWidget<BaseWidgetData> GetWidgetById(int id)
        {
            var widget = (IWidget<BaseWidgetData>) _widgetRegistry.GetWidgetById(id);

            if (widget == null)
                throw new UserFriendlyException($"Widget {id} not found");
            return widget;
        }
        /*
        public IWidget<T> GetWidgetById<T>(int id) where T : BaseWidgetData, IWidget<T>, new()
        {
            return (IWidget<T>)_widgetRegistry.GetWidgetById(1);
        }

        public T GetWidgetData<T>() where T : BaseWidgetData, new()
        {
            _widgetRegistry.GetWidgets().Where(x => x.GetDataType() == typeof(T))
            return ((IWidget<T>)_widgetRegistry.GetWidgets).GetData();
        }*/
    }
}
