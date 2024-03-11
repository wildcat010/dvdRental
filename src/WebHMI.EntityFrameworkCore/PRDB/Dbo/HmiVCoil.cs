using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVCoil
{
    public int? Meid { get; set; }

    public string Extid { get; set; }

    public int SeqNo { get; set; }

    public int? IsNext { get; set; }

    public int? FurnaceNo { get; set; }

    public int? Slabmeid { get; set; }

    public int? Coilmeid { get; set; }

    public string HeatId { get; set; }

    public string SequenceId { get; set; }

    public string Alloycode { get; set; }

    public float? Slablength { get; set; }

    public float? SlabThick { get; set; }

    public float? SlabLength1 { get; set; }

    public float? SlabTemp { get; set; }

    public float? FinishedThick { get; set; }

    public float? FinishedWidth { get; set; }

    public float? FinishedLength { get; set; }

    public float? FinishedTemp { get; set; }

    public float? CoilerTemp { get; set; }

    public int? CoolingStrategy { get; set; }

    public int Ok0 { get; set; }

    public int Ok1 { get; set; }

    public int Ok3 { get; set; }

    public int Ok4 { get; set; }

    public int Simmat { get; set; }

    public int LprmMan { get; set; }

    public int EoeMan { get; set; }

    public string Batchrolling { get; set; }

    public short? Status { get; set; }

    public DateTime? Toc { get; set; }

    public long? Rnum { get; set; }
}
