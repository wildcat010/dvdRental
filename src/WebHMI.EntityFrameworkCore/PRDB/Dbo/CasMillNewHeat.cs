using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasMillNewHeat
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Aluminium (total)
    /// </summary>
    public float? AnalysisAl { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Aluminium (soluble)
    /// </summary>
    public float? AnalysisAls { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Arsenic
    /// </summary>
    public float? AnalysisAs { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Boron
    /// </summary>
    public float? AnalysisB { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Bismuth
    /// </summary>
    public float? AnalysisBi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Carbon
    /// </summary>
    public float? AnalysisC { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Calcium
    /// </summary>
    public float? AnalysisCa { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Cadmium
    /// </summary>
    public float? AnalysisCd { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Cerum
    /// </summary>
    public float? AnalysisCe { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Cobalt
    /// </summary>
    public float? AnalysisCo { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Chrome
    /// </summary>
    public float? AnalysisCr { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Copper
    /// </summary>
    public float? AnalysisCu { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Hydrogen
    /// </summary>
    public float? AnalysisH { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Magnesium
    /// </summary>
    public float? AnalysisMg { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Manganese
    /// </summary>
    public float? AnalysisMn { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Molybdaen
    /// </summary>
    public float? AnalysisMo { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Nitrogen
    /// </summary>
    public float? AnalysisN { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Niob
    /// </summary>
    public float? AnalysisNb { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Nickel
    /// </summary>
    public float? AnalysisNi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Oxygen
    /// </summary>
    public float? AnalysisO { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Phosphor
    /// </summary>
    public float? AnalysisP { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Lead
    /// </summary>
    public float? AnalysisPb { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Rhenium
    /// </summary>
    public float? AnalysisRe { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Sulfur
    /// </summary>
    public float? AnalysisS { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Antimon
    /// </summary>
    public float? AnalysisSb { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Selenium
    /// </summary>
    public float? AnalysisSe { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Silicon
    /// </summary>
    public float? AnalysisSi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Tin
    /// </summary>
    public float? AnalysisSn { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare1 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare2 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare3 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare4 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare5 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Tantalum
    /// </summary>
    public float? AnalysisTa { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Tellurium
    /// </summary>
    public float? AnalysisTe { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Titanium
    /// </summary>
    public float? AnalysisTi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Vanadium
    /// </summary>
    public float? AnalysisV { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Tungsten
    /// </summary>
    public float? AnalysisW { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Zink
    /// </summary>
    public float? AnalysisZn { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Zirkon
    /// </summary>
    public float? AnalysisZr { get; set; }

    /// <summary>
    /// heat identification
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// heatId same as from PDI
    /// </summary>
    public string HeatIdOld { get; set; }

    /// <summary>
    /// heatplanid
    /// </summary>
    public string HeatPlanId { get; set; }

    /// <summary>
    /// 1=heat start, 0=heat end
    /// </summary>
    public int? HeatStart { get; set; }

    /// <summary>
    /// treatment number of the heat
    /// </summary>
    public int? HeatTreatmentNo { get; set; }

    /// <summary>
    /// Unit[kg] end of heat cast send heat weight casted
    /// </summary>
    public float? HeatWeight { get; set; }

    /// <summary>
    /// Unit[m] (for heat start expected, for heat end measuredl) cast length
    /// </summary>
    public float? Length { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// Unit[m] start of mixed alloy area, position in the sequence (cast length
    /// </summary>
    public float? StartMixedArea { get; set; }

    /// <summary>
    /// Unit[m] start position of heat in cast
    /// </summary>
    public float? StartPosHeat { get; set; }

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
