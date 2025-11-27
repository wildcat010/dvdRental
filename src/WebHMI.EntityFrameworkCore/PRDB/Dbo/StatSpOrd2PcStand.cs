using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpOrd2PcStand
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
    public short? AgcAmpliFact { get; set; }

    /// <summary>
    /// AGC amplification factor  (wedge target/ next strip)
    /// </summary>
    public short? AgcAmpliFactWt { get; set; }

    /// <summary>
    /// AGC compensation factor
    /// </summary>
    public short? AgcCompFact { get; set; }

    /// <summary>
    /// AGC compensation factor (wedge target/ next strip)
    /// </summary>
    public short? AgcCompFactWt { get; set; }

    /// <summary>
    /// bending mode
    /// </summary>
    public short? BenMode { get; set; }

    /// <summary>
    /// backward slip
    /// </summary>
    public short? Bs { get; set; }

    /// <summary>
    /// backward slip (wedge target/ next strip)
    /// </summary>
    public short? BsWt { get; set; }

    /// <summary>
    /// CVC grind type 0= no ,1=yes
    /// </summary>
    public short? CVcgrindType { get; set; }

    /// <summary>
    /// calibration zero point
    /// </summary>
    public short? CalGs0 { get; set; }

    /// <summary>
    /// Calculated flatness value
    /// </summary>
    public short? CalcFlat { get; set; }

    /// <summary>
    /// only for HMI: Calculated flatness value status
    /// </summary>
    public short? CalcFlatStat { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public short? CgA0 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public short? CgA0bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public short? CgA0roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public short? CgA0stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public short? CgA1 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public short? CgA1bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public short? CgA1roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public short? CgA1stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public short? CgA2 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public short? CgA2bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public short? CgA2roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public short? CgA2stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public short? CgB0 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public short? CgB0bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public short? CgB0roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public short? CgB0stand { get; set; }

    /// <summary>
    /// interstand cooling (0-1)
    /// </summary>
    public short? CoIs { get; set; }

    /// <summary>
    /// interstand cooling (0-1) (wedge target/ next strip)
    /// </summary>
    public short? CoIsWt { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd0 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd1 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd2 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd3 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd4 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd5 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd6 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd7 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd8 { get; set; }

    /// <summary>
    /// roll cooling array for all systems
    /// </summary>
    public short? CoRollFlInd9 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd0 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd1 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd2 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd3 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd4 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd5 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd6 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd7 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd8 { get; set; }

    /// <summary>
    /// standby roll cooling array for all systems
    /// </summary>
    public short? CoRollSbFlInd9 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegDvDflow { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd0 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd1 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd10 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd11 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd12 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd13 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd14 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd15 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd16 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd17 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd18 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd19 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd2 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd20 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd21 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd22 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd23 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd24 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd25 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd26 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd27 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd3 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd4 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd5 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd6 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd7 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd8 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd9 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd0 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd1 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd10 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd11 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd12 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd13 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd14 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd15 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd16 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd17 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd18 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd19 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd2 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd20 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd21 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd22 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd23 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd24 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd25 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd26 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd27 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd3 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd4 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd5 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd6 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd7 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd8 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd9 { get; set; }

    /// <summary>
    /// maximum flow for segmented work roll cooling
    /// </summary>
    public short? CoSegMaxFlow { get; set; }

    /// <summary>
    /// minimum flow for segmented work roll cooling
    /// </summary>
    public short? CoSegMinFlow { get; set; }

    /// <summary>
    /// Switch main cooling bar: exit bar = 0, entry bar = 1
    /// </summary>
    public short? CoSegSwitchCoolBar { get; set; }

    /// <summary>
    /// workroll cooling delay time after tailout
    /// </summary>
    public short? CoWrSbDelay { get; set; }

    /// <summary>
    /// 2nd derivation of bending (incl.roll flattening.) rollpackages after technical bending force
    /// </summary>
    public short? D2sbDfb2 { get; set; }

    /// <summary>
    /// 2nd derivation of bending (incl.roll flattening.) rollpackages after technical rolling force
    /// </summary>
    public short? D2sbDfr2 { get; set; }

    /// <summary>
    /// 2nd derivation of stand strain after roll force
    /// </summary>
    public short? D2sgDf2 { get; set; }

    /// <summary>
    /// effectiveness profile on bending force at edge ( for profile monitor HRM )
    /// </summary>
    public short? DPrdFb { get; set; }

    /// <summary>
    /// delta entry temperature stand i+1 to delta exit temperature
    /// </summary>
    public short? DTenDtx { get; set; }

    /// <summary>
    /// delta exit temp to delta entry temperature
    /// </summary>
    public short? DTxDte { get; set; }

    /// <summary>
    /// delta exit temperature to delta entry thickness
    /// </summary>
    public short? DTxDhe { get; set; }

    /// <summary>
    /// delta exit temperature to delta exit thickness
    /// </summary>
    public short? DTxDhx { get; set; }

    /// <summary>
    /// delta exit temp.to delta circumferential work roll
    /// </summary>
    public short? DTxDv { get; set; }

    /// <summary>
    /// gradient of stand module in working point, factor dcg/drf
    /// </summary>
    public short? DcgDf { get; set; }

    /// <summary>
    /// delta interstand cooling to delta speed
    /// </summary>
    public short? DcoIsDv { get; set; }

    /// <summary>
    /// delta bending force  to delta roll force (efficency)
    /// </summary>
    public short? DfbDfr { get; set; }

    /// <summary>
    /// delta bending force to delta shifiting position (efficiency)
    /// </summary>
    public short? DfbDsr { get; set; }

    /// <summary>
    /// gradient bending force change to compensate thermal crown dFB/dt - to reach constant gap profile
    /// </summary>
    public short? DfbDt { get; set; }

    /// <summary>
    /// time constant for bending gradient
    /// </summary>
    public short? DfbDtTau { get; set; }

    /// <summary>
    /// delta rollforce to delta entry temperature
    /// </summary>
    public short? DfrDte { get; set; }

    /// <summary>
    /// delta rollforce to delta entry thickness
    /// </summary>
    public short? DfrDhe { get; set; }

    /// <summary>
    /// delta rollforce to delta exit thickness
    /// </summary>
    public short? DfrDhx { get; set; }

    /// <summary>
    /// delta roll force to delta shifiting position (efficiency)
    /// </summary>
    public short? DfrDsr { get; set; }

    /// <summary>
    /// delta roll force to delta circumferential work roll speed
    /// </summary>
    public short? DfrDv { get; set; }

    /// <summary>
    /// effectiveness bending force on strip flatness dlUnit/dFb
    /// </summary>
    public short? DluDfb { get; set; }

    /// <summary>
    /// delta screw down  to delta bending force (efficency)
    /// </summary>
    public short? DsDfb { get; set; }

    /// <summary>
    /// gradient screw down position change to compensate diameter changes dS/dt - to reach constant exit thickness at middle of strip
    /// </summary>
    public short? DsDt { get; set; }

    /// <summary>
    /// time constant for screw down gradient
    /// </summary>
    public short? DsDtTau { get; set; }

    /// <summary>
    /// derivation of bending (incl.roll flattening.) rollpackages after technical bending force
    /// </summary>
    public short? DsbDfb { get; set; }

    /// <summary>
    /// derivation of bending (incl.roll flattening.) rollpackages after technical rolling force
    /// </summary>
    public short? DsbDfr { get; set; }

    /// <summary>
    /// derivation of the loaded rolling gap after shift position
    /// </summary>
    public short? DsbDsr { get; set; }

    /// <summary>
    /// delta screw down to delta work roll shifting
    /// </summary>
    public short? Dsdsr { get; set; }

    /// <summary>
    /// derivation of stand strain after roll force
    /// </summary>
    public short? DsgDf { get; set; }

    /// <summary>
    /// effectiveness profile x2-part on bending force dx2P/dFB referring to gap profile
    /// </summary>
    public short? Dx2pDfb { get; set; }

    /// <summary>
    /// effectiveness profile x2-part on work roll shifting dx2P/dSR referring to gap profile
    /// </summary>
    public short? Dx2pDsr { get; set; }

    /// <summary>
    /// effectiveness profile x4-part on bending force dx4P/dFB referring to gap profile
    /// </summary>
    public short? Dx4pDfb { get; set; }

    /// <summary>
    /// effectiveness profile x4-part on work roll shifting dx4P/dSR referring to gap profile
    /// </summary>
    public short? Dx4pDsr { get; set; }

    /// <summary>
    /// slablength entry ()
    /// </summary>
    public short? EntryLength { get; set; }

    /// <summary>
    /// total bending force
    /// </summary>
    public short? Fb { get; set; }

    /// <summary>
    /// only for HMI: total bending force status
    /// </summary>
    public short? FbStat { get; set; }

    /// <summary>
    /// total bending force (wedge target/ next strip)
    /// </summary>
    public short? FbWt { get; set; }

    /// <summary>
    /// setup value oil flow - WR lubrication (0-1) bottom
    /// </summary>
    public short? FlowOwrlBot { get; set; }

    /// <summary>
    /// only for HMI: setup value oil flow - WR lubrication (0-1) status bottom
    /// </summary>
    public short? FlowOwrlBotStat { get; set; }

    /// <summary>
    /// setup value oil flow - WR lubrication (0-1) top
    /// </summary>
    public short? FlowOwrlTop { get; set; }

    /// <summary>
    /// only for HMI: setup value oil flow - WR lubrication (0-1) status top
    /// </summary>
    public short? FlowOwrlTopStat { get; set; }

    /// <summary>
    /// total roll force
    /// </summary>
    public short? Fr { get; set; }

    /// <summary>
    /// only for HMI: total roll force status
    /// </summary>
    public short? FrStat { get; set; }

    /// <summary>
    /// total roll force (wedge target/ next strip)
    /// </summary>
    public short? FrWt { get; set; }

    /// <summary>
    /// forward slip
    /// </summary>
    public short? Fs { get; set; }

    /// <summary>
    /// forward slip (wedge target/ next strip)
    /// </summary>
    public short? FsWt { get; set; }

    /// <summary>
    /// specific entry tension (specific backward tension)
    /// </summary>
    public short? Ft0 { get; set; }

    /// <summary>
    /// specific entry tension (specific backward tension) (wedge target/ next strip)
    /// </summary>
    public short? Ft0Wt { get; set; }

    /// <summary>
    /// entry thickness  stand (hot)
    /// </summary>
    public short? H0 { get; set; }

    /// <summary>
    /// only for HMI: Entry thickness stand (hot) status
    /// </summary>
    public short? H0Stat { get; set; }

    /// <summary>
    /// entry thickness  stand (hot) (wedge target/ next strip)
    /// </summary>
    public short? H0Wt { get; set; }

    /// <summary>
    /// exit  thickness  stand (hot)
    /// </summary>
    public short? H1 { get; set; }

    /// <summary>
    /// only for HMI: Exit thickness stand (hot) status
    /// </summary>
    public short? H1Stat { get; set; }

    /// <summary>
    /// exit  thickness  stand (hot)(wedge target/ next strip)
    /// </summary>
    public short? H1Wt { get; set; }

    /// <summary>
    /// length of wedge behind stand
    /// </summary>
    public short? LWedgeX { get; set; }

    /// <summary>
    /// duration of work roll lubrication start ramp
    /// </summary>
    public short? LubRampTimeStart { get; set; }

    /// <summary>
    /// duration of work roll lubrication stop ramp
    /// </summary>
    public short? LubRampTimeStop { get; set; }

    /// <summary>
    /// start length for lubrication ( negative = before stand loaded, positive = after stand loaded)
    /// </summary>
    public short? LubStartLen { get; set; }

    /// <summary>
    /// Start mode of lubrication (bit0=1: stand loaded, bit1=1:following stand loaded, bit2=1:start according to length,bit3=1:continuous)
    /// </summary>
    public short? LubStartMod { get; set; }

    /// <summary>
    /// stop length for lubrication
    /// </summary>
    public short? LubStopLen { get; set; }

    /// <summary>
    /// material module (CM) in working point
    /// </summary>
    public short? MatModule { get; set; }

    /// <summary>
    /// material module (CM) in working point (wedge target/ next strip)
    /// </summary>
    public short? MatModuleWt { get; set; }

    /// <summary>
    /// rolling torque
    /// </summary>
    public short? Ms { get; set; }

    /// <summary>
    /// rolling torque (wedge target/ next strip)
    /// </summary>
    public short? MsWt { get; set; }

    /// <summary>
    /// shape type for PFC
    /// </summary>
    public short? PfcShapeType { get; set; }

    /// <summary>
    /// work roll shifting position
    /// </summary>
    public short? PositionWrs { get; set; }

    /// <summary>
    /// only for HMI: work roll shifting position status
    /// </summary>
    public short? PositionWrsstat { get; set; }

    /// <summary>
    /// work roll shifting position (wedge target/ next strip)
    /// </summary>
    public short? PositionWrswt { get; set; }

    /// <summary>
    /// Calculated profile value
    /// </summary>
    public short? Profile { get; set; }

    /// <summary>
    /// only for HMI: Strip profile status
    /// </summary>
    public short? ProfileStat { get; set; }

    /// <summary>
    /// proportional change of master speed during rolling of wedge
    /// </summary>
    public short? PropDspeed { get; set; }

    /// <summary>
    /// Rolling power
    /// </summary>
    public short? RPower { get; set; }

    /// <summary>
    /// only for HMI: Rolling power status
    /// </summary>
    public short? RPowerStat { get; set; }

    /// <summary>
    /// Rolling power  (wedge target/ next strip)
    /// </summary>
    public short? RPowerWt { get; set; }

    /// <summary>
    /// racModulus
    /// </summary>
    public short? RacModulus { get; set; }

    /// <summary>
    /// Reduction
    /// </summary>
    public short? Red { get; set; }

    /// <summary>
    /// only for HMI: Reduction status
    /// </summary>
    public short? RedStat { get; set; }

    /// <summary>
    /// relative calculated profile for each stand from PFC
    /// </summary>
    public short? RelProfile { get; set; }

    /// <summary>
    /// back up roll diameter Top
    /// </summary>
    public short? RollDiaBur { get; set; }

    /// <summary>
    /// back up roll diameter Bottom
    /// </summary>
    public short? RollDiaBurbot { get; set; }

    /// <summary>
    /// work roll diameter Top
    /// </summary>
    public short? RollDiaWr { get; set; }

    /// <summary>
    /// work roll diameter Bottom
    /// </summary>
    public short? RollDiaWrbot { get; set; }

    /// <summary>
    /// 1 = roll kissing  (model calculated)
    /// </summary>
    public short? RollKissing { get; set; }

    /// <summary>
    /// screw down
    /// </summary>
    public short? Sd { get; set; }

    /// <summary>
    /// screw down correction (model used for calculation)
    /// </summary>
    public short? SdCorr { get; set; }

    /// <summary>
    /// status flags for screw down system (bit0:stand active, bit1:AGC absolute, bit2:DPC absolute)
    /// </summary>
    public short? SdFlag { get; set; }

    /// <summary>
    /// only for HMI: Screw down status
    /// </summary>
    public short? SdStat { get; set; }

    /// <summary>
    /// screwn down (wedge target/ next strip)
    /// </summary>
    public short? SdWt { get; set; }

    /// <summary>
    /// spray flag bit=1 is on (bit0:cross spray behind on, bit1:fume suppression spray on , bit2:roll gap spray on, bit3:looper cooling on , bit4: roll gap lubrication top on, bit5: roll gap lubrication bottom on, bit6: interstand descaling on, bit7: work roll cooling entry on, bit8: interstand cooling on, bit12: cross spray before on)
    /// </summary>
    public short? SprayFlag { get; set; }

    /// <summary>
    /// only for HMI: spray flag status
    /// </summary>
    public short? SprayFlagStat { get; set; }

    /// <summary>
    /// stand module (CG) in working point
    /// </summary>
    public short? StandModule { get; set; }

    /// <summary>
    /// stand module (CG) in working point  (wedge target/ next strip)
    /// </summary>
    public short? StandModuleWt { get; set; }

    /// <summary>
    /// strip stock behind stand
    /// </summary>
    public short? StripStock { get; set; }

    /// <summary>
    /// strip stock behind stand  (wedge target/ next strip)
    /// </summary>
    public short? StripStockWt { get; set; }

    /// <summary>
    /// entry temperature for each stand
    /// </summary>
    public short? T0 { get; set; }

    /// <summary>
    /// only for HMI: entry temperature for each stand status
    /// </summary>
    public short? T0Stat { get; set; }

    /// <summary>
    /// exit average temperature
    /// </summary>
    public short? T1 { get; set; }

    /// <summary>
    /// Temperature of the roll
    /// </summary>
    public short? TRoll { get; set; }

    /// <summary>
    /// flag that indicates which tension type has to be used with this strip in the basic automation 0=looper tension control, 1=minimum tension control
    /// </summary>
    public short? TenSelect { get; set; }

    /// <summary>
    /// Thermal crown calculated value for roll barrel length
    /// </summary>
    public short? ThermCrown { get; set; }

    /// <summary>
    /// workroll circumference speed
    /// </summary>
    public short? VCircum { get; set; }

    /// <summary>
    /// only for HMI: Workroll circumference speed status
    /// </summary>
    public short? VCircumStat { get; set; }

    /// <summary>
    /// workroll circumference speed (wedge target/ next strip)
    /// </summary>
    public short? VCircumWt { get; set; }

    /// <summary>
    /// warm stiffness of the stand (for looper control); yield stress of the strip
    /// </summary>
    public short? WarmStiff { get; set; }

    /// <summary>
    /// calculated wear
    /// </summary>
    public short? Wear { get; set; }

    /// <summary>
    /// effective work roll crown over barrel length
    /// </summary>
    public short? WrCrownEff { get; set; }

    /// <summary>
    /// minimal distance between the work rolls  (model calculated)
    /// </summary>
    public short? WrWrMinDistance { get; set; }

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
