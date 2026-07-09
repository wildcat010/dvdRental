using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Defect
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Sid { get; set; }

    public string Source { get; set; }

    public int? Action { get; set; }

    public short? Defclass { get; set; }

    public string Defcreator { get; set; }

    public double? Defend { get; set; }

    public short? Deflock { get; set; }

    public string Defside { get; set; }

    public double? Defstart { get; set; }

    public string Deftype { get; set; }

    public string Defecttext { get; set; }

    public string Intensity { get; set; }

    public double? Intensityval { get; set; }

    public string Matlock { get; set; }

    public int? Track { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
