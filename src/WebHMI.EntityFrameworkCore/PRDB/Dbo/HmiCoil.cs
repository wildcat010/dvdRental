using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Hmicoil
{
    public string Param { get; set; }

    public string Id { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
