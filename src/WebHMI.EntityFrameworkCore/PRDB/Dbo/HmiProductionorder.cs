using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiProductionOrder
{
    public string OrderNo { get; set; }

    public double? Thickness { get; set; }

    public decimal? Width { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Profile { get; set; }

    public string CoolType { get; set; }

    public decimal? CoilerTemp { get; set; }

    public int? AvailableQuantity { get; set; }
}
