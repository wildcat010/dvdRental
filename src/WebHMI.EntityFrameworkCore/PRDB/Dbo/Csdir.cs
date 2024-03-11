using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csdir
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

    /// <summary>
    /// source C=Computed, M= manual, E= effective
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Unit[_C] coil temperature in degC
    /// </summary>
    public float? CoilTemp { get; set; }

    /// <summary>
    /// Unit[_C] profile head temperature in degC (only in some plants)
    /// </summary>
    public float? CoilTempProfileHead { get; set; }

    /// <summary>
    /// Unit[_C] profile tail length in m (only in some plants)
    /// </summary>
    public float? CoilTempProfileTail { get; set; }

    /// <summary>
    /// in cooling sections where strip pass a different number of valves depending on coiler.
    /// </summary>
    public short? CoilerLocationSelection { get; set; }

    /// <summary>
    /// Unit[%] cooling rate bottom: HMI represent 0..100% as float in range 0..1
    /// </summary>
    public float? CoolRateBot { get; set; }

    /// <summary>
    /// Unit[%] Cool rate for dual phase cooling only, last cooling  zone
    /// </summary>
    public float? CoolRateBotDp { get; set; }

    /// <summary>
    /// Unit[%] cooling rate top: HMI represent 0..100% as float in range 0..1
    /// </summary>
    public float? CoolRateTop { get; set; }

    /// <summary>
    /// Unit[%] Cool rate for dual phase cooling only, last cooling  zone
    /// </summary>
    public float? CoolRateTopDp { get; set; }

    /// <summary>
    /// the strategy to be used in HMI enable 1-4 only, CS_FAULTY = -1, CS_NO_STRATS   = 5, CS_EARLY= 1, CS_LATE = 2, CS_TCRIT = 3, CS_DP = 4, [CS_SEGCURVE = 5]
    /// </summary>
    public int? CoolStrategy { get; set; }

    /// <summary>
    /// flag for use of  Compact Cooling
    /// </summary>
    public short? FlagCompactCool { get; set; }

    /// <summary>
    /// degree of phase transition at target temperature
    /// </summary>
    public float? FractionForTransition { get; set; }

    /// <summary>
    /// Unit[_C] hold on temperature in degC: available with CS_DP only
    /// </summary>
    public float? HoldTemp { get; set; }

    /// <summary>
    /// Unit[s] hold on time in s: HMI format as %4.1f, available with CS_DP only
    /// </summary>
    public float? HoldTime { get; set; }

    /// <summary>
    /// Unit[m] profile head length in m (only in some plants)
    /// </summary>
    public float? LengthProfileHead { get; set; }

    /// <summary>
    /// Unit[m] profile tail temperature in degC (only in some plants)
    /// </summary>
    public float? LengthProfileTail { get; set; }

    /// <summary>
    /// Unit[m] uncooled head length in m
    /// </summary>
    public float? LengthUncooledHead { get; set; }

    /// <summary>
    /// Unit[m] uncooled tail length in m
    /// </summary>
    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// strategy plan number
    /// </summary>
    public int? No { get; set; }

    /// <summary>
    /// number of first valve bot, that may be used for cooling
    /// </summary>
    public short? StartValveBot { get; set; }

    /// <summary>
    /// number of first valve top, that may be used for cooling
    /// </summary>
    public short? StartValveTop { get; set; }

    /// <summary>
    /// Unit[_C] temperature behind Compact Cooling
    /// </summary>
    public float? TempBehindCompCool { get; set; }

    /// <summary>
    /// Unit[_C] critical temperature in degC: available with CS_TCRIT only
    /// </summary>
    public float? TempCrit { get; set; }

    /// <summary>
    /// Unit[_C/s] temperature gradient
    /// </summary>
    public float? TempGrad { get; set; }

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
