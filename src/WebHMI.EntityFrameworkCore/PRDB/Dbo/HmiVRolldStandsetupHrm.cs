using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRolldStandsetupHrm
{
    public string Planttype { get; set; }

    public int? Standid { get; set; }

    public string Rolltype { get; set; }

    public string Rollpos { get; set; }

    public string Rollid { get; set; }

    public float Diameter { get; set; }

    public int? Grinding { get; set; }

    public int? Rollclass { get; set; }

    public int? Shapetype { get; set; }

    public float? Shimm { get; set; }

    public float? Rolledlength { get; set; }

    public float? Rolledweight { get; set; }

    public string Stat { get; set; }

    public int Shapecode { get; set; }
}
