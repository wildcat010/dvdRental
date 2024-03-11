using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRollclass
{
    public int Rollclass { get; set; }

    public string Description { get; set; }

    public string Planttype { get; set; }

    public string Rolltype { get; set; }

    public string Standrange { get; set; }

    public int? Standid { get; set; }
}
