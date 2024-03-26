using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Iscppass
{
    public string MeCreator { get; set; }

    public int MeId { get; set; }

    public short MesId { get; set; }

    public int PassNo { get; set; }

    public string Source { get; set; }

    public int? DescalerAuto { get; set; }

    public int? DescalerState { get; set; }

    public double? DescalerVolume { get; set; }

    public double? FumeSuppSprayBefor { get; set; }

    public double? FumeSuppSprayBehind { get; set; }

    public double? IntermBeamCool { get; set; }

    public int? IscAuto { get; set; }

    public double? IscMaxVolumeInd0 { get; set; }

    public double? IscMaxVolumeInd1 { get; set; }

    public double? IscMaxVolumeInd2 { get; set; }

    public double? IscMinVolumeInd0 { get; set; }

    public double? IscMinVolumeInd1 { get; set; }

    public double? IscMinVolumeInd2 { get; set; }

    public int? IscState { get; set; }

    public double? IscVolumeInd0 { get; set; }

    public double? IscVolumeInd1 { get; set; }

    public double? IscVolumeInd2 { get; set; }

    public double? LooperCool { get; set; }

    public int? PlanNo { get; set; }

    public int? PrioDescaler { get; set; }

    public int? PrioIsc { get; set; }

    public double? RollGapSpray { get; set; }

    public double? StripSprayBefor { get; set; }

    public double? StripSprayBehind { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
