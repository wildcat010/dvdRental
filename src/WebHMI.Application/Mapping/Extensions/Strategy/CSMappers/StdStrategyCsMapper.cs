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
        public static StdStrategyCsDto ToDto(Stdcsstrategy entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,

            Coolingstrategy = entity.Coolingstrategy,

            Ftzload = entity.Ftzload,
            TempgradInd0 = entity.TempgradInd0,
            TempgradInd1 = entity.TempgradInd1,
            ValveratiotopInd0 = entity.ValveratiotopInd0,
            ValveratiotopInd1 = entity.ValveratiotopInd1,
            ValveratiobotInd0 = entity.ValveratiobotInd0,
            ValveratiobotInd1 = entity.ValveratiobotInd1,
            Description2 = entity.Description2,
            StartvalvenumbertopInd0 = entity.StartvalvenumbertopInd0,
            StartvalvenumbertopInd1 = entity.StartvalvenumbertopInd1,
            StartvalvenumberbotInd0 = entity.StartvalvenumberbotInd0,
            StartvalvenumberbotInd1 = entity.StartvalvenumberbotInd1,
            Holdtime = entity.Holdtime,
            CoolratetopInd0 = entity.CoolratetopInd0,
            CoolratetopInd1 = entity.CoolratetopInd1,
            CoolratebotInd0 = entity.CoolratebotInd0,
            CoolratebotInd1 = entity.CoolratebotInd1,
            LeadingpyroindexInd0 = entity.LeadingpyroindexInd0,
            LeadingpyroindexInd1 = entity.LeadingpyroindexInd1,
            Targetf4tInd0 = entity.Targetf4tInd0,
            Targetf4tInd1 = entity.Targetf4tInd1,
            TargettempInd0 = entity.TargettempInd0,
            TargettempInd1 = entity.TargettempInd1,
            TempoffsetaInd0 = entity.TempoffsetaInd0,
            TempoffsetaInd1 = entity.TempoffsetaInd1,
            TempoffsetbInd0 = entity.TempoffsetbInd0,
            TempoffsetbInd1 = entity.TempoffsetbInd1,
            AdaptationInd0 = entity.AdaptationInd0,
            AdaptationInd1 = entity.AdaptationInd1,
            Autosplinetemptransition = entity.Autosplinetemptransition,
            Autosplinevaluelowtop = entity.Autosplinevaluelowtop,
            Autosplinevaluelowbot = entity.Autosplinevaluelowbot,
            Adaptationfm = entity.Adaptationfm,
            Tempoffsetfma = entity.Tempoffsetfma,
            Tempoffsetfmb = entity.Tempoffsetfmb,
            UsetempgradselectionInd0 = entity.UsetempgradselectionInd0,
            UsetempgradselectionInd1 = entity.UsetempgradselectionInd1,

        };

        public static void MapEntity(Stdcsstrategy entity, StdStrategyCsDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;


            entity.Coolingstrategy = dto.Coolingstrategy;
            entity.Ftzload = dto.Ftzload;
            entity.TempgradInd0 = dto.TempgradInd0;
            entity.TempgradInd1 = dto.TempgradInd1;
            entity.ValveratiotopInd0 = dto.ValveratiotopInd0;
            entity.ValveratiotopInd1 = dto.ValveratiotopInd1;
            entity.ValveratiobotInd0 = dto.ValveratiobotInd0;
            entity.ValveratiobotInd1 = dto.ValveratiobotInd1;
            entity.Description2 = dto.Description2;
            entity.StartvalvenumbertopInd0 = dto.StartvalvenumbertopInd0;
            entity.StartvalvenumbertopInd1 = dto.StartvalvenumbertopInd1;
            entity.StartvalvenumberbotInd0 = dto.StartvalvenumberbotInd0;
            entity.StartvalvenumberbotInd1 = dto.StartvalvenumberbotInd1;
            entity.Holdtime = dto.Holdtime;
            entity.CoolratetopInd0 = dto.CoolratetopInd0;
            entity.CoolratetopInd1 = dto.CoolratetopInd1;
            entity.CoolratebotInd0 = dto.CoolratebotInd0;
            entity.CoolratebotInd1 = dto.CoolratebotInd1;
            entity.LeadingpyroindexInd0 = dto.LeadingpyroindexInd0;
            entity.LeadingpyroindexInd1 = dto.LeadingpyroindexInd1;
            entity.Targetf4tInd0 = dto.Targetf4tInd0;
            entity.Targetf4tInd1 = dto.Targetf4tInd1;
            entity.TargettempInd0 = dto.TargettempInd0;
            entity.TargettempInd1 = dto.TargettempInd1;
            entity.TempoffsetaInd0 = dto.TempoffsetaInd0;
            entity.TempoffsetaInd1 = dto.TempoffsetaInd1;
            entity.TempoffsetbInd0 = dto.TempoffsetbInd0;
            entity.TempoffsetbInd1 = dto.TempoffsetbInd1;
            entity.AdaptationInd0 = dto.AdaptationInd0;
            entity.AdaptationInd1 = dto.AdaptationInd1;
            entity.Autosplinetemptransition = dto.Autosplinetemptransition;
            entity.Autosplinevaluelowtop = dto.Autosplinevaluelowtop;
            entity.Autosplinevaluelowbot = dto.Autosplinevaluelowbot;
            entity.Adaptationfm = dto.Adaptationfm;
            entity.Tempoffsetfma = dto.Tempoffsetfma;
            entity.Tempoffsetfmb = dto.Tempoffsetfmb;
            entity.UsetempgradselectionInd0 = dto.UsetempgradselectionInd0;
            entity.UsetempgradselectionInd1 = dto.UsetempgradselectionInd1;

        }
    }
}
