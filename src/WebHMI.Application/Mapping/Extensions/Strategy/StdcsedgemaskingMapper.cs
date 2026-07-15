
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    internal class StdcsedgemaskingMapper
    {
        internal static void MapEntity(StdCsEdgeMasking entity, StdcsedgemaskingDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Description2 = dto.Comment;
            entity.EdgeMaskingWidthInd00 = dto.Valve1To10;
            entity.EdgeMaskingWidthInd01 = dto.Valve11To20;
            entity.EdgeMaskingWidthInd02 = dto.Valve21To30;
            entity.EdgeMaskingWidthInd03 = dto.Valve31To38;
            entity.EdgeMaskingWidthInd04 = dto.Valve39To46;
            entity.EdgeMaskingWidthInd05 = dto.Valve47To54;
            entity.EdgeMaskingWidthInd06 = dto.Valve55To62;
            entity.EdgeMaskingWidthInd07 = dto.Valve63To70;
            entity.EdgeMaskingWidthInd08 = dto.Valve71To78;
            entity.EdgeMaskingWidthInd09 = dto.Valve79To86;
            entity.EdgeMaskingWidthInd10 = dto.Valve87To94;
            entity.EdgeMaskingWidthInd11 = dto.Valve95To102;

        }

        internal static StdcsedgemaskingDto ToDto(StdCsEdgeMasking entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            Comment = entity.Description2,
            Valve1To10 = entity.EdgeMaskingWidthInd00,
            Valve11To20 = entity.EdgeMaskingWidthInd01,
            Valve21To30 = entity.EdgeMaskingWidthInd02,
            Valve31To38 = entity.EdgeMaskingWidthInd03,
            Valve39To46 = entity.EdgeMaskingWidthInd04,
            Valve47To54 = entity.EdgeMaskingWidthInd05,
            Valve55To62 = entity.EdgeMaskingWidthInd06,
            Valve63To70 = entity.EdgeMaskingWidthInd07,
            Valve71To78 = entity.EdgeMaskingWidthInd08,
            Valve79To86 = entity.EdgeMaskingWidthInd09,
            Valve87To94 = entity.EdgeMaskingWidthInd10,
            Valve95To102 = entity.EdgeMaskingWidthInd11,
        };
    }
}
