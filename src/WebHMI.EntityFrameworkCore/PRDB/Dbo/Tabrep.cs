using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Tabrep
{
    /// <summary>
    /// identification of data
    /// </summary>
    public string DataId { get; set; }

    /// <summary>
    /// major number for sorting
    /// </summary>
    public int MajNo { get; set; }

    /// <summary>
    /// minor number for sorting
    /// </summary>
    public int MinNo { get; set; }

    /// <summary>
    /// content of data
    /// </summary>
    public string Data { get; set; }

    /// <summary>
    /// default value
    /// </summary>
    public string DefaultVal { get; set; }

    /// <summary>
    /// multiplier
    /// </summary>
    public float? Factor { get; set; }

    /// <summary>
    /// processing flags
    /// </summary>
    public string Flags { get; set; }

    /// <summary>
    /// table name 1
    /// </summary>
    public string Table1 { get; set; }

    /// <summary>
    /// table name 2
    /// </summary>
    public string Table2 { get; set; }

    /// <summary>
    /// table name 3
    /// </summary>
    public string Table3 { get; set; }

    /// <summary>
    /// table name 4
    /// </summary>
    public string Table4 { get; set; }

    /// <summary>
    /// table name 5
    /// </summary>
    public string Table5 { get; set; }

    /// <summary>
    /// table attribute 1
    /// </summary>
    public string TableAtt1 { get; set; }

    /// <summary>
    /// table attribute 2
    /// </summary>
    public string TableAtt2 { get; set; }

    /// <summary>
    /// table attribute 3
    /// </summary>
    public string TableAtt3 { get; set; }

    /// <summary>
    /// table attribute 4
    /// </summary>
    public string TableAtt4 { get; set; }

    /// <summary>
    /// table attribute 5
    /// </summary>
    public string TableAtt5 { get; set; }

    /// <summary>
    /// table attribute (if source)
    /// </summary>
    public string TableAttFrom { get; set; }

    /// <summary>
    /// type of table attribute 1
    /// </summary>
    public string TableAttTyp1 { get; set; }

    /// <summary>
    /// type of table attribute 2
    /// </summary>
    public string TableAttTyp2 { get; set; }

    /// <summary>
    /// type of table attribute 3
    /// </summary>
    public string TableAttTyp3 { get; set; }

    /// <summary>
    /// type of table attribute 4
    /// </summary>
    public string TableAttTyp4 { get; set; }

    /// <summary>
    /// type of table attribute 5
    /// </summary>
    public string TableAttTyp5 { get; set; }

    /// <summary>
    /// type of table attribute (if source)
    /// </summary>
    public string TableAttTypFrom { get; set; }

    /// <summary>
    /// table call number (if source)
    /// </summary>
    public int? TableCallNoFrom { get; set; }

    /// <summary>
    /// table name (if source)
    /// </summary>
    public string TableFrom { get; set; }

    /// <summary>
    /// telegram attribute
    /// </summary>
    public string TelAtt { get; set; }

    /// <summary>
    /// length of telegram attribute
    /// </summary>
    public int? TelAttLen { get; set; }

    /// <summary>
    /// length of telegram attribute (if destination)
    /// </summary>
    public int? TelAttLenTo { get; set; }

    /// <summary>
    /// offset of telegram attribute (if destination)
    /// </summary>
    public int? TelAttOffsTo { get; set; }

    /// <summary>
    /// telegram attribute (if destination)
    /// </summary>
    public string TelAttTo { get; set; }

    /// <summary>
    /// type of telegram attribute
    /// </summary>
    public string TelAttTyp { get; set; }

    /// <summary>
    /// type of telegram attribute (if destination)
    /// </summary>
    public string TelAttTypTo { get; set; }

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
