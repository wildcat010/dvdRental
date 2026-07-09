using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpphyent
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short Thickhead { get; set; }

    public short? Basisid { get; set; }

    public short? Bendmodeflag { get; set; }

    public short? Coiloutdia { get; set; }

    public short? Hexitcustomer { get; set; }

    public short? Heatid { get; set; }

    public short? Lenmarkingdatadiscline { get; set; }

    public short? Lenmarkingdatashellline1 { get; set; }

    public short? Lenmarkingdatashellline2 { get; set; }

    public short? Markingdatashellline1 { get; set; }

    public short? Markingdatashellline2 { get; set; }

    public short? Seqid { get; set; }

    public short? Steelcustomer { get; set; }

    public short? Widthexitcustomer { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
