using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVProductionHistory
{
    public int Meid { get; set; }

    public string CoilId { get; set; }

    public string SlabId { get; set; }

    public string SequenceId { get; set; }

    public string HeatId1 { get; set; }

    public int? Flagbatchrolling { get; set; }

    public string Alloycode { get; set; }

    public DateTime? Prodstart { get; set; }

    public DateTime? ProdEnd { get; set; }

    public double? WExit { get; set; }

    public double? WExitAver { get; set; }

    public double? WExitMin { get; set; }

    public double? WExitMax { get; set; }

    public double? HExit { get; set; }

    public double? HExitAver { get; set; }

    public double? HExitMin { get; set; }

    public double? HExitMax { get; set; }

    public double? TExitCs { get; set; }

    public double? TExitCsaver { get; set; }

    public double? TExitCsmin { get; set; }

    public double? TExitCsmax { get; set; }

    public double? CoilLengthX { get; set; }
}
