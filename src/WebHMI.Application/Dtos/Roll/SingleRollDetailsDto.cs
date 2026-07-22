using System;
using System.Collections.Generic;
using WebHMI.Interface;

namespace WebHMI.Dtos.Roll
{
    public class SingleRollDetailsDto : IAuditLogRelatedIdGetter
    {
        public string Rollid { get; set; }
        public string Rolltype { get; set; }
        public string Planttype { get; set; }
        public int? Standid { get; set; }
        public string Stat { get; set; }
        public string Rollpos { get; set; }
        public double Diameter { get; set; }
        public double? InitTemp { get; set; }
        public double? Shimm { get; set; }
        public int? Rollclass { get; set; }
        public string RollClassName { get; set; }
        public int RollPropertyClass { get; set; }
        public string RollPropertyClassName { get; set; }
        public DateTime? Mounttime { get; set; }
        public DateTime? Dismounttime { get; set; }
        public double? Roughness { get; set; }
        public short ShapeCode { get; set; }
        public int? ShapeType { get; set; }
        public string ShapeDescription { get; set; }
        public List<double> ShapeCoeffArray { get; set; }
        public double? RolledWeight { get; set; }
        public double? RolledLength { get; set; }
        public int? RolledCoils { get; set; }
        public int? Grinding { get; set; }
        public string RelatedRollid { get; set; }
        public short RollChamferClassId { get; set; }
        public string Remarks { get; internal set; }
        public int? ReasonId { get; internal set; }
        public string PlannedRollPos { get; internal set; }
        public int? PlannedStandId { get; internal set; }
        public string StandRange { get; set; }
        public DateTime? GrindingTime { get; set; } = new();

        public string GetAuditLogRelatedId()
        {
            return $"{Rollid}";
        }
    }
}
