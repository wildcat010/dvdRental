using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdMsmDir
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0..999] plan number for micro structure monitor aps table
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[_C] elongation to fracture
    /// </summary>
    public float? A80 { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 0=Optimierung auf Rm, 1=Optimierung auf Re
    /// </summary>
    public short? MsmMode { get; set; }

    /// <summary>
    /// Aktivierung f_r Optimizer: aus=0, ein=1
    /// </summary>
    public short? MsmSwitch { get; set; }

    /// <summary>
    /// Unit[_C] Obergrenze von FCT f_r Optimierung (Wert ohne Vorzeichen). Optimizer optimiert aus urspr_nglicher finishCoolingTempSp - msmTempTolMin auf finishCoolingTempSp +  msmTempTolMax.
    /// </summary>
    public float? MsmTempTolMax { get; set; }

    /// <summary>
    /// Unit[_C] Untergrenze von FCT f_r Optimierung (Wert ohne Vorzeichen). Optimizer optimiert aus urspr_nglicher finishCoolingTempSp - msmTempTolMin auf finishCoolingTempSp + msmTempTolMax.
    /// </summary>
    public float? MsmTempTolMin { get; set; }

    /// <summary>
    /// Unit[N/m_] Maximal zul_ssige Zugfestigkeit f_r dieses Material, -1 bei Nichtverf_gbarkeit
    /// </summary>
    public float? TgtTensileStrengthMax { get; set; }

    /// <summary>
    /// Unit[N/m_] Minimal zul_ssige Zugfestigkeit f_r dieses Material, -1 bei Nichtverf_gbarkeit
    /// </summary>
    public float? TgtTensileStrengthMin { get; set; }

    /// <summary>
    /// Unit[N/m_] Gew_nschte Zugfestigkeit f_r dieses Material, z. B. 0,5*(tgtTensileStrengthMin+tgtTensileStrengthMax), -1 bei Nichtverf_gbarkeit
    /// </summary>
    public float? TgtTensileStrengthTarget { get; set; }

    /// <summary>
    /// Unit[N/m_] Maximal zul_ssige Streckgrenze f_r dieses Material, -1 bei Nichtverf_gbarkeit
    /// </summary>
    public float? TgtYieldStrengthMax { get; set; }

    /// <summary>
    /// Unit[N/m_] Minimal zul_ssige Streckgrenze f_r dieses Material, -1 bei Nichtverf_gbarkeit
    /// </summary>
    public float? TgtYieldStrengthMin { get; set; }

    /// <summary>
    /// Unit[N/m_] Gew_nschte Streckgrenze f_r dieses Material, z. B. 1,2*tgtYieldStrengthMin oder 0,5*(tgtYieldStrengthMin+tgtYieldStrengthMax), -1 bei Nichtverf_gbarkeit
    /// </summary>
    public float? TgtYieldStrengthTarget { get; set; }

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
