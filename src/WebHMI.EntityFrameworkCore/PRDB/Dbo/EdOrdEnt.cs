using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Edordent
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public double? Alloycompensation { get; set; }

    public short? Amountbindings { get; set; }

    public short? Amountbindingsr { get; set; }

    public double? Castspeed { get; set; }

    public double? Castspeedmin { get; set; }

    public int? Checkerflag { get; set; }

    public double? Checkerheight { get; set; }

    public double? Classmaxcrowndelta { get; set; }

    public double? Classmaxflatdeltaasym { get; set; }

    public double? Classmaxflatdeltasym { get; set; }

    public double? Classmaxwedgedelta { get; set; }

    public double? Classmincrowndelta { get; set; }

    public double? Classminflatdeltasym { get; set; }

    public double? Classminwedgedelta { get; set; }

    public double? Coiltemp { get; set; }

    public double? Coiltemplimitmaxcust { get; set; }

    public double? Coiltemplimitmincust { get; set; }

    public double? Coiltempmaxtol { get; set; }

    public double? Coiltempmintol { get; set; }

    public double? Coiltempprofilehead { get; set; }

    public double? Coiltempprofiletail { get; set; }

    public short? Coilerlocationselection { get; set; }

    public double? Coolexitf4t { get; set; }

    public int? Coolfineczoneload { get; set; }

    public double? Coolratebot { get; set; }

    public double? Coolratebot2 { get; set; }

    public double? Coolratebot3 { get; set; }

    public double? Coolratetop { get; set; }

    public double? Coolratetop2 { get; set; }

    public double? Coolratetop3 { get; set; }

    public int? Coolstrategy { get; set; }

    public short? Coolingstrategymodeselection { get; set; }

    public double? Cscoolrateredhighbot { get; set; }

    public double? Cscoolrateredhightop { get; set; }

    public double? Cscoolrateredlowbot { get; set; }

    public double? Cscoolrateredlowtop { get; set; }

    public int? Csfinecoolingzoneload { get; set; }

    public int? Csleadingpyrometerindex { get; set; }

    public int? Csleadingpyrometerindex2 { get; set; }

    public int? Csleadingpyrometerindex3 { get; set; }

    public int? Cssplineindexbot { get; set; }

    public int? Cssplineindextop { get; set; }

    public double? Cstransitiontemp { get; set; }

    public int? Csvalvesequenceindex { get; set; }

    public int? Destination { get; set; }

    public int? Dilatometercurve { get; set; }

    public double? Duration { get; set; }

    public double? Edgemask { get; set; }

    public double? Exitcrownc25 { get; set; }

    public short? Ferriticrollingmode { get; set; }

    public int? Firstinheat { get; set; }

    public int? Flagaltthick { get; set; }

    public int? Flagbatchrolling { get; set; }

    public short? Flagcompactcool { get; set; }

    public int? Flagdiamond { get; set; }

    public int? Flagdivide { get; set; }

    public int? Flagdualphase { get; set; }

    public int? Flagplateprod { get; set; }

    public int? Flagspeedreqcas { get; set; }

    public int? Flagstainless { get; set; }

    public double? Fmtemplimitmaxcust { get; set; }

    public double? Fmtemplimitmincust { get; set; }

    public double? Fractionfortransition { get; set; }

    public double? Hclassmaxaltdelta { get; set; }

    public double? Hclassmaxdelta { get; set; }

    public double? Hclassminaltdelta { get; set; }

    public double? Hclassmindelta { get; set; }

    public double? Hexit { get; set; }

    public double? Hexitalt { get; set; }

    public double? Hexitcus { get; set; }

    public double? Hintermediate { get; set; }

    public double? Hplatealt { get; set; }

    public double? Holdtemp { get; set; }

    public double? Holdtemp2 { get; set; }

    public double? Holdtime { get; set; }

    public double? Holdtime2 { get; set; }

    public int? Idriga { get; set; }

    public int? Idseq { get; set; }

    public int? Incspectionflag { get; set; }

    public int? Inspectioncode { get; set; }

    public double? Lengthorder { get; set; }

    public double? Lengthprofilehead { get; set; }

    public double? Lengthprofiletail { get; set; }

    public double? Lengthuncooledhead { get; set; }

    public double? Lengthuncooledtail { get; set; }

    public int? Ok { get; set; }

    public string Operationflag { get; set; }

    public string Orderno { get; set; }

    public string Parentactmecreator { get; set; }

    public int? Parentactmeid { get; set; }

    public short? Parentactmesid { get; set; }

    public short? Parentbasid { get; set; }

    public string Parentextid { get; set; }

    public string Parentmetyp { get; set; }

    public string Parentorimecreator { get; set; }

    public int? Parentorimeid { get; set; }

    public short? Parentorimesid { get; set; }

    public int? Partnum { get; set; }

    public double? Planneddivision { get; set; }

    public string Prodtype { get; set; }

    public string Productionorderid { get; set; }

    public double? Rmtargprofile { get; set; }

    public short? Startvalvebot { get; set; }

    public short? Startvalvebot2 { get; set; }

    public short? Startvalvebot3 { get; set; }

    public short? Startvalvetop { get; set; }

    public short? Startvalvetop2 { get; set; }

    public short? Startvalvetop3 { get; set; }

    public string Steelcus { get; set; }

    public double? Tclassmaxdelta { get; set; }

    public double? Tclassmindelta { get; set; }

    public double? Tcore { get; set; }

    public double? Tcsholdf4t { get; set; }

    public double? Tcsholdf4t2 { get; set; }

    public double? Texit { get; set; }

    public double? Texitcaster { get; set; }

    public double? TheadxInd00 { get; set; }

    public double? TheadxInd01 { get; set; }

    public double? TheadxInd02 { get; set; }

    public double? TheadxInd03 { get; set; }

    public double? TheadxInd04 { get; set; }

    public double? TheadxInd05 { get; set; }

    public double? TheadxInd06 { get; set; }

    public double? TheadxInd07 { get; set; }

    public double? TheadxInd08 { get; set; }

    public double? TheadxInd09 { get; set; }

    public double? TheadxInd10 { get; set; }

    public double? TheadxInd11 { get; set; }

    public double? TheadxInd12 { get; set; }

    public double? TheadxInd13 { get; set; }

    public double? TheadxInd14 { get; set; }

    public double? TheadxInd15 { get; set; }

    public double? TheadxInd16 { get; set; }

    public double? TheadxInd17 { get; set; }

    public double? TheadxInd18 { get; set; }

    public double? TheadxInd19 { get; set; }

    public double? TheadxInd20 { get; set; }

    public double? TposheadxInd00 { get; set; }

    public double? TposheadxInd01 { get; set; }

    public double? TposheadxInd02 { get; set; }

    public double? TposheadxInd03 { get; set; }

    public double? TposheadxInd04 { get; set; }

    public double? TposheadxInd05 { get; set; }

    public double? TposheadxInd06 { get; set; }

    public double? TposheadxInd07 { get; set; }

    public double? TposheadxInd08 { get; set; }

    public double? TposheadxInd09 { get; set; }

    public double? TposheadxInd10 { get; set; }

    public double? TposheadxInd11 { get; set; }

    public double? TposheadxInd12 { get; set; }

    public double? TposheadxInd13 { get; set; }

    public double? TposheadxInd14 { get; set; }

    public double? TposheadxInd15 { get; set; }

    public double? TposheadxInd16 { get; set; }

    public double? TposheadxInd17 { get; set; }

    public double? TposheadxInd18 { get; set; }

    public double? TposheadxInd19 { get; set; }

    public double? TposheadxInd20 { get; set; }

    public double? TposxInd00 { get; set; }

    public double? TposxInd01 { get; set; }

    public double? TposxInd02 { get; set; }

    public double? TposxInd03 { get; set; }

    public double? TposxInd04 { get; set; }

    public double? TposxInd05 { get; set; }

    public double? TposxInd06 { get; set; }

    public double? TposxInd07 { get; set; }

    public double? TposxInd08 { get; set; }

    public double? TposxInd09 { get; set; }

    public double? TposxInd10 { get; set; }

    public double? TposxInd11 { get; set; }

    public double? TposxInd12 { get; set; }

    public double? TposxInd13 { get; set; }

    public double? TposxInd14 { get; set; }

    public double? TposxInd15 { get; set; }

    public double? TposxInd16 { get; set; }

    public double? TposxInd17 { get; set; }

    public double? TposxInd18 { get; set; }

    public double? TposxInd19 { get; set; }

    public double? TposxInd20 { get; set; }

    public double? Tslab { get; set; }

    public double? Ttemperaturefeend { get; set; }

    public double? Ttemperaturefestart { get; set; }

    public double? TxInd00 { get; set; }

    public double? TxInd01 { get; set; }

    public double? TxInd02 { get; set; }

    public double? TxInd03 { get; set; }

    public double? TxInd04 { get; set; }

    public double? TxInd05 { get; set; }

    public double? TxInd06 { get; set; }

    public double? TxInd07 { get; set; }

    public double? TxInd08 { get; set; }

    public double? TxInd09 { get; set; }

    public double? TxInd10 { get; set; }

    public double? TxInd11 { get; set; }

    public double? TxInd12 { get; set; }

    public double? TxInd13 { get; set; }

    public double? TxInd14 { get; set; }

    public double? TxInd15 { get; set; }

    public double? TxInd16 { get; set; }

    public double? TxInd17 { get; set; }

    public double? TxInd18 { get; set; }

    public double? TxInd19 { get; set; }

    public double? TxInd20 { get; set; }

    public double? Targetflatness { get; set; }

    public double? Tempbehindcompcool { get; set; }

    public double? Tempcrit { get; set; }

    public double? Tempgrad { get; set; }

    public double? Thicklimitmaxcust { get; set; }

    public double? Thicklimitmincust { get; set; }

    public double? Wclassmaxdelta { get; set; }

    public double? Wclassmindelta { get; set; }

    public double? Widthentryfm { get; set; }

    public double? Widthexit { get; set; }

    public double? Widthexitcus { get; set; }

    public double? Widthlimitmaxcust { get; set; }

    public double? Widthlimitmincust { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
