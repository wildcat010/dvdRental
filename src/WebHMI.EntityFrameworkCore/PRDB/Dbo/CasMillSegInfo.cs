using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasMillSegInfo
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0=top surface, 1=12,5%, 2=25%, 3=37,5% of thickness, 4=core
    /// </summary>
    public float? ActualTempInd0 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0=top surface, 1=12,5%, 2=25%, 3=37,5% of thickness, 4=core
    /// </summary>
    public float? ActualTempInd1 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0=top surface, 1=12,5%, 2=25%, 3=37,5% of thickness, 4=core
    /// </summary>
    public float? ActualTempInd2 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0=top surface, 1=12,5%, 2=25%, 3=37,5% of thickness, 4=core
    /// </summary>
    public float? ActualTempInd3 { get; set; }

    /// <summary>
    /// Unit[_C] Calculated average first 5m temperature at position: 0=top surface, 1=12,5%, 2=25%, 3=37,5% of thickness, 4=core
    /// </summary>
    public float? ActualTempInd4 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Al { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Als { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2As { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2B { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Bi { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2C { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Ca { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Cd { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Ce { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Co { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Cr { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Cu { get; set; }

    /// <summary>
    /// analysis2flag
    /// </summary>
    public int? Analysis2Flag { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2H { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Mg { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Mn { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Mo { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2N { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Nb { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Ni { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2O { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2P { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Pb { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Re { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2S { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Sb { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Se { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Si { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Sn { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Spare1 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Spare2 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Spare3 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Spare4 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Spare5 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Ta { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Te { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Ti { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2V { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2W { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Zn { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? Analysis2Zr { get; set; }

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
    /// Analysis flag ( 0=default analysis for the steel grade, 1=melt shop analysis, 2=caster analysis, 3=mixed analysis)
    /// </summary>
    public int? AnalysisFlag { get; set; }

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
    /// treatment number of the heat
    /// </summary>
    public int? HeatTreatmentNo { get; set; }

    /// <summary>
    /// heat concentration by intermix model
    /// </summary>
    public float? MixConcentrationFactor { get; set; }

    /// <summary>
    /// Unit[m] remaining length of the heat
    /// </summary>
    public float? RemainLength { get; set; }

    /// <summary>
    /// Unit[m] position in the sequence (cast length)
    /// </summary>
    public float? SeqPosition { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// sequence number (increments with every start cast)
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Unit[m/s] actual speed of strand at entry of the mill
    /// </summary>
    public float? Speed { get; set; }

    /// <summary>
    /// steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[m] caster exit thickness( cold at transfer to mill)
    /// </summary>
    public float? Thickness { get; set; }

    /// <summary>
    /// Unit[m] cold width
    /// </summary>
    public float? Width { get; set; }

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
