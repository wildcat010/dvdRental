using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDirFmPfcCycShiftPMapper
    {
        public static void MapEntity(Stddirfmpfccycshiftp entity, StdDirFmPfcCycShiftDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Manint = dto.Manint;
        }

        public static StdDirFmPfcCycShiftDto ToDto(Stddirfmpfccycshiftp entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            Manint = entity.Manint,
        };
    }
}
