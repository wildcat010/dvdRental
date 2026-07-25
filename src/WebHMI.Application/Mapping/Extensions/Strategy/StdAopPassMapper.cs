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
            entity.AntiOxidationEntryInd0 = dto.AntiOxidationEntryTop;
            entity.AntiOxidationEntryInd1 = dto.AntiOxidationEntryBot;
            entity.AntiOxStateExit = dto.AntiOxStateExit;
            entity.AntiOxidationExitInd0 = dto.AntiOxidationExitTop;
            entity.AntiOxidationExitInd1 = dto.AntiOxidationExitBot;
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
            AntiOxidationEntryTop = entity.AntiOxidationEntryInd0,
            AntiOxidationEntryBot = entity.AntiOxidationEntryInd1,
            AntiOxStateExit = entity.AntiOxStateExit,
            AntiOxidationExitTop = entity.AntiOxidationExitInd0,
            AntiOxidationExitBot = entity.AntiOxidationExitInd1,
            AntiPeelingState = entity.AntiPeelingState,
            AntiPeeling = entity.AntiPeeling
        };
    }
}
