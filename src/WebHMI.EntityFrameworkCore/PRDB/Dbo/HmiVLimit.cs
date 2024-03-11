using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVLimit
{
    public string Paramname { get; set; }

    public string Og { get; set; }

    public string Ug { get; set; }

    public string Planttype { get; set; }

    public string Description { get; set; }

    public string Moddescr { get; set; }

    public string Ptype { get; set; }
}
