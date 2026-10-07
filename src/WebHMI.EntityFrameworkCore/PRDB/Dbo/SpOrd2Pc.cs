using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class SpOrd2Pc
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
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// thick head flag (in HSM =0)
    /// </summary>
    public short ThickHead { get; set; }

    /// <summary>
    /// Reference Linear Coefficient Coiler
    /// </summary>
    public double? WFgLiCoefC { get; set; }

    /// <summary>
    /// Reference Linear Coefficient Head
    /// </summary>
    public double? WFgLiCoefH { get; set; }

    /// <summary>
    /// Reference Square Coefficient Coiler
    /// </summary>
    public double? WFgSqCoefC { get; set; }

    /// <summary>
    /// Reference Square Coefficient Head
    /// </summary>
    public double? WFgSqCoefH { get; set; }

    /// <summary>
    /// 1 = absolut cut at end of material (limitation)
    /// </summary>
    public short? AbsCutInfo { get; set; }

    /// <summary>
    /// Unit[m/s2] power speed down for strip tail
    /// </summary>
    public double? AccRateSdtail { get; set; }

    /// <summary>
    /// Bending mode (00=FM,=HRM)
    /// </summary>
    public short? BendMode { get; set; }

    /// <summary>
    /// 0 = normal strip or plate,   1 = checker strip or plate
    /// </summary>
    public int? CheckerFlag { get; set; }

    /// <summary>
    /// Unit[m] Checker height
    /// </summary>
    public double? CheckerHeight { get; set; }

    /// <summary>
    /// Unit[%] CS:  percentage of autenite
    /// </summary>
    public double? CsAustenite { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd00 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd01 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd02 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd03 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd04 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd05 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd06 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd07 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd08 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd09 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd10 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd11 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd12 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd13 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd14 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd15 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd16 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd17 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd18 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd19 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd20 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd21 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd22 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd23 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd24 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd25 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd26 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd27 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd28 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd29 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd30 { get; set; }

    /// <summary>
    /// CS: bottom valve volume flow (0/1)
    /// </summary>
    public short? CsBotValveInd31 { get; set; }

    /// <summary>
    /// Unit[%] CS:  percentage of cementite
    /// </summary>
    public double? CsCementite { get; set; }

    /// <summary>
    /// Unit[C] CS: calculated coiler temperature
    /// </summary>
    public double? CsCoilTempCalc { get; set; }

    /// <summary>
    /// CS: coil setpoint temperature
    /// </summary>
    public double? CsCoilTempSetp { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd00 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd01 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd02 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd03 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd04 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd05 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd06 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd07 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd08 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd09 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd10 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd11 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd12 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd13 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd14 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd15 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd16 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd17 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd18 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd19 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd20 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd21 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd22 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd23 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd24 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd25 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd26 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd27 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd28 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd29 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd30 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd31 { get; set; }

    /// <summary>
    /// Unit[%] CS: percentage of ferrite
    /// </summary>
    public double? CsFerrite { get; set; }

    /// <summary>
    /// Unit[%] CS:  percentage of perlite
    /// </summary>
    public double? CsPerlite { get; set; }

    /// <summary>
    /// Unit[m] CS: profile head length
    /// </summary>
    public double? CsProfHeadLength { get; set; }

    /// <summary>
    /// Unit[_C] CS: profile head temperature
    /// </summary>
    public double? CsProfHeadTemp { get; set; }

    /// <summary>
    /// Unit[m] CS:profile tail length
    /// </summary>
    public double? CsProfTailLength { get; set; }

    /// <summary>
    /// Unit[_C] CS: profile tail temperature
    /// </summary>
    public double? CsProfTailTemp { get; set; }

    /// <summary>
    /// CS: roller table mode: 0 - auto, 1 - manual
    /// </summary>
    public double? CsRollerTableMode { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd00 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd01 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd02 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd03 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd04 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd05 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd06 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd07 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd08 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd09 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd10 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd11 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd12 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd13 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd14 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd15 { get; set; }

    /// <summary>
    /// CS: error code from MOS-CS
    /// </summary>
    public short? CsSbaz { get; set; }

    /// <summary>
    /// CS: correction offset for coiling temperature
    /// </summary>
    public double? CsTempOffsetInd0 { get; set; }

    /// <summary>
    /// CS: correction offset for coiling temperature
    /// </summary>
    public double? CsTempOffsetInd1 { get; set; }

    /// <summary>
    /// CS: correction offset for coiling temperature
    /// </summary>
    public double? CsTempOffsetInd2 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd00 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd01 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd02 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd03 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd04 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd05 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd06 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd07 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd08 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd09 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd10 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd11 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd12 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd13 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd14 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd15 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd16 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd17 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd18 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd19 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd20 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd21 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd22 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd23 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd24 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd25 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd26 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd27 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd28 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd29 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd30 { get; set; }

    /// <summary>
    /// CS: top valve volume flow (0/1)
    /// </summary>
    public short? CsTopValveInd31 { get; set; }

    /// <summary>
    /// Unit[m] CS uncooled head length
    /// </summary>
    public double? CsUncHeadLength { get; set; }

    /// <summary>
    /// Unit[m] CS uncooled tail length
    /// </summary>
    public double? CsUncTailLength { get; set; }

    /// <summary>
    /// Unit[m] cut length counted from actual material head, related to material thickness at shear position
    /// </summary>
    public double? CutLen { get; set; }

    /// <summary>
    /// 0: cut at end of order, 1: no cut at end of order , 3:  cut according to length (cutValue), 10: cut at the end of the material
    /// </summary>
    public short? CutRule { get; set; }

    /// <summary>
    /// shear for cut, 1: pendulum shear, 2: rotary shear, 3:  flying shear
    /// </summary>
    public int? CutShearId { get; set; }

    /// <summary>
    /// flatness controll 1LAS/PR_1LAS
    /// </summary>
    public double? DPrXdFb1Las1 { get; set; }

    /// <summary>
    /// spare
    /// </summary>
    public double? DPrXdFb1Las2 { get; set; }

    /// <summary>
    /// flatness controll 2LAS/PR_2LAS
    /// </summary>
    public double? DPrXdFb2Las1 { get; set; }

    /// <summary>
    /// flatness controll 3LAS/PR_2LAS
    /// </summary>
    public double? DPrXdFb2Las2 { get; set; }

    /// <summary>
    /// flatness controll 3LAS/PR_3LAS
    /// </summary>
    public double? DPrXdFb3Las1 { get; set; }

    /// <summary>
    /// flatness controll 4LAS/PR_4LAS
    /// </summary>
    public double? DPrXdFb3Las2 { get; set; }

    /// <summary>
    /// flatness controll 4LAS/PR_4LAS
    /// </summary>
    public double? DPrXdFb4Las1 { get; set; }

    /// <summary>
    /// flatness controll 5LAS/PR_4LAS
    /// </summary>
    public double? DPrXdFb4Las2 { get; set; }

    /// <summary>
    /// flatness controll 5LAS/PR_5LAS
    /// </summary>
    public double? DPrXdFb5Las1 { get; set; }

    /// <summary>
    /// flatness controll 6LAS/PR_5LAS
    /// </summary>
    public double? DPrXdFb5Las2 { get; set; }

    /// <summary>
    /// flatness controll 6LAS/PR_6LAS
    /// </summary>
    public double? DPrXdFb6Las1 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_6LAS
    /// </summary>
    public double? DPrXdFb6Las2 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_7LAS
    /// </summary>
    public double? DPrXdFb7Las1 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_6LAS
    /// </summary>
    public double? DPrXdFb7Las2 { get; set; }

    /// <summary>
    /// Unit[m/s] poportional speed change (TC)
    /// </summary>
    public double? DSpeedProp { get; set; }

    /// <summary>
    /// Coiler: density at coiling temperature
    /// </summary>
    public double? DensTcoiler { get; set; }

    /// <summary>
    /// secondary descaler: entry top and bottom off/on (0/1)
    /// </summary>
    public short? DescEntryHfm { get; set; }

    /// <summary>
    /// primary descaler HRM: entry top and bottom off/on (0/1)
    /// </summary>
    public short? DescEntryHrm { get; set; }

    /// <summary>
    /// secondary descaler: exit top and bottom off/on (0/1)
    /// </summary>
    public short? DescExitHfm { get; set; }

    /// <summary>
    /// primary descaler HRM: exit top and bottom off/on (0/1)
    /// </summary>
    public short? DescExitHrm { get; set; }

    /// <summary>
    /// Unit[m] strip edge distance I
    /// </summary>
    public double? DistanceE1 { get; set; }

    /// <summary>
    /// Unit[m] strip edge distance II
    /// </summary>
    public double? DistanceE2 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd00 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd01 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd02 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd03 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd04 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd05 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd06 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd07 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd08 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd09 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd10 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd11 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd12 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmtailInd13 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd00 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd01 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd02 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd03 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd04 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd05 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd06 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd07 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd08 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd09 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd10 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd11 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd12 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhfmInd13 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd00 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd01 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd02 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd03 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd04 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd05 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd06 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd07 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd08 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd09 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd10 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd11 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd12 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmtailInd13 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd00 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd01 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd02 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd03 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd04 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd05 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd06 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd07 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd08 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd09 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd10 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd11 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd12 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public double? DtIhhrmInd13 { get; set; }

    /// <summary>
    /// enco panel 1 (0 - open, 1- closed)
    /// </summary>
    public short? EncoPanel1 { get; set; }

    /// <summary>
    /// enco panel 2 (0 - open, 1- closed)
    /// </summary>
    public short? EncoPanel2 { get; set; }

    /// <summary>
    /// enco panel 3 (0 - open, 1- closed)
    /// </summary>
    public short? EncoPanel3 { get; set; }

    /// <summary>
    /// enco panel 4 (0 - open, 1- closed)
    /// </summary>
    public short? EncoPanel4 { get; set; }

    public short? FccCoolBlocked { get; set; }

    /// <summary>
    /// flatness curve number default=0
    /// </summary>
    public short? FlatCurveNr { get; set; }

    public short? FlcAsymBlocked { get; set; }

    public short? FlcSymBlocked { get; set; }

    /// <summary>
    /// Unit[%/m] secondary descaler: entry top and bottom flow
    /// </summary>
    public double? FlowDescEntryHfm { get; set; }

    /// <summary>
    /// Unit[%/m] primary descaler HRM: entry top and bottom flow
    /// </summary>
    public double? FlowDescEntryHrm { get; set; }

    /// <summary>
    /// Unit[%/m] secondary descaler: exit top and bottom flow
    /// </summary>
    public double? FlowDescExitHfm { get; set; }

    /// <summary>
    /// Unit[%/m] primary descaler HRM: exit top and bottom flow
    /// </summary>
    public double? FlowDescExitHrm { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference entry bottom
    /// </summary>
    public double? FlowPcEntryB { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference entry top
    /// </summary>
    public double? FlowPcEntryT { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference exit bottom
    /// </summary>
    public double? FlowPcExitB { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference exit top
    /// </summary>
    public double? FlowPcExitT { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry flying shear
    /// </summary>
    public double? FrPrenFs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry inductive heating furnace
    /// </summary>
    public double? FrPrenIh { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry pendulum shear
    /// </summary>
    public double? FrPrenPs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry rotary shear
    /// </summary>
    public double? FrPrenRs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit flying shear
    /// </summary>
    public double? FrPrexFs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit inductive heating furnace
    /// </summary>
    public double? FrPrexIh { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit pendulum shear
    /// </summary>
    public double? FrPrexPs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit rotary shear
    /// </summary>
    public double? FrPrexRs { get; set; }

    /// <summary>
    /// Unit[N/m2] tension reel/coiler: specific tension
    /// </summary>
    public double? FtCoiler { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry flying shear
    /// </summary>
    public double? FtPrenFs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry inductive heating furnace
    /// </summary>
    public double? FtPrenIh { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry pendulum shear
    /// </summary>
    public double? FtPrenPs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry rotary shear
    /// </summary>
    public double? FtPrenRs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit flying shear
    /// </summary>
    public double? FtPrexFs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit inductive heating furnace
    /// </summary>
    public double? FtPrexIh { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit pendulum shear
    /// </summary>
    public double? FtPrexPs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit rotary shear
    /// </summary>
    public double? FtPrexRs { get; set; }

    /// <summary>
    /// Unit[m] cast slab thickness (hot)
    /// </summary>
    public double? HCast { get; set; }

    /// <summary>
    /// Unit[m] cast slab thickness cold
    /// </summary>
    public double? HCastCold { get; set; }

    /// <summary>
    /// Unit[m] tension reel/coiler: strip thickness (hot)
    /// </summary>
    public double? HCoiler { get; set; }

    /// <summary>
    /// Unit[m] entry thickness (rough strip thickness cold)
    /// </summary>
    public double? HEntryColdFm { get; set; }

    /// <summary>
    /// Unit[m] entry thickness (rough strip thickness hot)
    /// </summary>
    public double? HEntryFm { get; set; }

    /// <summary>
    /// Unit[m] strip thickness cold
    /// </summary>
    public double? HExitCold { get; set; }

    /// <summary>
    /// Unit[_C] ih total power
    /// </summary>
    public double? IHtotalPower { get; set; }

    /// <summary>
    /// Unit[_C] Required  Induction Heater exit temperature to reach HFM exit Temperature
    /// </summary>
    public double? IHtExit { get; set; }

    /// <summary>
    /// Flag for inheritance, 0 = Long time, 2 = short time exact, 3 = short time similar
    /// </summary>
    public int? InherPfc { get; set; }

    /// <summary>
    /// Material Id from short time inheritance
    /// </summary>
    public string InherPfcId { get; set; }

    /// <summary>
    /// Unit[m] slab length hot
    /// </summary>
    public double? LEntryHot { get; set; }

    /// <summary>
    /// Unit[m] length after FM
    /// </summary>
    public double? LExit { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd0 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd1 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd2 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd3 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd4 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd5 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd6 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd7 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd8 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public double? LPointRefInd9 { get; set; }

    /// <summary>
    /// Unit[m] roughed strip length (ONLY FOR SIMULATION!!!)
    /// </summary>
    public double? LRoughedStrip { get; set; }

    /// <summary>
    /// Unit[m] length of the wedge (slab related)
    /// </summary>
    public double? LWedge { get; set; }

    /// <summary>
    /// Unit[m] length of the wedge  HRM (slab related)
    /// </summary>
    public double? LWedgeHrm { get; set; }

    /// <summary>
    /// Unit[m] length of transfer bar with acceleration
    /// </summary>
    public double? LenTrBarAccel { get; set; }

    /// <summary>
    /// Unit[m] length of transfer bar with which the speed up starts
    /// </summary>
    public double? Length2Spup { get; set; }

    /// <summary>
    /// Unit[%] mandrel expansion factor  0-1
    /// </summary>
    public double? MandrelExpFac { get; set; }

    /// <summary>
    /// Unit[m/s] minimum speed caster (for next material enter FM)
    /// </summary>
    public double? MinSpeedCas { get; set; }

    /// <summary>
    /// first active stand number
    /// </summary>
    public short? NoFas { get; set; }

    /// <summary>
    /// first active stand number HFM
    /// </summary>
    public short? NoFasHfm { get; set; }

    /// <summary>
    /// last active stand number
    /// </summary>
    public short? NoLas { get; set; }

    /// <summary>
    /// last active stand number HRM
    /// </summary>
    public short? NoLasHrm { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd00 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd01 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd02 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd03 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd04 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd05 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd06 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd07 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd08 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd09 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd10 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd11 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd12 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmtailInd13 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd00 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd01 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd02 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd03 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd04 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd05 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd06 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd07 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd08 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd09 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd10 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd11 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd12 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhfmInd13 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd00 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd01 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd02 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd03 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd04 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd05 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd06 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd07 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd08 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd09 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd10 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd11 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd12 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public double? PIhhrmtailInd13 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd00 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd01 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd02 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd03 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd04 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd05 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd06 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd07 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd08 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd09 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd10 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd11 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd12 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public double? PIhhrmInd13 { get; set; }

    /// <summary>
    /// Unit[m/s2] power speed up value
    /// </summary>
    public double? PSuValue { get; set; }

    /// <summary>
    /// Unit[m] strip position for speed change end 1
    /// </summary>
    public double? PosSpeedChangeEnd2 { get; set; }

    /// <summary>
    /// Unit[m] calculated exit profile
    /// </summary>
    public double? Profexcalc { get; set; }

    /// <summary>
    /// Unit[m] calculated(measured) profile of HRM
    /// </summary>
    public double? ProfexcalcHrm { get; set; }

    /// <summary>
    /// Unit[m] PFC target profile of HRM
    /// </summary>
    public double? ProfextargetHrm { get; set; }

    /// <summary>
    /// Unit[m] strip profile
    /// </summary>
    public double? ProfileX { get; set; }

    /// <summary>
    /// error code from MOS-FM
    /// </summary>
    public int? Sbaz { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry flying shear
    /// </summary>
    public double? SdPrenFs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry flying shear
    /// </summary>
    public double? SdPrenIh { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry pendulum shear
    /// </summary>
    public double? SdPrenPs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry rotary shear
    /// </summary>
    public double? SdPrenRs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit flying shear
    /// </summary>
    public double? SdPrexFs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit flying shear
    /// </summary>
    public double? SdPrexIh { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit pendulum shear
    /// </summary>
    public double? SdPrexPs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit rotary shear
    /// </summary>
    public double? SdPrexRs { get; set; }

    /// <summary>
    /// induction heater sensitivity dTihx/dVentry  to keep HFM exit temp constant
    /// </summary>
    public double? SensIhdTdV { get; set; }

    /// <summary>
    /// Flag setpoints coiler ok: 1=setpoints are ok
    /// </summary>
    public short? SetpointsCocOk { get; set; }

    /// <summary>
    /// Flag: 1=setpoints from MOS-CS are o.k., -1: last calculation not o.k., but setpoints available, -2: all calculations not o.k., no setpoints available
    /// </summary>
    public short? SetpointsCsOk { get; set; }

    /// <summary>
    /// Flag: 1=setpoints from MOS-FM are o.k., -1: last calculation not o.k., but setpoints available, -2: all calculations not o.k., no setpoints available
    /// </summary>
    public short? SetpointsFmOk { get; set; }

    /// <summary>
    /// Flag: 1=setpoints from MOS-HRM are o.k., -1: last calculation not o.k., but setpoints available, -2: all calculations not o.k., no setpoints available
    /// </summary>
    public short? SetpointsHrmOk { get; set; }

    /// <summary>
    /// Flag: 1=setpoints process area2 are o.k.
    /// </summary>
    public short? SetpointsPc2Ok { get; set; }

    /// <summary>
    /// Flag: 1=setpoints from SST (process area 2) are o.k.
    /// </summary>
    public short? SetpointsSstPc2Ok { get; set; }

    /// <summary>
    /// Unit[m/s2] Speed up rate for speed change 1 (after tail cut)
    /// </summary>
    public double? SpeedChangeRate1 { get; set; }

    /// <summary>
    /// Unit[m/s2] Speed up rate for speed change 2
    /// </summary>
    public double? SpeedChangeRate2 { get; set; }

    /// <summary>
    /// flag for speedup start selection:0=no speedup, 1=speedup with LAS loaded, 2=speedup with coiler loaded, 4 =speedup with time
    /// </summary>
    public short? SpeedupFlag { get; set; }

    /// <summary>
    /// Unit[s] time after which the speedup starts
    /// </summary>
    public double? SpeedupTime { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-CS
    /// </summary>
    public string SptlFaultCs { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-FM
    /// </summary>
    public string SptlFaultHfm { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-RM
    /// </summary>
    public string SptlFaultHrm { get; set; }

    /// <summary>
    /// standNo, from which speed down is driven
    /// </summary>
    public double? StandNoStartSpeedDown { get; set; }

    /// <summary>
    /// Unit[m] Starting point of wedge,given as distance from tail end of the slab
    /// </summary>
    public double? StartWedge { get; set; }

    /// <summary>
    /// Unit[m] Starting point of wedge HRM,given as distance from tail end of the slab
    /// </summary>
    public double? StartWedgeHrm { get; set; }

    /// <summary>
    /// Unit[_C] strip temperature (exit finishing mill)
    /// </summary>
    public double? T { get; set; }

    /// <summary>
    /// Unit[_C] entry temperature under measuring house
    /// </summary>
    public double? T0Mh { get; set; }

    /// <summary>
    /// Unit[_C] temperature measuring house behind HRM
    /// </summary>
    public double? T0MhHrm { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd0 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd1 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd2 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd3 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd4 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd5 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd6 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd7 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd8 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public double? TAtLengthInd9 { get; set; }

    /// <summary>
    /// Unit[_C] entry transfer bar temperature (roughing mill exit temperature)
    /// </summary>
    public double? TEntry { get; set; }

    /// <summary>
    /// Unit[_C] slab entry temperature  (from MOS-RM for IVI-FM)
    /// </summary>
    public double? TEntryFrRm { get; set; }

    /// <summary>
    /// Unit[_C] surface temperature at exit of inductive heater
    /// </summary>
    public double? TIhhfmx { get; set; }

    /// <summary>
    /// Unit[_C] surface temperature at exit of inductive heater for tail end
    /// </summary>
    public double? TIhhfmxtail { get; set; }

    /// <summary>
    /// Unit[_C] surface temperature at exit of inductive heater
    /// </summary>
    public double? TIhhrmx { get; set; }

    /// <summary>
    /// Unit[_C] surface temperature at exit of inductive heater for tail end
    /// </summary>
    public double? TIhhrmxtail { get; set; }

    /// <summary>
    /// Unit[m/s2] temperature speed up value
    /// </summary>
    public double? TSuValue { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd00 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd01 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd02 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd03 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd04 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd05 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd06 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd07 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd08 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd09 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd10 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd11 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd12 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd13 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd14 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd15 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd16 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd17 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd18 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd19 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd20 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd21 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd22 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd23 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd24 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd25 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd26 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd27 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd28 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd29 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd30 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd31 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd32 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd33 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd34 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd35 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd36 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd37 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd38 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd39 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd40 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd41 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd42 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd43 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd44 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd45 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd46 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd47 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd48 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd49 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd50 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd51 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd52 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd53 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd54 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd55 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd56 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd57 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd58 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd59 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd60 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd61 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd62 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd63 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd64 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd65 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd66 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd67 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd68 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd69 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd70 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd71 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd72 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd73 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd74 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd75 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd76 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd77 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd78 { get; set; }

    /// <summary>
    /// Unit[IU] target flatness curve for L1 for MZC
    /// </summary>
    public double? TargetFlatnessCurveInd79 { get; set; }

    /// <summary>
    /// Unit[m/s] target speed for speed change 1  (after tail cut)
    /// </summary>
    public double? TargetSpeed1 { get; set; }

    /// <summary>
    /// Unit[m/s] target speed for speed change 2
    /// </summary>
    public double? TargetSpeed2 { get; set; }

    /// <summary>
    /// Unit[_C] target temperature for strip tail behind IH after speed up
    /// </summary>
    public double? TargetTempTailIhhfm { get; set; }

    /// <summary>
    /// Unit[_C] target temperature for strip tail behind IH after speed up
    /// </summary>
    public double? TargetTempTailIhhrm { get; set; }

    /// <summary>
    /// thickness gauge grade compensation
    /// </summary>
    public double? ThgCompGrade { get; set; }

    /// <summary>
    /// 0 - endless strip, 1 - thread in to FM
    /// </summary>
    public short? ThreadInFlag { get; set; }

    /// <summary>
    /// Unit[m] total thickness of the floor plate for the coiler (base plate + ripple thickness)
    /// </summary>
    public double? TotalHexit { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd0 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd1 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd2 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd3 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd4 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd5 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd6 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd7 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd8 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public double? VAtLengthInd9 { get; set; }

    /// <summary>
    /// Unit[m/s] circumference roll speed F1 for reduced threadin speed F1
    /// </summary>
    public double? VCrs { get; set; }

    /// <summary>
    /// Unit[m/s] tension reel/coiler: LAS speed
    /// </summary>
    public double? VExitLas { get; set; }

    /// <summary>
    /// Unit[m/s] target strip exit speed
    /// </summary>
    public double? VExitTarg { get; set; }

    /// <summary>
    /// Unit[m/s] Max target strip exit speed
    /// </summary>
    public double? VExitTargMax { get; set; }

    /// <summary>
    /// Unit[m/s] speed with which the tail has to leave the mill
    /// </summary>
    public double? VTailOutFm { get; set; }

    /// <summary>
    /// Unit[m/s] strip thread in speed coiler
    /// </summary>
    public double? VThrCoiler { get; set; }

    /// <summary>
    /// Unit[m/s] target maximum circumference speed LAS threadin
    /// </summary>
    public double? VTmcLas { get; set; }

    /// <summary>
    /// Unit[m/s] target maximum circumference speed LAS after coiler threadin
    /// </summary>
    public double? VTmcLasAc { get; set; }

    /// <summary>
    /// Unit[m] second part of strip for side guide
    /// </summary>
    public double? W2sideGuide { get; set; }

    /// <summary>
    /// Unit[m] cast slab width hot
    /// </summary>
    public double? WCast { get; set; }

    /// <summary>
    /// Unit[m] width caster cold
    /// </summary>
    public double? WCastCold { get; set; }

    /// <summary>
    /// Unit[m] length of width change
    /// </summary>
    public double? WChangeLength { get; set; }

    /// <summary>
    /// Unit[m] position width change in front of F5
    /// </summary>
    public double? WChangePos { get; set; }

    /// <summary>
    /// Unit[m] tension reel/coiler: strip width (hot)
    /// </summary>
    public double? WCoiler { get; set; }

    /// <summary>
    /// Unit[m] entry width hot (rough strip width cold)
    /// </summary>
    public double? WEntryColdFm { get; set; }

    /// <summary>
    /// Unit[m] entry width hot (rough strip width hot)
    /// </summary>
    public double? WEntryHot { get; set; }

    /// <summary>
    /// Unit[m] strip width cold
    /// </summary>
    public double? WExitCold { get; set; }

    /// <summary>
    /// Unit[m] width behind FM hot
    /// </summary>
    public double? WExitFmHot { get; set; }

    /// <summary>
    /// Unit[m] width behind HRM hot
    /// </summary>
    public double? WExitHotHrm { get; set; }

    /// <summary>
    /// Unit[m] strip wedge target
    /// </summary>
    public double? WedgeX { get; set; }

    public short? WpcAsymBlocked { get; set; }

    public short? WpcSymBlocked { get; set; }

    /// <summary>
    /// Unit[N/m2] tension reel/coiler: high temperature yield
    /// </summary>
    public double? YieldStressCoiler { get; set; }

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
