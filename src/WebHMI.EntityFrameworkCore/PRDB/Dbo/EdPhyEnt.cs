using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Edphyent
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public double? Aimslabthickness { get; set; }

    public double? Aimslabthicknesshead { get; set; }

    public double? Aimslabthicknesstail { get; set; }

    public int? Bendmodeflag { get; set; }

    public short? Casterline { get; set; }

    public double? Coillength { get; set; }

    public int? Flagcaster { get; set; }

    public int? Flagmixed { get; set; }

    public int? Furnaceno { get; set; }

    public double? Hentry { get; set; }

    public double? Hentryfm { get; set; }

    public double? Hexitcustomer { get; set; }

    public string Heatid { get; set; }

    public string Heatidl3 { get; set; }

    public string Heatplanid { get; set; }

    public int? Heatpos { get; set; }

    public double? Lentryfm { get; set; }

    public int? Matpos { get; set; }

    public double? Maxslablength { get; set; }

    public double? Maxslabweight { get; set; }

    public double? Minslablength { get; set; }

    public double? Minslabweight { get; set; }

    public string Nokallreason { get; set; }

    public int? Ok { get; set; }

    public int? Okall { get; set; }

    public int? Operationflag { get; set; }

    public string Planid { get; set; }

    public int? Plateproduction { get; set; }

    public string Sequenceid { get; set; }

    public int? Simmat { get; set; }

    public double? Slablength { get; set; }

    public double? Slabposthickchangeend { get; set; }

    public double? Slabposthickchangestart { get; set; }

    public double? Slabposwidthchangeend { get; set; }

    public double? Slabposwidthchangestart { get; set; }

    public double? Slabweight { get; set; }

    public double? Slabwidth { get; set; }

    public double? Slabwidthhead { get; set; }

    public double? Slabwidthtail { get; set; }

    public string Steelcustomer { get; set; }

    public double? Tentry { get; set; }

    public double? Tentryfm { get; set; }

    public double? Weightspecific { get; set; }

    public double? Widthchange { get; set; }

    public int? Widthchangeflag { get; set; }

    public short? Widthchangesent { get; set; }

    public double? Widthexitcustomer { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
