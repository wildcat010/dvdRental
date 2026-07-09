using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRollInventory
{
    public string Rollid { get; set; }

    public string Planttype { get; set; }

    public string Rolltype { get; set; }

    public double Diameter { get; set; }

    public string Stat { get; set; }

    public double? Inittemp { get; set; }

    public int Rollclass { get; set; }

    public string Rollclassdesc { get; set; }

    public short Shapecode { get; set; }

    public int? Shapetype { get; set; }

    public string Standrange { get; set; }

    public DateTime? Plannedinstalltime { get; set; }

    public DateTime? Mounttime { get; set; }

    public DateTime? Dismounttime { get; set; }

    public int Rollpropertyclass { get; set; }

    public string Rollpropertydesc { get; set; }

    public string Rollpos { get; set; }

    public int? Standid { get; set; }

    public double? Rolledlength { get; set; }

    public double? Rolledweight { get; set; }

    public int? Grinding { get; set; }

    public DateTime? Grindingtime { get; set; }

    public string Relatedrollid { get; set; }

    public int? Plannedstandid { get; set; }

    public string Plannedrollpos { get; set; }

    public int? Removereason { get; set; }

    public string Remarks { get; set; }

    public short Rollchamfercode { get; set; }

    public string Rollchamferdesc { get; set; }

    public double? Shimm { get; set; }

    public double? Roughness { get; set; }

    public int? Rolledstrips { get; set; }

    public double? Rolledtime { get; set; }

    public DateTime? Tom { get; set; }
}
