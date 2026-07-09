using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdiscppass
{
    public int Activeflag { get; set; }

    public int Passno { get; set; }

    public int Planno { get; set; }

    public int? Descalerauto { get; set; }

    public int? Descalerstate { get; set; }

    public double? Descalervolume { get; set; }

    public string Description { get; set; }

    public double? Fumesuppspraybefor { get; set; }

    public double? Fumesuppspraybehind { get; set; }

    public double? Intermbeamcool { get; set; }

    public int? Iscauto { get; set; }

    public double? IscmaxvolumeInd0 { get; set; }

    public double? IscmaxvolumeInd1 { get; set; }

    public double? IscmaxvolumeInd2 { get; set; }

    public double? IscmaxvolumeInd3 { get; set; }

    public double? IscminvolumeInd0 { get; set; }

    public double? IscminvolumeInd1 { get; set; }

    public double? IscminvolumeInd2 { get; set; }

    public double? IscminvolumeInd3 { get; set; }

    public int? Iscstate { get; set; }

    public double? IscvolumeInd0 { get; set; }

    public double? IscvolumeInd1 { get; set; }

    public double? IscvolumeInd2 { get; set; }

    public double? IscvolumeInd3 { get; set; }

    public double? Loopercool { get; set; }

    public int? Priodescaler { get; set; }

    public int? Prioisc { get; set; }

    public double? Rollgapspray { get; set; }

    public double? Stripspraybefor { get; set; }

    public double? Stripspraybehind { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
