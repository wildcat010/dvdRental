using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PfcReport
{
    /// <summary>
    /// time of post-calculation for last active pass
    /// </summary>
    public int Calctime { get; set; }

    /// <summary>
    /// L2 id
    /// </summary>
    public string ExtId { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd0 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd1 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd2 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd3 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd4 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd5 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd6 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd7 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CxxTcrownInd8 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd0 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd1 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd2 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd3 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd4 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd5 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd6 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd7 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CxxWcrownInd8 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd0 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd1 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd2 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd3 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd4 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd5 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd6 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd7 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by dynamic profile control
    /// </summary>
    public double? AdditionalBendingDpcInd8 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd0 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd1 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd2 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd3 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd4 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd5 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd6 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd7 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force by flatness control
    /// </summary>
    public double? AdditionalBendingFlcInd8 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd0 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd1 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd2 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd3 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd4 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd5 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd6 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd7 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from profile control
    /// </summary>
    public double? AdditionalBendingPrcInd8 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd0 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd1 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd2 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd3 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd4 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd5 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd6 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd7 { get; set; }

    /// <summary>
    /// Unit[kN] additional bending force from thermal crown compensation
    /// </summary>
    public double? AdditionalBendingTccInd8 { get; set; }

    /// <summary>
    /// alloy code supplied to model
    /// </summary>
    public string AlloyCode { get; set; }

    /// <summary>
    /// usage of alternative target allowed, i.e. flatness before profile
    /// </summary>
    public short? AltTgtProfAllowed { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd0 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd1 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd2 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd3 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd4 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd5 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd6 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd7 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from inheritance
    /// </summary>
    public double? BendingForceInhInd8 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd0 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd1 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd2 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd3 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd4 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd5 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd6 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd7 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from post-calculation
    /// </summary>
    public double? BendingForcePostInd8 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd0 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd1 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd2 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd3 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd4 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd5 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd6 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd7 { get; set; }

    /// <summary>
    /// Unit[kN] bending force from pre-calculation
    /// </summary>
    public double? BendingForcePreInd8 { get; set; }

    /// <summary>
    /// Unit[%] carbon content]
    /// </summary>
    public double? C { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd0 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd1 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd2 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd3 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd4 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd5 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd6 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd7 { get; set; }

    /// <summary>
    /// Unit[m] thermal crown roll center (diameter one WR)
    /// </summary>
    public double? CenterTcrownInd8 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd0 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd1 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd2 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd3 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd4 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd5 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd6 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd7 { get; set; }

    /// <summary>
    /// Unit[m] wear crown roll center (diameter one WR)
    /// </summary>
    public double? CenterWcrownInd8 { get; set; }

    /// <summary>
    /// Unit[m] quadratic contour defect
    /// </summary>
    public double? ContourDefectX2 { get; set; }

    /// <summary>
    /// Unit[m] sixth-order contour defect
    /// </summary>
    public double? ContourDefectX6 { get; set; }

    /// <summary>
    /// Unit[%] chromium content
    /// </summary>
    public double? Cr { get; set; }

    /// <summary>
    /// Unit[%] relative profile error
    /// </summary>
    public double? CrError { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd0 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd1 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd2 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd3 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd4 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd5 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd6 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd7 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from inheritance
    /// </summary>
    public double? CrInhInd8 { get; set; }

    /// <summary>
    /// Unit[%] measured relative profile
    /// </summary>
    public double? CrMeas { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd0 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd1 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd2 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd3 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd4 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd5 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd6 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd7 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from post-calculation
    /// </summary>
    public double? CrPostInd8 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd0 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd1 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd2 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd3 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd4 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd5 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd6 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd7 { get; set; }

    /// <summary>
    /// Unit[%] relative crown from pre-calculation
    /// </summary>
    public double? CrPreInd8 { get; set; }

    /// <summary>
    /// Unit[%] copper content
    /// </summary>
    public double? Cu { get; set; }

    /// <summary>
    /// Unit[m] convex contour defect
    /// </summary>
    public double? DefectConvex { get; set; }

    /// <summary>
    /// datafile for offline investigations
    /// </summary>
    public string DmmFileName { get; set; }

    /// <summary>
    /// Unit[m] contour indicator: dog bone drive side
    /// </summary>
    public double? DogBoneDs { get; set; }

    /// <summary>
    /// Unit[m] contour indicator: dog bone operator side
    /// </summary>
    public double? DogBoneOs { get; set; }

    /// <summary>
    /// Unit[m] contour indicator: edge drop drive side
    /// </summary>
    public double? EdgeDropDs { get; set; }

    /// <summary>
    /// Unit[m] contour indicator: edge drop operator side
    /// </summary>
    public double? EdgeDropOs { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd0 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd1 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd2 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd3 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd4 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd5 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd6 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd7 { get; set; }

    /// <summary>
    /// Unit[mm] center line exit thickness
    /// </summary>
    public double? ExitThicknessInd8 { get; set; }

    /// <summary>
    /// Unit[IU] measured flatness
    /// </summary>
    public double? FlMeas { get; set; }

    /// <summary>
    /// Unit[IU] measured flatness error
    /// </summary>
    public double? FlatnessError { get; set; }

    /// <summary>
    /// index of active flatness gauge
    /// </summary>
    public short? GaugeIndexFlatness { get; set; }

    /// <summary>
    /// index of active profile gauge
    /// </summary>
    public short? GaugeIndexProfile { get; set; }

    /// <summary>
    /// Unit[%] high strength low alloy elements content
    /// </summary>
    public double? Hsla { get; set; }

    /// <summary>
    /// id used for inheritance
    /// </summary>
    public string InheritanceId { get; set; }

    /// <summary>
    /// inheritance type (0=LTI)
    /// </summary>
    public short? InheritanceType { get; set; }

    /// <summary>
    /// time stamp of last NN adaptation (online)
    /// </summary>
    public int? LastLongTermAdaptation { get; set; }

    /// <summary>
    /// time stamp of last NN training (offline)
    /// </summary>
    public int? LastLongTermTraining { get; set; }

    /// <summary>
    /// Unit[m] length of finished product
    /// </summary>
    public double? Length { get; set; }

    /// <summary>
    /// error flag of NN evaluation in post-calculation
    /// </summary>
    public short? LongTermErrorFlagPost { get; set; }

    /// <summary>
    /// error flag of NN evaluation in pre-calculation
    /// </summary>
    public short? LongTermErrorFlagPre { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd0 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd1 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd2 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd3 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd4 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd5 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd6 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd7 { get; set; }

    /// <summary>
    /// Unit[kN] lower limit for the bending force set-up
    /// </summary>
    public double? LowerLimitBendingInd8 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd0 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd1 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd2 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd3 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd4 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd5 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd6 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd7 { get; set; }

    /// <summary>
    /// Unit[rad] lower limit for the pair-cross angle set-up
    /// </summary>
    public double? LowerLimitPairCrossInd8 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd0 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd1 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd2 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd3 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd4 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd5 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd6 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd7 { get; set; }

    /// <summary>
    /// Unit[m] lower limit for the shift position set-up
    /// </summary>
    public double? LowerLimitShiftInd8 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd0 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd1 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd2 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd3 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd4 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd5 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd6 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd7 { get; set; }

    /// <summary>
    /// Unit[kN] operator intervention on bending force (pulpit bottons)
    /// </summary>
    public double? ManualInterventionBendingInd8 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd0 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd1 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd2 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd3 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd4 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd5 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd6 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd7 { get; set; }

    /// <summary>
    /// Unit[m] operator intervention on shift position
    /// </summary>
    public double? ManualInterventionShiftInd8 { get; set; }

    /// <summary>
    /// Unit[IU] maximal value measured flatness
    /// </summary>
    public double? MaxMeasFlatness { get; set; }

    /// <summary>
    /// Unit[m] maximal value measured profile
    /// </summary>
    public double? MaxMeasProfile { get; set; }

    /// <summary>
    /// Unit[IU] minimal value measured flatness
    /// </summary>
    public double? MinMeasFlatness { get; set; }

    /// <summary>
    /// Unit[m] minimal value measured profile
    /// </summary>
    public double? MinMeasProfile { get; set; }

    /// <summary>
    /// Unit[%] manganese content
    /// </summary>
    public double? Mn { get; set; }

    /// <summary>
    /// Unit[%] nickel content
    /// </summary>
    public double? Ni { get; set; }

    /// <summary>
    /// number of invalid flatness scans
    /// </summary>
    public short? NoInvalidFlatnessScans { get; set; }

    /// <summary>
    /// number of invalid profile scans
    /// </summary>
    public short? NoInvalidProfileScans { get; set; }

    /// <summary>
    /// total number of passes
    /// </summary>
    public short? NoPasses { get; set; }

    /// <summary>
    /// number of valid flatness scans
    /// </summary>
    public short? NoValidFlatnessScans { get; set; }

    /// <summary>
    /// number of valid profile scans
    /// </summary>
    public short? NoValidProfileScans { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd0 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd1 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd2 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd3 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd4 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd5 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd6 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd7 { get; set; }

    /// <summary>
    /// Unit[kN] visual unflatness from operator (HMI)
    /// </summary>
    public double? ObservedUnflatnessInd8 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd0 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd1 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd2 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd3 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd4 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd5 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd6 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd7 { get; set; }

    /// <summary>
    /// Unit[kN] manual bending set-up value from operator
    /// </summary>
    public double? OperatorBendingInd8 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd0 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd1 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd2 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd3 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd4 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd5 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd6 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd7 { get; set; }

    /// <summary>
    /// Unit[rad] manual pair cross set-up value from operator
    /// </summary>
    public double? OperatorPairCrossInd8 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd0 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd1 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd2 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd3 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd4 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd5 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd6 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd7 { get; set; }

    /// <summary>
    /// Unit[m] manual shifting set-up value from operator
    /// </summary>
    public double? OperatorShiftInd8 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd0 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd1 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd2 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd3 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd4 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd5 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd6 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd7 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from post-calculation
    /// </summary>
    public double? PairCrossPostInd8 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd0 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd1 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd2 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd3 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd4 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd5 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd6 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd7 { get; set; }

    /// <summary>
    /// Unit[rad] pair-cross value from pre-calculation
    /// </summary>
    public double? PairCrossPreInd8 { get; set; }

    /// <summary>
    /// pass index of flatness measurement
    /// </summary>
    public short? PassIndexFlatness { get; set; }

    /// <summary>
    /// pass index of profile measurement
    /// </summary>
    public short? PassIndexProfile { get; set; }

    /// <summary>
    /// Unit[m] absolute profile error
    /// </summary>
    public double? PrError { get; set; }

    /// <summary>
    /// Unit[m] measured absolute profile
    /// </summary>
    public double? PrMeas { get; set; }

    /// <summary>
    /// profile adaptation flag (1=ok)
    /// </summary>
    public int? ProfileAdaptInfo { get; set; }

    /// <summary>
    /// Unit[m] internal offset for the target profile (for adaptation)
    /// </summary>
    public double? ProfileOffsetInternal { get; set; }

    /// <summary>
    /// Unit[m] profile offset from LTI
    /// </summary>
    public double? ProfileOffsetLti { get; set; }

    /// <summary>
    /// Unit[m] profile offset from operator (from HMI)
    /// </summary>
    public double? ProfileOffsetOperator { get; set; }

    /// <summary>
    /// Unit[m] target profile from primary data
    /// </summary>
    public double? ProfilePdi { get; set; }

    /// <summary>
    /// Unit[m] changed target profile in case of actuator limitations
    /// </summary>
    public double? ProfilePfc { get; set; }

    /// <summary>
    /// Unit[m] calculated absolute profile from post-calculation
    /// </summary>
    public double? ProfilePost { get; set; }

    /// <summary>
    /// Unit[m] calculated absolute profile from pre-calculation
    /// </summary>
    public double? ProfilePre { get; set; }

    /// <summary>
    /// Unit[m] slope of measured profile over the strip length
    /// </summary>
    public double? ProfileSlope { get; set; }

    /// <summary>
    /// number of scans with quarter buckles
    /// </summary>
    public short? QuarterBuckleSize { get; set; }

    /// <summary>
    /// Unit[IU] measured quarter buckles
    /// </summary>
    public double? QuarterBuckleValue { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd0 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd1 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd2 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd3 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd4 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd5 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd6 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd7 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from post-calculation
    /// </summary>
    public double? RollForcePostInd8 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd0 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd1 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd2 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd3 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd4 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd5 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd6 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd7 { get; set; }

    /// <summary>
    /// Unit[kN] roll force value from pre-calculation
    /// </summary>
    public double? RollForcePreInd8 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd0 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd1 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd2 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd3 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd4 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd5 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd6 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd7 { get; set; }

    /// <summary>
    /// roll id top WR
    /// </summary>
    public string RollIdInd8 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd0 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd1 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd2 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd3 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd4 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd5 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd6 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd7 { get; set; }

    /// <summary>
    /// shape code top WR
    /// </summary>
    public int? ShapeCodeInd8 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd0 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd1 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd2 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd3 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd4 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd5 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd6 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd7 { get; set; }

    /// <summary>
    /// Unit[m] shift position from post-calculation
    /// </summary>
    public double? ShiftPositionPostInd8 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd0 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd1 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd2 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd3 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd4 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd5 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd6 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd7 { get; set; }

    /// <summary>
    /// Unit[m] shift position from pre-calculation
    /// </summary>
    public double? ShiftPositionPreInd8 { get; set; }

    /// <summary>
    /// Unit[%] silicon content
    /// </summary>
    public double? Si { get; set; }

    /// <summary>
    /// Unit[IU] standard deviation measured flatness
    /// </summary>
    public double? StdMeasFlatness { get; set; }

    /// <summary>
    /// Unit[m] standard deviation measured profile
    /// </summary>
    public double? StdMeasProfile { get; set; }

    /// <summary>
    /// Unit[m] kink from LTI
    /// </summary>
    public double? TargetCrKink { get; set; }

    /// <summary>
    /// Unit[m] target flatness
    /// </summary>
    public double? TargetFlatness { get; set; }

    /// <summary>
    /// Unit[m] contour indicator: thick edge value DS
    /// </summary>
    public double? ThickEdgeDs { get; set; }

    /// <summary>
    /// Unit[m] contour indicator: thick edge value OS
    /// </summary>
    public double? ThickEdgeOs { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd0 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd1 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd2 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd3 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd4 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd5 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd6 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd7 { get; set; }

    /// <summary>
    /// Unit[kN] upper limit for the bending force set-up
    /// </summary>
    public double? UpperLimitBendingInd8 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd0 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd1 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd2 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd3 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd4 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd5 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd6 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd7 { get; set; }

    /// <summary>
    /// Unit[rad] upper limit for the pair-cross angle set-up
    /// </summary>
    public double? UpperLimitPairCrossInd8 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd0 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd1 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd2 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd3 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd4 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd5 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd6 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd7 { get; set; }

    /// <summary>
    /// Unit[m] upper limit for the shift position set-up
    /// </summary>
    public double? UpperLimitShiftInd8 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd0 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd1 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd2 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd3 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd4 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd5 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd6 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd7 { get; set; }

    /// <summary>
    /// wear correction factor (used only for tapered rolls)
    /// </summary>
    public double? WearCorrectionInd8 { get; set; }

    /// <summary>
    /// Unit[m] measured strip wedge
    /// </summary>
    public double? Wedge { get; set; }

    /// <summary>
    /// Unit[m] target width
    /// </summary>
    public double? Width { get; set; }

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
