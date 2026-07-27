using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVProductionHistory
{
    public int MeId { get; set; }

    public string CoilId { get; set; }

    public string SlabId { get; set; }

    public string SequenceId { get; set; }

    public string HeatId1 { get; set; }

    public int? FlagBatchRolling { get; set; }

    public string AlloyCode { get; set; }

    public DateTime? ProdStart { get; set; }

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

    public double? TExitCsAver { get; set; }

    public double? TExitCsMin { get; set; }

    public double? TExitCsMax { get; set; }

    public double? CoilLengthX { get; set; }

    public string EnOrCreator { get; set; }

    public int EnOrMeid { get; set; }

    public short? EnOrStatus { get; set; }

    public string EnOrExitId { get; set; }

    public string EnOrMeType { get; set; }

    public short? EnOrCurMesId { get; set; }
}
