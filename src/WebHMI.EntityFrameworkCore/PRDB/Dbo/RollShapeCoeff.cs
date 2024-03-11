using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Shape coefficent of rolls
/// </summary>
public partial class RollShapeCoeff
{
    /// <summary>
    /// Code for the shape parametersShape
    /// </summary>
    public int ShapeCode { get; set; }

    /// <summary>
    /// Description for this shape code
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Shape curve by customer (use extra table shapeCurveCustom)
    /// </summary>
    public int? ShapeCurveCode { get; set; }

    /// <summary>
    /// Shape type ( 1 CVC | 2 smart crown | 3 cosine)
    /// </summary>
    public int? ShapeType { get; set; }

    /// <summary>
    /// Shape coefficient x(exp1) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX1 { get; set; }

    /// <summary>
    /// Unit[1/m] Shape coefficient x(exp2) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX2 { get; set; }

    /// <summary>
    /// Unit[1/m2] Shape coefficient x(exp3) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX3 { get; set; }

    /// <summary>
    /// Unit[1/m3] Shape coefficient x(exp4) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX4 { get; set; }

    /// <summary>
    /// Unit[1/m4] Shape coefficient x(exp5) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX5 { get; set; }

    /// <summary>
    /// Unit[1/m5] Shape coefficient x(exp6) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX6 { get; set; }

    /// <summary>
    /// Unit[1/m6] Shape coefficient x(exp7) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX7 { get; set; }

    /// <summary>
    /// Unit[1/m7] Shape coefficient x(exp8) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX8 { get; set; }

    /// <summary>
    /// Unit[1/m8] Shape coefficient x(exp9) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX9 { get; set; }

    /// <summary>
    /// Unit[-]:Stand range
    /// </summary>
    public string StandRange { get; set; }

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
