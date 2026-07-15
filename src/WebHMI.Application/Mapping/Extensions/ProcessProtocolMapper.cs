using Abp.Extensions;
using System.Collections.Generic;
using System.Linq;
using WebHMI.Dtos.Setpoints.SetpointsCS;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.Mapping.Extensions
{
    public static class ProcessProtocolMapper
    {
        public static ProcessProtocolDto Map(this ProcessProtocolDto dto, CsProtDatum csprotdatum, List<CsProtTick> csProtTickData, List<CsSimilarStripsDto> csSimilarStripsDto)
        {
            dto.ChemicalComposition.Map(csprotdatum);
            dto.ChartsXValues = csProtTickData.Select(x => x.Ril).ToList();
            dto.FmTemperatureYValues = csProtTickData.Select(x => x.TempFm).ToList();
            dto.CoilerTemperatureYValues = csProtTickData.Select(x => x.TempCs).ToList();
            dto.ExitSpeedYValues = csProtTickData.Select(x => x.Speed).ToList();
            dto.WaterAmountYValues = csProtTickData.Select(x => x.TotalCalcWaterFlow).ToList();
            dto.SegValues = csProtTickData.Select(x => x.Seg).ToList();
            dto.CsTickDataCollection = csProtTickData.Select(x => x.Map()).ToList();
            dto.SimilarStrips = csSimilarStripsDto;
            return dto
                .Map(csprotdatum);
        }

        public static ProcessProtocolDto Map(this ProcessProtocolDto dto, CsProtDatum csprotdatum)
        {
            dto.CoilId = csprotdatum.ProductId;
            dto.Grade = csprotdatum.AlloyCode;
            dto.Produced = csprotdatum.Toc;
            dto.Strategy = csprotdatum.CoolingStrategy;
            dto.CRT = csprotdatum.CoolRateTop;
            dto.CRB = csprotdatum.CoolRateBot;
            dto.Thick = csprotdatum.ThicknessSp;
            dto.Width = csprotdatum.WidthSp;
            dto.FMT = csprotdatum.FinishingTempSp;
            dto.CT = csprotdatum.CoilerTempSp;
            dto.FT = csprotdatum.F4tSp;
            dto.Length = csprotdatum.StripLength;
            dto.OpMode = csprotdatum.OpMode;
            dto.SimilarFM = csprotdatum.AmountSimilartStripsFm;
            dto.SimilarCS = csprotdatum.AmountSimilartStripsCs;
            dto.VerySimilarCS = csprotdatum.AmountVerySimilartStripsCs;
            dto.AirLimit = csprotdatum.AirCoolingLimitation;
            dto.Status = csprotdatum.Flag;
            dto.StatusB = csprotdatum.Status;
            dto.TO0A = csprotdatum.DcTempOffsetAInd0;
            dto.TO0B = csprotdatum.DcTempOffsetBInd0;
            dto.TO1A = csprotdatum.DcTempOffsetAInd1;
            dto.TO1B = csprotdatum.DcTempOffsetBInd1;
            dto.TO2A = csprotdatum.DcTempOffsetAInd2;
            dto.TO2B = csprotdatum.DcTempOffsetBInd2;
            dto.TO3A = csprotdatum.DcTempOffsetAInd3;
            dto.TO3B = csprotdatum.DcTempOffsetBInd3;
            dto.PrecalculatedValvePatternTop = TranslateFromValveAsciPatternToPrecalculatedValvePatterns(csprotdatum.VPrecalcTop, csprotdatum.VDefectTop);
            dto.PrecalculatedValvePatternBot = TranslateFromValveAsciPatternToPrecalculatedValvePatterns(csprotdatum.VPrecalcBot, csprotdatum.VDefectBot);
            return dto;
        }

        public static CsTickDataDto Map(this CsProtTick csprottick)
        {
            var dto = new CsTickDataDto();
            dto.Seg = csprottick.Seg;
            dto.Ril = csprottick.Ril;
            dto.Secdiff = csprottick.Tdiff;
            dto.Speed = csprottick.Speed;
            dto.Acc = csprottick.Slope;
            dto.Speed5D = csprottick.Speed5DiagDiff;
            dto.TempFM = csprottick.TempFm;
            dto.ErrFM = csprottick.TemperatureDeviation;
            dto.TempCS = csprottick.TempCs;
            dto.ErrCS = csprottick.TempCsdiff;
            dto.TotalFlow = csprottick.TotalCalcWaterFlow;
            dto.TOFM0 = csprottick.DcTempOffsetInd0;
            dto.TOFM2 = csprottick.DcTempOffsetInd1;
            dto.TOFM1 = csprottick.DcTempOffsetInd2;
            dto.TOFM3 = csprottick.DcTempOffsetInd3;
            dto.UsedValvePatternsTop = TranslateFromValveAsciPatternToUsedValvePattern(csprottick.ValveStateTop, csprottick.ValveSetpTop);
            dto.UsedValvePatternsBot = TranslateFromValveAsciPatternToUsedValvePattern(csprottick.ValveStateBot, csprottick.ValveStateBot);
            return dto;
        }

        private static List<HmiCsValveState> TranslateFromValveAsciPatternToPrecalculatedValvePatterns(string valveValue, string valveStatus)
        {
            var translated = new List<HmiCsValveState>();
            for (int i = 0; i < valveValue.Length; i++)
            {
                var valve = new HmiCsValveState();
                valve.ActState = TranslateAsciiValveValue(valveValue[i]);
                if (!valveStatus.IsNullOrWhiteSpace())
                    valve.DefState = valveStatus[i] == 'X' || valveStatus[i] == 'x' ? HmiCsValveColors.VD_DOff : HmiCsValveColors.VD_DOn;
                else
                    valve.DefState = HmiCsValveColors.VD_DOn;
                translated.Add(valve);
            }
            return translated;
        }

        private static List<HmiCsValveState> TranslateFromValveAsciPatternToUsedValvePattern(string valveValue, string valveStatus)
        {
            var translated = new List<HmiCsValveState>();
            for (int i = 0; i < valveValue.Length; i++)
            {
                var valve = new HmiCsValveState();
                valve.ActState = TranslateAsciiValveValue(valveValue[i]);
                valve.CtlState = TranslateAsciiValveValue(valveStatus[i]);
                valve.DefState = HmiCsValveColors.VD_DOn;
                translated.Add(valve);
            }
            return translated;
        }

        private static double TranslateAsciiValveValue(char input)
        {
            if (input == 'X')
                return 100;
            else if (input == ' '|| input == '_')
                return 0;
            else
                return char.GetNumericValue(input) * 10;
        }
    }

    public static class ChemistryMapper
    {
        public static ChemistryElements Map(this ChemistryElements elements, List<EdLogEnt> edlogent, StatEdLogEnt statEdlogent)
        {
            elements.Ag.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd00;
            elements.Ag.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd00;
            elements.Ag.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd00;
            elements.Ag.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd00;
            elements.Ag.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd00;
            elements.Ag.Status = statEdlogent?.AlloyValueInd00;

            elements.Al.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd01;
            elements.Al.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd01;
            elements.Al.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd01;
            elements.Al.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd01;
            elements.Al.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd01;
            elements.Al.Status = statEdlogent?.AlloyValueInd01;

            elements.As.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd02;
            elements.As.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd02;
            elements.As.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd02;
            elements.As.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd02;
            elements.As.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd02;
            elements.As.Status = statEdlogent?.AlloyValueInd02;

            elements.B.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd03;
            elements.B.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd03;
            elements.B.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd03;
            elements.B.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd03;
            elements.B.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd03;
            elements.B.Status = statEdlogent?.AlloyValueInd03;

            elements.Be.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd04;
            elements.Be.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd04;
            elements.Be.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd04;
            elements.Be.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd04;
            elements.Be.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd04;
            elements.Be.Status = statEdlogent?.AlloyValueInd04;

            elements.Bi.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd05;
            elements.Bi.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd05;
            elements.Bi.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd05;
            elements.Bi.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd05;
            elements.Bi.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd05;
            elements.Bi.Status = statEdlogent?.AlloyValueInd05;

            elements.C.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd06;
            elements.C.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd06;
            elements.C.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd06;
            elements.C.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd06;
            elements.C.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd06;
            elements.C.Status = statEdlogent?.AlloyValueInd06;

            elements.Ca.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd07;
            elements.Ca.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd07;
            elements.Ca.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd07;
            elements.Ca.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd07;
            elements.Ca.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd07;
            elements.Ca.Status = statEdlogent?.AlloyValueInd07;

            elements.Cd.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd08;
            elements.Cd.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd08;
            elements.Cd.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd08;
            elements.Cd.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd08;
            elements.Cd.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd08;
            elements.Cd.Status = statEdlogent?.AlloyValueInd08;

            elements.Co.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd09;
            elements.Co.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd09;
            elements.Co.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd09;
            elements.Co.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd09;
            elements.Co.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd09;
            elements.Co.Status = statEdlogent?.AlloyValueInd09;

            elements.Cr.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd10;
            elements.Cr.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd10;
            elements.Cr.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd10;
            elements.Cr.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd10;
            elements.Cr.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd10;
            elements.Cr.Status = statEdlogent?.AlloyValueInd10;

            elements.Cu.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd11;
            elements.Cu.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd11;
            elements.Cu.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd11;
            elements.Cu.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd11;
            elements.Cu.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd11;
            elements.Cu.Status = statEdlogent?.AlloyValueInd11;

            elements.Fe.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd12;
            elements.Fe.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd12;
            elements.Fe.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd12;
            elements.Fe.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd12;
            elements.Fe.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd12;
            elements.Fe.Status = statEdlogent?.AlloyValueInd12;

            elements.Ga.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd13;
            elements.Ga.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd13;
            elements.Ga.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd13;
            elements.Ga.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd13;
            elements.Ga.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd13;
            elements.Ga.Status = statEdlogent?.AlloyValueInd13;

            elements.H.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd14;
            elements.H.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd14;
            elements.H.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd14;
            elements.H.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd14;
            elements.H.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd14;
            elements.H.Status = statEdlogent?.AlloyValueInd14;

            elements.In.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd15;
            elements.In.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd15;
            elements.In.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd15;
            elements.In.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd15;
            elements.In.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd15;
            elements.In.Status = statEdlogent?.AlloyValueInd15;

            elements.Li.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd16;
            elements.Li.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd16;
            elements.Li.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd16;
            elements.Li.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd16;
            elements.Li.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd16;
            elements.Li.Status = statEdlogent?.AlloyValueInd16;

            elements.Mg.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd17;
            elements.Mg.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd17;
            elements.Mg.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd17;
            elements.Mg.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd17;
            elements.Mg.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd17;
            elements.Mg.Status = statEdlogent?.AlloyValueInd17;

            elements.Mn.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd18;
            elements.Mn.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd18;
            elements.Mn.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd18;
            elements.Mn.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd18;
            elements.Mn.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd18;
            elements.Mn.Status = statEdlogent?.AlloyValueInd18;

            elements.Mo.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd19;
            elements.Mo.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd19;
            elements.Mo.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd19;
            elements.Mo.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd19;
            elements.Mo.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd19;
            elements.Mo.Status = statEdlogent?.AlloyValueInd19;

            elements.N.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd20;
            elements.N.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd20;
            elements.N.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd20;
            elements.N.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd20;
            elements.N.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd20;
            elements.N.Status = statEdlogent?.AlloyValueInd20;

            elements.Na.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd21;
            elements.Na.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd21;
            elements.Na.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd21;
            elements.Na.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd21;
            elements.Na.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd21;
            elements.Na.Status = statEdlogent?.AlloyValueInd21;

            elements.Nb.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd22;
            elements.Nb.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd22;
            elements.Nb.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd22;
            elements.Nb.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd22;
            elements.Nb.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd22;
            elements.Nb.Status = statEdlogent?.AlloyValueInd22;

            elements.Ni.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd23;
            elements.Ni.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd23;
            elements.Ni.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd23;
            elements.Ni.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd23;
            elements.Ni.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd23;
            elements.Ni.Status = statEdlogent?.AlloyValueInd23;

            elements.O.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd24;
            elements.O.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd24;
            elements.O.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd24;
            elements.O.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd24;
            elements.O.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd24;
            elements.O.Status = statEdlogent?.AlloyValueInd24;

            elements.P.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd25;
            elements.P.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd25;
            elements.P.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd25;
            elements.P.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd25;
            elements.P.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd25;
            elements.P.Status = statEdlogent?.AlloyValueInd25;

            elements.Pb.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd26;
            elements.Pb.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd26;
            elements.Pb.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd26;
            elements.Pb.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd26;
            elements.Pb.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd26;
            elements.Pb.Status = statEdlogent?.AlloyValueInd26;

            elements.S.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd27;
            elements.S.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd27;
            elements.S.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd27;
            elements.S.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd27;
            elements.S.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd27;
            elements.S.Status = statEdlogent?.AlloyValueInd27;

            elements.Sb.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd28;
            elements.Sb.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd28;
            elements.Sb.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd28;
            elements.Sb.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd28;
            elements.Sb.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd28;
            elements.Sb.Status = statEdlogent?.AlloyValueInd28;

            elements.Se.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd29;
            elements.Se.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd29;
            elements.Se.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd29;
            elements.Se.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd29;
            elements.Se.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd29;
            elements.Se.Status = statEdlogent?.AlloyValueInd29;

            elements.Si.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd30;
            elements.Si.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd30;
            elements.Si.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd30;
            elements.Si.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd30;
            elements.Si.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd30;
            elements.Si.Status = statEdlogent?.AlloyValueInd30;

            elements.Sn.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd31;
            elements.Sn.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd31;
            elements.Sn.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd31;
            elements.Sn.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd31;
            elements.Sn.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd31;
            elements.Sn.Status = statEdlogent?.AlloyValueInd31;

            elements.Sr.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd32;
            elements.Sr.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd32;
            elements.Sr.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd32;
            elements.Sr.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd32;
            elements.Sr.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd32;
            elements.Sr.Status = statEdlogent?.AlloyValueInd32;

            elements.Ta.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd33;
            elements.Ta.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd33;
            elements.Ta.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd33;
            elements.Ta.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd33;
            elements.Ta.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd33;
            elements.Ta.Status = statEdlogent?.AlloyValueInd33;

            elements.Te.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd34;
            elements.Te.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd34;
            elements.Te.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd34;
            elements.Te.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd34;
            elements.Te.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd34;
            elements.Te.Status = statEdlogent?.AlloyValueInd34;

            elements.Ti.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd35;
            elements.Ti.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd35;
            elements.Ti.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd35;
            elements.Ti.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd35;
            elements.Ti.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd35;
            elements.Ti.Status = statEdlogent?.AlloyValueInd35;

            elements.V.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd36;
            elements.V.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd36;
            elements.V.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd36;
            elements.V.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd36;
            elements.V.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd36;
            elements.V.Status = statEdlogent?.AlloyValueInd36;

            elements.W.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd37;
            elements.W.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd37;
            elements.W.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd37;
            elements.W.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd37;
            elements.W.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd37;
            elements.W.Status = statEdlogent?.AlloyValueInd37;

            elements.Zn.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd38;
            elements.Zn.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd38;
            elements.Zn.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd38;
            elements.Zn.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd38;
            elements.Zn.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd38;
            elements.Zn.Status = statEdlogent?.AlloyValueInd38;

            elements.Zr.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyValueInd39;
            elements.Zr.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyValueInd39;
            elements.Zr.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyValueInd39;
            elements.Zr.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyValueInd39;
            elements.Zr.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyValueInd39;
            elements.Zr.Status = statEdlogent?.AlloyValueInd39;

            return elements;
        }

        public static ChemistryElements Map(this ChemistryElements elements, CsProtDatum csprotdatum)
        {
            elements.C.E = csprotdatum.AnalysisCarbon;
            elements.S.E = csprotdatum.AnalysisSulfur;
            elements.Mo.E = csprotdatum.AnalysisMolybdenum;
            elements.Mn.E = csprotdatum.AnalysisManganium;
            elements.Ni.E = csprotdatum.AnalysisNickel;
            elements.Ti.E = csprotdatum.AnalysisTin;
            elements.Nb.E = csprotdatum.AnalysisNiobium;
            elements.B.E = csprotdatum.AnalysisBoron;
            elements.V.E = csprotdatum.AnalysisVanadium;
            elements.Al.E = csprotdatum.AnalysisAluminium;
            elements.Si.E = csprotdatum.AnalysisSilicon;
            elements.Cu.E = csprotdatum.AnalysisCopper;
            elements.N.E = csprotdatum.AnalysisNitrogen;
            elements.P.E = csprotdatum.AnalysisPhosphorus;
            elements.Cr.E = csprotdatum.AnalysisChromium;

            return elements;
        }

        public static void Map(this EdLogEnt edlogent, ChemistryElements elements)
        {
            edlogent.AlloyValueInd00 = elements?.Ag.M;
            edlogent.AlloyValueInd01 = elements?.Al.M;
            edlogent.AlloyValueInd02 = elements?.As.M;
            edlogent.AlloyValueInd03 = elements?.B.M;
            edlogent.AlloyValueInd04 = elements?.Be.M;
            edlogent.AlloyValueInd05 = elements?.Bi.M;
            edlogent.AlloyValueInd06 = elements?.C.M;
            edlogent.AlloyValueInd07 = elements?.Ca.M;
            edlogent.AlloyValueInd08 = elements?.Cd.M;
            edlogent.AlloyValueInd09 = elements?.Co.M;
            edlogent.AlloyValueInd10 = elements?.Cr.M;
            edlogent.AlloyValueInd11 = elements?.Cu.M;
            edlogent.AlloyValueInd12 = elements?.Fe.M;
            edlogent.AlloyValueInd13 = elements?.Ga.M;
            edlogent.AlloyValueInd14 = elements?.H.M;
            edlogent.AlloyValueInd15 = elements?.In.M;
            edlogent.AlloyValueInd16 = elements?.Li.M;
            edlogent.AlloyValueInd17 = elements?.Mg.M;
            edlogent.AlloyValueInd18 = elements?.Mn.M;
            edlogent.AlloyValueInd19 = elements?.Mo.M;
            edlogent.AlloyValueInd20 = elements?.N.M;
            edlogent.AlloyValueInd21 = elements?.Na.M;
            edlogent.AlloyValueInd22 = elements?.Nb.M;
            edlogent.AlloyValueInd23 = elements?.Ni.M;
            edlogent.AlloyValueInd24 = elements?.O.M;
            edlogent.AlloyValueInd25 = elements?.P.M;
            edlogent.AlloyValueInd26 = elements?.Pb.M;
            edlogent.AlloyValueInd27 = elements?.S.M;
            edlogent.AlloyValueInd28 = elements?.Sb.M;
            edlogent.AlloyValueInd29 = elements?.Se.M;
            edlogent.AlloyValueInd30 = elements?.Si.M;
            edlogent.AlloyValueInd31 = elements?.Sn.M;
            edlogent.AlloyValueInd32 = elements?.Sr.M;
            edlogent.AlloyValueInd33 = elements?.Ta.M;
            edlogent.AlloyValueInd34 = elements?.Te.M;
            edlogent.AlloyValueInd35 = elements?.Ti.M;
            edlogent.AlloyValueInd36 = elements?.V.M;
            edlogent.AlloyValueInd37 = elements?.W.M;
            edlogent.AlloyValueInd38 = elements?.Zn.M;
            edlogent.AlloyValueInd39 = elements?.Zr.M;
        }
    }
}
