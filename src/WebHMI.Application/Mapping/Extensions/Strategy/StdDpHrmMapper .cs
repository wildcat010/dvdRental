
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDpHrmMapper
    {
        public static void MapEntity(StdDphrm entity, StdDpRmDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            //entity.Description = dto.Description;
        }

        public static StdDpRmDto ToDto(StdDphrm entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            //Description = entity.Description
        };
    }
}
