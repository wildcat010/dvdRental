using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class SpLogEnt
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
    public string AlloyCode { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd0 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd1 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd10 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd11 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd12 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd13 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd14 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd15 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd16 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd17 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd18 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd19 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd2 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd20 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd21 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd22 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd23 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd24 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd25 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd26 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd27 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd28 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd29 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd3 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd30 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd31 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd32 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd33 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd34 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd35 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd36 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd37 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd38 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd39 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd4 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd5 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd6 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd7 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd8 { get; set; }

    /// <summary>
    /// Unit[%] chemical analysis elements
    /// </summary>
    public float? AlloyValueInd9 { get; set; }

    /// <summary>
    /// Casting grade code for surface inspection gauge
    /// </summary>
    public string CastingGradeCode { get; set; }

    /// <summary>
    /// Unit[kg/m3] specific weight of material
    /// </summary>
    public float? SpecWeight { get; set; }

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
