using System;

namespace WebHMI.Dtos.Roll
{
    public class SingleRollDataCoreDto
    {
        public string Rollid { get; set; }
        public string Rolltype { get; set; }
        public string Planttype { get; set; }
        public int? Standid { get; set; }
        public string Stat { get; set; }
        public string Rollpos { get; set; }
        public double Diameter { get; set; }
        public double? Shimm { get; set; }
        public int? Rollclass { get; set; }
        public string RollClassDesc { get; set; }
        public int? RollPropertyClass { get; set; }
        public string RollPropertyClassName { get; set; }
        public DateTime? Mounttime { get; set; }
        public DateTime? Dismounttime { get; set; }
        public int? Grinding { get; set; }
        public double? RolledWeight { get; set; }
        public double? RolledLength { get; set; }
        public string RelatedRollid { get; set; }
        public int? ResonId { get; set; }
        public string Remarks { get; set; }
        public short RollChamferClassId { get; set; }
        public string RollChamferDesc { get; set; }
        public DateTime? PlannedInstallTime { get; set; } = new();
        public short RollShapeCode { get; set; }
        public int? RollShapeType { get; set; }
        public DateTime? GrindingTime { get; set; } = new();
        public int? RolledStrips { get; set; }
        public double? RolledTime { get; set; }
        public DateTime? Tom { get; set; }
    }
}
