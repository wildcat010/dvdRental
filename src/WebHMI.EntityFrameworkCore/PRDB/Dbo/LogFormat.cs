using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogFormat
{
    public short Id { get; set; }

    public string Lang { get; set; }

    public string Format { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual LogIndex IdNavigation { get; set; }
}
