using WebHMI.Dtos;
using WebHMI.Dtos.ProductData;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class ProductDataMapper
    {
        public static ProductionHistoryDto MapToDto(this HmiVProductionHistory dbo)
        {
            var dto = new ProductionHistoryDto();

            dto.MeCode = new MeCodeDto()
            {
                Status = dbo.EnOrStatus ,
                MeId = dbo.EnOrMeId,
                MatType = dbo.EnOrMeType,
                MesId = dbo.EnOrCurMesId ?? -1,
                ExtId = dbo.EnOrExitId,
                MeCreator = dbo.EnOrCreator
            };

            dto.CoilID = dbo.CoilId;
            dto.SlabId = dbo.SlabId;
            dto.SequenceID = dbo.SequenceId;
            dto.HeatID1 = dbo.HeatId1;
            dto.FlagBatchRolling = dbo.FlagBatchRolling;
            dto.AlloyCode = dbo.AlloyCode;
            dto.Prodstart = dbo.ProdStart;
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
            dto.CSExitTemp = dbo.TexitCsAver;
            dto.CSExitTempMin = dbo.TexitCsMin;
            dto.CSExitTempMax = dbo.TexitCsMax;
            dto.CoilLength = dbo.CoilLengthX;
            return dto;
        }

    }
}
