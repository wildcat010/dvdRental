using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdPcRampMapper
    {
        public static void MapEntity(StdPcramp entity, StdPcRampDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.RampNo = dto.RampNo; 
            entity.PcRampAuto = dto.Pcrampauto;
            entity.PcRampState = dto.Pcrampstate;
            entity.PcRampVolume = dto.Pcrampvolume;
            entity.PrioPowerC = dto.Priopowerc;
        }

        public static StdPcRampDto ToDto(StdPcramp entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            RampNo = entity.RampNo,
            Pcrampauto = entity.PcRampAuto,
            Pcrampstate = entity.PcRampState,
            Pcrampvolume = entity.PcRampVolume,
            Priopowerc = entity.PrioPowerC,
        };
    }
}
