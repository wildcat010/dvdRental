using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L3l2inspectionDatum
{
    /// <summary>
    /// unique key
    /// </summary>
    public short Id { get; set; }

    /// <summary>
    /// Unit[%] elongation to fracture (parallel to strip)
    /// </summary>
    public float? A5Par { get; set; }

    /// <summary>
    /// Unit[%] elongation to fracture  (perpendicular to strip)
    /// </summary>
    public float? A5Perp { get; set; }

    /// <summary>
    /// Unit[0.1%] elongation to fracture at 80mm measuring length(parallel to strip)
    /// </summary>
    public float? A80Par { get; set; }

    /// <summary>
    /// Unit[%] elongoation to fracture at 80 mm  measuring length (perpendicular to strip)
    /// </summary>
    public float? A80Perp { get; set; }

    /// <summary>
    /// Unit[%] elongation to yield(parallel to strip)
    /// </summary>
    public float? AgPar { get; set; }

    /// <summary>
    /// Unit[%] elongation to yield  (perpendicular to strip)
    /// </summary>
    public float? AgPerp { get; set; }

    /// <summary>
    /// Unit[%] Aluminium content (%)
    /// </summary>
    public float? AnalysisAl { get; set; }

    /// <summary>
    /// Unit[%] Boron content (%)
    /// </summary>
    public float? AnalysisB { get; set; }

    /// <summary>
    /// Unit[%] Carbon content(%)
    /// </summary>
    public float? AnalysisC { get; set; }

    /// <summary>
    /// Unit[%] Chromium content (%)
    /// </summary>
    public float? AnalysisCr { get; set; }

    /// <summary>
    /// Unit[%] Copper content (%)
    /// </summary>
    public float? AnalysisCu { get; set; }

    /// <summary>
    /// Unit[%] Manganese content(%)
    /// </summary>
    public float? AnalysisMn { get; set; }

    /// <summary>
    /// Unit[%] Molybdenum content (%)
    /// </summary>
    public float? AnalysisMo { get; set; }

    /// <summary>
    /// Unit[%] Nitrogen content (%)
    /// </summary>
    public float? AnalysisN { get; set; }

    /// <summary>
    /// Unit[%] Niobium content (%)
    /// </summary>
    public float? AnalysisNb { get; set; }

    /// <summary>
    /// Unit[%] Nickel content (%)
    /// </summary>
    public float? AnalysisNi { get; set; }

    /// <summary>
    /// Unit[%] Phosphorus content (%)
    /// </summary>
    public float? AnalysisP { get; set; }

    /// <summary>
    /// Unit[%] Lead content (%)
    /// </summary>
    public float? AnalysisPb { get; set; }

    /// <summary>
    /// Unit[%] Sulfur content (%)
    /// </summary>
    public float? AnalysisS { get; set; }

    /// <summary>
    /// Unit[%] Silicon content(%)
    /// </summary>
    public float? AnalysisSi { get; set; }

    /// <summary>
    /// Unit[%] Tin content (%)
    /// </summary>
    public float? AnalysisSn { get; set; }

    /// <summary>
    /// Unit[%] Titanium content (%)
    /// </summary>
    public float? AnalysisTi { get; set; }

    /// <summary>
    /// Unit[%] Vanadium content (%)
    /// </summary>
    public float? AnalysisV { get; set; }

    /// <summary>
    /// Unit[_C] setpoint temperature at coiler
    /// </summary>
    public float? CT { get; set; }

    /// <summary>
    /// coilid
    /// </summary>
    public string CoilId { get; set; }

    /// <summary>
    /// Unit[m] mesured thickness after finishing mill
    /// </summary>
    public float? FmMeasThickness { get; set; }

    /// <summary>
    /// Unit[_C] setpoint temperature after finishing mill
    /// </summary>
    public float? FmT { get; set; }

    /// <summary>
    /// Unit[m] setpoint thickness after finishing mill
    /// </summary>
    public float? FmThickness { get; set; }

    /// <summary>
    /// Unit[_C] setpoint temperature after furnace
    /// </summary>
    public float? FurT { get; set; }

    /// <summary>
    /// Unit[m] setpoint thickness after furnace
    /// </summary>
    public float? FurThickness { get; set; }

    /// <summary>
    /// Unit[Hv] hardness (Vickers) (parallel to strip)
    /// </summary>
    public float? HvPar { get; set; }

    /// <summary>
    /// Unit[Hv] hardness (Vickers)(perpendicular to strip)
    /// </summary>
    public float? HvPerp { get; set; }

    /// <summary>
    /// Unit[MPa] upper yield strength (parallel to strip)
    /// </summary>
    public float? RehPar { get; set; }

    /// <summary>
    /// Unit[MPa] upper yield strength   (perpendicular to strip)
    /// </summary>
    public float? RehPerp { get; set; }

    /// <summary>
    /// Unit[MPa] lower yield strength(parallel to strip)
    /// </summary>
    public float? RelPar { get; set; }

    /// <summary>
    /// Unit[MPa] lower yield strength  (perpendicular to strip)
    /// </summary>
    public float? RelPerp { get; set; }

    /// <summary>
    /// Unit[m] distance of sample position measured from head end
    /// </summary>
    public float? Ril { get; set; }

    /// <summary>
    /// Unit[MPa] tensile strength (parallel to strip)
    /// </summary>
    public float? RmPar { get; set; }

    /// <summary>
    /// Unit[MPa] tensile strength (perpendicular to strip)
    /// </summary>
    public float? RmPerp { get; set; }

    /// <summary>
    /// Unit[_C] setpoint temperature after roughing mill
    /// </summary>
    public float? RmT { get; set; }

    /// <summary>
    /// Unit[m] setpoint thickness after roughing mill
    /// </summary>
    public float? RmThickness { get; set; }

    /// <summary>
    /// Unit[MPa] yield strength at 0.2% permanent elongation (parallel to strip)
    /// </summary>
    public float? Rp02Par { get; set; }

    /// <summary>
    /// Unit[MPa] yield strength at 0.2% permanent elongiation
    /// </summary>
    public float? Rp02Perp { get; set; }

    /// <summary>
    /// Unit[MPa] yield point (parallel to strip)
    /// </summary>
    public float? Rt05Par { get; set; }

    /// <summary>
    /// Unit[MPa] yield point   (perpendicular to strip)
    /// </summary>
    public float? Rt05Perp { get; set; }

    /// <summary>
    /// steelgrade
    /// </summary>
    public string Steelgrade { get; set; }

    /// <summary>
    /// timestamp (yymmdd)
    /// </summary>
    public DateTime? TimeStamp { get; set; }

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
