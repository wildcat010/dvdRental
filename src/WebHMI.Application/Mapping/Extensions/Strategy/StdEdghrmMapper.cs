using Microsoft.AspNetCore.Razor.TagHelpers;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdEdghrmMapper
    {
        public static void MapEntity(StdEdghrm entity, StdEdghrmDto dto)
        {

            entity.ActiveFlag = dto.ActiveFlag;
            entity.PlanNo = dto.PlanNo;
            entity.Description = dto.Description;
            entity.Dw = dto.Dw;
            entity.EdgMode = dto.EdgMode;
            entity.EdgerActive = dto.EdgerActive;
            entity.PlanNo = dto.PlanNo;
        }

        public static StdEdghrmDto ToDto(StdEdghrm entity) => new()
        {
            ActiveFlag = entity.ActiveFlag,
            PlanNo = entity.PlanNo,
            Description = entity.Description,
            Dw = entity.Dw,
            EdgMode = entity.EdgMode,
            EdgerActive = entity.EdgerActive,
        };
    }
}
