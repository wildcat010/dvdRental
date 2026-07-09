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
        public static ProcessProtocolDto Map(this ProcessProtocolDto dto, Csprotdatum csprotdatum, List<Csprottick> csProtTickData, List<CsSimilarStripsDto> csSimilarStripsDto)
        {
            dto.ChemicalComposition.Map(csprotdatum);
            dto.ChartsXValues = csProtTickData.Select(x => x.Ril).ToList();
            dto.FmTemperatureYValues = csProtTickData.Select(x => x.Tempfm).ToList();
            dto.CoilerTemperatureYValues = csProtTickData.Select(x => x.Tempcs).ToList();
            dto.ExitSpeedYValues = csProtTickData.Select(x => x.Speed).ToList();
            dto.WaterAmountYValues = csProtTickData.Select(x => x.Totalcalcwaterflow).ToList();
            dto.SegValues = csProtTickData.Select(x => x.Seg).ToList();
            dto.CsTickDataCollection = csProtTickData.Select(x => x.Map()).ToList();
            dto.SimilarStrips = csSimilarStripsDto;
            return dto
                .Map(csprotdatum);
        }

        public static ProcessProtocolDto Map(this ProcessProtocolDto dto, Csprotdatum csprotdatum)
        {
            dto.CoilId = csprotdatum.Productid;
            dto.Grade = csprotdatum.Alloycode;
            dto.Produced = csprotdatum.Toc;
            dto.Strategy = csprotdatum.Coolingstrategy;
            dto.CRT = csprotdatum.Coolratetop;
            dto.CRB = csprotdatum.Coolratebot;
            dto.Thick = csprotdatum.Thicknesssp;
            dto.Width = csprotdatum.Widthsp;
            dto.FMT = csprotdatum.Finishingtempsp;
            dto.CT = csprotdatum.Coilertempsp;
            dto.FT = csprotdatum.F4tsp;
            dto.Length = csprotdatum.Striplength;
            dto.OpMode = csprotdatum.Opmode;
            dto.SimilarFM = csprotdatum.Amountsimilartstripsfm;
            dto.SimilarCS = csprotdatum.Amountsimilartstripscs;
            dto.VerySimilarCS = csprotdatum.Amountverysimilartstripscs;
            dto.AirLimit = csprotdatum.Aircoolinglimitation;
            dto.Status = csprotdatum.Flag;
            dto.StatusB = csprotdatum.Status;
            dto.TO0A = csprotdatum.DctempoffsetaInd0;
            dto.TO0B = csprotdatum.DctempoffsetbInd0;
            dto.TO1A = csprotdatum.DctempoffsetaInd1;
            dto.TO1B = csprotdatum.DctempoffsetbInd1;
            dto.TO2A = csprotdatum.DctempoffsetaInd2;
            dto.TO2B = csprotdatum.DctempoffsetbInd2;
            dto.TO3A = csprotdatum.DctempoffsetaInd3;
            dto.TO3B = csprotdatum.DctempoffsetbInd3;
            dto.PrecalculatedValvePatternTop = TranslateFromValveAsciPatternToPrecalculatedValvePatterns(csprotdatum.Vprecalctop, csprotdatum.Vdefecttop);
            dto.PrecalculatedValvePatternBot = TranslateFromValveAsciPatternToPrecalculatedValvePatterns(csprotdatum.Vprecalcbot, csprotdatum.Vdefectbot);
            return dto;
        }

        public static CsTickDataDto Map(this Csprottick csprottick)
        {
            var dto = new CsTickDataDto();
            dto.Seg = csprottick.Seg;
            dto.Ril = csprottick.Ril;
            dto.Secdiff = csprottick.Tdiff;
            dto.Speed = csprottick.Speed;
            dto.Acc = csprottick.Slope;
            dto.Speed5D = csprottick.Speed5diagdiff;
            dto.TempFM = csprottick.Tempfm;
            dto.ErrFM = csprottick.Temperaturedeviation;
            dto.TempCS = csprottick.Tempcs;
            dto.ErrCS = csprottick.Tempcsdiff;
            dto.TotalFlow = csprottick.Totalcalcwaterflow;
            dto.TOFM0 = csprottick.DctempoffsetInd0;
            dto.TOFM2 = csprottick.DctempoffsetInd1;
            dto.TOFM1 = csprottick.DctempoffsetInd2;
            dto.TOFM3 = csprottick.DctempoffsetInd3;
            dto.UsedValvePatternsTop = TranslateFromValveAsciPatternToUsedValvePattern(csprottick.Valvestatetop, csprottick.Valvesetptop);
            dto.UsedValvePatternsBot = TranslateFromValveAsciPatternToUsedValvePattern(csprottick.Valvestatebot, csprottick.Valvestatebot);
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
        public static ChemistryElements Map(this ChemistryElements elements, List<Edlogent> edlogent, StatEdlogent statEdlogent)
        {
            elements.Ag.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd00;
            elements.Ag.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd00;
            elements.Ag.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd00;
            elements.Ag.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd00;
            elements.Ag.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd00;
            elements.Ag.Status = statEdlogent?.AlloyvalueInd00;

            elements.Al.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd01;
            elements.Al.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd01;
            elements.Al.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd01;
            elements.Al.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd01;
            elements.Al.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd01;
            elements.Al.Status = statEdlogent?.AlloyvalueInd01;

            elements.As.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd02;
            elements.As.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd02;
            elements.As.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd02;
            elements.As.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd02;
            elements.As.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd02;
            elements.As.Status = statEdlogent?.AlloyvalueInd02;

            elements.B.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd03;
            elements.B.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd03;
            elements.B.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd03;
            elements.B.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd03;
            elements.B.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd03;
            elements.B.Status = statEdlogent?.AlloyvalueInd03;

            elements.Be.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd04;
            elements.Be.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd04;
            elements.Be.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd04;
            elements.Be.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd04;
            elements.Be.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd04;
            elements.Be.Status = statEdlogent?.AlloyvalueInd04;

            elements.Bi.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd05;
            elements.Bi.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd05;
            elements.Bi.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd05;
            elements.Bi.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd05;
            elements.Bi.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd05;
            elements.Bi.Status = statEdlogent?.AlloyvalueInd05;

            elements.C.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd06;
            elements.C.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd06;
            elements.C.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd06;
            elements.C.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd06;
            elements.C.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd06;
            elements.C.Status = statEdlogent?.AlloyvalueInd06;

            elements.Ca.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd07;
            elements.Ca.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd07;
            elements.Ca.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd07;
            elements.Ca.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd07;
            elements.Ca.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd07;
            elements.Ca.Status = statEdlogent?.AlloyvalueInd07;

            elements.Cd.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd08;
            elements.Cd.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd08;
            elements.Cd.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd08;
            elements.Cd.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd08;
            elements.Cd.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd08;
            elements.Cd.Status = statEdlogent?.AlloyvalueInd08;

            elements.Co.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd09;
            elements.Co.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd09;
            elements.Co.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd09;
            elements.Co.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd09;
            elements.Co.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd09;
            elements.Co.Status = statEdlogent?.AlloyvalueInd09;

            elements.Cr.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd10;
            elements.Cr.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd10;
            elements.Cr.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd10;
            elements.Cr.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd10;
            elements.Cr.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd10;
            elements.Cr.Status = statEdlogent?.AlloyvalueInd10;

            elements.Cu.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd11;
            elements.Cu.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd11;
            elements.Cu.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd11;
            elements.Cu.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd11;
            elements.Cu.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd11;
            elements.Cu.Status = statEdlogent?.AlloyvalueInd11;

            elements.Fe.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd12;
            elements.Fe.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd12;
            elements.Fe.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd12;
            elements.Fe.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd12;
            elements.Fe.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd12;
            elements.Fe.Status = statEdlogent?.AlloyvalueInd12;

            elements.Ga.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd13;
            elements.Ga.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd13;
            elements.Ga.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd13;
            elements.Ga.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd13;
            elements.Ga.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd13;
            elements.Ga.Status = statEdlogent?.AlloyvalueInd13;

            elements.H.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd14;
            elements.H.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd14;
            elements.H.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd14;
            elements.H.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd14;
            elements.H.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd14;
            elements.H.Status = statEdlogent?.AlloyvalueInd14;

            elements.In.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd15;
            elements.In.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd15;
            elements.In.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd15;
            elements.In.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd15;
            elements.In.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd15;
            elements.In.Status = statEdlogent?.AlloyvalueInd15;

            elements.Li.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd16;
            elements.Li.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd16;
            elements.Li.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd16;
            elements.Li.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd16;
            elements.Li.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd16;
            elements.Li.Status = statEdlogent?.AlloyvalueInd16;

            elements.Mg.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd17;
            elements.Mg.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd17;
            elements.Mg.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd17;
            elements.Mg.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd17;
            elements.Mg.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd17;
            elements.Mg.Status = statEdlogent?.AlloyvalueInd17;

            elements.Mn.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd18;
            elements.Mn.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd18;
            elements.Mn.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd18;
            elements.Mn.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd18;
            elements.Mn.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd18;
            elements.Mn.Status = statEdlogent?.AlloyvalueInd18;

            elements.Mo.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd19;
            elements.Mo.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd19;
            elements.Mo.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd19;
            elements.Mo.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd19;
            elements.Mo.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd19;
            elements.Mo.Status = statEdlogent?.AlloyvalueInd19;

            elements.N.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd20;
            elements.N.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd20;
            elements.N.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd20;
            elements.N.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd20;
            elements.N.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd20;
            elements.N.Status = statEdlogent?.AlloyvalueInd20;

            elements.Na.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd21;
            elements.Na.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd21;
            elements.Na.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd21;
            elements.Na.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd21;
            elements.Na.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd21;
            elements.Na.Status = statEdlogent?.AlloyvalueInd21;

            elements.Nb.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd22;
            elements.Nb.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd22;
            elements.Nb.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd22;
            elements.Nb.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd22;
            elements.Nb.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd22;
            elements.Nb.Status = statEdlogent?.AlloyvalueInd22;

            elements.Ni.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd23;
            elements.Ni.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd23;
            elements.Ni.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd23;
            elements.Ni.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd23;
            elements.Ni.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd23;
            elements.Ni.Status = statEdlogent?.AlloyvalueInd23;

            elements.O.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd24;
            elements.O.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd24;
            elements.O.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd24;
            elements.O.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd24;
            elements.O.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd24;
            elements.O.Status = statEdlogent?.AlloyvalueInd24;

            elements.P.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd25;
            elements.P.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd25;
            elements.P.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd25;
            elements.P.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd25;
            elements.P.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd25;
            elements.P.Status = statEdlogent?.AlloyvalueInd25;

            elements.Pb.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd26;
            elements.Pb.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd26;
            elements.Pb.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd26;
            elements.Pb.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd26;
            elements.Pb.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd26;
            elements.Pb.Status = statEdlogent?.AlloyvalueInd26;

            elements.S.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd27;
            elements.S.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd27;
            elements.S.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd27;
            elements.S.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd27;
            elements.S.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd27;
            elements.S.Status = statEdlogent?.AlloyvalueInd27;

            elements.Sb.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd28;
            elements.Sb.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd28;
            elements.Sb.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd28;
            elements.Sb.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd28;
            elements.Sb.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd28;
            elements.Sb.Status = statEdlogent?.AlloyvalueInd28;

            elements.Se.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd29;
            elements.Se.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd29;
            elements.Se.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd29;
            elements.Se.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd29;
            elements.Se.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd29;
            elements.Se.Status = statEdlogent?.AlloyvalueInd29;

            elements.Si.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd30;
            elements.Si.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd30;
            elements.Si.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd30;
            elements.Si.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd30;
            elements.Si.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd30;
            elements.Si.Status = statEdlogent?.AlloyvalueInd30;

            elements.Sn.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd31;
            elements.Sn.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd31;
            elements.Sn.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd31;
            elements.Sn.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd31;
            elements.Sn.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd31;
            elements.Sn.Status = statEdlogent?.AlloyvalueInd31;

            elements.Sr.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd32;
            elements.Sr.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd32;
            elements.Sr.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd32;
            elements.Sr.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd32;
            elements.Sr.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd32;
            elements.Sr.Status = statEdlogent?.AlloyvalueInd32;

            elements.Ta.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd33;
            elements.Ta.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd33;
            elements.Ta.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd33;
            elements.Ta.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd33;
            elements.Ta.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd33;
            elements.Ta.Status = statEdlogent?.AlloyvalueInd33;

            elements.Te.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd34;
            elements.Te.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd34;
            elements.Te.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd34;
            elements.Te.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd34;
            elements.Te.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd34;
            elements.Te.Status = statEdlogent?.AlloyvalueInd34;

            elements.Ti.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd35;
            elements.Ti.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd35;
            elements.Ti.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd35;
            elements.Ti.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd35;
            elements.Ti.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd35;
            elements.Ti.Status = statEdlogent?.AlloyvalueInd35;

            elements.V.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd36;
            elements.V.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd36;
            elements.V.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd36;
            elements.V.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd36;
            elements.V.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd36;
            elements.V.Status = statEdlogent?.AlloyvalueInd36;

            elements.W.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd37;
            elements.W.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd37;
            elements.W.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd37;
            elements.W.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd37;
            elements.W.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd37;
            elements.W.Status = statEdlogent?.AlloyvalueInd37;

            elements.Zn.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd38;
            elements.Zn.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd38;
            elements.Zn.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd38;
            elements.Zn.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd38;
            elements.Zn.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd38;
            elements.Zn.Status = statEdlogent?.AlloyvalueInd38;

            elements.Zr.L = edlogent.FirstOrDefault(x => x.Source == "L")?.AlloyvalueInd39;
            elements.Zr.M = edlogent.FirstOrDefault(x => x.Source == "M")?.AlloyvalueInd39;
            elements.Zr.E = edlogent.FirstOrDefault(x => x.Source == "E")?.AlloyvalueInd39;
            elements.Zr.P = edlogent.FirstOrDefault(x => x.Source == "P")?.AlloyvalueInd39;
            elements.Zr.S = edlogent.FirstOrDefault(x => x.Source == "S")?.AlloyvalueInd39;
            elements.Zr.Status = statEdlogent?.AlloyvalueInd39;

            return elements;
        }

        public static ChemistryElements Map(this ChemistryElements elements, Csprotdatum csprotdatum)
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

        public static void Map(this Edlogent edlogent, ChemistryElements elements)
        {
            edlogent.AlloyvalueInd00 = elements?.Ag.M;
            edlogent.AlloyvalueInd01 = elements?.Al.M;
            edlogent.AlloyvalueInd02 = elements?.As.M;
            edlogent.AlloyvalueInd03 = elements?.B.M;
            edlogent.AlloyvalueInd04 = elements?.Be.M;
            edlogent.AlloyvalueInd05 = elements?.Bi.M;
            edlogent.AlloyvalueInd06 = elements?.C.M;
            edlogent.AlloyvalueInd07 = elements?.Ca.M;
            edlogent.AlloyvalueInd08 = elements?.Cd.M;
            edlogent.AlloyvalueInd09 = elements?.Co.M;
            edlogent.AlloyvalueInd10 = elements?.Cr.M;
            edlogent.AlloyvalueInd11 = elements?.Cu.M;
            edlogent.AlloyvalueInd12 = elements?.Fe.M;
            edlogent.AlloyvalueInd13 = elements?.Ga.M;
            edlogent.AlloyvalueInd14 = elements?.H.M;
            edlogent.AlloyvalueInd15 = elements?.In.M;
            edlogent.AlloyvalueInd16 = elements?.Li.M;
            edlogent.AlloyvalueInd17 = elements?.Mg.M;
            edlogent.AlloyvalueInd18 = elements?.Mn.M;
            edlogent.AlloyvalueInd19 = elements?.Mo.M;
            edlogent.AlloyvalueInd20 = elements?.N.M;
            edlogent.AlloyvalueInd21 = elements?.Na.M;
            edlogent.AlloyvalueInd22 = elements?.Nb.M;
            edlogent.AlloyvalueInd23 = elements?.Ni.M;
            edlogent.AlloyvalueInd24 = elements?.O.M;
            edlogent.AlloyvalueInd25 = elements?.P.M;
            edlogent.AlloyvalueInd26 = elements?.Pb.M;
            edlogent.AlloyvalueInd27 = elements?.S.M;
            edlogent.AlloyvalueInd28 = elements?.Sb.M;
            edlogent.AlloyvalueInd29 = elements?.Se.M;
            edlogent.AlloyvalueInd30 = elements?.Si.M;
            edlogent.AlloyvalueInd31 = elements?.Sn.M;
            edlogent.AlloyvalueInd32 = elements?.Sr.M;
            edlogent.AlloyvalueInd33 = elements?.Ta.M;
            edlogent.AlloyvalueInd34 = elements?.Te.M;
            edlogent.AlloyvalueInd35 = elements?.Ti.M;
            edlogent.AlloyvalueInd36 = elements?.V.M;
            edlogent.AlloyvalueInd37 = elements?.W.M;
            edlogent.AlloyvalueInd38 = elements?.Zn.M;
            edlogent.AlloyvalueInd39 = elements?.Zr.M;
        }
    }
}
