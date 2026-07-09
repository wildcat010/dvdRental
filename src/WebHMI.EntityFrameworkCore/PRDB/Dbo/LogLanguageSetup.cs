using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogLanguageSetup
{
    public string Lang { get; set; }

    public string Descr { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
