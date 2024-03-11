using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRolldatausage
{
    public string RollId { get; set; }

    public int? ActUsedCal { get; set; }

    public int? CheckerPlate { get; set; }

    public float? DiamDiff { get; set; }

    public float Diameter { get; set; }

    public float? DiameterCore { get; set; }

    public DateTime? DismountTime { get; set; }

    public int? Grinding { get; set; }

    public int? GrindingInstall { get; set; }

    public float? InitTemp { get; set; }

    public float? IntTime { get; set; }

    public float? MaxDiameter { get; set; }

    public float? MinDiameter { get; set; }

    public DateTime? MountTime { get; set; }

    public DateTime? PlannedInstallTime { get; set; }

    public string PlannedRollPos { get; set; }

    public int? PlannedStandId { get; set; }

    public string PlantType { get; set; }

    public string RelatedRollId { get; set; }

    public string Remarks { get; set; }

    public int? RemoveReason { get; set; }

    public short RollChamferCode { get; set; }

    public int? RollClass { get; set; }

    public DateTime? RollInTime { get; set; }

    public DateTime? RollOutTime { get; set; }

    public string RollPos { get; set; }

    public int RollPropertyClass { get; set; }

    public short RollShapeCode { get; set; }

    public string RollType { get; set; }

    public int? RollUsage { get; set; }

    public float? RolledLength { get; set; }

    public float? RolledLengthAct { get; set; }

    public int? RolledStrips { get; set; }

    public float? RolledWeight { get; set; }

    public float? RolledWeigthAct { get; set; }

    public float? Roughness { get; set; }

    public float? Shimm { get; set; }

    public int? StandId { get; set; }

    public string StandRange { get; set; }

    public string Stat { get; set; }

    public string StatusInOut { get; set; }

    public string Surface { get; set; }

    public float? WearFacMan { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public string StandName { get; set; }

    public string PlannedStandName { get; set; }

    public string Lang { get; set; }

    public float? Donelength { get; set; }

    public int? Donestrips { get; set; }

    public float? Donetime { get; set; }

    public float? Doneweight { get; set; }
}
