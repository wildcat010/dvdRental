using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRollInventory
{
    public string RollId { get; set; }

    public string PlantType { get; set; }

    public string RollType { get; set; }

    public float Diameter { get; set; }

    public string Stat { get; set; }

    public float? InitTemp { get; set; }

    public int RollClass { get; set; }

    public string Rollclassdesc { get; set; }

    public short Shapecode { get; set; }

    public int? ShapeType { get; set; }

    public string StandRange { get; set; }

    public DateTime? Tom { get; set; }

    public DateTime? PlannedInstallTime { get; set; }

    public DateTime? MountTime { get; set; }

    public DateTime? DismountTime { get; set; }

    public int RollPropertyClass { get; set; }

    public string Rollpropertydesc { get; set; }

    public string RollPos { get; set; }

    public int? StandId { get; set; }

    public float? Rolledlength { get; set; }

    public float? Rolledweight { get; set; }

    public int? Grinding { get; set; }

    public string RelatedRollId { get; set; }

    public int? PlannedStandId { get; set; }

    public string PlannedRollPos { get; set; }

    public int? RemoveReason { get; set; }

    public string Remarks { get; set; }

    public short RollChamferCode { get; set; }

    public float? Shimm { get; set; }

    public float? Roughness { get; set; }
}
