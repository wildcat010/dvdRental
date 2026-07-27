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
    /// Frame Stretch Modulus Edger
    /// </summary>
    public short? Cge { get; set; }

    /// <summary>
    /// Material Modulus Edger
    /// </summary>
    public short? Cme { get; set; }

    /// <summary>
    /// interstand cooling (0-1)
    /// </summary>
    public short? CoIs { get; set; }

    /// <summary>
    /// interstand cooling (0-1) (wedge target/ next strip)
    /// </summary>
    public short? CoIsWt { get; set; }

    /// <summary>
    /// Place of spray nozzle group A in the cascade. Example: A should be used before B, then cascadeNozzleA=1 and cascadeNozzleB=2. If the values are not meaningful, then nozzles A and B are used simultaneously
    /// </summary>
    public short? CoMzcCascadeA { get; set; }

    /// <summary>
    /// Place of spray nozzle group B in the cascade. Example: A should be used before B, then cascadeNozzleA=1 and cascadeNozzleB=2. If the values are not meaningful, then nozzles A and B are used simultaneously
    /// </summary>
    public short? CoMzcCascadeB { get; set; }

    /// <summary>
    /// Reference total coolant amount, i.e., the mean coolant flow of all selected/active cooling zones (=covered by strip+-valveNumberChangeF4). This value is in [0, 1]
    /// </summary>
    public short? CoMzcCoolAverage { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd00 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd01 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd02 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd03 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd04 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd05 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd06 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd07 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd08 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd09 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd10 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd11 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd12 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd13 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd14 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd15 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd16 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd17 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd18 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd19 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd20 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd21 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd22 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd23 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd24 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd25 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd26 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd27 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd28 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd29 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd30 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd31 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd32 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd33 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd34 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd35 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd36 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd37 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd38 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public short? CoMzcCoolDistributionInd39 { get; set; }

    /// <summary>
    /// Change in the number of cooling zones: 0 = Only covered cooling zones are cooled, 1 = Both on OS and DS, an additional zone is cooled next to the edge of the strip, -1 = the first covered cooling zone is not cooled. For larger numbers (2, 3, â€¦ or -2, -3, â€¦) the number of additional or removed cooling zones are accordingly
    /// </summary>
    public short? CoMzcValveNumberChange { get; set; }

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
    public short? CoSegFlowSbInd00 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd01 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd02 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd03 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd04 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd05 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd06 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd07 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd08 { get; set; }

    /// <summary>
    /// delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public short? CoSegFlowSbInd09 { get; set; }

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
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd00 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd01 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd02 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd03 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd04 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd05 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd06 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd07 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd08 { get; set; }

    /// <summary>
    /// segmented cooling flow entry and exit bar
    /// </summary>
    public short? CoSegFlowInd09 { get; set; }

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
    /// flatness controller sensitivities: bending with respect to I-Units
    /// </summary>
    public short? DFbdIu { get; set; }

    /// <summary>
    /// sensitivities of bending with respect to shifting
    /// </summary>
    public short? DFbdsr { get; set; }

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
    /// delta screw down  to delta bending force (efficency)
    /// </summary>
    public short? DsDfb { get; set; }

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
    /// sensitivity for screw down wrt shifting position
    /// </summary>
    public short? Dsddsr { get; set; }

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
    /// slablength entry ()
    /// </summary>
    public short? EntryLength { get; set; }

    /// <summary>
    /// total bending force
    /// </summary>
    public short? Fb { get; set; }

    /// <summary>
    /// total bending force (wedge target/ next strip)
    /// </summary>
    public short? FbWt { get; set; }

    /// <summary>
    /// setup value oil flow - WR lubrication (0-1) bottom
    /// </summary>
    public short? FlowOwrlBot { get; set; }

    /// <summary>
    /// setup value oil flow - WR lubrication (0-1) top
    /// </summary>
    public short? FlowOwrlTop { get; set; }

    /// <summary>
    /// total roll force
    /// </summary>
    public short? Fr { get; set; }

    /// <summary>
    /// total roll force Edger
    /// </summary>
    public short? FrE { get; set; }

    /// <summary>
    /// total roll force edger (wedge target/ next strip)
    /// </summary>
    public short? FrEwt { get; set; }

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
    /// entry thickness  stand (hot) (wedge target/ next strip)
    /// </summary>
    public short? H0Wt { get; set; }

    /// <summary>
    /// exit  thickness  stand (hot)
    /// </summary>
    public short? H1 { get; set; }

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
    /// work roll shifting position (wedge target/ next strip)
    /// </summary>
    public short? PositionWrswt { get; set; }

    /// <summary>
    /// Calculated profile value
    /// </summary>
    public short? Profile { get; set; }

    /// <summary>
    /// proportional change of master speed during rolling of wedge
    /// </summary>
    public short? PropDspeed { get; set; }

    /// <summary>
    /// Rolling power
    /// </summary>
    public short? RPower { get; set; }

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
    /// relative calculated profile for each stand from PFC
    /// </summary>
    public short? RelProfile { get; set; }

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
    /// screw down Edger
    /// </summary>
    public short? SdE { get; set; }

    /// <summary>
    /// screwn down edger (wedge target/ next strip)
    /// </summary>
    public short? SdEwt { get; set; }

    /// <summary>
    /// status flags for screw down system (bit0:stand active, bit1:AGC absolute, bit2:DPC absolute, bit3: edger active)
    /// </summary>
    public short? SdFlag { get; set; }

    /// <summary>
    /// screwn down (wedge target/ next strip)
    /// </summary>
    public short? SdWt { get; set; }

    /// <summary>
    /// spray flag bit=1 is on (bit0:cross spray behind on, bit1:fume suppression spray on , bit2:roll gap spray on, bit3:looper cooling on , bit4: roll gap lubrication top on, bit5: roll gap lubrication bottom on, bit6: interstand descaling on, bit7: work roll cooling entry on, bit8: interstand cooling on, bit12: cross spray before on)
    /// </summary>
    public short? SprayFlag { get; set; }

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
    /// exit average temperature
    /// </summary>
    public short? T1 { get; set; }

    /// <summary>
    /// sum thermal crown (2xWKR+BUR) used in gap calculation
    /// </summary>
    public short? TCrown { get; set; }

    /// <summary>
    /// Temperature of the roll
    /// </summary>
    public short? TRoll { get; set; }

    /// <summary>
    /// flag that indicates which tension type has to be used with this strip in the basic automation 0=looper tension control, 1=minimum tension control
    /// </summary>
    public short? TenSelect { get; set; }

    /// <summary>
    /// workroll circumference speed
    /// </summary>
    public short? VCircum { get; set; }

    /// <summary>
    /// workroll circumference speed (wedge target/ next strip)
    /// </summary>
    public short? VCircumWt { get; set; }

    /// <summary>
    /// sum wear crown (2xWKR+BUR) used in gap calculation
    /// </summary>
    public short? WCrown { get; set; }

    /// <summary>
    /// effective work roll crown over barrel length
    /// </summary>
    public short? WrCrownEff { get; set; }

    /// <summary>
    /// minimal distance between the work rolls  (model calculated)
    /// </summary>
    public short? WrWrMinDistance { get; set; }

    /// <summary>
    /// yield stress of the strip
    /// </summary>
    public short? YieldStress { get; set; }

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
    /// workroll circumference speed Edger
    /// </summary>
    public short? VCircumE { get; set; }

    public short? StandActive { get; set; }

    public short? EdgerActive { get; set; }

    public short? WEntryE { get; set; }

    public short? WExitE { get; set; }

    public short? WEntry { get; set; }

    public short? WExit { get; set; }

    public virtual Me1 Me1 { get; set; }
}
