using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class VMatStructEntry
{
    public int EnOrMeId { get; set; }

    public string EnOrExtId { get; set; }

    public string EnOrMeType { get; set; }

    public short? EnOrMesId { get; set; }

    public short EnOrBasId { get; set; }

    public int EnLoMeId { get; set; }

    public string EnLoExtId { get; set; }

    public string EnLoMeType { get; set; }

    public short? EnLoMesid { get; set; }

    public short EnLoBasId { get; set; }

    public int EnPhMeId { get; set; }

    public string EnPhExtId { get; set; }

    public short EnPhBasId { get; set; }

    public string EnPhMeType { get; set; }

    public short? EnPhMesId { get; set; }

    public short? EnOrStatus { get; set; }

    public string EnOrCreator { get; set; }

    public short? EnLoStatus { get; set; }

    public string EnLoCreator { get; set; }

    public short? EnPhStatus { get; set; }

    public string EnPhCreator { get; set; }

    public DateTime? LastUpdate { get; set; }
}
