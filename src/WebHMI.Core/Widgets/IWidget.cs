using System;
using System.Threading.Tasks;
using WebHMI.Core.Widget.Models;

namespace WebHMI.Core.Widget
{
    public interface IWidget
    {
        Type GetDataType();
        int GetWidgetId();
        Task Initialize();
        Task Update();
        bool RequiresUpdate();
    }

    public interface IWidget<out T> : IWidget where T : BaseWidgetData
    {
        T GetData();
    }
}
