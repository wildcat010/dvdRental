using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Cscalibrationconfig
{
    public int Id { get; set; }

    public double? Amplstep { get; set; }

    public short? Novalves { get; set; }

    public double? Timestep { get; set; }

    public short? Valvefirst { get; set; }

    public short? Valvegroup { get; set; }

    public short? Valvelast { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
