using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdIscpPassMapper
    {
        public static void MapEntity(StdIscppass entity, StdIscpPassDto dto)
        {
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            entity.PlanNo = dto.PlanNo;
            entity.DescalerAuto = dto.DescalerAuto;
            entity.DescalerState = dto.DescalerState;
            entity.DescalerVolume = dto.DescalerVolume;
            entity.Description = dto.Description;
            entity.FumeSuppSprayBefor = dto.FumeSuppSprayBefor;
            entity.FumeSuppSprayBehState = dto.FumeSuppSprayBehState;
            entity.FumeSuppSprayBehind = dto.FumeSuppSprayBehind;
            entity.IntermBeamCool = dto.IntermBeamCool;
            entity.IscAuto = dto.IscAuto;
            entity.IscMaxVolumeInd0 = dto.IscMaxVolumeInd0;
            entity.IscMaxVolumeInd1 = dto.IscMaxVolumeInd1;
            entity.IscMaxVolumeInd2 = dto.IscMaxVolumeInd2;
            entity.IscMaxVolumeInd3 = dto.IscMaxVolumeInd3;
            entity.IscMinVolumeInd0 = dto.IscMinVolumeInd0;
            entity.IscMinVolumeInd1 = dto.IscMinVolumeInd1;
            entity.IscMinVolumeInd2 = dto.IscMinVolumeInd2;
            entity.IscMinVolumeInd3 = dto.IscMinVolumeInd3;
            entity.IscState = dto.IscState;
            entity.IscVolumeInd0 = dto.IscVolumeInd0;
            entity.IscVolumeInd1 = dto.IscVolumeInd1;
            entity.IscVolumeInd2 = dto.IscVolumeInd2;
            entity.IscVolumeInd3 = dto.IscVolumeInd3;
            entity.LongCrossSpray = dto.LongCrossSpray;
            entity.LooperCool = dto.LooperCool;
            entity.PrioDescaler = dto.PrioDescaler;
            entity.PrioIsc = dto.PrioIsc;
            entity.RollGapSpray = dto.RollGapSpray;
            entity.StripSprayBefor = dto.StripSprayBefor;
            entity.StripSprayBehind = dto.StripSprayBehind;

        }

        public static StdIscpPassDto ToDto(StdIscppass entity) => new()
        {
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            PlanNo = entity.PlanNo,
            DescalerAuto = entity.DescalerAuto,
            DescalerState = entity.DescalerState,
            DescalerVolume = entity.DescalerVolume,
            Description = entity.Description,
            FumeSuppSprayBefor = entity.FumeSuppSprayBefor,
            FumeSuppSprayBehState = entity.FumeSuppSprayBehState,
            FumeSuppSprayBehind = entity.FumeSuppSprayBehind,
            IntermBeamCool = entity.IntermBeamCool,
            IscAuto = entity.IscAuto,
            IscMaxVolumeInd0 = entity.IscMaxVolumeInd0,
            IscMaxVolumeInd1 = entity.IscMaxVolumeInd1,
            IscMaxVolumeInd2 = entity.IscMaxVolumeInd2,
            IscMaxVolumeInd3 = entity.IscMaxVolumeInd3,
            IscMinVolumeInd0 = entity.IscMinVolumeInd0,
            IscMinVolumeInd1 = entity.IscMinVolumeInd1,
            IscMinVolumeInd2 = entity.IscMinVolumeInd2,
            IscMinVolumeInd3 = entity.IscMinVolumeInd3,
            IscState = entity.IscState,
            IscVolumeInd0 = entity.IscVolumeInd0,
            IscVolumeInd1 = entity.IscVolumeInd1,
            IscVolumeInd2 = entity.IscVolumeInd2,
            IscVolumeInd3 = entity.IscVolumeInd3,
            LongCrossSpray = entity.LongCrossSpray,
            LooperCool = entity.LooperCool,
            PrioDescaler = entity.PrioDescaler,
            PrioIsc = entity.PrioIsc,
            RollGapSpray = entity.RollGapSpray,
            StripSprayBefor = entity.StripSprayBefor,
            StripSprayBehind = entity.StripSprayBehind,
        };
    }
}
