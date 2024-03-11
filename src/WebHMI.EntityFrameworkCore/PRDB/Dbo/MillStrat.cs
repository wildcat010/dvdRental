using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// mill specific strategy data set
/// </summary>
public partial class MillStrat
{
    /// <summary>
    /// plant type (HRM, HFM, SPM, TCM, ....)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// record number (always 0)
    /// </summary>
    public int RecordNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// bender setup mode 1:off, 2:on
    /// </summary>
    public int? BendSetupMode { get; set; }

    /// <summary>
    /// dynamic crown setup mode 1:off, 2:on
    /// </summary>
    public int? DCrownSetupMode { get; set; }

    /// <summary>
    /// flatness feedback control mode 1:off, 2:on
    /// </summary>
    public int? FlatFeedbackControlMode { get; set; }

    /// <summary>
    /// roll force compensation mode therma crown compensation mode 1:off, 2:on
    /// </summary>
    public int? FrCompMode { get; set; }

    /// <summary>
    /// head end bending mode 1:off, 2:on
    /// </summary>
    public int? HeadEndBendCompMode { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd0 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd1 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd10 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd11 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd2 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd3 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd4 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd5 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd6 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd7 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd8 { get; set; }

    /// <summary>
    /// Unit[W] maximal power of the inductive heater coils
    /// </summary>
    public double? IHpowerMaxInd9 { get; set; }

    /// <summary>
    /// pair cross setup mode 1:off, 2:on
    /// </summary>
    public int? PcSetupMode { get; set; }

    /// <summary>
    /// Unit[m] Correction value of target profile
    /// </summary>
    public double? ProfileCorr { get; set; }

    /// <summary>
    /// thermal crown compensation mode 1:off, 2:on
    /// </summary>
    public int? TCrownCompMode { get; set; }

    /// <summary>
    /// Unit[m] for future use
    /// </summary>
    public double? WidthCor { get; set; }

    /// <summary>
    /// work roll shift pattern number
    /// </summary>
    public int? WrShiftPatNumber { get; set; }

    /// <summary>
    /// work roll shifting mode 1:off, 2:on
    /// </summary>
    public int? WrShiftSetupMode { get; set; }

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
