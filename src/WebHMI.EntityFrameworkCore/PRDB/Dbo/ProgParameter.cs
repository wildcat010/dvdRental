using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Progparameter
{
    public string Param { get; set; }

    public string Description { get; set; }

    public string Paramchar { get; set; }

    public double? Paramnum { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
