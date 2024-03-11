using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class EntryProfileMeasuring
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    /// <summary>
    /// scan number
    /// </summary>
    public short ScanNo { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 0. Order
    /// </summary>
    public float? Coeff0 { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 1. Order
    /// </summary>
    public float? Coeff1 { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 2. Order
    /// </summary>
    public float? Coeff2 { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 3. Order
    /// </summary>
    public float? Coeff3 { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 4. Order
    /// </summary>
    public float? Coeff4 { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 5. Order
    /// </summary>
    public float? Coeff5 { get; set; }

    /// <summary>
    /// Unit[m] polynom: coefficient 6. Order
    /// </summary>
    public float? Coeff6 { get; set; }

    /// <summary>
    /// conversion factor cold/warm
    /// </summary>
    public float? ConvFact { get; set; }

    /// <summary>
    /// correlation coefficient
    /// </summary>
    public float? CorrCoeff { get; set; }

    /// <summary>
    /// disturbances (according to radiometrie)
    /// </summary>
    public int? Disturbances { get; set; }

    /// <summary>
    /// Unit[m] strip edge distance I
    /// </summary>
    public float? EdgeDis1 { get; set; }

    /// <summary>
    /// Unit[m] strip edge distance II
    /// </summary>
    public float? EdgeDis2 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd0 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd1 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd10 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd11 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd12 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd13 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd14 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd15 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd16 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd17 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd18 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd19 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd2 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd20 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd21 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd22 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd23 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd24 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd25 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd26 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd27 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd28 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd29 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd3 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd30 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd31 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd32 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd33 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd34 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd35 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd36 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd37 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd38 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd39 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd4 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd40 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd41 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd42 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd43 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd44 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd45 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd46 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd47 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd48 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd49 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd5 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd50 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd51 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd52 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd53 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd54 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd55 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd56 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd57 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd58 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd59 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd6 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd60 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd61 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd62 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd63 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd64 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd65 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd66 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd67 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd68 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd69 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd7 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd70 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd71 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd72 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd73 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd74 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd75 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd76 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd77 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd78 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd79 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd8 { get; set; }

    /// <summary>
    /// Unit[m] distance from strip edge
    /// </summary>
    public float? EdgeDisInd9 { get; set; }

    /// <summary>
    /// Unit[m] 1st parameter for edge drop
    /// </summary>
    public float? EdgeDrop1Par { get; set; }

    /// <summary>
    /// Unit[m] 2nd parameter for edge drop
    /// </summary>
    public float? EdgeDrop2Par { get; set; }

    /// <summary>
    /// Unit[m] edge drop DS
    /// </summary>
    public float? EdgeDropDs { get; set; }

    /// <summary>
    /// Unit[m] edge drop OS
    /// </summary>
    public float? EdgeDropOs { get; set; }

    /// <summary>
    /// Unit[m] parameter deleted edge drop
    /// </summary>
    public float? EdgeDropParDel { get; set; }

    /// <summary>
    /// Unit[m] absolute length start scan
    /// </summary>
    public float? LengthStartScan { get; set; }

    /// <summary>
    /// Unit[m] absolute length stop scan
    /// </summary>
    public float? LengthStopScan { get; set; }

    /// <summary>
    /// material identifier (steel make)
    /// </summary>
    public int? MaterialIdent { get; set; }

    /// <summary>
    /// Unit[m] normed width for calculation
    /// </summary>
    public float? NormWidthCalc { get; set; }

    /// <summary>
    /// Unit[m] profile - strip edge distance I
    /// </summary>
    public float? ProfileEdgeDis1 { get; set; }

    /// <summary>
    /// Unit[m] profile - strip edge distance II
    /// </summary>
    public float? ProfileEdgeDis2 { get; set; }

    /// <summary>
    /// profile polynom gradient
    /// </summary>
    public short? ProfileGrad { get; set; }

    /// <summary>
    /// Unit[s] profile scan time
    /// </summary>
    public float? ProfileScanTime { get; set; }

    /// <summary>
    /// system status bits (according to radiometrie)
    /// </summary>
    public int? SystemStatus { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd0 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd1 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd10 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd11 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd12 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd13 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd14 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd15 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd16 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd17 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd18 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd19 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd2 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd20 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd21 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd22 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd23 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd24 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd25 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd26 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd27 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd28 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd29 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd3 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd30 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd31 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd32 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd33 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd34 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd35 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd36 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd37 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd38 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd39 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd4 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd40 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd41 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd42 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd43 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd44 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd45 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd46 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd47 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd48 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd49 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd5 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd50 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd51 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd52 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd53 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd54 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd55 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd56 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd57 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd58 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd59 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd6 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd60 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd61 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd62 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd63 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd64 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd65 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd66 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd67 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd68 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd69 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd7 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd70 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd71 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd72 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd73 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd74 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd75 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd76 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd77 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd78 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd79 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd8 { get; set; }

    /// <summary>
    /// Unit[Cel] temperature (from scanner)
    /// </summary>
    public float? TempInd9 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd0 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd1 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd10 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd11 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd12 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd13 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd14 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd15 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd16 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd17 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd18 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd19 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd2 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd20 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd21 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd22 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd23 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd24 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd25 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd26 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd27 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd28 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd29 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd3 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd30 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd31 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd32 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd33 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd34 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd35 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd36 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd37 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd38 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd39 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd4 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd40 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd41 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd42 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd43 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd44 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd45 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd46 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd47 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd48 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd49 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd5 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd50 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd51 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd52 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd53 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd54 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd55 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd56 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd57 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd58 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd59 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd6 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd60 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd61 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd62 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd63 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd64 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd65 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd66 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd67 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd68 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd69 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd7 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd70 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd71 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd72 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd73 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd74 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd75 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd76 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd77 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd78 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd79 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd8 { get; set; }

    /// <summary>
    /// Unit[m] thickness
    /// </summary>
    public float? ThicknessInd9 { get; set; }

    /// <summary>
    /// Unit[m] used width for calculation
    /// </summary>
    public float? UseWidthCalc { get; set; }

    /// <summary>
    /// warnings (according to radiometrie)
    /// </summary>
    public int? Warnings { get; set; }

    /// <summary>
    /// Unit[m] wedge - strip edge distance I
    /// </summary>
    public float? WedgeEdgeDis1 { get; set; }

    /// <summary>
    /// Unit[m] wedge - strip edge distance II
    /// </summary>
    public float? WedgeEdgeDis2 { get; set; }

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

    public virtual Me1 Me1 { get; set; }
}
