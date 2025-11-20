using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class SpOrd2PcStand
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
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Stand Idendification
    /// </summary>
    public short StandId { get; set; }

    /// <summary>
    /// thick head flag (in HSM = 0)
    /// </summary>
    public short ThickHead { get; set; }

    /// <summary>
    /// AGC amplification factor
    /// </summary>
    public float? AgcAmpliFact { get; set; }

    /// <summary>
    /// AGC amplification factor  (wedge target/ next strip)
    /// </summary>
    public float? AgcAmpliFactWt { get; set; }

    /// <summary>
    /// AGC compensation factor
    /// </summary>
    public float? AgcCompFact { get; set; }

    /// <summary>
    /// AGC compensation factor (wedge target/ next strip)
    /// </summary>
    public float? AgcCompFactWt { get; set; }

    /// <summary>
    /// bending mode
    /// </summary>
    public float? BenMode { get; set; }

    /// <summary>
    /// backward slip
    /// </summary>
    public float? Bs { get; set; }

    /// <summary>
    /// backward slip (wedge target/ next strip)
    /// </summary>
    public float? BsWt { get; set; }

    /// <summary>
    /// CVC grind type 0= no ,1=yes
    /// </summary>
    public short? CVcgrindType { get; set; }

    /// <summary>
    /// Unit[m] calibration zero point
    /// </summary>
    public float? CalGs0 { get; set; }

    /// <summary>
    /// Calculated flatness value
    /// </summary>
    public float? CalcFlat { get; set; }

    /// <summary>
    /// only for HMI: Calculated flatness value status
    /// </summary>
    public short? CalcFlatStat { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public float? CgA0 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public float? CgA0bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public float? CgA0roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public float? CgA0stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public float? CgA1 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public float? CgA1bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public float? CgA1roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public float? CgA1stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public float? CgA2 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public float? CgA2bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public float? CgA2roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public float? CgA2stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public float? CgB0 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public float? CgB0bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public float? CgB0roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public float? CgB0stand { get; set; }

    /// <summary>
    /// Unit[%] interstand cooling (0-1)
    /// </summary>
    public float? CoIs { get; set; }

    /// <summary>
    /// Unit[%] interstand cooling (0-1) (wedge target/ next strip)
    /// </summary>
    public float? CoIsWt { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd0 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd1 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd2 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd3 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd4 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd5 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd6 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd7 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd8 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public float? CoRollFlInd9 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd0 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd1 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd2 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd3 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd4 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd5 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd6 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd7 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd8 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public float? CoRollSbFlInd9 { get; set; }

    /// <summary>
    /// Unit[m/s/%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegDvDflow { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd0 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd1 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd10 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd11 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd12 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd13 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd14 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd15 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd16 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd17 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd18 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd19 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd2 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd20 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd21 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd22 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd23 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd24 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd25 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd26 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd27 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd3 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd4 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd5 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd6 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd7 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd8 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public float? CoSegFlowSbInd9 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd0 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd1 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd10 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd11 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd12 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd13 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd14 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd15 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd16 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd17 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd18 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd19 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd2 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd20 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd21 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd22 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd23 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd24 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd25 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd26 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd27 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd3 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd4 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd5 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd6 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd7 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd8 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public float? CoSegFlowInd9 { get; set; }

    /// <summary>
    /// Unit[%] maximum flow for segmented work roll cooling
    /// </summary>
    public float? CoSegMaxFlow { get; set; }

    /// <summary>
    /// Unit[%] minimum flow for segmented work roll cooling
    /// </summary>
    public float? CoSegMinFlow { get; set; }

    /// <summary>
    /// Unit[%] Switch main cooling bar: exit bar = 0, entry bar = 1
    /// </summary>
    public short? CoSegSwitchCoolBar { get; set; }

    /// <summary>
    /// Unit[s] workroll cooling delay time after tailout
    /// </summary>
    public float? CoWrSbDelay { get; set; }

    /// <summary>
    /// Unit[m/N] 2nd derivation of bending (incl.roll flattening.) rollpackages after technical bending force
    /// </summary>
    public float? D2sbDfb2 { get; set; }

    /// <summary>
    /// Unit[m/N] 2nd derivation of bending (incl.roll flattening.) rollpackages after technical rolling force
    /// </summary>
    public float? D2sbDfr2 { get; set; }

    /// <summary>
    /// Unit[m/N] 2nd derivation of stand strain after roll force
    /// </summary>
    public float? D2sgDf2 { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile on bending force at edge ( for profile monitor HRM )
    /// </summary>
    public float? DPrdFb { get; set; }

    /// <summary>
    /// Unit[_C/_C] delta entry temperature stand i+1 to delta exit temperature
    /// </summary>
    public float? DTenDtx { get; set; }

    /// <summary>
    /// Unit[_C/_C] delta exit temp to delta entry temperature
    /// </summary>
    public float? DTxDte { get; set; }

    /// <summary>
    /// Unit[_C/m] delta exit temperature to delta entry thickness
    /// </summary>
    public float? DTxDhe { get; set; }

    /// <summary>
    /// Unit[_C/m] delta exit temperature to delta exit thickness
    /// </summary>
    public float? DTxDhx { get; set; }

    /// <summary>
    /// Unit[_C/m/s] delta exit temp.to delta circumferential work roll
    /// </summary>
    public float? DTxDv { get; set; }

    /// <summary>
    /// Unit[1/m] gradient of stand module in working point, factor dcg/drf
    /// </summary>
    public float? DcgDf { get; set; }

    /// <summary>
    /// Unit[%/ m/s] delta interstand cooling to delta speed
    /// </summary>
    public float? DcoIsDv { get; set; }

    /// <summary>
    /// Unit[N/N] delta bending force  to delta roll force (efficency)
    /// </summary>
    public float? DfbDfr { get; set; }

    /// <summary>
    /// Unit[N/s] gradient bending force change to compensate thermal crown dFB/dt - to reach constant gap profile
    /// </summary>
    public float? DfbDt { get; set; }

    /// <summary>
    /// Unit[s] time constant for bending gradient
    /// </summary>
    public float? DfbDtTau { get; set; }

    /// <summary>
    /// Unit[N/_C] delta rollforce to delta entry temperature
    /// </summary>
    public float? DfrDte { get; set; }

    /// <summary>
    /// Unit[N/m] delta rollforce to delta entry thickness
    /// </summary>
    public float? DfrDhe { get; set; }

    /// <summary>
    /// Unit[N/m] delta rollforce to delta exit thickness
    /// </summary>
    public float? DfrDhx { get; set; }

    /// <summary>
    /// Unit[N/m] delta roll force to delta shifiting position (efficiency)
    /// </summary>
    public float? DfrDsr { get; set; }

    /// <summary>
    /// Unit[N/m/s] delta roll force to delta circumferential work roll speed
    /// </summary>
    public float? DfrDv { get; set; }

    /// <summary>
    /// Unit[1/N] effectiveness bending force on strip flatness dlUnit/dFb
    /// </summary>
    public float? DluDfb { get; set; }

    /// <summary>
    /// Unit[m/N] delta screw down  to delta bending force (efficency)
    /// </summary>
    public float? DsDfb { get; set; }

    /// <summary>
    /// Unit[m/s] gradient screw down position change to compensate diameter changes dS/dt - to reach constant exit thickness at middle of strip
    /// </summary>
    public float? DsDt { get; set; }

    /// <summary>
    /// Unit[s] time constant for screw down gradient
    /// </summary>
    public float? DsDtTau { get; set; }

    /// <summary>
    /// Unit[m/N] derivation of bending (incl.roll flattening.) rollpackages after technical bending force
    /// </summary>
    public float? DsbDfb { get; set; }

    /// <summary>
    /// Unit[m/N] derivation of bending (incl.roll flattening.) rollpackages after technical rolling force
    /// </summary>
    public float? DsbDfr { get; set; }

    /// <summary>
    /// Unit[m/m] derivation of the loaded rolling gap after shift position
    /// </summary>
    public float? DsbDsr { get; set; }

    /// <summary>
    /// Unit[m/m] delta screw down to delta work roll shifting
    /// </summary>
    public float? Dsdsr { get; set; }

    /// <summary>
    /// derivation of stand strain after roll force
    /// </summary>
    public float? DsgDf { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile x2-part on bending force dx2P/dFB referring to gap profile
    /// </summary>
    public float? Dx2pDfb { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile x2-part on work roll shifting dx2P/dSR referring to gap profile
    /// </summary>
    public float? Dx2pDsr { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile x4-part on bending force dx4P/dFB referring to gap profile
    /// </summary>
    public float? Dx4pDfb { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile x4-part on work roll shifting dx4P/dSR referring to gap profile
    /// </summary>
    public float? Dx4pDsr { get; set; }

    /// <summary>
    /// Unit[m] slablength entry ()
    /// </summary>
    public float? EntryLength { get; set; }

    /// <summary>
    /// Unit[N] total bending force
    /// </summary>
    public float? Fb { get; set; }

    /// <summary>
    /// only for HMI: total bending force status
    /// </summary>
    public short? FbStat { get; set; }

    /// <summary>
    /// Unit[N] total bending force (wedge target/ next strip)
    /// </summary>
    public float? FbWt { get; set; }

    /// <summary>
    /// Unit[%/m] setup value oil flow - WR lubrication (0-1) bottom
    /// </summary>
    public float? FlowOwrlBot { get; set; }

    /// <summary>
    /// only for HMI: setup value oil flow - WR lubrication (0-1) status bottom
    /// </summary>
    public short? FlowOwrlBotStat { get; set; }

    /// <summary>
    /// Unit[%/m] setup value oil flow - WR lubrication (0-1) top
    /// </summary>
    public float? FlowOwrlTop { get; set; }

    /// <summary>
    /// only for HMI: setup value oil flow - WR lubrication (0-1) status top
    /// </summary>
    public short? FlowOwrlTopStat { get; set; }

    /// <summary>
    /// Unit[N] total roll force
    /// </summary>
    public float? Fr { get; set; }

    /// <summary>
    /// only for HMI: total roll force status
    /// </summary>
    public short? FrStat { get; set; }

    /// <summary>
    /// Unit[N] total roll force (wedge target/ next strip)
    /// </summary>
    public float? FrWt { get; set; }

    /// <summary>
    /// forward slip
    /// </summary>
    public float? Fs { get; set; }

    /// <summary>
    /// forward slip (wedge target/ next strip)
    /// </summary>
    public float? FsWt { get; set; }

    /// <summary>
    /// Unit[N/m2] specific entry tension (specific backward tension)
    /// </summary>
    public float? Ft0 { get; set; }

    /// <summary>
    /// Unit[N/m2] specific entry tension (specific backward tension) (wedge target/ next strip)
    /// </summary>
    public float? Ft0Wt { get; set; }

    /// <summary>
    /// Unit[m] entry thickness  stand (hot)
    /// </summary>
    public float? H0 { get; set; }

    /// <summary>
    /// only for HMI: Entry thickness stand (hot) status
    /// </summary>
    public short? H0Stat { get; set; }

    /// <summary>
    /// Unit[m] entry thickness  stand (hot) (wedge target/ next strip)
    /// </summary>
    public float? H0Wt { get; set; }

    /// <summary>
    /// Unit[m] exit  thickness  stand (hot)
    /// </summary>
    public float? H1 { get; set; }

    /// <summary>
    /// only for HMI: Exit thickness stand (hot) status
    /// </summary>
    public short? H1Stat { get; set; }

    /// <summary>
    /// exit  thickness  stand (hot)(wedge target/ next strip)
    /// </summary>
    public float? H1Wt { get; set; }

    /// <summary>
    /// Unit[m] length of wedge behind stand
    /// </summary>
    public float? LWedgeX { get; set; }

    /// <summary>
    /// Unit[s] duration of work roll lubrication start ramp
    /// </summary>
    public float? LubRampTimeStart { get; set; }

    /// <summary>
    /// Unit[s] duration of work roll lubrication stop ramp
    /// </summary>
    public float? LubRampTimeStop { get; set; }

    /// <summary>
    /// Unit[m] start length for lubrication ( negative = before stand loaded, positive = after stand loaded)
    /// </summary>
    public float? LubStartLen { get; set; }

    /// <summary>
    /// Start mode of lubrication (bit0=1: stand loaded, bit1=1:following stand loaded, bit2=1:start according to length,bit3=1:continuous)
    /// </summary>
    public short? LubStartMod { get; set; }

    /// <summary>
    /// Unit[m] stop length for lubrication
    /// </summary>
    public float? LubStopLen { get; set; }

    /// <summary>
    /// Unit[N/m] material module (CM) in working point
    /// </summary>
    public float? MatModule { get; set; }

    /// <summary>
    /// Unit[N/m] material module (CM) in working point (wedge target/ next strip)
    /// </summary>
    public float? MatModuleWt { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque
    /// </summary>
    public float? Ms { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque (wedge target/ next strip)
    /// </summary>
    public float? MsWt { get; set; }

    /// <summary>
    /// shape type for PFC
    /// </summary>
    public short? PfcShapeType { get; set; }

    /// <summary>
    /// Unit[m] work roll shifting position
    /// </summary>
    public float? PositionWrs { get; set; }

    /// <summary>
    /// only for HMI: work roll shifting position status
    /// </summary>
    public short? PositionWrsstat { get; set; }

    /// <summary>
    /// Unit[m] work roll shifting position (wedge target/ next strip)
    /// </summary>
    public float? PositionWrswt { get; set; }

    /// <summary>
    /// Unit[m] Calculated profile value
    /// </summary>
    public float? Profile { get; set; }

    /// <summary>
    /// only for HMI: Strip profile status
    /// </summary>
    public short? ProfileStat { get; set; }

    /// <summary>
    /// proportional change of master speed during rolling of wedge
    /// </summary>
    public float? PropDspeed { get; set; }

    /// <summary>
    /// Unit[W] Rolling power
    /// </summary>
    public float? RPower { get; set; }

    /// <summary>
    /// only for HMI: Rolling power status
    /// </summary>
    public short? RPowerStat { get; set; }

    /// <summary>
    /// Unit[W] Rolling power  (wedge target/ next strip)
    /// </summary>
    public float? RPowerWt { get; set; }

    /// <summary>
    /// racModulus
    /// </summary>
    public float? RacModulus { get; set; }

    /// <summary>
    /// Reduction
    /// </summary>
    public float? Red { get; set; }

    /// <summary>
    /// only for HMI: Reduction status
    /// </summary>
    public short? RedStat { get; set; }

    /// <summary>
    /// relative calculated profile for each stand from PFC
    /// </summary>
    public float? RelProfile { get; set; }

    /// <summary>
    /// Unit[m] back up roll diameter Top
    /// </summary>
    public float? RollDiaBur { get; set; }

    /// <summary>
    /// Unit[m] back up roll diameter Bottom
    /// </summary>
    public float? RollDiaBurbot { get; set; }

    /// <summary>
    /// Unit[m] work roll diameter Top
    /// </summary>
    public float? RollDiaWr { get; set; }

    /// <summary>
    /// Unit[m] work roll diameter Bottom
    /// </summary>
    public float? RollDiaWrbot { get; set; }

    /// <summary>
    /// 1 = roll kissing  (model calculated)
    /// </summary>
    public int? RollKissing { get; set; }

    /// <summary>
    /// Unit[m] screw down
    /// </summary>
    public float? Sd { get; set; }

    /// <summary>
    /// Unit[m] screw down correction (model used for calculation)
    /// </summary>
    public float? SdCorr { get; set; }

    /// <summary>
    /// status flags for screw down system (bit0:stand active, bit1:AGC absolute, bit2:DPC absolute)
    /// </summary>
    public short? SdFlag { get; set; }

    /// <summary>
    /// only for HMI: Screw down status
    /// </summary>
    public short? SdStat { get; set; }

    /// <summary>
    /// Unit[m] screwn down (wedge target/ next strip)
    /// </summary>
    public float? SdWt { get; set; }

    /// <summary>
    /// spray flag bit=1 is on (bit0:cross spray behind on, bit1:fume suppression spray on , bit2:roll gap spray on, bit3:looper cooling on , bit4: roll gap lubrication top on, bit5: roll gap lubrication bottom on, bit6: interstand descaling on, bit7: work roll cooling entry on, bit8: interstand cooling on, bit12: cross spray before on)
    /// </summary>
    public short? SprayFlag { get; set; }

    /// <summary>
    /// only for HMI: spray flag status
    /// </summary>
    public short? SprayFlagStat { get; set; }

    /// <summary>
    /// Unit[N/m] stand module (CG) in working point
    /// </summary>
    public float? StandModule { get; set; }

    /// <summary>
    /// Unit[N/m] stand module (CG) in working point  (wedge target/ next strip)
    /// </summary>
    public float? StandModuleWt { get; set; }

    /// <summary>
    /// Unit[m] strip stock behind stand
    /// </summary>
    public float? StripStock { get; set; }

    /// <summary>
    /// Unit[m] strip stock behind stand  (wedge target/ next strip)
    /// </summary>
    public float? StripStockWt { get; set; }

    /// <summary>
    /// Unit[_C] entry temperature for each stand
    /// </summary>
    public float? T0 { get; set; }

    /// <summary>
    /// only for HMI: entry temperature for each stand status
    /// </summary>
    public short? T0Stat { get; set; }

    /// <summary>
    /// Unit[_C] exit average temperature
    /// </summary>
    public float? T1 { get; set; }

    /// <summary>
    /// Unit[__C] Temperature of the roll
    /// </summary>
    public double? TRoll { get; set; }

    /// <summary>
    /// flag that indicates which tension type has to be used with this strip in the basic automation 0=looper tension control, 1=minimum tension control
    /// </summary>
    public short? TenSelect { get; set; }

    /// <summary>
    /// Unit[m] Thermal crown calculated value for roll barrel length
    /// </summary>
    public float? ThermCrown { get; set; }

    /// <summary>
    /// Unit[m/s] workroll circumference speed
    /// </summary>
    public float? VCircum { get; set; }

    /// <summary>
    /// only for HMI: Workroll circumference speed status
    /// </summary>
    public short? VCircumStat { get; set; }

    /// <summary>
    /// Unit[m/s] workroll circumference speed (wedge target/ next strip)
    /// </summary>
    public float? VCircumWt { get; set; }

    /// <summary>
    /// Unit[N/m2] warm stiffness of the stand (for looper control); yield stress of the strip
    /// </summary>
    public float? WarmStiff { get; set; }

    /// <summary>
    /// Unit[m] calculated wear
    /// </summary>
    public float? Wear { get; set; }

    /// <summary>
    /// Unit[m] effective work roll crown over barrel length
    /// </summary>
    public float? WrCrownEff { get; set; }

    /// <summary>
    /// Unit[m] minimal distance between the work rolls  (model calculated)
    /// </summary>
    public float? WrWrMinDistance { get; set; }

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

    /// <summary>
    /// Unit[N/m] delta bending force to delta shifiting position (efficiency)
    /// </summary>
    public double? DfbDsr { get; set; }

    public virtual Me1 Me1 { get; set; }
}
