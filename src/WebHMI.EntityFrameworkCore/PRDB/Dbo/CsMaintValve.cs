using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsMaintValve
{
    /// <summary>
    /// sequence step valve index
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// maintenance index
    /// </summary>
    public int MId { get; set; }

    /// <summary>
    /// Sequence index
    /// </summary>
    public int SqId { get; set; }

    /// <summary>
    /// sequence step index
    /// </summary>
    public int StId { get; set; }

    /// <summary>
    /// measured amplitude (feedback received)
    /// </summary>
    public short? AmplMeasDown { get; set; }

    /// <summary>
    /// measured amplitude (feedback received)
    /// </summary>
    public short? AmplMeasUp { get; set; }

    /// <summary>
    /// desired flow (calculated by the model)
    /// </summary>
    public float? FlowDesDown { get; set; }

    /// <summary>
    /// desired flow (calculated by the model)
    /// </summary>
    public float? FlowDesUp { get; set; }

    /// <summary>
    /// measured flow (stable feedback received)
    /// </summary>
    public float? FlowMeasDown { get; set; }

    /// <summary>
    /// measured flow (stable feedback received)
    /// </summary>
    public float? FlowMeasUp { get; set; }

    /// <summary>
    /// nominal flow (measured nominal flow for nominal pressure 1bar)
    /// </summary>
    public float? FlowNomDown { get; set; }

    /// <summary>
    /// nominal flow (measured nominal flow for nominal pressure 1bar)
    /// </summary>
    public float? FlowNomUp { get; set; }

    /// <summary>
    /// observed flow
    /// </summary>
    public float? FlowObsDown { get; set; }

    /// <summary>
    /// observed flow
    /// </summary>
    public float? FlowObsUp { get; set; }

    /// <summary>
    /// 1 - OK, 2 - defective OFF, 3 - defective ON, 4 - uncalibrated (when desired and measured values are too much different, in example more than 10%),
    /// </summary>
    public short? Status { get; set; }

    /// <summary>
    /// Valve number
    /// </summary>
    public short? ValveNo { get; set; }

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
