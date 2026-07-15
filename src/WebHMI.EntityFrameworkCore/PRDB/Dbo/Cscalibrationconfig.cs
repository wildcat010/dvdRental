using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsCalibrationConfig
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public double? AmplStep { get; set; }

    public short? NoValves { get; set; }

    public double? TimeStep { get; set; }

    public short? ValveFirst { get; set; }

    public short? ValveGroup { get; set; }

    public short? ValveLast { get; set; }

    /// <summary>
    /// modifying process
    /// </summary>
    public string Mop { get; set; }

    /// <summary>
    /// time of creation
    /// </summary>
    public DateTime? Toc { get; set; }

    /// <summary>
    /// time of modification
    /// </summary>
    public DateTime? Tom { get; set; }
}
