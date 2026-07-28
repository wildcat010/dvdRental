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

    public short EnOrBasId { get; set; }

    public string EdOrSrc { get; set; }

    public int EnLoMeId { get; set; }

    public string EdLoSrc { get; set; }

    public string AlloyCode { get; set; }

    public double? HEntry { get; set; }

    public double? HExit { get; set; }

    public double? WEntry { get; set; }

    public double? WeightEntry { get; set; }

    public double? LEntry { get; set; }

    public double? WExit { get; set; }

    public string SequenceId { get; set; }

    public int? PdiStatus { get; set; }

    public short? SetpointsPc2Ok { get; set; }

    public short? SetpointsHrmOk { get; set; }

    public int? Sbaz { get; set; }

    public DateTime? LastCalc { get; set; }

    public string SptlFaultCs { get; set; }

    public string ApsKey { get; set; }

    public int? SimMat { get; set; }

    public short? SetpointsCsOk { get; set; }

    public double? TEntryFm { get; set; }

    public double? TExitFm { get; set; }

    public double? TExitCaster { get; set; }

    public double? CoilTemp { get; set; }

    public int? CoolStrategy { get; set; }

    public double? CsCoilTempSetp { get; set; }

    public double? HExitCold { get; set; }

    public double? WExitCold { get; set; }

    public string HeatId { get; set; }

    public int? FlagBatchRolling { get; set; }

    public int? PlateProduction { get; set; }

    public DateTime? ProdStartTime { get; set; }

    public DateTime? ProdEndTime { get; set; }

    public double? LExit { get; set; }

    public double? HExitHrm { get; set; }

    public double? HExitHrmcalc { get; set; }

    public double? ProfileHrm { get; set; }

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

    public int? IdSeq { get; set; }

    public int? IdRiga { get; set; }

    public string SptlFaultHfm { get; set; }

    public string SptlFaultHrm { get; set; }

    public string HeatName { get; set; }
}
