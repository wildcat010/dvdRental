using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Disturbance
{
    /// <summary>
    /// Unit[Unit] Number of record
    /// </summary>
    public int DistNo { get; set; }

    /// <summary>
    /// Unit[Unit] status of record: S: record of actual shift, proofed by DOT, U: record of prev. shift, 15 Minutes after changes of shift, I: records of past shifts.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// work level = PL, TCM (at Tako)
    /// </summary>
    public string WorkLevel { get; set; }

    /// <summary>
    /// information flag, is disturbance has been transmitted to level 3
    /// </summary>
    public int? Archive { get; set; }

    /// <summary>
    /// Unit[Unit] creator id (HMI/DOT)
    /// </summary>
    public int BeginId { get; set; }

    /// <summary>
    /// Unit[Unit] start time of disturbance
    /// </summary>
    public DateTime DistBeg { get; set; }

    /// <summary>
    /// Unit[Unit] end time of disturbance
    /// </summary>
    public DateTime? DistEnd { get; set; }

    /// <summary>
    /// Unit[Unit] createor id (HMI/DOT/open)
    /// </summary>
    public int? EndId { get; set; }

    /// <summary>
    /// ID for initiator, defined in StdTxt table
    /// </summary>
    public string InitiatorId { get; set; }

    /// <summary>
    /// ID for plant, defined in StdTxt table
    /// </summary>
    public string PlantId { get; set; }

    /// <summary>
    /// ID for plant section, defined in StdTxt table
    /// </summary>
    public string PlantPartId { get; set; }

    /// <summary>
    /// Unit[Unit] reason code of disturbance
    /// </summary>
    public string Reason { get; set; }

    /// <summary>
    /// Unit[Unit] long text for reason
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// ID for type of disturbance, defined in StdTxt table
    /// </summary>
    public string TypeId { get; set; }

    /// <summary>
    /// modifying process
    /// </summary>
    public string Mop { get; set; }

    /// <summary>
    /// time of creation
    /// </summary>
    public DateTime? Toc { get; set; }

    /// <summary>
    /// time of modification
    /// </summary>
    public DateTime? Tom { get; set; }
}
