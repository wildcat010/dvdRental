using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdtppass
{
    public int Activeflag { get; set; }

    public int Passno { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

    public double? Looperangle { get; set; }

    public int? Loopermode { get; set; }

    public double? Looperstriplen { get; set; }

    public double? Speciffotension { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
