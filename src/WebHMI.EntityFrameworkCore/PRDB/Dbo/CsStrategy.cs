using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csstrategy
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short? Adaptationfm { get; set; }

    public short? AdaptationInd0 { get; set; }

    public short? AdaptationInd1 { get; set; }

    public double? Autosplinetemptransition { get; set; }

    public double? Autosplinevaluelowbot { get; set; }

    public double? Autosplinevaluelowtop { get; set; }

    public double? CoolratebotInd0 { get; set; }

    public double? CoolratebotInd1 { get; set; }

    public double? CoolratetopInd0 { get; set; }

    public double? CoolratetopInd1 { get; set; }

    public int? Coolingstrategy { get; set; }

    public string Description { get; set; }

    public double? Ftzload { get; set; }

    public double? Holdtime { get; set; }

    public short? LeadingpyroindexInd0 { get; set; }

    public short? LeadingpyroindexInd1 { get; set; }

    public short? Manint { get; set; }

    public int? Planno { get; set; }

    public short? StartvalvenumberbotInd0 { get; set; }

    public short? StartvalvenumberbotInd1 { get; set; }

    public short? StartvalvenumbertopInd0 { get; set; }

    public short? StartvalvenumbertopInd1 { get; set; }

    public double? Targetf4tInd0 { get; set; }

    public double? Targetf4tInd1 { get; set; }

    public double? TargettempInd0 { get; set; }

    public double? TargettempInd1 { get; set; }

    public double? TempgradInd0 { get; set; }

    public double? TempgradInd1 { get; set; }

    public double? TempoffsetaInd0 { get; set; }

    public double? TempoffsetaInd1 { get; set; }

    public double? TempoffsetbInd0 { get; set; }

    public double? TempoffsetbInd1 { get; set; }

    public double? Tempoffsetfma { get; set; }

    public double? Tempoffsetfmb { get; set; }

    public string Toextid { get; set; }

    public short? UsetempgradselectionInd0 { get; set; }

    public short? UsetempgradselectionInd1 { get; set; }

    public short? ValveratiobotInd0 { get; set; }

    public short? ValveratiobotInd1 { get; set; }

    public short? ValveratiotopInd0 { get; set; }

    public short? ValveratiotopInd1 { get; set; }

    public short? Valvesequenceindexcus { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
