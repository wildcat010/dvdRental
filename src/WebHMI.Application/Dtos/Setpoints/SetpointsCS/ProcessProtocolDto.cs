using System;
using System.Collections.Generic;
using XIDL;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class ProcessProtocolDto
    {
        public string CoilId { get; set; }
        public string Grade { get; set; }
        public DateTime? Produced { get; set; }
        public ChemistryElements ChemicalComposition { get; set; } = new();
        public List<CsTickDataDto> CsTickDataCollection { get; set; } = new();
        public int? Strategy { get; set; } = new();
        public int? CRT { get; set; } = new();
        public int? CRB { get; set; } = new();
        public double? Thick { get; set; } = new();
        public double? Width { get; set; } = new();
        public double? FMT { get; set; } = new();
        public double? CT { get; set; } = new();
        public double? FT { get; set; } = new();
        public double? Length { get; set; } = new();
        public string OpMode { get; set; }
        public int? SimilarFM { get; set; } = new();
        public int? SimilarCS { get; set; } = new();
        public int? VerySimilarCS { get; set; } = new();
        public int? AirLimit { get; set; } = new();
        public int? Status { get; set; } = new();
        public int? StatusB { get; set; } = new();
        public double? TO0A { get; set; } = new();
        public double? TO0B { get; set; } = new();
        public double? TO1A { get; set; } = new();
        public double? TO1B { get; set; } = new();
        public double? TO2A { get; set; } = new();
        public double? TO2B { get; set; } = new();
        public double? TO3A { get; set; } = new();
        public double? TO3B { get; set; } = new();
        public List<double?> ChartsXValues { get; set; }
        public List<double?> FmTemperatureYValues { get; set; }
        public List<double?> CoilerTemperatureYValues { get; set; }
        public List<double?> ExitSpeedYValues { get; set; }
        public List<double?> WaterAmountYValues { get; set; }
        public List<int> SegValues { get; set; }
        public List<HmiCsValveState> PrecalculatedValvePatternTop { get; set; }
        public List<HmiCsValveState> PrecalculatedValvePatternBot { get; set; }
        public List<CsSimilarStripsDto> SimilarStrips { get; set; }

    }
}
