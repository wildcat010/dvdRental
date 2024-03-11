using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Roll property
/// </summary>
public partial class RollProperty
{
    /// <summary>
    /// roll property class, intern usage for MOS (rollPropRef), related to rolldata
    /// </summary>
    public int RollPropertyClass { get; set; }

    /// <summary>
    /// Unit[J/degCkg] heat capacity roll kernel
    /// </summary>
    public double? CwIn { get; set; }

    /// <summary>
    /// Unit[J/degCkg] heat capacity roll surface
    /// </summary>
    public double? CwOut { get; set; }

    /// <summary>
    /// Unit[kg/m^3] density roll kernel
    /// </summary>
    public double? DensityIn { get; set; }

    /// <summary>
    /// Unit[kg/m^3] density roll surface
    /// </summary>
    public double? DensityOut { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[N/m^2] module of elasticity roll kernel
    /// </summary>
    public double? EmodIn { get; set; }

    /// <summary>
    /// Unit[N/m^2] module of elasticity roll surface
    /// </summary>
    public double? EmodOut { get; set; }

    /// <summary>
    /// Unit[1/grdC] expansion coefficient roll kernel
    /// </summary>
    public double? ExpansionCoefIn { get; set; }

    /// <summary>
    /// Unit[1/grdC] expansion coefficient roll surface
    /// </summary>
    public double? ExpansionCoefOut { get; set; }

    /// <summary>
    /// Unit[J/degCm^2s] heat transition coefficent roll-environment with cooling
    /// </summary>
    public double? HtEnv { get; set; }

    /// <summary>
    /// Unit[J/degCm^2s] heat transition coefficent roll-environment without cooling
    /// </summary>
    public double? HtEnv2 { get; set; }

    /// <summary>
    /// Unit[J/degCm^2s] heat transition coefficent roll-neck
    /// </summary>
    public double? HtNeck { get; set; }

    /// <summary>
    /// Unit[J/degCms] heat flow coefficent roll kernel
    /// </summary>
    public double? LambdaIn { get; set; }

    /// <summary>
    /// Unit[J/degCms] heat flow coefficent roll surface
    /// </summary>
    public double? LambdaOut { get; set; }

    /// <summary>
    /// Unit[grdC] max temp yield polynom
    /// </summary>
    public double? MaxTemp { get; set; }

    /// <summary>
    /// Unit[grdC] min temp yield polynom
    /// </summary>
    public double? MinTemp { get; set; }

    /// <summary>
    /// plant type HRM , HFM, ....
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// type of roll (BUR; IMR; WKR)
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// Unit[degC] initial roll temperature
    /// </summary>
    public double? TInit { get; set; }

    /// <summary>
    /// Unit[degC] roll neck temperature
    /// </summary>
    public double? TNeck { get; set; }

    /// <summary>
    /// Unit[degC] max roll neck temperature
    /// </summary>
    public double? TNeckMax { get; set; }

    /// <summary>
    /// Unit[m/N] wear coeficient for bottom roll
    /// </summary>
    public double? WEffBotRoll { get; set; }

    /// <summary>
    /// Unit[m/N] wear coeficient for top roll
    /// </summary>
    public double? WEffTopRoll { get; set; }

    /// <summary>
    /// factor for wear model related to roll material
    /// </summary>
    public float? WearFacMat { get; set; }

    /// <summary>
    /// yield polynom coeff
    /// </summary>
    public double? YieldPolynomCInd0 { get; set; }

    /// <summary>
    /// yield polynom coeff
    /// </summary>
    public double? YieldPolynomCInd1 { get; set; }

    /// <summary>
    /// yield polynom coeff
    /// </summary>
    public double? YieldPolynomCInd2 { get; set; }

    /// <summary>
    /// yield polynom coeff
    /// </summary>
    public double? YieldPolynomCInd3 { get; set; }

    /// <summary>
    /// Unit[N/m2] roll surface yield stress
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

    public virtual ICollection<RollDatum> RollData { get; set; } = new List<RollDatum>();
}
