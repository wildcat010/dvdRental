using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpLogEnt
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
    /// thick head flag ( in HSM = 0)
    /// </summary>
    public short ThickHead { get; set; }

    /// <summary>
    /// material alloy code
    /// </summary>
    public short? AlloyCode { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd0 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd1 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd10 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd11 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd12 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd13 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd14 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd15 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd16 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd17 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd18 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd19 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd2 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd20 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd21 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd22 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd23 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd24 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd25 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd26 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd27 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd28 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd29 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd3 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd30 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd31 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd32 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd33 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd34 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd35 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd36 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd37 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd38 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd39 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd4 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd5 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd6 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd7 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd8 { get; set; }

    /// <summary>
    /// chemical analysis elements
    /// </summary>
    public short? AlloyValueInd9 { get; set; }

    /// <summary>
    /// Casting grade code for surface inspection gauge
    /// </summary>
    public short? CastingGradeCode { get; set; }

    /// <summary>
    /// specific weight of material
    /// </summary>
    public short? SpecWeight { get; set; }

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
