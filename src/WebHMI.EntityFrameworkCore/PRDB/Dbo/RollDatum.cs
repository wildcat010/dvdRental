using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rolldatum
{
    public string Rollid { get; set; }

    public int? Actusedcal { get; set; }

    public int? Checkerplate { get; set; }

    public double? Diamdiff { get; set; }

    public double Diameter { get; set; }

    public double? Diametercore { get; set; }

    public DateTime? Dismounttime { get; set; }

    public int? Grinding { get; set; }

    public int? Grindinginstall { get; set; }

    public double? Inittemp { get; set; }

    public double? Inttime { get; set; }

    public double? Maxdiameter { get; set; }

    public double? Mindiameter { get; set; }

    public DateTime? Mounttime { get; set; }

    public DateTime? Plannedinstalltime { get; set; }

    public string Plannedrollpos { get; set; }

    public int? Plannedstandid { get; set; }

    public string Planttype { get; set; }

    public string Relatedrollid { get; set; }

    public string Remarks { get; set; }

    public int? Removereason { get; set; }

    public short Rollchamfercode { get; set; }

    public int? Rollclass { get; set; }

    public string Rollpos { get; set; }

    public int Rollpropertyclass { get; set; }

    public short Rollshapecode { get; set; }

    public string Rolltype { get; set; }

    public int? Rollusage { get; set; }

    public double? Rolledlength { get; set; }

    public double? Rolledlengthact { get; set; }

    public int? Rolledstrips { get; set; }

    public double? Rolledweight { get; set; }

    public double? Rolledweigthact { get; set; }

    public double? Roughness { get; set; }

    public double? Shimm { get; set; }

    public int? Standid { get; set; }

    public string Standrange { get; set; }

    public string Stat { get; set; }

    public string Surface { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
