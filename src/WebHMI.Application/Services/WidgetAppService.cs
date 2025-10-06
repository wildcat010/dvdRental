using System.Linq;
using System.Threading.Tasks;
using WebHMI.Core.Widget;
using WebHMI.Core.Widget.Models;
using WebHMI.Core.Widget.Widgets;
using WebHMI.Dtos;
using WebHMI.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebHMI.Application.Services
{
    public class WidgetAppService : ApplicationServiceBase
    {
        private readonly IWidgetService _widgetService;

        public WidgetAppService(IWidgetService widgetService)
        {
            _widgetService = widgetService;
        }

        public Task<SampleWidgetData> GetSampleWidgetData()
        {
            var widget = (SampleWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdSample);

            return Task.FromResult(widget.GetData());
        }
        public async Task<PrimaryDataDefectsWidgetData> GetDefectsWidgetData(int meid, string matType)
        {
            var widget = (PrimaryDataDefectsWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdPrimaryDataDefects);

            widget.SetMeIdMatType(meid, matType);
            await widget.Update();

            return await Task.FromResult(widget.GetData());
        }

        public Task<ScheduleSummaryWidgetData> GetScheduleSummaryWidgetData()
        {
            var widget = (ScheduleSummaryByStatusWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdScheduleSummary);

            return Task.FromResult(widget.GetData());
        }

        public async Task<ShiftAggregatedResultWidgetData> GetLastShiftsSummaryWidgetData()
        {
            var widget = (LastShiftsProductionWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdLastShiftsProduction);

            return await Task.FromResult(widget.GetData());
        }

        public async Task<StandardDistributionWidgetData> GetProdSequenceDistrByAlloyCode()
        {
            var widget = (ProdSequenceByAlloyCodeWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdProdSummaryByAlloyCode);

            return await Task.FromResult(widget.GetData());
        }

        public async Task<StandardDistributionWidgetData> GetProdSequenceDistrByThickness()
        {
            var widget = (ProdSequenceByThicknessWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdProdSummaryByThickness);
            return await Task.FromResult(widget.GetData());
        }

        public async Task<StandardDistributionWidgetData> GetProdSequenceDistrByWidth()
        {
            var widget = (ProdSequenceByWidthWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdProdSummaryByWidth);
            return await Task.FromResult(widget.GetData());
        }
        public async Task<ProdSequenceThicknessWidthData> GetProdSequenceThicknessWidth()
        {
            var widget = (ProdSequenceThicknessWidthWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdThicknessWidth);
            return await Task.FromResult(widget.GetData());

        }
        public ProdSequenceThicknessWidthData GetProdSequenceThicknessWidthById(string seqID)
        {
            var widget = (ProdSequenceThicknessWidthWidget)_widgetService.GetWidgetById(WidgetDefs.WidgetIdThicknessWidth);
            var widgetData = widget.GetData(); 

            var filteredData = widgetData.ProductionDistributionData
                                                        .Where(kvp => kvp.Value.SeqId == seqID)
                                                        .ToList();

            var result = new ProdSequenceThicknessWidthData()
            {
                WidgetId = widgetData.WidgetId,
                Status = widgetData.Status,
                LastCalculation = widgetData.LastCalculation,
                ProductionDistributionData = filteredData
            };

            return result;
        }

        public Task<BaseWidgetData> Refresh(int widgetId)
        {
            return _widgetService.Refresh(widgetId);
        }
    }
}
