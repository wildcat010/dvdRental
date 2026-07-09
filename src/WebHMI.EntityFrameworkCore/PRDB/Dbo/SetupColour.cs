using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class SetupColour
{
    public string Colour { get; set; }

    public int? Rgbnumber { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
