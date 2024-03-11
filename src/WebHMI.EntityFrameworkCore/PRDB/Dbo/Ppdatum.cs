using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Ppdatum
{
    /// <summary>
    /// object name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// reference Name
    /// </summary>
    public string RefName { get; set; }

    /// <summary>
    /// object id
    /// </summary>
    public int SetId { get; set; }

    /// <summary>
    /// character value
    /// </summary>
    public string CValue { get; set; }

    /// <summary>
    /// Calculation type
    /// </summary>
    public int? CalcType { get; set; }

    /// <summary>
    /// double value
    /// </summary>
    public double? DValue { get; set; }

    /// <summary>
    /// value type
    /// </summary>
    public int? DataType { get; set; }

    /// <summary>
    /// float value
    /// </summary>
    public float? FValue { get; set; }

    /// <summary>
    /// integer value
    /// </summary>
    public int? IValue { get; set; }

    /// <summary>
    /// long value
    /// </summary>
    public int? LValue { get; set; }

    /// <summary>
    /// remark
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// short value
    /// </summary>
    public short? SValue { get; set; }

    /// <summary>
    /// time value
    /// </summary>
    public DateTime? TValue { get; set; }

    /// <summary>
    /// unit of value
    /// </summary>
    public string Unit { get; set; }

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
