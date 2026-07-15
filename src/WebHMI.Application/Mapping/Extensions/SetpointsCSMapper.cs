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

            result.HExit.L = edordentL?.HExit;
            result.HExit.E = edordentE?.HExit;
            result.HExit.DbSource = "EdOrdEnt.HExit";

            result.WidthExit.L = edordentL?.WidthExit;
            result.WidthExit.E = edordentE?.WidthExit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";

            result.TExit.L = edordentL?.TExit;
            result.TExit.E = edordentE?.TExit;
            result.TExit.DbSource = "EdOrdEnt.TExit";

            result.LExit.L = spord2pcL?.LExit;
            result.LExit.E = spord2pcE?.LExit;
            result.LExit.DbSource = "SpOrd2Pc.LExit";

            result.CoilTemp.L = edordentL?.CoilTemp;
            result.CoilTemp.M = edordentM?.CoilTemp;
            result.CoilTemp.E = edordentE?.CoilTemp;
            result.CoilTemp.DbSource = "EdOrdEnt.CoilTemp";

            result.CoolingStrategy.L = csstrategyL?.CoolingStrategy;
            result.CoolingStrategy.M = csstrategyM?.CoolingStrategy;
            result.CoolingStrategy.E = csstrategyE?.CoolingStrategy;
            result.CoolingStrategy.DbSource = "CsStrategy.CoolingStrategy";

            result.FtzLoad.L = csstrategyL?.FtzLoad;
            result.FtzLoad.M = csstrategyM?.FtzLoad;
            result.FtzLoad.E = csstrategyE?.FtzLoad;
            result.FtzLoad.DbSource = "CsStrategy.FtzLoad";

            result.StartValveNumberTopInd0.L = csstrategyL?.StartValveNumberTopInd0;
            result.StartValveNumberTopInd0.M = csstrategyM?.StartValveNumberTopInd0;
            result.StartValveNumberTopInd0.E = csstrategyE?.StartValveNumberTopInd0;
            result.StartValveNumberTopInd0.DbSource = "CsStrategy.StartValveNumberTopInd0";

            result.StartValveNumberBotInd0.L = csstrategyL?.StartValveNumberBotInd0;
            result.StartValveNumberBotInd0.M = csstrategyM?.StartValveNumberBotInd0;
            result.StartValveNumberBotInd0.E = csstrategyE?.StartValveNumberBotInd0;
            result.StartValveNumberBotInd0.DbSource = "CsStrategy.StartValveNumberBotInd0";

            result.CoolRateTopInd0.L = csstrategyL?.CoolRateTopInd0;
            result.CoolRateTopInd0.M = csstrategyM?.CoolRateTopInd0;
            result.CoolRateTopInd0.E = csstrategyE?.CoolRateTopInd0;
            result.CoolRateTopInd0.DbSource = "CsStrategy.CoolRateTopInd0";

            result.CoolRateBotInd0.L = csstrategyL?.CoolRateBotInd0;
            result.CoolRateBotInd0.M = csstrategyM?.CoolRateBotInd0;
            result.CoolRateBotInd0.E = csstrategyE?.CoolRateBotInd0;
            result.CoolRateBotInd0.DbSource = "CsStrategy.CoolRateBotInd0";

            result.LengthUncooledHead.L = csprofileL?.LengthUncooledHead;
            result.LengthUncooledHead.M = csprofileM?.LengthUncooledHead;
            result.LengthUncooledHead.E = csprofileE?.LengthUncooledHead;
            result.LengthUncooledHead.DbSource = "CsProfile.LengthUncooledHead";

            result.LengthUncooledTail.L = csprofileL?.LengthUncooledTail;
            result.LengthUncooledTail.M = csprofileM?.LengthUncooledTail;
            result.LengthUncooledTail.E = csprofileE?.LengthUncooledTail;
            result.LengthUncooledTail.DbSource = "CsProfile.LengthUncooledTail";

            result.LengthProfileHead.L = csprofileL?.LengthProfileHead;
            result.LengthProfileHead.M = csprofileM?.LengthProfileHead;
            result.LengthProfileHead.E = csprofileE?.LengthProfileHead;
            result.LengthProfileHead.DbSource = "CsProfile.LengthProfileHead";

            result.LengthProfileTail.L = csprofileL?.LengthProfileTail;
            result.LengthProfileTail.M = csprofileM?.LengthProfileTail;
            result.LengthProfileTail.E = csprofileE?.LengthProfileTail;
            result.LengthProfileTail.DbSource = "CsProfile.LengthProfileTail";

            result.CoilTempProfileHead.L = csprofileL?.CoilTempProfileHead;
            result.CoilTempProfileHead.M = csprofileM?.CoilTempProfileHead;
            result.CoilTempProfileHead.E = csprofileE?.CoilTempProfileHead;
            result.CoilTempProfileHead.DbSource = "CsProfile.CoilTempProfileHead";

            result.CoilTempProfileTail.L = csprofileL?.CoilTempProfileTail;
            result.CoilTempProfileTail.M = csprofileM?.CoilTempProfileTail;
            result.CoilTempProfileTail.E = csprofileE?.CoilTempProfileTail;
            result.CoilTempProfileTail.DbSource = "CsProfile.CoilTempProfileTail";

            result.CsStrategyPlanNo.L = csstrategyL?.PlanNo;
            result.CsStrategyPlanNo.M = csstrategyM?.PlanNo;
            result.CsStrategyPlanNo.E = csstrategyE?.PlanNo;
            result.CsStrategyPlanNo.DbSource = "CsStrategy.PlanNo";

            result.CsProfilePlanNo.L = csprofileL?.PlanNo;
            result.CsProfilePlanNo.M = csprofileM?.PlanNo;
            result.CsProfilePlanNo.E = csprofileE?.PlanNo;
            result.CsProfilePlanNo.DbSource = "CsProfile.PlanNo";

            result.CscrsPlanNo.L = cscrsL?.PlanNo;
            result.CscrsPlanNo.M = cscrsM?.PlanNo;
            result.CscrsPlanNo.E = cscrsE?.PlanNo;
            result.CscrsPlanNo.DbSource = "CsCrs.PlanNo";

            result.CsRtCoolingPlanNo.L = csrtcoolingL?.PlanNo;
            result.CsRtCoolingPlanNo.M = csrtcoolingM?.PlanNo;
            result.CsRtCoolingPlanNo.E = csrtcoolingE?.PlanNo;
            result.CsRtCoolingPlanNo.DbSource = "CsRtCooling.PlanNo";

            result.CsPerfPlanNo.L = cspervesL?.PlanNo;
            result.CsPerfPlanNo.M = cspervesM?.PlanNo;
            result.CsPerfPlanNo.E = cspervesE?.PlanNo;
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

            result.PreCalculation.OrderData.Vexit.L = spord2pcL?.VExitLas;
            result.PreCalculation.OrderData.Vexit.M = spord2pcM?.VExitLas;
            result.PreCalculation.OrderData.Vexit.E = spord2pcE?.VExitLas;
            result.PreCalculation.OrderData.Vexit.DbSource = "SpOrd2Pc.VExitLas";
            
            result.PreCalculation.OrderData.VthrCoiler.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.VThrCoiler != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.VThrCoiler, 7) : null;
            result.PreCalculation.OrderData.VthrCoiler.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.VThrCoiler)}";

            //result.PreCalculationTab.OrderData.Vtail.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vtargettailout != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vtargettailout, 7) : null;
            //result.PreCalculationTab.OrderData.Vtail.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Vtargettailout)}";

            result.PreCalculation.OrderData.TempSpeedup.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.TSuValue != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.TSuValue, 7) : null;
            result.PreCalculation.OrderData.TempSpeedup.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.TSuValue)}";

            result.PreCalculation.OrderData.TempSpeedupFlag.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.SpeedupFlag;
            result.PreCalculation.OrderData.TempSpeedupFlag.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.SpeedupFlag)}";

            //result.PreCalculationTab.OrderData.VMax.E = dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vmax != null ? Math.Round((double)dataBlob.SpOrd2Pcs.FirstOrDefault(x => x.Source == "E")?.Vmax, 7) : null;
            //result.PreCalculationTab.OrderData.VMax.DbSource = $"{nameof(Spord2pc)}.{nameof(Spord2pc.Vmax)}";

            result.PreCalculation.OrderData.WaterAmount.L = cspcresultL?.WaterAmount;
            result.PreCalculation.OrderData.WaterAmount.M = cspcresultM?.WaterAmount;
            result.PreCalculation.OrderData.WaterAmount.E = cspcresultM?.WaterAmount;
            result.PreCalculation.OrderData.WaterAmount.DbSource = "CsPcResult.Wateramount";

            return result;
        }

        private static void MapPreCalcTempCurve(SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            foreach (var record in dataBlob.CsPcCurves)
            {
                var point = new CsTemperatureCurvePoint() { XDistance = record.DistPoint, YValue = record.Temp };
                result.PreCalculation.TemperatureCurve.Add(point);
            }
        }

        private static void MapPreCalcValveSettings(SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            var record = dataBlob?.CsPcResult;

            for (int i = 0; i < record?.VPrecalcTop?.Length; i++)
            {
                var setting = new CsValveSetting()
                {
                    Index = i,
                    TopValue = record.VPrecalcTop[i],
                    BottomValue = record.VPrecalcBot[i]
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
                        XPosition = record.StartPosition,
                        YSpeed = record.StartSpeed,
                    },
                    End = new CsSpeedDiagramPoint()
                    {
                        XPosition = record.EndPosition,
                        YSpeed = record.EndSpeed,
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

            result.CoolingStrategyTab.PlanNo.L = csstrategyL?.PlanNo;
            result.CoolingStrategyTab.PlanNo.M = csstrategyM?.PlanNo;
            result.CoolingStrategyTab.PlanNo.E = csstrategyE?.PlanNo;
            result.CoolingStrategyTab.PlanNo.DbSource = "CsStrategy.PlanNo";

            result.CoolingStrategyTab.StartValveNumberTopInd0.L = csstrategyL?.StartValveNumberTopInd0;
            result.CoolingStrategyTab.StartValveNumberTopInd0.M = csstrategyM?.StartValveNumberTopInd0;
            result.CoolingStrategyTab.StartValveNumberTopInd0.E = csstrategyE?.StartValveNumberTopInd0;
            result.CoolingStrategyTab.StartValveNumberTopInd0.DbSource = "CsStrategy.StartValveNumberTopInd0";

            result.CoolingStrategyTab.StartValveNumberBotInd0.L = csstrategyL?.StartValveNumberBotInd0;
            result.CoolingStrategyTab.StartValveNumberBotInd0.M = csstrategyM?.StartValveNumberBotInd0;
            result.CoolingStrategyTab.StartValveNumberBotInd0.E = csstrategyE?.StartValveNumberBotInd0;
            result.CoolingStrategyTab.StartValveNumberBotInd0.DbSource = "CsStrategy.StartValveNumberBotInd0";

            result.CoolingStrategyTab.CoolRateTopInd0.L = csstrategyL?.CoolRateTopInd0;
            result.CoolingStrategyTab.CoolRateTopInd0.M = csstrategyM?.CoolRateTopInd0;
            result.CoolingStrategyTab.CoolRateTopInd0.E = csstrategyE?.CoolRateTopInd0;
            result.CoolingStrategyTab.CoolRateTopInd0.DbSource = "CsStrategy.CoolRateTopInd0";

            result.CoolingStrategyTab.CoolRateBotInd0.L = csstrategyL?.CoolRateBotInd0;
            result.CoolingStrategyTab.CoolRateBotInd0.M = csstrategyM?.CoolRateBotInd0;
            result.CoolingStrategyTab.CoolRateBotInd0.E = csstrategyE?.CoolRateBotInd0;
            result.CoolingStrategyTab.CoolRateBotInd0.DbSource = "CsStrategy.CoolRateBotInd0";

            result.CoolingStrategyTab.TempOffsetAInd0.L = csstrategyL?.TempOffsetAInd0;
            result.CoolingStrategyTab.TempOffsetAInd0.M = csstrategyM?.TempOffsetAInd0;
            result.CoolingStrategyTab.TempOffsetAInd0.E = csstrategyE?.TempOffsetAInd0;
            result.CoolingStrategyTab.TempOffsetAInd0.DbSource = "CsStrategy.TempOffsetAInd0";

            result.CoolingStrategyTab.TempOffsetBInd0.L = csstrategyL?.TempOffsetBInd0;
            result.CoolingStrategyTab.TempOffsetBInd0.M = csstrategyM?.TempOffsetBInd0;
            result.CoolingStrategyTab.TempOffsetBInd0.E = csstrategyE?.TempOffsetBInd0;
            result.CoolingStrategyTab.TempOffsetBInd0.DbSource = "CsStrategy.TempOffsetBInd0";

            result.CoolingStrategyTab.AdaptationInd0.L = csstrategyL?.AdaptationInd0;
            result.CoolingStrategyTab.AdaptationInd0.M = csstrategyM?.AdaptationInd0;
            result.CoolingStrategyTab.AdaptationInd0.E = csstrategyE?.AdaptationInd0;
            result.CoolingStrategyTab.AdaptationInd0.DbSource = "CsStrategy.AdaptationInd0";

            result.CoolingStrategyTab.LeadingPyroIndexInd0.L = csstrategyL?.LeadingPyroIndexInd0;
            result.CoolingStrategyTab.LeadingPyroIndexInd0.M = csstrategyM?.LeadingPyroIndexInd0;
            result.CoolingStrategyTab.LeadingPyroIndexInd0.E = csstrategyE?.LeadingPyroIndexInd0;
            result.CoolingStrategyTab.LeadingPyroIndexInd0.DbSource = "CsStrategy.LeadingPyroIndexInd0";

            result.CoolingStrategyTab.TargetF4TInd0.L = csstrategyL?.TargetF4tInd0;
            result.CoolingStrategyTab.TargetF4TInd0.M = csstrategyM?.TargetF4tInd0;
            result.CoolingStrategyTab.TargetF4TInd0.E = csstrategyE?.TargetF4tInd0;
            result.CoolingStrategyTab.TargetF4TInd0.DbSource = "CsStrategy.TargetF4tInd0";

            result.CoolingStrategyTab.TargetTempInd0.L = csstrategyL?.TargetTempInd0;
            result.CoolingStrategyTab.TargetTempInd0.M = csstrategyM?.TargetTempInd0;
            result.CoolingStrategyTab.TargetTempInd0.E = csstrategyE?.TargetTempInd0;
            result.CoolingStrategyTab.TargetTempInd0.DbSource = "CsStrategy.TargetTempInd0";

            result.CoolingStrategyTab.StartValveNumberTopInd1.L = csstrategyL?.StartValveNumberTopInd1;
            result.CoolingStrategyTab.StartValveNumberTopInd1.E = csstrategyE?.StartValveNumberTopInd1;
            result.CoolingStrategyTab.StartValveNumberTopInd1.DbSource = "CsStrategy.StartValveNumberTopInd1";

            result.CoolingStrategyTab.StartValveNumberBotInd1.L = csstrategyL?.StartValveNumberBotInd1;
            result.CoolingStrategyTab.StartValveNumberBotInd1.E = csstrategyE?.StartValveNumberBotInd1;
            result.CoolingStrategyTab.StartValveNumberBotInd1.DbSource = "CsStrategy.StartValveNumberBotInd1";

            result.CoolingStrategyTab.CoolRateTopInd1.L = csstrategyL?.CoolRateTopInd1;
            result.CoolingStrategyTab.CoolRateTopInd1.E = csstrategyE?.CoolRateTopInd1;
            result.CoolingStrategyTab.CoolRateTopInd1.DbSource = "CsStrategy.CoolRateTopInd1";

            result.CoolingStrategyTab.CoolRateBotInd1.L = csstrategyL?.CoolRateBotInd1;
            result.CoolingStrategyTab.CoolRateBotInd1.E = csstrategyE?.CoolRateBotInd1;
            result.CoolingStrategyTab.CoolRateBotInd1.DbSource = "CsStrategy.CoolRateBotInd1";

            result.CoolingStrategyTab.TempOffsetAInd1.L = csstrategyL?.TempOffsetAInd1;
            result.CoolingStrategyTab.TempOffsetAInd1.E = csstrategyE?.TempOffsetAInd1;
            result.CoolingStrategyTab.TempOffsetAInd1.DbSource = "CsStrategy.TempOffsetAInd1";

            result.CoolingStrategyTab.TempOffsetBInd1.L = csstrategyL?.TempOffsetBInd1;
            result.CoolingStrategyTab.TempOffsetBInd1.E = csstrategyE?.TempOffsetBInd1;
            result.CoolingStrategyTab.TempOffsetBInd1.DbSource = "CsStrategy.TempOffsetBInd1";

            result.CoolingStrategyTab.AdaptationInd1.L = csstrategyL?.AdaptationInd1;
            result.CoolingStrategyTab.AdaptationInd1.E = csstrategyE?.AdaptationInd1;
            result.CoolingStrategyTab.AdaptationInd1.DbSource = "CsStrategy.AdaptationInd1";

            result.CoolingStrategyTab.LeadingPyroIndexInd1.L = csstrategyL?.LeadingPyroIndexInd1;
            result.CoolingStrategyTab.LeadingPyroIndexInd1.E = csstrategyE?.LeadingPyroIndexInd1;
            result.CoolingStrategyTab.LeadingPyroIndexInd1.DbSource = "CsStrategy.LeadingPyroIndexInd1";

            result.CoolingStrategyTab.TargetF4TInd1.L = csstrategyL?.TargetF4tInd1;
            result.CoolingStrategyTab.TargetF4TInd1.E = csstrategyE?.TargetF4tInd1;
            result.CoolingStrategyTab.TargetF4TInd1.DbSource = "CsStrategy.TargetF4tInd1";

            result.CoolingStrategyTab.TargetTempInd1.L = csstrategyL?.TargetTempInd1;
            result.CoolingStrategyTab.TargetTempInd1.E = csstrategyE?.TargetTempInd1;
            result.CoolingStrategyTab.TargetTempInd1.DbSource = "CsStrategy.TargetTempInd1";

            result.CoolingStrategyTab.AutoSplineValueLowTop.L = csstrategyL?.AutoSplineValueLowTop;
            result.CoolingStrategyTab.AutoSplineValueLowTop.E = csstrategyE?.AutoSplineValueLowTop;
            result.CoolingStrategyTab.AutoSplineValueLowTop.DbSource = "CsStrategy.AutoSplineValueLowTop";

            result.CoolingStrategyTab.AutoSplineValueLowBot.L = csstrategyL?.AutoSplineValueLowBot;
            result.CoolingStrategyTab.AutoSplineValueLowBot.E = csstrategyE?.AutoSplineValueLowBot;
            result.CoolingStrategyTab.AutoSplineValueLowBot.DbSource = "CsStrategy.AutoSplineValueLowBot";

            result.CoolingStrategyTab.AutoSplineTempTransition.L = csstrategyL?.AutoSplineTempTransition;
            result.CoolingStrategyTab.AutoSplineTempTransition.E = csstrategyE?.AutoSplineTempTransition;
            result.CoolingStrategyTab.AutoSplineTempTransition.DbSource = "CsStrategy.AutoSplineTempTransition";

            result.CoolingStrategyTab.TempOffsetFma.L = csstrategyL?.TempOffsetFmA;
            result.CoolingStrategyTab.TempOffsetFma.M = csstrategyM?.TempOffsetFmA;
            result.CoolingStrategyTab.TempOffsetFma.E = csstrategyE?.TempOffsetFmA;
            result.CoolingStrategyTab.TempOffsetFma.DbSource = "CsStrategy.TempOffsetFmA";

            result.CoolingStrategyTab.TempOffsetFmb.L = csstrategyL?.TempOffsetFmB;
            result.CoolingStrategyTab.TempOffsetFmb.M = csstrategyM?.TempOffsetFmB;
            result.CoolingStrategyTab.TempOffsetFmb.E = csstrategyE?.TempOffsetFmB;
            result.CoolingStrategyTab.TempOffsetFmb.DbSource = "CsStrategy.TempOffsetFmB";

            result.CoolingStrategyTab.AdaptationFm.L = csstrategyL?.AdaptationFm;
            result.CoolingStrategyTab.AdaptationFm.M = csstrategyM?.AdaptationFm;
            result.CoolingStrategyTab.AdaptationFm.E = csstrategyE?.AdaptationFm;
            result.CoolingStrategyTab.AdaptationFm.DbSource = "CsStrategy.AdaptationFm";

            return result;

        }

        public static SetpointsCsDto MapProfileCooling(this SetpointsCsDto result, SetpointsCsDataBlob dataBlob)
        {
            var csprofileL = dataBlob.CsProfiles.Where(x => x.Source == "L").FirstOrDefault();
            var csprofileM = dataBlob.CsProfiles.Where(x => x.Source == "M").FirstOrDefault();
            var csprofileE = dataBlob.CsProfiles.Where(x => x.Source == "E").FirstOrDefault();

            result.ProfileCoolingTab.PlanNo.L = csprofileL?.PlanNo;
            result.ProfileCoolingTab.PlanNo.M = csprofileM?.PlanNo;
            result.ProfileCoolingTab.PlanNo.E = csprofileE?.PlanNo;
            result.ProfileCoolingTab.PlanNo.DbSource = "CsProfile.PlanNo";

            result.ProfileCoolingTab.LengthUncooledHead.L = csprofileL?.LengthUncooledHead;
            result.ProfileCoolingTab.LengthUncooledHead.M = csprofileM?.LengthUncooledHead;
            result.ProfileCoolingTab.LengthUncooledHead.E = csprofileE?.LengthUncooledHead;
            result.ProfileCoolingTab.LengthUncooledHead.DbSource = "CsProfile.LengthUncooledHead";

            result.ProfileCoolingTab.CoilTempProfileHead.L = csprofileL?.CoilTempProfileHead;
            result.ProfileCoolingTab.CoilTempProfileHead.M = csprofileM?.CoilTempProfileHead;
            result.ProfileCoolingTab.CoilTempProfileHead.E = csprofileE?.CoilTempProfileHead;
            result.ProfileCoolingTab.CoilTempProfileHead.DbSource = "CsProfile.CoilTempProfileHead";

            result.ProfileCoolingTab.LengthProfileHead.L = csprofileL?.LengthProfileHead;
            result.ProfileCoolingTab.LengthProfileHead.M = csprofileM?.LengthProfileHead;
            result.ProfileCoolingTab.LengthProfileHead.E = csprofileE?.LengthProfileHead;
            result.ProfileCoolingTab.LengthProfileHead.DbSource = "CsProfile.LengthProfileHead";

            result.ProfileCoolingTab.LengthProfileHeadWedge.L = csprofileL?.LengthProfileHeadWedge;
            result.ProfileCoolingTab.LengthProfileHeadWedge.M = csprofileM?.LengthProfileHeadWedge;
            result.ProfileCoolingTab.LengthProfileHeadWedge.E = csprofileE?.LengthProfileHeadWedge;
            result.ProfileCoolingTab.LengthProfileHeadWedge.DbSource = "CsProfile.LengthProfileHeadWedge";

            result.ProfileCoolingTab.LengthProfileTailWedge.L = csprofileL?.LengthProfileTailWedge;
            result.ProfileCoolingTab.LengthProfileTailWedge.M = csprofileM?.LengthProfileTailWedge;
            result.ProfileCoolingTab.LengthProfileTailWedge.E = csprofileE?.LengthProfileTailWedge;
            result.ProfileCoolingTab.LengthProfileTailWedge.DbSource = "CsProfile.LengthProfileTailWedge";

            result.ProfileCoolingTab.LengthProfileTail.L = csprofileL?.LengthProfileTail;
            result.ProfileCoolingTab.LengthProfileTail.M = csprofileM?.LengthProfileTail;
            result.ProfileCoolingTab.LengthProfileTail.E = csprofileE?.LengthProfileTail;
            result.ProfileCoolingTab.LengthProfileTail.DbSource = "CsProfile.LengthProfileTail";

            result.ProfileCoolingTab.CoilTempProfileTail.L = csprofileL?.CoilTempProfileTail;
            result.ProfileCoolingTab.CoilTempProfileTail.M = csprofileM?.CoilTempProfileTail;
            result.ProfileCoolingTab.CoilTempProfileTail.E = csprofileE?.CoilTempProfileTail;
            result.ProfileCoolingTab.CoilTempProfileTail.DbSource = "CsProfile.CoilTempProfileTail";

            result.ProfileCoolingTab.LengthUncooledTail.L = csprofileL?.LengthUncooledTail;
            result.ProfileCoolingTab.LengthUncooledTail.M = csprofileM?.LengthUncooledTail;
            result.ProfileCoolingTab.LengthUncooledTail.E = csprofileE?.LengthUncooledTail;
            result.ProfileCoolingTab.LengthUncooledTail.DbSource = "CsProfile.LengthUncooledTail";

            return result;
        }
    }
}
