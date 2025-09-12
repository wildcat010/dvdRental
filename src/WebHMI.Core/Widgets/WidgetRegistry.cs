using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Abp.Dependency;
using WebHMI.Core.Widget.Models;
using WebHMI.Core.Widget.Widgets;

namespace WebHMI.Core.Widget
{
    public class WidgetRegistry : ISingletonDependency
    {
        private readonly Dictionary<int, IWidget<BaseWidgetData>> _widgets = new();

        public WidgetRegistry(
            SampleWidget sampleWidget,
            //DelaysChartWidget delaysChartWidget,
            ////TonsPerHourChartWidget tonsPerHourChartWidget,
            ////CoilsCounterChartWidget coilsCounterChartWidget,
            ////ThicknessAndWidthChartWidget thicknessAndWidthChartWidget,
            ////MaterialsInFurnaceSummaryWidget materialsInFurnaceSummaryWidget,
            //NextScheduledMaterialsWidget nextScheduledMaterialsWidget,
            ////CasterStatusWidget casterStatusWidget,
            //EntryTrackingByLocationWidget entryTrackingByLocationWidget,
            ScheduleSummaryByStatusWidget scheduleSummaryWidget,
            //HardnessDistributionWidget hardnessDistributionWidget,
            //ThicknessOverHardnessWidget thicknessOverHardnessWidget,
            PrimaryDataDefectsWidget primaryDataDefectsWidget,
            //PrimaryDataChemistryWidget primaryDataChemistryWidget,
            //ExitConveyorCoiler1Widget exitConveyorCoiler1Widget,
            //ExitConveyorCoiler2Widget exitConveyorCoiler2Widget,
            //DelaysSummaryWidget delaysSummaryWidget,
            LastShiftsProductionWidget  lastShiftsProductionWidget,
			ProdSequenceByAlloyCodeWidget prodSequenceByAlloyCodeWidget,
			ProdSequenceByThicknessWidget prodSequenceByThicknessWidget,
			ProdSequenceByWidthWidget prodSequenceByWidthWidget,
			ProdSequenceThicknessWidthWidget prodSequenceThicknessWidth


		)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string useMockHmi = appSettings["UseMockDb"] ?? "";

            if (useMockHmi != "true")
            {
               RegisterWidget(sampleWidget);
               // //RegisterWidget(delaysChartWidget);
               // //RegisterWidget(tonsPerHourChartWidget);
               //// RegisterWidget(coilsCounterChartWidget);
               // //RegisterWidget(thicknessAndWidthChartWidget);
               // //RegisterWidget(materialsInFurnaceSummaryWidget);
               // RegisterWidget(nextScheduledMaterialsWidget);
               // //RegisterWidget(casterStatusWidget);
               // RegisterWidget(entryTrackingByLocationWidget);
               RegisterWidget(scheduleSummaryWidget);
               // RegisterWidget(hardnessDistributionWidget);
               // RegisterWidget(thicknessOverHardnessWidget);
               RegisterWidget(primaryDataDefectsWidget);
               // RegisterWidget(primaryDataChemistryWidget);
               // RegisterWidget(exitConveyorCoiler1Widget);
               // RegisterWidget(exitConveyorCoiler2Widget);
               // RegisterWidget(delaysSummaryWidget);
               RegisterWidget(lastShiftsProductionWidget);
               RegisterWidget(prodSequenceByAlloyCodeWidget);
               RegisterWidget(prodSequenceByThicknessWidget);
               RegisterWidget(prodSequenceByWidthWidget);
               RegisterWidget(prodSequenceThicknessWidth);
				

			}             
        }

        public async Task InitializeWidgets()
        {
            foreach (var widget in _widgets)
            {
                await widget.Value.Initialize();
            }
        }

        public IWidget GetWidgetById(int id)
        {
            return _widgets.ContainsKey(id) ? _widgets[id] : null;
        }

        public IEnumerable<IWidget> GetWidgets()
        {
            return _widgets.Values;
        }

        private void RegisterWidget(IWidget<BaseWidgetData> widget)
        {
            _widgets.Add(widget.GetWidgetId(), widget);
        }
    }
}
