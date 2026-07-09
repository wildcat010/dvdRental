using System;
using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Setpoints.SetpointsCS;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsCSMapper
    {
        public static MaterialOverviewCsDto MapOverview(this MaterialOverviewCsDto result, SetpointsCsOverviewDataBlob dataBlob)
        {
            var edordentL = dataBlob.Edordents.Where(x => x.Source == "L").FirstOrDefault();
            var edordentM = dataBlob.Edordents.Where(x => x.Source == "M").FirstOrDefault();
            var edordentE = dataBlob.Edordents.Where(x => x.Source == "E").FirstOrDefault();

            var spord2pcL = dataBlob.SpOrd2Pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spord2pcM = dataBlob.SpOrd2Pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spord2pcE = dataBlob.SpOrd2Pcs.Where(x => x.Source == "E").FirstOrDefault();

            var csstrategyL = dataBlob.CsStrategies.Where(x => x.Source == "X").FirstOrDefault();
            var csstrategyM = dataBlob.CsStrategies.Where(x => x.Source == "M").FirstOrDefault();
            var csstrategyE = dataBlob.CsStrategies.Where(x => x.Source == "E").FirstOrDefault();

            var csprofileL = dataBlob.CsProfiles.Where(x => x.Source == "L").FirstOrDefault();
            var csprofileM = dataBlob.CsProfiles.Where(x => x.Source == "M").FirstOrDefault();
            var csprofileE = dataBlob.CsProfiles.Where(x => x.Source == "E").FirstOrDefault();

            var cscrsL = dataBlob.CsCrs.Where(x => x.Source == "L").FirstOrDefault();
            var cscrsM = dataBlob.CsCrs.Where(x => x.Source == "M").FirstOrDefault();
            var cscrsE = dataBlob.CsCrs.Where(x => x.Source == "E").FirstOrDefault();

            var csrtcoolingL = dataBlob.CsRtCoolings.Where(x => x.Source == "L").FirstOrDefault();
            var csrtcoolingM = dataBlob.CsRtCoolings.Where(x => x.Source == "M").FirstOrDefault();
            var csrtcoolingE = dataBlob.CsRtCoolings.Where(x => x.Source == "E").FirstOrDefault();

            var cspervesL = dataBlob.CsPerves.Where(x => x.Source == "L").FirstOrDefault();
            var cspervesM = dataBlob.CsPerves.Where(x => x.Source == "M").FirstOrDefault();
            var cspervesE = dataBlob.CsPerves.Where(x => x.Source == "E").FirstOrDefault();

            result.HExit.L = edordentL?.Hexit;
            result.HExit.E = edordentE?.Hexit;
            result.HExit.DbSource = "EdOrdEnt.HExit";

            result.WidthExit.L = edordentL?.Widthexit;
            result.WidthExit.E = edordentE?.Widthexit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";

            result.TExit.L = edordentL?.Texit;
            result.TExit.E = edordentE?.Texit;
            result.TExit.DbSource = "EdOrdEnt.TExit";

            result.LExit.L = spord2pcL?.Lexit;
            result.LExit.E = spord2pcE?.Lexit;
            result.LExit.DbSource = "SpOrd2Pc.LExit";

            result.CoilTemp.L = edordentL?.Coiltemp;
            result.CoilTemp.M = edordentM?.Coiltemp;
            result.CoilTemp.E = edordentE?.Coiltemp;
            result.CoilTemp.DbSource = "EdOrdEnt.CoilTemp";

            result.CoolingStrategy.L = csstrategyL?.Coolingstrategy;
            result.CoolingStrategy.M = csstrategyM?.Coolingstrategy;
            result.CoolingStrategy.E = csstrategyE?.Coolingstrategy;
            result.CoolingStrategy.DbSource = "CsStrategy.CoolingStrategy";

            result.FtzLoad.L = csstrategyL?.Ftzload;
            result.FtzLoad.M = csstrategyM?.Ftzload;
            result.FtzLoad.E = csstrategyE?.Ftzload;
            result.FtzLoad.DbSource = "CsStrategy.FtzLoad";

            result.StartValveNumberTopInd0.L = csstrategyL?.StartvalvenumbertopInd0;
            result.StartValveNumberTopInd0.M = csstrategyM?.StartvalvenumbertopInd0;
            result.StartValveNumberTopInd0.E = csstrategyE?.StartvalvenumbertopInd0;
            result.StartValveNumberTopInd0.DbSource = "CsStrategy.StartValveNumberTopInd0";

            result.StartValveNumberBotInd0.L = csstrategyL?.StartvalvenumberbotInd0;
            result.StartValveNumberBotInd0.M = csstrategyM?.StartvalvenumberbotInd0;
            result.StartValveNumberBotInd0.E = csstrategyE?.StartvalvenumberbotInd0;
            result.StartValveNumberBotInd0.DbSource = "CsStrategy.StartValveNumberBotInd0";

            result.CoolRateTopInd0.L = csstrategyL?.CoolratetopInd0;
            result.CoolRateTopInd0.M = csstrategyM?.CoolratetopInd0;
            result.CoolRateTopInd0.E = csstrategyE?.CoolratetopInd0;
            result.CoolRateTopInd0.DbSource = "CsStrategy.CoolRateTopInd0";

            result.CoolRateBotInd0.L = csstrategyL?.CoolratebotInd0;
            result.CoolRateBotInd0.M = csstrategyM?.CoolratebotInd0;
            result.CoolRateBotInd0.E = csstrategyE?.CoolratebotInd0;
            result.CoolRateBotInd0.DbSource = "CsStrategy.CoolRateBotInd0";

            result.LengthUncooledHead.L = csprofileL?.Lengthuncooledhead;
            result.LengthUncooledHead.M = csprofileM?.Lengthuncooledhead;
            result.LengthUncooledHead.E = csprofileE?.Lengthuncooledhead;
            result.LengthUncooledHead.DbSource = "CsProfile.LengthUncooledHead";

            result.LengthUncooledTail.L = csprofileL?.Lengthuncooledtail;
            result.LengthUncooledTail.M = csprofileM?.Lengthuncooledtail;
            result.LengthUncooledTail.E = csprofileE?.Lengthuncooledtail;
            result.LengthUncooledTail.DbSource = "CsProfile.LengthUncooledTail";

            result.LengthProfileHead.L = csprofileL?.Lengthprofilehead;
            result.LengthProfileHead.M = csprofileM?.Lengthprofilehead;
            result.LengthProfileHead.E = csprofileE?.Lengthprofilehead;
            result.LengthProfileHead.DbSource = "CsProfile.LengthProfileHead";

            result.LengthProfileTail.L = csprofileL?.Lengthprofiletail;
            result.LengthProfileTail.M = csprofileM?.Lengthprofiletail;
            result.LengthProfileTail.E = csprofileE?.Lengthprofiletail;
            result.LengthProfileTail.DbSource = "CsProfile.LengthProfileTail";

            result.CoilTempProfileHead.L = csprofileL?.Coiltempprofilehead;
            result.CoilTempProfileHead.M = csprofileM?.Coiltempprofilehead;
            result.CoilTempProfileHead.E = csprofileE?.Coiltempprofilehead;
            result.CoilTempProfileHead.DbSource = "CsProfile.CoilTempProfileHead";

            result.CoilTempProfileTail.L = csprofileL?.Coiltempprofiletail;
            result.CoilTempProfileTail.M = csprofileM?.Coiltempprofiletail;
            result.CoilTempProfileTail.E = csprofileE?.Coiltempprofiletail;
            result.CoilTempProfileTail.DbSource = "CsProfile.CoilTempProfileTail";

            result.CsStrategyPlanNo.L = csstrategyL?.Planno;
            result.CsStrategyPlanNo.M = csstrategyM?.Planno;
            result.CsStrategyPlanNo.E = csstrategyE?.Planno;
            result.CsStrategyPlanNo.DbSource = "CsStrategy.PlanNo";

            result.CsProfilePlanNo.L = csprofileL?.Planno;
            result.CsProfilePlanNo.M = csprofileM?.Planno;
            result.CsProfilePlanNo.E = csprofileE?.Planno;
            result.CsProfilePlanNo.DbSource = "CsProfile.PlanNo";

            result.CscrsPlanNo.L = cscrsL?.Planno;
            result.CscrsPlanNo.M = cscrsM?.Planno;
            result.CscrsPlanNo.E = cscrsE?.Planno;
            result.CscrsPlanNo.DbSource = "CsCrs.PlanNo";

            result.CsRtCoolingPlanNo.L = csrtcoolingL?.Planno;
            result.CsRtCoolingPlanNo.M = csrtcoolingM?.Planno;
            result.CsRtCoolingPlanNo.E = csrtcoolingE?.Planno;
            result.CsRtCoolingPlanNo.DbSource = "CsRtCooling.PlanNo";

            result.CsPerfPlanNo.L = cspervesL?.Planno;
            result.CsPerfPlanNo.M = cspervesM?.Planno;
            result.CsPerfPlanNo.E = cspervesE?.Planno;
            result.CsPerfPlanNo.DbSource = "CsPerf.PlanNo";

            return result;
        }

        public static SetpointsCsDto MapPreCalculation(this SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {

            MapPreCalcTempCurve(result, dataBlob);
            MapPreCalcValveSettings(result, dataBlob);
            MapPreCalcSpeedDiagram(result, dataBlob);

            var spord2pcL = dataBlob.SpOrd2Pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spord2pcM = dataBlob.SpOrd2Pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spord2pcE = dataBlob.SpOrd2Pcs.Where(x => x.Source == "E").FirstOrDefault();

            var cspcresultL = dataBlob.Cspcresults.FirstOrDefault();
            var cspcresultM = dataBlob.Cspcresults.FirstOrDefault();
            var cspcresultE = dataBlob.Cspcresults.FirstOrDefault();

            result.PreCalculation.OrderData.Vexit.L = spord2pcL?.Vexitlas;
            result.PreCalculation.OrderData.Vexit.M = spord2pcM?.Vexitlas;
            result.PreCalculation.OrderData.Vexit.E = spord2pcE?.Vexitlas;
            result.PreCalculation.OrderData.Vexit.DbSource = "SpOrd2Pc.VExitLas";
            
            result.PreCalculation.OrderData.VthrCoiler.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vthrcoiler != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vthrcoiler, 7) : null;
            result.PreCalculation.OrderData.VthrCoiler.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Vthrcoiler)}";

            //result.PreCalculationTab.OrderData.Vtail.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vtargettailout != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vtargettailout, 7) : null;
            //result.PreCalculationTab.OrderData.Vtail.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Vtargettailout)}";

            result.PreCalculation.OrderData.TempSpeedup.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Tsuvalue != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Tsuvalue, 7) : null;
            result.PreCalculation.OrderData.TempSpeedup.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Tsuvalue)}";

            result.PreCalculation.OrderData.TempSpeedupFlag.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Speedupflag;
            result.PreCalculation.OrderData.TempSpeedupFlag.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Speedupflag)}";

            //result.PreCalculationTab.OrderData.VMax.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vmax != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vmax, 7) : null;
            //result.PreCalculationTab.OrderData.VMax.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Vmax)}";

            result.PreCalculation.OrderData.WaterAmount.L = cspcresultL?.Wateramount;
            result.PreCalculation.OrderData.WaterAmount.M = cspcresultM?.Wateramount;
            result.PreCalculation.OrderData.WaterAmount.E = cspcresultM?.Wateramount;
            result.PreCalculation.OrderData.WaterAmount.DbSource = "CsPcResult.Wateramount";

            return result;
        }

        private static void MapPreCalcTempCurve(SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            foreach (var record in dataBlob.CsPcCurves)
            {
                var point = new CsTemperatureCurvePoint() { XDistance = record.Distpoint, YValue = record.Temp };
                result.PreCalculation.TemperatureCurve.Add(point);
            }
        }

        private static void MapPreCalcValveSettings(SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            var record = dataBlob?.CsPcResult;

            for (int i = 0; i < record?.Vprecalctop?.Length; i++)
            {
                var setting = new CsValveSetting()
                {
                    Index = i,
                    TopValue = record.Vprecalctop[i],
                    BottomValue = record.Vprecalcbot[i]
                };

                result.PreCalculation.ValveSettings.Add(setting);
            }
        }

        private static void MapPreCalcSpeedDiagram(SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            var records = dataBlob.CsPcSpeedDiags;

            foreach (var record in records)
            {
                var line = new CsSpeedDiagramLine()
                {
                    Start = new CsSpeedDiagramPoint()
                    {
                        XPosition = record.Startposition,
                        YSpeed = record.Startspeed,
                    },
                    End = new CsSpeedDiagramPoint()
                    {
                        XPosition = record.Endposition,
                        YSpeed = record.Endspeed,
                    },
                };

                result.PreCalculation.SpeedDiagram.Add(line);
            }
        }

        public static SetpointsCsDto MapCoolingStrategy(this SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            var csstrategyL = dataBlob.CsStrategies.Where(x => x.Source == "X").FirstOrDefault();
            var csstrategyM = dataBlob.CsStrategies.Where(x => x.Source == "M").FirstOrDefault();
            var csstrategyE = dataBlob.CsStrategies.Where(x => x.Source == "E").FirstOrDefault();

            result.CoolingStrategyTab.PlanNo.L = csstrategyL?.Planno;
            result.CoolingStrategyTab.PlanNo.M = csstrategyM?.Planno;
            result.CoolingStrategyTab.PlanNo.E = csstrategyE?.Planno;
            result.CoolingStrategyTab.PlanNo.DbSource = "CsStrategy.PlanNo";

            result.CoolingStrategyTab.StartValveNumberTopInd0.L = csstrategyL?.StartvalvenumbertopInd0;
            result.CoolingStrategyTab.StartValveNumberTopInd0.M = csstrategyM?.StartvalvenumbertopInd0;
            result.CoolingStrategyTab.StartValveNumberTopInd0.E = csstrategyE?.StartvalvenumbertopInd0;
            result.CoolingStrategyTab.StartValveNumberTopInd0.DbSource = "CsStrategy.StartValveNumberTopInd0";

            result.CoolingStrategyTab.StartValveNumberBotInd0.L = csstrategyL?.StartvalvenumberbotInd0;
            result.CoolingStrategyTab.StartValveNumberBotInd0.M = csstrategyM?.StartvalvenumberbotInd0;
            result.CoolingStrategyTab.StartValveNumberBotInd0.E = csstrategyE?.StartvalvenumberbotInd0;
            result.CoolingStrategyTab.StartValveNumberBotInd0.DbSource = "CsStrategy.StartValveNumberBotInd0";

            result.CoolingStrategyTab.CoolRateTopInd0.L = csstrategyL?.CoolratetopInd0;
            result.CoolingStrategyTab.CoolRateTopInd0.M = csstrategyM?.CoolratetopInd0;
            result.CoolingStrategyTab.CoolRateTopInd0.E = csstrategyE?.CoolratetopInd0;
            result.CoolingStrategyTab.CoolRateTopInd0.DbSource = "CsStrategy.CoolRateTopInd0";

            result.CoolingStrategyTab.CoolRateBotInd0.L = csstrategyL?.CoolratebotInd0;
            result.CoolingStrategyTab.CoolRateBotInd0.M = csstrategyM?.CoolratebotInd0;
            result.CoolingStrategyTab.CoolRateBotInd0.E = csstrategyE?.CoolratebotInd0;
            result.CoolingStrategyTab.CoolRateBotInd0.DbSource = "CsStrategy.CoolRateBotInd0";

            result.CoolingStrategyTab.TempOffsetAInd0.L = csstrategyL?.TempoffsetaInd0;
            result.CoolingStrategyTab.TempOffsetAInd0.M = csstrategyM?.TempoffsetaInd0;
            result.CoolingStrategyTab.TempOffsetAInd0.E = csstrategyE?.TempoffsetaInd0;
            result.CoolingStrategyTab.TempOffsetAInd0.DbSource = "CsStrategy.TempOffsetAInd0";

            result.CoolingStrategyTab.TempOffsetBInd0.L = csstrategyL?.TempoffsetbInd0;
            result.CoolingStrategyTab.TempOffsetBInd0.M = csstrategyM?.TempoffsetbInd0;
            result.CoolingStrategyTab.TempOffsetBInd0.E = csstrategyE?.TempoffsetbInd0;
            result.CoolingStrategyTab.TempOffsetBInd0.DbSource = "CsStrategy.TempOffsetBInd0";

            result.CoolingStrategyTab.AdaptationInd0.L = csstrategyL?.AdaptationInd0;
            result.CoolingStrategyTab.AdaptationInd0.M = csstrategyM?.AdaptationInd0;
            result.CoolingStrategyTab.AdaptationInd0.E = csstrategyE?.AdaptationInd0;
            result.CoolingStrategyTab.AdaptationInd0.DbSource = "CsStrategy.AdaptationInd0";

            result.CoolingStrategyTab.LeadingPyroIndexInd0.L = csstrategyL?.LeadingpyroindexInd0;
            result.CoolingStrategyTab.LeadingPyroIndexInd0.M = csstrategyM?.LeadingpyroindexInd0;
            result.CoolingStrategyTab.LeadingPyroIndexInd0.E = csstrategyE?.LeadingpyroindexInd0;
            result.CoolingStrategyTab.LeadingPyroIndexInd0.DbSource = "CsStrategy.LeadingPyroIndexInd0";

            result.CoolingStrategyTab.TargetF4TInd0.L = csstrategyL?.Targetf4tInd0;
            result.CoolingStrategyTab.TargetF4TInd0.M = csstrategyM?.Targetf4tInd0;
            result.CoolingStrategyTab.TargetF4TInd0.E = csstrategyE?.Targetf4tInd0;
            result.CoolingStrategyTab.TargetF4TInd0.DbSource = "CsStrategy.TargetF4tInd0";

            result.CoolingStrategyTab.TargetTempInd0.L = csstrategyL?.TargettempInd0;
            result.CoolingStrategyTab.TargetTempInd0.M = csstrategyM?.TargettempInd0;
            result.CoolingStrategyTab.TargetTempInd0.E = csstrategyE?.TargettempInd0;
            result.CoolingStrategyTab.TargetTempInd0.DbSource = "CsStrategy.TargetTempInd0";

            result.CoolingStrategyTab.StartValveNumberTopInd1.L = csstrategyL?.StartvalvenumbertopInd1;
            result.CoolingStrategyTab.StartValveNumberTopInd1.E = csstrategyE?.StartvalvenumbertopInd1;
            result.CoolingStrategyTab.StartValveNumberTopInd1.DbSource = "CsStrategy.StartValveNumberTopInd1";

            result.CoolingStrategyTab.StartValveNumberBotInd1.L = csstrategyL?.StartvalvenumberbotInd1;
            result.CoolingStrategyTab.StartValveNumberBotInd1.E = csstrategyE?.StartvalvenumberbotInd1;
            result.CoolingStrategyTab.StartValveNumberBotInd1.DbSource = "CsStrategy.StartValveNumberBotInd1";

            result.CoolingStrategyTab.CoolRateTopInd1.L = csstrategyL?.CoolratetopInd1;
            result.CoolingStrategyTab.CoolRateTopInd1.E = csstrategyE?.CoolratetopInd1;
            result.CoolingStrategyTab.CoolRateTopInd1.DbSource = "CsStrategy.CoolRateTopInd1";

            result.CoolingStrategyTab.CoolRateBotInd1.L = csstrategyL?.CoolratebotInd1;
            result.CoolingStrategyTab.CoolRateBotInd1.E = csstrategyE?.CoolratebotInd1;
            result.CoolingStrategyTab.CoolRateBotInd1.DbSource = "CsStrategy.CoolRateBotInd1";

            result.CoolingStrategyTab.TempOffsetAInd1.L = csstrategyL?.TempoffsetaInd1;
            result.CoolingStrategyTab.TempOffsetAInd1.E = csstrategyE?.TempoffsetaInd1;
            result.CoolingStrategyTab.TempOffsetAInd1.DbSource = "CsStrategy.TempOffsetAInd1";

            result.CoolingStrategyTab.TempOffsetBInd1.L = csstrategyL?.TempoffsetbInd1;
            result.CoolingStrategyTab.TempOffsetBInd1.E = csstrategyE?.TempoffsetbInd1;
            result.CoolingStrategyTab.TempOffsetBInd1.DbSource = "CsStrategy.TempOffsetBInd1";

            result.CoolingStrategyTab.AdaptationInd1.L = csstrategyL?.AdaptationInd1;
            result.CoolingStrategyTab.AdaptationInd1.E = csstrategyE?.AdaptationInd1;
            result.CoolingStrategyTab.AdaptationInd1.DbSource = "CsStrategy.AdaptationInd1";

            result.CoolingStrategyTab.LeadingPyroIndexInd1.L = csstrategyL?.LeadingpyroindexInd1;
            result.CoolingStrategyTab.LeadingPyroIndexInd1.E = csstrategyE?.LeadingpyroindexInd1;
            result.CoolingStrategyTab.LeadingPyroIndexInd1.DbSource = "CsStrategy.LeadingPyroIndexInd1";

            result.CoolingStrategyTab.TargetF4TInd1.L = csstrategyL?.Targetf4tInd1;
            result.CoolingStrategyTab.TargetF4TInd1.E = csstrategyE?.Targetf4tInd1;
            result.CoolingStrategyTab.TargetF4TInd1.DbSource = "CsStrategy.TargetF4tInd1";

            result.CoolingStrategyTab.TargetTempInd1.L = csstrategyL?.TargettempInd1;
            result.CoolingStrategyTab.TargetTempInd1.E = csstrategyE?.TargettempInd1;
            result.CoolingStrategyTab.TargetTempInd1.DbSource = "CsStrategy.TargetTempInd1";

            result.CoolingStrategyTab.AutoSplineValueLowTop.L = csstrategyL?.Autosplinevaluelowtop;
            result.CoolingStrategyTab.AutoSplineValueLowTop.E = csstrategyE?.Autosplinevaluelowtop;
            result.CoolingStrategyTab.AutoSplineValueLowTop.DbSource = "CsStrategy.AutoSplineValueLowTop";

            result.CoolingStrategyTab.AutoSplineValueLowBot.L = csstrategyL?.Autosplinevaluelowbot;
            result.CoolingStrategyTab.AutoSplineValueLowBot.E = csstrategyE?.Autosplinevaluelowbot;
            result.CoolingStrategyTab.AutoSplineValueLowBot.DbSource = "CsStrategy.AutoSplineValueLowBot";

            result.CoolingStrategyTab.AutoSplineTempTransition.L = csstrategyL?.Autosplinetemptransition;
            result.CoolingStrategyTab.AutoSplineTempTransition.E = csstrategyE?.Autosplinetemptransition;
            result.CoolingStrategyTab.AutoSplineTempTransition.DbSource = "CsStrategy.AutoSplineTempTransition";

            result.CoolingStrategyTab.TempOffsetFma.L = csstrategyL?.Tempoffsetfma;
            result.CoolingStrategyTab.TempOffsetFma.M = csstrategyM?.Tempoffsetfma;
            result.CoolingStrategyTab.TempOffsetFma.E = csstrategyE?.Tempoffsetfma;
            result.CoolingStrategyTab.TempOffsetFma.DbSource = "CsStrategy.TempOffsetFmA";

            result.CoolingStrategyTab.TempOffsetFmb.L = csstrategyL?.Tempoffsetfmb;
            result.CoolingStrategyTab.TempOffsetFmb.M = csstrategyM?.Tempoffsetfmb;
            result.CoolingStrategyTab.TempOffsetFmb.E = csstrategyE?.Tempoffsetfmb;
            result.CoolingStrategyTab.TempOffsetFmb.DbSource = "CsStrategy.TempOffsetFmB";

            result.CoolingStrategyTab.AdaptationFm.L = csstrategyL?.Adaptationfm;
            result.CoolingStrategyTab.AdaptationFm.M = csstrategyM?.Adaptationfm;
            result.CoolingStrategyTab.AdaptationFm.E = csstrategyE?.Adaptationfm;
            result.CoolingStrategyTab.AdaptationFm.DbSource = "CsStrategy.AdaptationFm";

            return result;

        }

        public static SetpointsCsDto MapProfileCooling(this SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            var csprofileL = dataBlob.CsProfiles.Where(x => x.Source == "L").FirstOrDefault();
            var csprofileM = dataBlob.CsProfiles.Where(x => x.Source == "M").FirstOrDefault();
            var csprofileE = dataBlob.CsProfiles.Where(x => x.Source == "E").FirstOrDefault();

            result.ProfileCoolingTab.PlanNo.L = csprofileL?.Planno;
            result.ProfileCoolingTab.PlanNo.M = csprofileM?.Planno;
            result.ProfileCoolingTab.PlanNo.E = csprofileE?.Planno;
            result.ProfileCoolingTab.PlanNo.DbSource = "CsProfile.PlanNo";

            result.ProfileCoolingTab.LengthUncooledHead.L = csprofileL?.Lengthuncooledhead;
            result.ProfileCoolingTab.LengthUncooledHead.M = csprofileM?.Lengthuncooledhead;
            result.ProfileCoolingTab.LengthUncooledHead.E = csprofileE?.Lengthuncooledhead;
            result.ProfileCoolingTab.LengthUncooledHead.DbSource = "CsProfile.LengthUncooledHead";

            result.ProfileCoolingTab.CoilTempProfileHead.L = csprofileL?.Coiltempprofilehead;
            result.ProfileCoolingTab.CoilTempProfileHead.M = csprofileM?.Coiltempprofilehead;
            result.ProfileCoolingTab.CoilTempProfileHead.E = csprofileE?.Coiltempprofilehead;
            result.ProfileCoolingTab.CoilTempProfileHead.DbSource = "CsProfile.CoilTempProfileHead";

            result.ProfileCoolingTab.LengthProfileHead.L = csprofileL?.Lengthprofilehead;
            result.ProfileCoolingTab.LengthProfileHead.M = csprofileM?.Lengthprofilehead;
            result.ProfileCoolingTab.LengthProfileHead.E = csprofileE?.Lengthprofilehead;
            result.ProfileCoolingTab.LengthProfileHead.DbSource = "CsProfile.LengthProfileHead";

            result.ProfileCoolingTab.LengthProfileHeadWedge.L = csprofileL?.Lengthprofileheadwedge;
            result.ProfileCoolingTab.LengthProfileHeadWedge.M = csprofileM?.Lengthprofileheadwedge;
            result.ProfileCoolingTab.LengthProfileHeadWedge.E = csprofileE?.Lengthprofileheadwedge;
            result.ProfileCoolingTab.LengthProfileHeadWedge.DbSource = "CsProfile.LengthProfileHeadWedge";

            result.ProfileCoolingTab.LengthProfileTailWedge.L = csprofileL?.Lengthprofiletailwedge;
            result.ProfileCoolingTab.LengthProfileTailWedge.M = csprofileM?.Lengthprofiletailwedge;
            result.ProfileCoolingTab.LengthProfileTailWedge.E = csprofileE?.Lengthprofiletailwedge;
            result.ProfileCoolingTab.LengthProfileTailWedge.DbSource = "CsProfile.LengthProfileTailWedge";

            result.ProfileCoolingTab.LengthProfileTail.L = csprofileL?.Lengthprofiletail;
            result.ProfileCoolingTab.LengthProfileTail.M = csprofileM?.Lengthprofiletail;
            result.ProfileCoolingTab.LengthProfileTail.E = csprofileE?.Lengthprofiletail;
            result.ProfileCoolingTab.LengthProfileTail.DbSource = "CsProfile.LengthProfileTail";

            result.ProfileCoolingTab.CoilTempProfileTail.L = csprofileL?.Coiltempprofiletail;
            result.ProfileCoolingTab.CoilTempProfileTail.M = csprofileM?.Coiltempprofiletail;
            result.ProfileCoolingTab.CoilTempProfileTail.E = csprofileE?.Coiltempprofiletail;
            result.ProfileCoolingTab.CoilTempProfileTail.DbSource = "CsProfile.CoilTempProfileTail";

            result.ProfileCoolingTab.LengthUncooledTail.L = csprofileL?.Lengthuncooledtail;
            result.ProfileCoolingTab.LengthUncooledTail.M = csprofileM?.Lengthuncooledtail;
            result.ProfileCoolingTab.LengthUncooledTail.E = csprofileE?.Lengthuncooledtail;
            result.ProfileCoolingTab.LengthUncooledTail.DbSource = "CsProfile.LengthUncooledTail";

            return result;
        }
    }
}
