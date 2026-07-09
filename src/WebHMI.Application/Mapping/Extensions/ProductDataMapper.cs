using WebHMI.Dtos.ProductData;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class ProductDataMapper
    {
        public static ProductionHistoryDto MapToDto(this HmiVProductionHistory dbo)
        {
            var dto = new ProductionHistoryDto();
            dto.CoilID = dbo.Coilid;
            dto.SlabId = dbo.Slabid;
            dto.SequenceID = dbo.Sequenceid;
            dto.HeatID1 = dbo.Heatid1;
            dto.FlagBatchRolling = dbo.Flagbatchrolling;
            dto.AlloyCode = dbo.Alloycode;
            dto.Prodend = dbo.Prodend;
            dto.ExitWidthSP = dbo.Wexit;
            dto.ExitWidth = dbo.Wexitaver;
            dto.ExitWidthMin = dbo.Wexitmin;
            dto.ExitWidthMax = dbo.Wexitmax;
            dto.ExitThicknessSP = dbo.Hexit;
            dto.ExitThickness = dbo.Hexitaver;
            dto.ExitThicknessMin = dbo.Hexitmin;
            dto.ExitThicknessMax = dbo.Hexitmax;
            dto.CSExitTempSP = dbo.Texitcs;
            dto.CSExitTemp = dbo.Texitcsaver;
            dto.CSExitTempMin = dbo.Texitcsmin;
            dto.CSExitTempMax = dbo.Texitcsmax;
            dto.CoilLength = dbo.Coillengthx;
            return dto;
        }

    }
}
