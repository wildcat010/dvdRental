using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csprofile
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public double? Coiltempprofilehead { get; set; }

    public double? Coiltempprofiletail { get; set; }

    public string Description { get; set; }

    public double? Lengthprofilehead { get; set; }

    public double? Lengthprofileheadwedge { get; set; }

    public double? Lengthprofiletail { get; set; }

    public double? Lengthprofiletailwedge { get; set; }

    public double? Lengthuncooledhead { get; set; }

    public double? Lengthuncooledtail { get; set; }

    public short? Manint { get; set; }

    public int? Planno { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
