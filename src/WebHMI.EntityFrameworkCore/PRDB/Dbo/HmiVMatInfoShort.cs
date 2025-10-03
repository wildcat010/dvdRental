using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVMatInfoShort
{
    public string EnPhExtId { get; set; }

    public int EnPhMeId { get; set; }

    public string EdPhySrc { get; set; }

    public short? EnPhStatus { get; set; }

    public int EnOrMeId { get; set; }

    public string EnOrExtId { get; set; }

    public string EnOrMeType { get; set; }

    public short? EnOrMesId { get; set; }

    public string EnOrCreator { get; set; }

    public string EdOrSrc { get; set; }

    public int EnLoMeId { get; set; }

    public string EdLoSrc { get; set; }

    public string AlloyCode { get; set; }

    public float? HEntry { get; set; }

    public float? HExit { get; set; }

    public float? WEntry { get; set; }

    public float? WeightEntry { get; set; }

    public float? LEntry { get; set; }

    public float? WExit { get; set; }

    public string SequenceId { get; set; }

    public short? PdiStatus { get; set; }

    public short? SetpointsPc2Ok { get; set; }

    public int? Sbaz { get; set; }

    public DateTime? LastCalc { get; set; }

    public string ApsKey { get; set; }

    public int? SimMat { get; set; }

    public short? SetpointsCsOk { get; set; }

    public float? TEntryFm { get; set; }

    public float? TExitFm { get; set; }

    public float? TExitCaster { get; set; }

    public float? CoilTemp { get; set; }

    public float? CsCoilTempSetp { get; set; }

    public float? HExitCold { get; set; }

    public float? WExitCold { get; set; }

    public string HeatId { get; set; }

    public int? FlagBatchRolling { get; set; }

    public int? PlateProduction { get; set; }

    public DateTime? ProdStartTime { get; set; }

    public DateTime? ProdEndTime { get; set; }

    public float? LExit { get; set; }

    public float? HExitHrm { get; set; }

    public float? HExitHrmcalc { get; set; }

    public float? ProfileHrm { get; set; }

    public string OrderNo { get; set; }

    public string EnLoExtId { get; set; }

    public short? EnLoMesid { get; set; }

    public string EnLoMeType { get; set; }

    public string EnPhMeType { get; set; }

    public short? EnPhMesId { get; set; }

    public short? EnOrStatus { get; set; }

    public short? EnLoStatus { get; set; }

    public string EnPhCreator { get; set; }

    public string EnLoCreator { get; set; }
}
