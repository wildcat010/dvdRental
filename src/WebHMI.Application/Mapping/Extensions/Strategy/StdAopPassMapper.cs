using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdAopPassMapper
    {
        public static void MapEntity(Stdaoppass entity, StdAopPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.Antioxstateentry = dto.AntiOxStateEntry;
            entity.Antioxidationentry = dto.AntiOxidationEntry;
            entity.Antioxstateexit = dto.AntiOxStateExit;
            entity.Antioxidationexit = dto.AntiOxidationExit;
            entity.Antipeelingstate = dto.AntiPeelingState;
            entity.Antipeeling = dto.AntiPeeling;
        }

        public static StdAopPassDto ToDto(Stdaoppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            AntiOxStateEntry = entity.Antioxstateentry,
            AntiOxidationEntry = entity.Antioxidationentry,
            AntiOxStateExit = entity.Antioxstateexit,
            AntiOxidationExit = entity.Antioxidationexit,
            AntiPeelingState = entity.Antipeelingstate,
            AntiPeeling = entity.Antipeeling
        };
    }
}
