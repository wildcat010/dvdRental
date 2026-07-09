using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csmaintenancevalvestest
{
    public int Id { get; set; }

    public int? Manualamplitudebot { get; set; }

    public int? Manualamplitudetop { get; set; }

    public double? Udsmaxamplitude { get; set; }

    public short? Udsnovalves { get; set; }

    public double? Udsstepsize { get; set; }

    public double? Udssteptime { get; set; }

    public short? Udsvalvetype { get; set; }

    public short? Udsvalvesnofrom { get; set; }

    public short? Udsvalvesnoto { get; set; }

    public double? Wormaplitude { get; set; }

    public short? Wormnovalves { get; set; }

    public double? Wormtime { get; set; }

    public short? Wpcpressuredesired { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
