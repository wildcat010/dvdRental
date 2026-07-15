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
        public static void MapEntity(StdAoppass entity, StdAopPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            entity.Description = dto.Description;
            entity.AntiOxStateEntry = dto.AntiOxStateEntry;
            entity.AntiOxidationEntry = dto.AntiOxidationEntry;
            entity.AntiOxStateExit = dto.AntiOxStateExit;
            entity.AntiOxidationExit = dto.AntiOxidationExit;
            entity.AntiPeelingState = dto.AntiPeelingState;
            entity.AntiPeeling = dto.AntiPeeling;
        }

        public static StdAopPassDto ToDto(StdAoppass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            AntiOxStateEntry = entity.AntiOxStateEntry,
            AntiOxidationEntry = entity.AntiOxidationEntry,
            AntiOxStateExit = entity.AntiOxStateExit,
            AntiOxidationExit = entity.AntiOxidationExit,
            AntiPeelingState = entity.AntiPeelingState,
            AntiPeeling = entity.AntiPeeling
        };
    }
}
