using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdStrategyCsMapper
    {
        public static StdStrategyCsDto ToDto(StdCsStrategy entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,

            Coolingstrategy = entity.CoolingStrategy,

            Ftzload = entity.FtzLoad,
            TempgradInd0 = entity.TempGradInd0,
            TempgradInd1 = entity.TempGradInd1,
            ValveratiotopInd0 = entity.ValveRatioTopInd0,
            ValveratiotopInd1 = entity.ValveRatioTopInd1,
            ValveratiobotInd0 = entity.ValveRatioBotInd0,
            ValveratiobotInd1 = entity.ValveRatioBotInd1,
            Description2 = entity.Description2,
            StartvalvenumbertopInd0 = entity.StartValveNumberTopInd0,
            StartvalvenumbertopInd1 = entity.StartValveNumberTopInd1,
            StartvalvenumberbotInd0 = entity.StartValveNumberBotInd0,
            StartvalvenumberbotInd1 = entity.StartValveNumberBotInd1,
            Holdtime = entity.HoldTime,
            CoolratetopInd0 = entity.CoolRateTopInd0,
            CoolratetopInd1 = entity.CoolRateTopInd1,
            CoolratebotInd0 = entity.CoolRateBotInd0,
            CoolratebotInd1 = entity.CoolRateBotInd1,
            LeadingpyroindexInd0 = entity.LeadingPyroIndexInd0,
            LeadingpyroindexInd1 = entity.LeadingPyroIndexInd1,
            Targetf4tInd0 = entity.TargetF4tInd0,
            Targetf4tInd1 = entity.TargetF4tInd1,
            TargettempInd0 = entity.TargetTempInd0,
            TargettempInd1 = entity.TargetTempInd1,
            TempoffsetaInd0 = entity.TempOffsetAInd0,
            TempoffsetaInd1 = entity.TempOffsetAInd1,
            TempoffsetbInd0 = entity.TempOffsetBInd0,
            TempoffsetbInd1 = entity.TempOffsetBInd1,
            AdaptationInd0 = entity.AdaptationInd0,
            AdaptationInd1 = entity.AdaptationInd1,
            Autosplinetemptransition = entity.AutoSplineTempTransition,
            Autosplinevaluelowtop = entity.AutoSplineValueLowTop,
            Autosplinevaluelowbot = entity.AutoSplineValueLowBot,
            Adaptationfm = entity.AdaptationFm,
            Tempoffsetfma = entity.TempOffsetFmA,
            Tempoffsetfmb = entity.TempOffsetFmB,
            UsetempgradselectionInd0 = entity.UseTempGradSelectionInd0,
            UsetempgradselectionInd1 = entity.UseTempGradSelectionInd1,
            Valvesequenceindexcus = entity.ValveSequenceIndexCus

        };

        public static void MapEntity(StdCsStrategy entity, StdStrategyCsDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;


            entity.CoolingStrategy = dto.Coolingstrategy;
            entity.FtzLoad = dto.Ftzload;
            entity.TempGradInd0 = dto.TempgradInd0;
            entity.TempGradInd1 = dto.TempgradInd1;
            entity.ValveRatioTopInd0 = dto.ValveratiotopInd0;
            entity.ValveRatioTopInd1 = dto.ValveratiotopInd1;
            entity.ValveRatioBotInd0 = dto.ValveratiobotInd0;
            entity.ValveRatioBotInd1 = dto.ValveratiobotInd1;
            entity.Description2 = dto.Description2;
            entity.StartValveNumberTopInd0 = dto.StartvalvenumbertopInd0;
            entity.StartValveNumberTopInd1 = dto.StartvalvenumbertopInd1;
            entity.StartValveNumberBotInd0 = dto.StartvalvenumberbotInd0;
            entity.StartValveNumberBotInd1 = dto.StartvalvenumberbotInd1;
            entity.HoldTime = dto.Holdtime;
            entity.CoolRateTopInd0 = dto.CoolratetopInd0;
            entity.CoolRateTopInd1 = dto.CoolratetopInd1;
            entity.CoolRateBotInd0 = dto.CoolratebotInd0;
            entity.CoolRateBotInd1 = dto.CoolratebotInd1;
            entity.LeadingPyroIndexInd0 = dto.LeadingpyroindexInd0;
            entity.LeadingPyroIndexInd1 = dto.LeadingpyroindexInd1;
            entity.TargetF4tInd0 = dto.Targetf4tInd0;
            entity.TargetF4tInd1 = dto.Targetf4tInd1;
            entity.TargetTempInd0 = dto.TargettempInd0;
            entity.TargetTempInd1 = dto.TargettempInd1;
            entity.TempOffsetAInd0 = dto.TempoffsetaInd0;
            entity.TempOffsetAInd1 = dto.TempoffsetaInd1;
            entity.TempOffsetBInd0 = dto.TempoffsetbInd0;
            entity.TempOffsetBInd1 = dto.TempoffsetbInd1;
            entity.AdaptationInd0 = dto.AdaptationInd0;
            entity.AdaptationInd1 = dto.AdaptationInd1;
            entity.AutoSplineTempTransition = dto.Autosplinetemptransition;
            entity.AutoSplineValueLowTop = dto.Autosplinevaluelowtop;
            entity.AutoSplineValueLowBot = dto.Autosplinevaluelowbot;
            entity.AdaptationFm = dto.Adaptationfm;
            entity.TempOffsetFmA = dto.Tempoffsetfma;
            entity.TempOffsetFmB = dto.Tempoffsetfmb;
            entity.UseTempGradSelectionInd0 = dto.UsetempgradselectionInd0;
            entity.UseTempGradSelectionInd1 = dto.UsetempgradselectionInd1;
            entity.ValveSequenceIndexCus = dto.Valvesequenceindexcus;

        }
    }
}
