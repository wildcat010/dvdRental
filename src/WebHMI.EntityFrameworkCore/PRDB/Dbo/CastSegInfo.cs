using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CastSegInfo
{
    /// <summary>
    /// counter
    /// </summary>
    public int Counter { get; set; }

    /// <summary>
    /// time of receiving the data
    /// </summary>
    public DateTime RecTime { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0 - top surface, ..., 4 - core
    /// </summary>
    public float? ActualTempInd0 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0 - top surface, ..., 4 - core
    /// </summary>
    public float? ActualTempInd1 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0 - top surface, ..., 4 - core
    /// </summary>
    public float? ActualTempInd2 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0 - top surface, ..., 4 - core
    /// </summary>
    public float? ActualTempInd3 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0 - top surface, ..., 4 - core
    /// </summary>
    public float? ActualTempInd4 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd0 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd1 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd10 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd11 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd12 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd13 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd14 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd15 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd16 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd17 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd18 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd19 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd2 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd20 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd21 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd22 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd23 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd24 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd25 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd26 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd27 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd28 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd29 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd3 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd30 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd31 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd32 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd33 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd34 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd35 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd36 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd37 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd38 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd39 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd4 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd5 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd6 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd7 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd8 { get; set; }

    /// <summary>
    /// Array of names for slab chemistry
    /// </summary>
    public string AlloyNameInd9 { get; set; }

    /// <summary>
    /// number of alloy elements
    /// </summary>
    public int? AlloyNo { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd0 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd1 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd10 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd11 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd12 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd13 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd14 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd15 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd16 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd17 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd18 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd19 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd2 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd20 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd21 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd22 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd23 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd24 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd25 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd26 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd27 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd28 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd29 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd3 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd30 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd31 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd32 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd33 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd34 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd35 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd36 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd37 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd38 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd39 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd4 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd5 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd6 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd7 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd8 { get; set; }

    /// <summary>
    /// Unit[%] Array of slab chemistry (measured)
    /// </summary>
    public float? AlloyValueInd9 { get; set; }

    /// <summary>
    /// Analysis flag ( 0 - default analysis for the steel grade, 1 = melt shop analysis, 2=caster analysis)
    /// </summary>
    public int? AnalysisFlag { get; set; }

    /// <summary>
    /// heat identification
    /// </summary>
    public string HeatId { get; set; }

    public short? HeatTreatmentNo { get; set; }

    /// <summary>
    /// remain length of the heat
    /// </summary>
    public float? RemainLength { get; set; }

    /// <summary>
    /// Unit[m] position in the sequence (cast length)
    /// </summary>
    public float? SeqPosition { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// sequence number (increments with every start cast)
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Unit[m/s] actual speed of strand at entry of the mill
    /// </summary>
    public float? Speed { get; set; }

    /// <summary>
    /// steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[m] caster exit thickness( cold at transfer to mill)
    /// </summary>
    public float? Thickness { get; set; }

    /// <summary>
    /// Unit[m] cold width
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
