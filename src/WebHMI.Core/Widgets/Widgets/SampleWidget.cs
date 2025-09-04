using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using WebHMI.Core.Widget.Models;
using WebHMI.Notification;

namespace WebHMI.Core.Widget.Widgets
{
	public class SampleWidget : BaseWidget<SampleWidgetData>, ISingletonDependency
	{
		public SampleWidget(ISignalRNotifier notifier) : base(notifier)
		{
			Data.WidgetId = WidgetDefs.WidgetIdSample;
		}

		public override Task Initialize()
		{
			Update().GetAwaiter().GetResult();

			return base.Initialize();
		}

		public override async Task Update()
		{
			Random randNum = new Random();
			Data.RandomData = Enumerable
				.Repeat(0, 5)
				.Select(i => randNum.Next(10, 100))
				.ToArray();

			await base.Update();

		}

		protected override long GetRefreshPeriodInSeconds() => 15;
	}
}
