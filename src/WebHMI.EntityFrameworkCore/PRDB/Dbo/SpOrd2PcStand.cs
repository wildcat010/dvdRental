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
    public double? AgcAmpliFact { get; set; }

    /// <summary>
    /// AGC amplification factor  (wedge target/ next strip)
    /// </summary>
    public double? AgcAmpliFactWt { get; set; }

    /// <summary>
    /// AGC compensation factor
    /// </summary>
    public double? AgcCompFact { get; set; }

    /// <summary>
    /// AGC compensation factor (wedge target/ next strip)
    /// </summary>
    public double? AgcCompFactWt { get; set; }

    /// <summary>
    /// backward slip
    /// </summary>
    public double? Bs { get; set; }

    /// <summary>
    /// backward slip (wedge target/ next strip)
    /// </summary>
    public double? BsWt { get; set; }

    /// <summary>
    /// CVC grind type 0= no ,1=yes
    /// </summary>
    public short? CVcgrindType { get; set; }

    /// <summary>
    /// Unit[m] calibration zero point
    /// </summary>
    public double? CalGs0 { get; set; }

    /// <summary>
    /// Calculated flatness value
    /// </summary>
    public double? CalcFlat { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public double? CgA0 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public double? CgA0bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public double? CgA0roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public double? CgA0stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public double? CgA1 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public double? CgA1bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public double? CgA1roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public double? CgA1stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public double? CgA2 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public double? CgA2bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public double? CgA2roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public double? CgA2stand { get; set; }

    /// <summary>
    /// coefficient stand spring curve over all
    /// </summary>
    public double? CgB0 { get; set; }

    /// <summary>
    /// coefficient stand spring curve bending
    /// </summary>
    public double? CgB0bend { get; set; }

    /// <summary>
    /// coefficient stand spring curve roll
    /// </summary>
    public double? CgB0roll { get; set; }

    /// <summary>
    /// coefficient stand spring curve stand
    /// </summary>
    public double? CgB0stand { get; set; }

    /// <summary>
    /// Unit[N/m] Frame Stretch Modulus Edger
    /// </summary>
    public double? Cge { get; set; }

    /// <summary>
    /// Unit[N/m] Material Modulus Edger
    /// </summary>
    public double? Cme { get; set; }

    /// <summary>
    /// Unit[%] interstand cooling (0-1)
    /// </summary>
    public double? CoIs { get; set; }

    /// <summary>
    /// Unit[%] interstand cooling (0-1) (wedge target/ next strip)
    /// </summary>
    public double? CoIsWt { get; set; }

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
    public double? CoMzcCoolAverage { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd00 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd01 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd02 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd03 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd04 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd05 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd06 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd07 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd08 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd09 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd10 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd11 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd12 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd13 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd14 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd15 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd16 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd17 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd18 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd19 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd20 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd21 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd22 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd23 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd24 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd25 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd26 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd27 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd28 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd29 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd30 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd31 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd32 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd33 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd34 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd35 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd36 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd37 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd38 { get; set; }

    /// <summary>
    /// Reference coolant amount for each cooling zone normalized to 0 (= valve closed) to 1=(valve always opened)
    /// </summary>
    public double? CoMzcCoolDistributionInd39 { get; set; }

    /// <summary>
    /// First index of the nozzle with contact to strip + additional nozzles
    /// </summary>
    public double? CoMzcFirstnozzle { get; set; }

    /// <summary>
    /// Amount of flow for the edge nozzles (no contact to strip and not an additional valve) [0-1]
    /// </summary>
    public double? CoMzcFlowRateEdge { get; set; }

    /// <summary>
    /// Amplitude of the parabolic shape [0-1]
    /// </summary>
    public double? CoMzcParabolic { get; set; }

    /// <summary>
    /// Change in the number of cooling zones: 0 = Only covered cooling zones are cooled, 1 = Both on OS and DS, an additional zone is cooled next to the edge of the strip, -1 = the first covered cooling zone is not cooled. For larger numbers (2, 3, â€¦ or -2, -3, â€¦) the number of additional or removed cooling zones are accordingly
    /// </summary>
    public short? CoMzcValveNumberChange { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd0 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd1 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd2 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd3 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd4 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd5 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd6 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd7 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd8 { get; set; }

    /// <summary>
    /// Unit[%] roll cooling array for all systems
    /// </summary>
    public double? CoRollFlInd9 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd0 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd1 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd2 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd3 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd4 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd5 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd6 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd7 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd8 { get; set; }

    /// <summary>
    /// Unit[%] standby roll cooling array for all systems
    /// </summary>
    public double? CoRollSbFlInd9 { get; set; }

    /// <summary>
    /// Unit[m/s/%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegDvDflow { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd00 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd01 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd02 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd03 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd04 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd05 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd06 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd07 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd08 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd09 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd10 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd11 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd12 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd13 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd14 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd15 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd16 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd17 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd18 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd19 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd20 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd21 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd22 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd23 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd24 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd25 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd26 { get; set; }

    /// <summary>
    /// Unit[%] delta speed to delta flow for segmented work roll cooling
    /// </summary>
    public double? CoSegFlowSbInd27 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd00 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd01 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd02 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd03 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd04 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd05 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd06 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd07 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd08 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd09 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd10 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd11 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd12 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd13 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd14 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd15 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd16 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd17 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd18 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd19 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd20 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd21 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd22 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd23 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd24 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd25 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd26 { get; set; }

    /// <summary>
    /// Unit[%] segmented cooling flow entry and exit bar
    /// </summary>
    public double? CoSegFlowInd27 { get; set; }

    /// <summary>
    /// Unit[%] maximum flow for segmented work roll cooling
    /// </summary>
    public double? CoSegMaxFlow { get; set; }

    /// <summary>
    /// Unit[%] minimum flow for segmented work roll cooling
    /// </summary>
    public double? CoSegMinFlow { get; set; }

    /// <summary>
    /// Unit[%] Switch main cooling bar: exit bar = 0, entry bar = 1
    /// </summary>
    public short? CoSegSwitchCoolBar { get; set; }

    /// <summary>
    /// Unit[s] workroll cooling delay time after tailout
    /// </summary>
    public double? CoWrSbDelay { get; set; }

    /// <summary>
    /// Unit[m/N] 2nd derivation of bending (incl.roll flattening.) rollpackages after technical bending force
    /// </summary>
    public double? D2sbDfb2 { get; set; }

    /// <summary>
    /// Unit[m/N] 2nd derivation of bending (incl.roll flattening.) rollpackages after technical rolling force
    /// </summary>
    public double? D2sbDfr2 { get; set; }

    /// <summary>
    /// Unit[m/N] 2nd derivation of stand strain after roll force
    /// </summary>
    public double? D2sgDf2 { get; set; }

    /// <summary>
    /// Unit[m/N] flatness controller sensitivities: bending with respect to I-Units
    /// </summary>
    public double? DFbdIu { get; set; }

    /// <summary>
    /// Unit[N/m] sensitivities of bending with respect to shifting
    /// </summary>
    public double? DFbdsr { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile on bending force at edge ( for profile monitor HRM )
    /// </summary>
    public double? DPrdFb { get; set; }

    /// <summary>
    /// Unit[_C/_C] delta entry temperature stand i+1 to delta exit temperature
    /// </summary>
    public double? DTenDtx { get; set; }

    /// <summary>
    /// Unit[_C/_C] delta exit temp to delta entry temperature
    /// </summary>
    public double? DTxDte { get; set; }

    /// <summary>
    /// Unit[_C/m] delta exit temperature to delta entry thickness
    /// </summary>
    public double? DTxDhe { get; set; }

    /// <summary>
    /// Unit[_C/m] delta exit temperature to delta exit thickness
    /// </summary>
    public double? DTxDhx { get; set; }

    /// <summary>
    /// Unit[_C/m/s] delta exit temp.to delta circumferential work roll
    /// </summary>
    public double? DTxDv { get; set; }

    /// <summary>
    /// Unit[1/m] gradient of stand module in working point, factor dcg/drf
    /// </summary>
    public double? DcgDf { get; set; }

    /// <summary>
    /// Unit[%/ m/s] delta interstand cooling to delta speed
    /// </summary>
    public double? DcoIsDv { get; set; }

    /// <summary>
    /// Unit[N/N] delta bending force  to delta roll force (efficency)
    /// </summary>
    public double? DfbDfr { get; set; }

    /// <summary>
    /// Unit[N/_C] delta rollforce to delta entry temperature
    /// </summary>
    public double? DfrDte { get; set; }

    /// <summary>
    /// Unit[N/m] delta rollforce to delta entry thickness
    /// </summary>
    public double? DfrDhe { get; set; }

    /// <summary>
    /// Unit[N/m] delta rollforce to delta exit thickness
    /// </summary>
    public double? DfrDhx { get; set; }

    /// <summary>
    /// Unit[N/m] delta roll force to delta shifiting position (efficiency)
    /// </summary>
    public double? DfrDsr { get; set; }

    /// <summary>
    /// Unit[N/m/s] delta roll force to delta circumferential work roll speed
    /// </summary>
    public double? DfrDv { get; set; }

    /// <summary>
    /// Unit[m/N] delta screw down  to delta bending force (efficency)
    /// </summary>
    public double? DsDfb { get; set; }

    /// <summary>
    /// Unit[m/N] derivation of bending (incl.roll flattening.) rollpackages after technical bending force
    /// </summary>
    public double? DsbDfb { get; set; }

    /// <summary>
    /// Unit[m/N] derivation of bending (incl.roll flattening.) rollpackages after technical rolling force
    /// </summary>
    public double? DsbDfr { get; set; }

    /// <summary>
    /// Unit[m/m] derivation of the loaded rolling gap after shift position
    /// </summary>
    public double? DsbDsr { get; set; }

    /// <summary>
    /// sensitivity for screw down wrt shifting position
    /// </summary>
    public double? Dsddsr { get; set; }

    /// <summary>
    /// Unit[m/m] delta screw down to delta work roll shifting
    /// </summary>
    public double? Dsdsr { get; set; }

    /// <summary>
    /// derivation of stand strain after roll force
    /// </summary>
    public double? DsgDf { get; set; }

    /// <summary>
    /// Unit[m/N] effectiveness profile x2-part on bending force dx2P/dFB referring to gap profile
    /// </summary>
    public double? Dx2pDfb { get; set; }

    /// <summary>
    /// status if edger active 0 = inactive / 1 = active / 2 = inlineRCH
    /// </summary>
    public short? EdgerActive { get; set; }

    /// <summary>
    /// Unit[m] slablength entry ()
    /// </summary>
    public double? EntryLength { get; set; }

    /// <summary>
    /// Unit[N] total bending force
    /// </summary>
    public double? Fb { get; set; }

    /// <summary>
    /// Unit[N] total bending force (wedge target/ next strip)
    /// </summary>
    public double? FbWt { get; set; }

    /// <summary>
    /// Unit[%/m] setup value oil flow - WR lubrication (0-1) bottom
    /// </summary>
    public double? FlowOwrlBot { get; set; }

    /// <summary>
    /// Unit[%/m] setup value oil flow - WR lubrication (0-1) top
    /// </summary>
    public double? FlowOwrlTop { get; set; }

    /// <summary>
    /// Unit[N] total roll force
    /// </summary>
    public double? Fr { get; set; }

    /// <summary>
    /// Unit[N] total roll force Edger
    /// </summary>
    public double? FrE { get; set; }

    /// <summary>
    /// Unit[N] total roll force edger (wedge target/ next strip)
    /// </summary>
    public double? FrEwt { get; set; }

    /// <summary>
    /// Unit[N] total roll force (wedge target/ next strip)
    /// </summary>
    public double? FrWt { get; set; }

    /// <summary>
    /// forward slip
    /// </summary>
    public double? Fs { get; set; }

    /// <summary>
    /// forward slip (wedge target/ next strip)
    /// </summary>
    public double? FsWt { get; set; }

    /// <summary>
    /// Unit[N/m2] specific entry tension (specific backward tension)
    /// </summary>
    public double? Ft0 { get; set; }

    /// <summary>
    /// Unit[N/m2] specific entry tension (specific backward tension) (wedge target/ next strip)
    /// </summary>
    public double? Ft0Wt { get; set; }

    /// <summary>
    /// Unit[m] entry thickness  stand (hot)
    /// </summary>
    public double? H0 { get; set; }

    /// <summary>
    /// Unit[m] entry thickness  stand (hot) (wedge target/ next strip)
    /// </summary>
    public double? H0Wt { get; set; }

    /// <summary>
    /// Unit[m] exit  thickness  stand (hot)
    /// </summary>
    public double? H1 { get; set; }

    /// <summary>
    /// exit  thickness  stand (hot)(wedge target/ next strip)
    /// </summary>
    public double? H1Wt { get; set; }

    /// <summary>
    /// Unit[m] length of wedge behind stand
    /// </summary>
    public double? LWedgeX { get; set; }

    /// <summary>
    /// Unit[s] duration of work roll lubrication start ramp
    /// </summary>
    public double? LubRampTimeStart { get; set; }

    /// <summary>
    /// Unit[s] duration of work roll lubrication stop ramp
    /// </summary>
    public double? LubRampTimeStop { get; set; }

    /// <summary>
    /// Unit[m] start length for lubrication ( negative = before stand loaded, positive = after stand loaded)
    /// </summary>
    public double? LubStartLen { get; set; }

    /// <summary>
    /// Start mode of lubrication (bit0=1: stand loaded, bit1=1:following stand loaded, bit2=1:start according to length,bit3=1:continuous)
    /// </summary>
    public short? LubStartMod { get; set; }

    /// <summary>
    /// Unit[m] stop length for lubrication
    /// </summary>
    public double? LubStopLen { get; set; }

    /// <summary>
    /// Unit[N/m] material module (CM) in working point
    /// </summary>
    public double? MatModule { get; set; }

    /// <summary>
    /// Unit[N/m] material module (CM) in working point (wedge target/ next strip)
    /// </summary>
    public double? MatModuleWt { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque
    /// </summary>
    public double? Ms { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque Edger
    /// </summary>
    public double? MsE { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque (wedge target/ next strip)
    /// </summary>
    public double? MsWt { get; set; }

    /// <summary>
    /// shape type for PFC
    /// </summary>
    public short? PfcShapeType { get; set; }

    /// <summary>
    /// Unit[m] work roll shifting position
    /// </summary>
    public double? PositionWrs { get; set; }

    /// <summary>
    /// Unit[m] work roll shifting position (wedge target/ next strip)
    /// </summary>
    public double? PositionWrswt { get; set; }

    /// <summary>
    /// Unit[m] Calculated profile value
    /// </summary>
    public double? Profile { get; set; }

    /// <summary>
    /// proportional change of master speed during rolling of wedge
    /// </summary>
    public double? PropDspeed { get; set; }

    /// <summary>
    /// Unit[W] Rolling power
    /// </summary>
    public double? RPower { get; set; }

    /// <summary>
    /// Unit[W] Rolling power Edger
    /// </summary>
    public double? RPowerE { get; set; }

    /// <summary>
    /// Unit[W] Rolling power  (wedge target/ next strip)
    /// </summary>
    public double? RPowerWt { get; set; }

    /// <summary>
    /// racModulus
    /// </summary>
    public double? RacModulus { get; set; }

    /// <summary>
    /// Reduction
    /// </summary>
    public double? Red { get; set; }

    /// <summary>
    /// relative calculated profile for each stand from PFC
    /// </summary>
    public double? RelProfile { get; set; }

    /// <summary>
    /// 1 = roll kissing  (model calculated)
    /// </summary>
    public int? RollKissing { get; set; }

    /// <summary>
    /// Unit[m] screw down
    /// </summary>
    public double? Sd { get; set; }

    /// <summary>
    /// Unit[m] screw down correction (model used for calculation)
    /// </summary>
    public double? SdCorr { get; set; }

    /// <summary>
    /// Unit[m] screw down Edger
    /// </summary>
    public double? SdE { get; set; }

    /// <summary>
    /// Unit[m] screwn down edger (wedge target/ next strip)
    /// </summary>
    public double? SdEwt { get; set; }

    /// <summary>
    /// status flags for screw down system (bit0:stand active, bit1:AGC absolute)
    /// </summary>
    public short? SdFlag { get; set; }

    /// <summary>
    /// Unit[m] screwn down (wedge target/ next strip)
    /// </summary>
    public double? SdWt { get; set; }

    /// <summary>
    /// spray flag bit=1 is on (bit0:cross spray behind on, bit1:fume suppression spray on , bit2:roll gap spray on, bit3:looper cooling on , bit4: roll gap lubrication top on, bit5: roll gap lubrication bottom on, bit6: interstand descaling on, bit7: work roll cooling entry on, bit8: interstand cooling on, bit12: cross spray before on)
    /// </summary>
    public short? SprayFlag { get; set; }

    /// <summary>
    /// status if stand active 0 = inactive / 1 = active / 2 = inlineRCH
    /// </summary>
    public short? StandActive { get; set; }

    /// <summary>
    /// Unit[N/m] stand module (CG) in working point
    /// </summary>
    public double? StandModule { get; set; }

    /// <summary>
    /// Unit[N/m] stand module (CG) in working point  (wedge target/ next strip)
    /// </summary>
    public double? StandModuleWt { get; set; }

    /// <summary>
    /// Unit[m] strip stock behind stand
    /// </summary>
    public double? StripStock { get; set; }

    /// <summary>
    /// Unit[m] strip stock behind stand  (wedge target/ next strip)
    /// </summary>
    public double? StripStockWt { get; set; }

    /// <summary>
    /// Unit[_C] entry temperature for each stand
    /// </summary>
    public double? T0 { get; set; }

    /// <summary>
    /// Unit[_C] exit average temperature
    /// </summary>
    public double? T1 { get; set; }

    /// <summary>
    /// Unit[m] sum thermal crown (2xWKR+BUR) used in gap calculation
    /// </summary>
    public double? TCrown { get; set; }

    /// <summary>
    /// Unit[__C] Temperature of the roll
    /// </summary>
    public double? TRoll { get; set; }

    /// <summary>
    /// flag that indicates which tension type has to be used with this strip in the basic automation 0=looper tension control, 1=minimum tension control
    /// </summary>
    public short? TenSelect { get; set; }

    /// <summary>
    /// Unit[m/s] workroll circumference speed
    /// </summary>
    public double? VCircum { get; set; }

    /// <summary>
    /// Unit[m/s] workroll circumference speed Edger
    /// </summary>
    public double? VCircumE { get; set; }

    /// <summary>
    /// Unit[m/s] workroll circumference speed (wedge target/ next strip)
    /// </summary>
    public double? VCircumWt { get; set; }

    /// <summary>
    /// Unit[m] sum wear crown (2xWKR+BUR) used in gap calculation
    /// </summary>
    public double? WCrown { get; set; }

    /// <summary>
    /// Unit[m] entry width
    /// </summary>
    public double? WEntry { get; set; }

    /// <summary>
    /// Unit[m] entry width Edger
    /// </summary>
    public double? WEntryE { get; set; }

    /// <summary>
    /// Unit[m] exit width
    /// </summary>
    public double? WExit { get; set; }

    /// <summary>
    /// Unit[m] exit width Edger
    /// </summary>
    public double? WExitE { get; set; }

    /// <summary>
    /// Unit[m] effective work roll crown over barrel length
    /// </summary>
    public double? WrCrownEff { get; set; }

    /// <summary>
    /// Unit[m] minimal distance between the work rolls  (model calculated)
    /// </summary>
    public double? WrWrMinDistance { get; set; }

    /// <summary>
    /// Unit[N/m2] yield stress of the strip
    /// </summary>
    public double? YieldStress { get; set; }

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
