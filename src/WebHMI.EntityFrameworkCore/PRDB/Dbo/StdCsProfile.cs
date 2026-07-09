using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdcsprofile
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public double? Coiltempprofilehead { get; set; }

    public double? Coiltempprofiletail { get; set; }

    public string Description { get; set; }

    public string Description2 { get; set; }

    public double? Lengthprofilehead { get; set; }

    public double? Lengthprofileheadwedge { get; set; }

    public double? Lengthprofiletail { get; set; }

    public double? Lengthprofiletailwedge { get; set; }

    public double? Lengthuncooledhead { get; set; }

    public double? Lengthuncooledtail { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
