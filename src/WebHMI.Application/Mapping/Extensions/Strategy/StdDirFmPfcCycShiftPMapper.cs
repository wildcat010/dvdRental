using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDirFmPfcCycShiftPMapper
    {
        public static void MapEntity(StdDirFmPfcCycShiftP entity, StdDirFmPfcCycShiftDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.ManInt = dto.Manint;
        }

        public static StdDirFmPfcCycShiftDto ToDto(StdDirFmPfcCycShiftP entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            Manint = entity.ManInt,
        };
    }
}
