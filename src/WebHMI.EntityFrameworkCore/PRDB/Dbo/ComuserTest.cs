using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ComuserTest
{
    public decimal Id { get; set; }

    public decimal MsgId { get; set; }

    public DateTime SendTime { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public decimal Status { get; set; }

    public string StatusText { get; set; }

    public string MsgKey { get; set; }

    public decimal ReadCount { get; set; }

    public decimal Simulation { get; set; }
}
