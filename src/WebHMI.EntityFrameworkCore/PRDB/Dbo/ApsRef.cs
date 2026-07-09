using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Apsref
{
    public string Keyname { get; set; }

    public string Keytype { get; set; }

    public string Apskey { get; set; }

    public string Description { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
