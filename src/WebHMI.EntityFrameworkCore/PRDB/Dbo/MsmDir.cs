using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class MsmDir
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    public string Source { get; set; }

    /// <summary>
    /// Unit[_C] elongation to fracture
    /// </summary>
    public float? A80 { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

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
    /// Unit[0...999] plan number
    /// </summary>
    public int? PlanNo { get; set; }

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

    public virtual Me1 Me1 { get; set; }
}
