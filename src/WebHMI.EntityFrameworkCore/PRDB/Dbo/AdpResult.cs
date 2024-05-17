using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class AdpResult
{
    public int CalcTime { get; set; }

    /// <summary>
    /// name
    /// </summary>
    public string Name { get; set; }

    public float? AdaCrInd0 { get; set; }

    public float? AdaCrInd1 { get; set; }

    public float? AdaCrInd2 { get; set; }

    public float? AdaCrInd3 { get; set; }

    public float? AdaCrInd4 { get; set; }

    public string AlloyCode { get; set; }

    public float? B { get; set; }

    public float? C { get; set; }

    public float? Cr { get; set; }

    public float? FlatnessError { get; set; }

    public float? HrmAdaCrInd0 { get; set; }

    public float? HrmAdaCrInd1 { get; set; }

    public float? HrmAdaCrInd2 { get; set; }

    public float? HrmPreCrInd0 { get; set; }

    public float? HrmPreCrInd1 { get; set; }

    public float? HrmPreCrInd2 { get; set; }

    public string InheritanceId { get; set; }

    public short? InheritanceType { get; set; }

    public float? LastFbInd0 { get; set; }

    public float? LastFbInd1 { get; set; }

    public float? LastFbInd2 { get; set; }

    public float? LastFbInd3 { get; set; }

    public float? LastFbInd4 { get; set; }

    public float? ManFbInd0 { get; set; }

    public float? ManFbInd1 { get; set; }

    public float? ManFbInd2 { get; set; }

    public float? ManFbInd3 { get; set; }

    public float? ManFbInd4 { get; set; }

    public short? ManSrInd0 { get; set; }

    public short? ManSrInd1 { get; set; }

    public short? ManSrInd2 { get; set; }

    public short? ManSrInd3 { get; set; }

    public short? ManSrInd4 { get; set; }

    public float? MeasThickness { get; set; }

    public float? MiFbInd0 { get; set; }

    public float? MiFbInd1 { get; set; }

    public float? MiFbInd2 { get; set; }

    public float? MiFbInd3 { get; set; }

    public float? MiFbInd4 { get; set; }

    public float? Mn { get; set; }

    public float? ModelProfile { get; set; }

    public float? Ni { get; set; }

    public float? P { get; set; }

    public float? PreCrInd0 { get; set; }

    public float? PreCrInd1 { get; set; }

    public float? PreCrInd2 { get; set; }

    public float? PreCrInd3 { get; set; }

    public float? PreCrInd4 { get; set; }

    public float? ProfileError { get; set; }

    public float? ProfileGauge { get; set; }

    public float? ProfileHrm { get; set; }

    public float? ProfileMeas { get; set; }

    public float? ProfileX2 { get; set; }

    public string RollIdWrTopInd0 { get; set; }

    public string RollIdWrTopInd1 { get; set; }

    public string RollIdWrTopInd2 { get; set; }

    public string RollIdWrTopInd3 { get; set; }

    public string RollIdWrTopInd4 { get; set; }

    public string RollIdHrmInd0 { get; set; }

    public string RollIdHrmInd1 { get; set; }

    public string RollIdHrmInd2 { get; set; }

    public float? S { get; set; }

    public float? SetFrInd0 { get; set; }

    public float? SetFrInd1 { get; set; }

    public float? SetFrInd2 { get; set; }

    public float? SetFrInd3 { get; set; }

    public float? SetFrInd4 { get; set; }

    public short? SetSrInd0 { get; set; }

    public short? SetSrInd1 { get; set; }

    public short? SetSrInd2 { get; set; }

    public short? SetSrInd3 { get; set; }

    public short? SetSrInd4 { get; set; }

    public float? SetupFbInd0 { get; set; }

    public float? SetupFbInd1 { get; set; }

    public float? SetupFbInd2 { get; set; }

    public float? SetupFbInd3 { get; set; }

    public float? SetupFbInd4 { get; set; }

    public float? ShiftSpeedInd0 { get; set; }

    public float? ShiftSpeedInd1 { get; set; }

    public float? ShiftSpeedInd2 { get; set; }

    public float? ShiftSpeedInd3 { get; set; }

    public float? ShiftSpeedInd4 { get; set; }

    public float? Si { get; set; }

    public float? TargetProfile { get; set; }

    public float? ThickHrmEx { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? ThicknessInd0 { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? ThicknessInd1 { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? ThicknessInd2 { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? ThicknessInd3 { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? ThicknessInd4 { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? ThicknessInd5 { get; set; }

    public float? V { get; set; }

    public float? W { get; set; }

    public float? WearCorrectionInd0 { get; set; }

    public float? WearCorrectionInd1 { get; set; }

    public float? WearCorrectionInd2 { get; set; }

    public float? WearCorrectionInd3 { get; set; }

    public float? WearCorrectionInd4 { get; set; }

    public float? WearInd0 { get; set; }

    public float? WearInd1 { get; set; }

    public float? WearInd2 { get; set; }

    public float? WearInd3 { get; set; }

    public float? WearInd4 { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? Width { get; set; }

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
