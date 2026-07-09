using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogIndex
{
    public short Id { get; set; }

    public short? Dbkeep { get; set; }

    public string Descr { get; set; }

    public bool? Needconfirm { get; set; }

    public short? Severity { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
