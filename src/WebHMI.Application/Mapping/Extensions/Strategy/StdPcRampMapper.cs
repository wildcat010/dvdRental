using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdPcRampMapper
    {
        //function to map the entity to the dto
        public static void MapEntity(StdPcramp entity, StdPcRampDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.RampNo = dto.RampNo; 
            entity.PcRampAuto = dto.Pcrampauto;
            entity.PcRampState = dto.Pcrampstate;
            entity.PcRampVolumeInd0 = dto.PcRampVolumeInd0;
            entity.PcRampVolumeInd1 = dto.PcRampVolumeInd1;
            entity.PrioPowerC = dto.Priopowerc;
        }

        //function to map the dto to the entity
        public static StdPcRampDto ToDto(StdPcramp entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            RampNo = entity.RampNo,
            Pcrampauto = entity.PcRampAuto,
            Pcrampstate = entity.PcRampState,
            PcRampVolumeInd0 = entity.PcRampVolumeInd0,
            PcRampVolumeInd1 = entity.PcRampVolumeInd1,
            Priopowerc = entity.PrioPowerC,
        };
    }
}
