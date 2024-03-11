using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVSelect
{
    public int Meid { get; set; }

    public string ExtId { get; set; }

    public string MeTyp { get; set; }

    public short? Status { get; set; }

    public int? Simmat { get; set; }

    public DateTime? Tom { get; set; }
}
