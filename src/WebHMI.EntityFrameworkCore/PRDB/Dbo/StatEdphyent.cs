using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatEdphyent
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short? Aimslabthickness { get; set; }

    public short? Aimslabthicknesshead { get; set; }

    public short? Aimslabthicknesstail { get; set; }

    public short? Bendmodeflag { get; set; }

    public short? Casterline { get; set; }

    public short? Coillength { get; set; }

    public short? Flagcaster { get; set; }

    public short? Flagmixed { get; set; }

    public short? Furnaceno { get; set; }

    public short? Hentry { get; set; }

    public short? Hentryfm { get; set; }

    public short? Hexitcustomer { get; set; }

    public short? Heatid { get; set; }

    public short? Heatidl3 { get; set; }

    public short? Heatplanid { get; set; }

    public short? Heatpos { get; set; }

    public short? Lentryfm { get; set; }

    public short? Matpos { get; set; }

    public short? Maxslablength { get; set; }

    public short? Maxslabweight { get; set; }

    public short? Minslablength { get; set; }

    public short? Minslabweight { get; set; }

    public short? Nokallreason { get; set; }

    public short? Ok { get; set; }

    public short? Okall { get; set; }

    public short? Operationflag { get; set; }

    public short? Planid { get; set; }

    public short? Plateproduction { get; set; }

    public short? Sequenceid { get; set; }

    public short? Simmat { get; set; }

    public short? Slablength { get; set; }

    public short? Slabposthickchangeend { get; set; }

    public short? Slabposthickchangestart { get; set; }

    public short? Slabposwidthchangeend { get; set; }

    public short? Slabposwidthchangestart { get; set; }

    public short? Slabweight { get; set; }

    public short? Slabwidth { get; set; }

    public short? Slabwidthhead { get; set; }

    public short? Slabwidthtail { get; set; }

    public short? Steelcustomer { get; set; }

    public short? Tentry { get; set; }

    public short? Tentryfm { get; set; }

    public short? Weightspecific { get; set; }

    public short? Widthchange { get; set; }

    public short? Widthchangeflag { get; set; }

    public short? Widthchangesent { get; set; }

    public short? Widthexitcustomer { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
