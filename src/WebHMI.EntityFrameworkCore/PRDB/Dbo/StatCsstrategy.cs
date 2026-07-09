using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatCsstrategy
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short? Adaptationfm { get; set; }

    public short? AdaptationInd0 { get; set; }

    public short? AdaptationInd1 { get; set; }

    public short? Autosplinetemptransition { get; set; }

    public short? Autosplinevaluelowbot { get; set; }

    public short? Autosplinevaluelowtop { get; set; }

    public short? CoolratebotInd0 { get; set; }

    public short? CoolratebotInd1 { get; set; }

    public short? CoolratetopInd0 { get; set; }

    public short? CoolratetopInd1 { get; set; }

    public short? Coolingstrategy { get; set; }

    public short? Description { get; set; }

    public short? Ftzload { get; set; }

    public short? Holdtime { get; set; }

    public short? LeadingpyroindexInd0 { get; set; }

    public short? LeadingpyroindexInd1 { get; set; }

    public short? Manint { get; set; }

    public short? Planno { get; set; }

    public short? StartvalvenumberbotInd0 { get; set; }

    public short? StartvalvenumberbotInd1 { get; set; }

    public short? StartvalvenumbertopInd0 { get; set; }

    public short? StartvalvenumbertopInd1 { get; set; }

    public short? Targetf4tInd0 { get; set; }

    public short? Targetf4tInd1 { get; set; }

    public short? TargettempInd0 { get; set; }

    public short? TargettempInd1 { get; set; }

    public short? TempgradInd0 { get; set; }

    public short? TempgradInd1 { get; set; }

    public short? TempoffsetaInd0 { get; set; }

    public short? TempoffsetaInd1 { get; set; }

    public short? TempoffsetbInd0 { get; set; }

    public short? TempoffsetbInd1 { get; set; }

    public short? Tempoffsetfma { get; set; }

    public short? Tempoffsetfmb { get; set; }

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
