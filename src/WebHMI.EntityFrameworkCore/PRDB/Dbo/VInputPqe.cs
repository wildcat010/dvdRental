using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class VInputPqe
{
    public string Extid { get; set; }

    public string SlabId { get; set; }

    public int? Flagbatchrolling { get; set; }

    public string Alloycode { get; set; }

    public string Aimheatid { get; set; }

    public string Heatid1 { get; set; }

    public string Sequenceid { get; set; }

    public DateTime? Prodstart { get; set; }

    public DateTime? Prodend { get; set; }

    public int? Duration { get; set; }

    public float? Wentryhrm { get; set; }

    public float? Weight { get; set; }

    public float? Wexithrmaver { get; set; }

    public float? Wexit { get; set; }

    public float? Wexitmin { get; set; }

    public float? Wexitmax { get; set; }

    public float? Hentryhrm { get; set; }

    public float? Hexithrmaver { get; set; }

    public float? Hexit { get; set; }

    public float? Hexitmin { get; set; }

    public float? Hexitmax { get; set; }

    public float? Hexitcustomer { get; set; }

    public float? Orderlengthx { get; set; }

    public float? Coillength { get; set; }

    public float? Widthexitcustomer { get; set; }

    public short? Coilno { get; set; }

    public int? Bendfmflag { get; set; }

    public short Basid { get; set; }

    public float? Slabweight { get; set; }

    public float? DWeight { get; set; }

    public float? Exitheadlength { get; set; }

    public int Meid { get; set; }

    public int Productmode { get; set; }

    public short? Seqfstlst { get; set; }

    public float? Cstemp { get; set; }

    public float? Fmtemp { get; set; }

    public float? Yieldstress { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public float? Profilex { get; set; }

    public float? Lengthwedge { get; set; }

    public float? Csuncheadlength { get; set; }

    public float? Csunctaillength { get; set; }

    public float? Csprofheadlength { get; set; }

    public float? Csproftaillength { get; set; }

    public float? Profexcalc { get; set; }

    public float? Vexitlas { get; set; }

    public short? Threadinflag { get; set; }

    public int? Isflyinggauge { get; set; }

    public short? Isbendingauto { get; set; }

    public short? Isshiftingauto { get; set; }

    public short? Mivsprofile { get; set; }

    public short? Mivsflatness { get; set; }

    public int? Plateproduction { get; set; }

    public int? Simmat { get; set; }

    public short? Chemistrychange { get; set; }

    public short? Contourprecondition { get; set; }

    public int? Coolwaterlim { get; set; }

    public short? Cstargdiff { get; set; }

    public int? Forcelimit { get; set; }

    public float? Opspeed { get; set; }

    public int? Speedlimitreached { get; set; }

    public short? Taperedslab { get; set; }

    public float? Vcast { get; set; }
}
