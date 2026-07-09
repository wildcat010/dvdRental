using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsmaintStep
{
    public int Id { get; set; }

    public int MId { get; set; }

    public int SqId { get; set; }

    public short? Ampldes { get; set; }

    public double? Flowdesdown { get; set; }

    public double? Flowdesup { get; set; }

    public double? Flowmeasdown { get; set; }

    public double? Flowmeasup { get; set; }

    public double? Flownomdown { get; set; }

    public double? Flownomup { get; set; }

    public double? Flowobsdown { get; set; }

    public double? Flowobsup { get; set; }

    public double? Flowref { get; set; }

    public short? Novalves { get; set; }

    public double? Pressuredesdown { get; set; }

    public double? Pressuredesup { get; set; }

    public double? Pressuremeasdown { get; set; }

    public double? Pressuremeasup { get; set; }

    public double? Pressureref { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
