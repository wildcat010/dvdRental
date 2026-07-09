using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogColour
{
    public short Id { get; set; }

    public string Colour { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
