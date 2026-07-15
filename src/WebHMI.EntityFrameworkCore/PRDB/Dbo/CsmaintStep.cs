using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsMaintStep
{
    /// <summary>
    /// sequence step index
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
    /// desired amplitude (calculated by the model)
    /// </summary>
    public short? AmplDes { get; set; }

    /// <summary>
    /// desired flow (calculated by the model)
    /// </summary>
    public double? FlowDesDown { get; set; }

    /// <summary>
    /// desired flow (calculated by the model)
    /// </summary>
    public double? FlowDesUp { get; set; }

    /// <summary>
    /// measured flow (stable feedback received)
    /// </summary>
    public double? FlowMeasDown { get; set; }

    /// <summary>
    /// measured flow (stable feedback received)
    /// </summary>
    public double? FlowMeasUp { get; set; }

    /// <summary>
    /// nominal flow (measured nominal flow for nominal pressure 1bar)
    /// </summary>
    public double? FlowNomDown { get; set; }

    /// <summary>
    /// nominal flow (measured nominal flow for nominal pressure 1bar)
    /// </summary>
    public double? FlowNomUp { get; set; }

    /// <summary>
    /// observed flow
    /// </summary>
    public double? FlowObsDown { get; set; }

    /// <summary>
    /// observed flow
    /// </summary>
    public double? FlowObsUp { get; set; }

    /// <summary>
    /// reference flow for 0 amplitude
    /// </summary>
    public double? FlowRef { get; set; }

    /// <summary>
    /// Number of tested valves on this step
    /// </summary>
    public short? NoValves { get; set; }

    /// <summary>
    /// desired pressure (calculated by the model)
    /// </summary>
    public double? PressureDesDown { get; set; }

    /// <summary>
    /// desired pressure (calculated by the model)
    /// </summary>
    public double? PressureDesUp { get; set; }

    /// <summary>
    /// measured pressure (stable feedback received)
    /// </summary>
    public double? PressureMeasDown { get; set; }

    /// <summary>
    /// measured pressure (stable feedback received)
    /// </summary>
    public double? PressureMeasUp { get; set; }

    /// <summary>
    /// Reference static pressure
    /// </summary>
    public double? PressureRef { get; set; }

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
