using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdPcRampMapper
    {
        public static void MapEntity(Stdpcramp entity, StdPcRampDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Rampno = dto.RampNo; 
            entity.Pcrampauto = dto.Pcrampauto;
            entity.Pcrampstate = dto.Pcrampstate;
            entity.Pcrampvolume = dto.Pcrampvolume;
            entity.Priopowerc = dto.Priopowerc;
        }

        public static StdPcRampDto ToDto(Stdpcramp entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            RampNo = entity.Rampno,
            Pcrampauto = entity.Pcrampauto,
            Pcrampstate = entity.Pcrampstate,
            Pcrampvolume = entity.Pcrampvolume,
            Priopowerc = entity.Priopowerc,
        };
    }
}
