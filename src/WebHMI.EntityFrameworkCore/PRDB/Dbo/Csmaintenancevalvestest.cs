using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsMaintenanceValvesTest
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public int? ManualAmplitudeBot { get; set; }

    public int? ManualAmplitudeTop { get; set; }

    public double? UdsmaxAmplitude { get; set; }

    public short? UdsnoValves { get; set; }

    public double? UdsstepSize { get; set; }

    public double? UdsstepTime { get; set; }

    public short? UdsvalveType { get; set; }

    public short? UdsvalvesNoFrom { get; set; }

    public short? UdsvalvesNoTo { get; set; }

    public double? WormAplitude { get; set; }

    public short? WormNoValves { get; set; }

    public double? WormTime { get; set; }

    public short? WpcPressureDesired { get; set; }

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
