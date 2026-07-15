using WebHMI.Dtos.ProductData;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class ProductDataMapper
    {
        public static ProductionHistoryDto MapToDto(this HmiVProductionHistory dbo)
        {
            var dto = new ProductionHistoryDto();
            dto.CoilID = dbo.CoilId;
            dto.SlabId = dbo.SlabId;
            dto.SequenceID = dbo.SequenceId;
            dto.HeatID1 = dbo.HeatId1;
            dto.FlagBatchRolling = dbo.Flagbatchrolling;
            dto.AlloyCode = dbo.Alloycode;
            dto.Prodend = dbo.ProdEnd;
            dto.ExitWidthSP = dbo.WExit;
            dto.ExitWidth = dbo.WExitAver;
            dto.ExitWidthMin = dbo.WExitMin;
            dto.ExitWidthMax = dbo.WExitMax;
            dto.ExitThicknessSP = dbo.HExit;
            dto.ExitThickness = dbo.HExitAver;
            dto.ExitThicknessMin = dbo.HExitMin;
            dto.ExitThicknessMax = dbo.HExitMax;
            dto.CSExitTempSP = dbo.TExitCs;
            dto.CSExitTemp = dbo.TExitCsaver;
            dto.CSExitTempMin = dbo.TExitCsmin;
            dto.CSExitTempMax = dbo.TExitCsmax;
            dto.CoilLength = dbo.CoilLengthX;
            return dto;
        }

    }
}
