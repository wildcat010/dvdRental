using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpOrd2Pc
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
    public short? WFgLiCoefC { get; set; }

    /// <summary>
    /// Reference Linear Coefficient Head
    /// </summary>
    public short? WFgLiCoefH { get; set; }

    /// <summary>
    /// Reference Square Coefficient Coiler
    /// </summary>
    public short? WFgSqCoefC { get; set; }

    /// <summary>
    /// Reference Square Coefficient Head
    /// </summary>
    public short? WFgSqCoefH { get; set; }

    /// <summary>
    /// 1 = absolut cut at end of material (limitation)
    /// </summary>
    public short? AbsCutInfo { get; set; }

    /// <summary>
    /// power speed down for strip tail
    /// </summary>
    public short? AccRateSdtail { get; set; }

    /// <summary>
    /// Bending mode (00=FM,=HRM)
    /// </summary>
    public short? BendMode { get; set; }

    /// <summary>
    /// 0 = normal strip or plate,   1 = checker strip or plate
    /// </summary>
    public short? CheckerFlag { get; set; }

    /// <summary>
    /// Checker height
    /// </summary>
    public short? CheckerHeight { get; set; }

    /// <summary>
    /// CS:  percentage of autenite
    /// </summary>
    public short? CsAustenite { get; set; }

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
    /// CS:  percentage of cementite
    /// </summary>
    public short? CsCementite { get; set; }

    /// <summary>
    /// CS: calculated coiler temperature
    /// </summary>
    public short? CsCoilTempCalc { get; set; }

    /// <summary>
    /// CS: coil setpoint temperature
    /// </summary>
    public short? CsCoilTempSetp { get; set; }

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
    /// CS: percentage of ferrite
    /// </summary>
    public short? CsFerrite { get; set; }

    /// <summary>
    /// CS:  percentage of perlite
    /// </summary>
    public short? CsPerlite { get; set; }

    /// <summary>
    /// CS: profile head length
    /// </summary>
    public short? CsProfHeadLength { get; set; }

    /// <summary>
    /// CS: profile head temperature
    /// </summary>
    public short? CsProfHeadTemp { get; set; }

    /// <summary>
    /// CS:profile tail length
    /// </summary>
    public short? CsProfTailLength { get; set; }

    /// <summary>
    /// CS: profile tail temperature
    /// </summary>
    public short? CsProfTailTemp { get; set; }

    /// <summary>
    /// CS: roller table mode: 0 - auto, 1 - manual
    /// </summary>
    public short? CsRollerTableMode { get; set; }

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
    public short? CsTempOffsetInd0 { get; set; }

    /// <summary>
    /// CS: correction offset for coiling temperature
    /// </summary>
    public short? CsTempOffsetInd1 { get; set; }

    /// <summary>
    /// CS: correction offset for coiling temperature
    /// </summary>
    public short? CsTempOffsetInd2 { get; set; }

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
    /// CS uncooled head length
    /// </summary>
    public short? CsUncHeadLength { get; set; }

    /// <summary>
    /// CS uncooled tail length
    /// </summary>
    public short? CsUncTailLength { get; set; }

    /// <summary>
    /// cut length counted from actual material head, related to material thickness at shear position
    /// </summary>
    public short? CutLen { get; set; }

    /// <summary>
    /// 0: cut at end of order, 1: no cut at end of order , 3:  cut according to length (cutValue), 10: cut at the end of the material
    /// </summary>
    public short? CutRule { get; set; }

    /// <summary>
    /// shear for cut, 1: pendulum shear, 2: rotary shear, 3:  flying shear
    /// </summary>
    public short? CutShearId { get; set; }

    /// <summary>
    /// flatness controll 1LAS/PR_1LAS
    /// </summary>
    public short? DPrXdFb1Las1 { get; set; }

    /// <summary>
    /// spare
    /// </summary>
    public short? DPrXdFb1Las2 { get; set; }

    /// <summary>
    /// flatness controll 2LAS/PR_2LAS
    /// </summary>
    public short? DPrXdFb2Las1 { get; set; }

    /// <summary>
    /// flatness controll 3LAS/PR_2LAS
    /// </summary>
    public short? DPrXdFb2Las2 { get; set; }

    /// <summary>
    /// flatness controll 3LAS/PR_3LAS
    /// </summary>
    public short? DPrXdFb3Las1 { get; set; }

    /// <summary>
    /// flatness controll 4LAS/PR_4LAS
    /// </summary>
    public short? DPrXdFb3Las2 { get; set; }

    /// <summary>
    /// flatness controll 4LAS/PR_4LAS
    /// </summary>
    public short? DPrXdFb4Las1 { get; set; }

    /// <summary>
    /// flatness controll 5LAS/PR_4LAS
    /// </summary>
    public short? DPrXdFb4Las2 { get; set; }

    /// <summary>
    /// flatness controll 5LAS/PR_5LAS
    /// </summary>
    public short? DPrXdFb5Las1 { get; set; }

    /// <summary>
    /// flatness controll 6LAS/PR_5LAS
    /// </summary>
    public short? DPrXdFb5Las2 { get; set; }

    /// <summary>
    /// flatness controll 6LAS/PR_6LAS
    /// </summary>
    public short? DPrXdFb6Las1 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_6LAS
    /// </summary>
    public short? DPrXdFb6Las2 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_7LAS
    /// </summary>
    public short? DPrXdFb7Las1 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_6LAS
    /// </summary>
    public short? DPrXdFb7Las2 { get; set; }

    /// <summary>
    /// poportional speed change (TC)
    /// </summary>
    public short? DSpeedProp { get; set; }

    /// <summary>
    /// Coiler: density at coiling temperature
    /// </summary>
    public short? DensTcoiler { get; set; }

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
    /// strip edge distance I
    /// </summary>
    public short? DistanceE1 { get; set; }

    /// <summary>
    /// strip edge distance II
    /// </summary>
    public short? DistanceE2 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd00 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd01 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd02 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd03 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd04 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd05 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd06 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd07 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd08 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd09 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd10 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd11 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd12 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmtailInd13 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd00 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd01 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd02 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd03 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd04 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd05 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd06 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd07 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd08 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd09 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd10 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd11 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd12 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhfmInd13 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd00 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd01 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd02 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd03 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd04 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd05 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd06 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd07 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd08 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd09 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd10 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd11 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd12 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmtailInd13 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd00 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd01 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd02 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd03 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd04 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd05 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd06 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd07 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd08 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd09 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd10 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd11 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd12 { get; set; }

    /// <summary>
    /// delta temperature for coil x of inductive heater
    /// </summary>
    public short? DtIhhrmInd13 { get; set; }

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
    /// secondary descaler: entry top and bottom flow
    /// </summary>
    public short? FlowDescEntryHfm { get; set; }

    /// <summary>
    /// primary descaler HRM: entry top and bottom flow
    /// </summary>
    public short? FlowDescEntryHrm { get; set; }

    /// <summary>
    /// secondary descaler: exit top and bottom flow
    /// </summary>
    public short? FlowDescExitHfm { get; set; }

    /// <summary>
    /// primary descaler HRM: exit top and bottom flow
    /// </summary>
    public short? FlowDescExitHrm { get; set; }

    /// <summary>
    ///  power cooling flow reference entry bottom
    /// </summary>
    public short? FlowPcEntryB { get; set; }

    /// <summary>
    ///  power cooling flow reference entry top
    /// </summary>
    public short? FlowPcEntryT { get; set; }

    /// <summary>
    ///  power cooling flow reference exit bottom
    /// </summary>
    public short? FlowPcExitB { get; set; }

    /// <summary>
    ///  power cooling flow reference exit top
    /// </summary>
    public short? FlowPcExitT { get; set; }

    /// <summary>
    /// force pinch roll entry flying shear
    /// </summary>
    public short? FrPrenFs { get; set; }

    /// <summary>
    /// force pinch roll entry inductive heating furnace
    /// </summary>
    public short? FrPrenIh { get; set; }

    /// <summary>
    /// force pinch roll entry pendulum shear
    /// </summary>
    public short? FrPrenPs { get; set; }

    /// <summary>
    /// force pinch roll entry rotary shear
    /// </summary>
    public short? FrPrenRs { get; set; }

    /// <summary>
    /// force pinch roll exit flying shear
    /// </summary>
    public short? FrPrexFs { get; set; }

    /// <summary>
    /// force pinch roll exit inductive heating furnace
    /// </summary>
    public short? FrPrexIh { get; set; }

    /// <summary>
    /// force pinch roll exit pendulum shear
    /// </summary>
    public short? FrPrexPs { get; set; }

    /// <summary>
    /// force pinch roll exit rotary shear
    /// </summary>
    public short? FrPrexRs { get; set; }

    /// <summary>
    /// tension reel/coiler: specific tension
    /// </summary>
    public short? FtCoiler { get; set; }

    /// <summary>
    /// specific forward tension pinch roll entry flying shear
    /// </summary>
    public short? FtPrenFs { get; set; }

    /// <summary>
    /// specific forward tension pinch roll entry inductive heating furnace
    /// </summary>
    public short? FtPrenIh { get; set; }

    /// <summary>
    /// specific forward tension pinch roll entry pendulum shear
    /// </summary>
    public short? FtPrenPs { get; set; }

    /// <summary>
    /// specific forward tension pinch roll entry rotary shear
    /// </summary>
    public short? FtPrenRs { get; set; }

    /// <summary>
    /// specific forward tension pinch roll exit flying shear
    /// </summary>
    public short? FtPrexFs { get; set; }

    /// <summary>
    /// specific forward tension pinch roll exit inductive heating furnace
    /// </summary>
    public short? FtPrexIh { get; set; }

    /// <summary>
    /// specific forward tension pinch roll exit pendulum shear
    /// </summary>
    public short? FtPrexPs { get; set; }

    /// <summary>
    /// specific forward tension pinch roll exit rotary shear
    /// </summary>
    public short? FtPrexRs { get; set; }

    /// <summary>
    /// cast slab thickness (hot)
    /// </summary>
    public short? HCast { get; set; }

    /// <summary>
    /// cast slab thickness cold
    /// </summary>
    public short? HCastCold { get; set; }

    /// <summary>
    /// tension reel/coiler: strip thickness (hot)
    /// </summary>
    public short? HCoiler { get; set; }

    /// <summary>
    /// entry thickness (rough strip thickness cold)
    /// </summary>
    public short? HEntryColdFm { get; set; }

    /// <summary>
    /// entry thickness (rough strip thickness hot)
    /// </summary>
    public short? HEntryFm { get; set; }

    /// <summary>
    /// strip thickness cold
    /// </summary>
    public short? HExitCold { get; set; }

    /// <summary>
    /// ih total power
    /// </summary>
    public short? IHtotalPower { get; set; }

    /// <summary>
    /// Required  Induction Heater exit temperature to reach HFM exit Temperature
    /// </summary>
    public short? IHtExit { get; set; }

    /// <summary>
    /// Flag for inheritance, 0 = Long time, 2 = short time exact, 3 = short time similar
    /// </summary>
    public short? InherPfc { get; set; }

    /// <summary>
    /// Material Id from short time inheritance
    /// </summary>
    public short? InherPfcId { get; set; }

    /// <summary>
    /// slab length hot
    /// </summary>
    public short? LEntryHot { get; set; }

    /// <summary>
    /// length after FM
    /// </summary>
    public short? LExit { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd0 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd1 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd2 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd3 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd4 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd5 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd6 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd7 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd8 { get; set; }

    /// <summary>
    /// related length for speed and temperature (for cooling model)
    /// </summary>
    public short? LPointRefInd9 { get; set; }

    /// <summary>
    /// roughed strip length (ONLY FOR SIMULATION!!!)
    /// </summary>
    public short? LRoughedStrip { get; set; }

    /// <summary>
    /// length of the wedge (slab related)
    /// </summary>
    public short? LWedge { get; set; }

    /// <summary>
    /// length of the wedge  HRM (slab related)
    /// </summary>
    public short? LWedgeHrm { get; set; }

    /// <summary>
    /// length of transfer bar with acceleration
    /// </summary>
    public short? LenTrBarAccel { get; set; }

    /// <summary>
    /// length of transfer bar with which the speed up starts
    /// </summary>
    public short? Length2Spup { get; set; }

    /// <summary>
    /// mandrel expansion factor  0-1
    /// </summary>
    public short? MandrelExpFac { get; set; }

    /// <summary>
    /// minimum speed caster (for next material enter FM)
    /// </summary>
    public short? MinSpeedCas { get; set; }

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
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd00 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd01 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd02 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd03 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd04 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd05 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd06 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd07 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd08 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd09 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd10 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd11 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd12 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmtailInd13 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd00 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd01 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd02 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd03 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd04 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd05 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd06 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd07 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd08 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd09 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd10 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd11 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd12 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhfmInd13 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd00 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd01 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd02 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd03 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd04 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd05 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd06 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd07 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd08 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd09 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd10 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd11 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd12 { get; set; }

    /// <summary>
    /// active power tail inductive heater coil x
    /// </summary>
    public short? PIhhrmtailInd13 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd00 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd01 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd02 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd03 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd04 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd05 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd06 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd07 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd08 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd09 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd10 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd11 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd12 { get; set; }

    /// <summary>
    /// active power inductive heater coil x
    /// </summary>
    public short? PIhhrmInd13 { get; set; }

    /// <summary>
    /// power speed up value
    /// </summary>
    public short? PSuValue { get; set; }

    /// <summary>
    /// strip position for speed change end 1
    /// </summary>
    public short? PosSpeedChangeEnd2 { get; set; }

    /// <summary>
    /// calculated exit profile
    /// </summary>
    public short? Profexcalc { get; set; }

    /// <summary>
    /// calculated(measured) profile of HRM
    /// </summary>
    public short? ProfexcalcHrm { get; set; }

    /// <summary>
    /// PFC target profile of HRM
    /// </summary>
    public short? ProfextargetHrm { get; set; }

    /// <summary>
    /// strip profile
    /// </summary>
    public short? ProfileX { get; set; }

    /// <summary>
    /// error code from MOS-FM
    /// </summary>
    public short? Sbaz { get; set; }

    /// <summary>
    /// gap pinch roll entry flying shear
    /// </summary>
    public short? SdPrenFs { get; set; }

    /// <summary>
    /// gap pinch roll entry flying shear
    /// </summary>
    public short? SdPrenIh { get; set; }

    /// <summary>
    /// gap pinch roll entry pendulum shear
    /// </summary>
    public short? SdPrenPs { get; set; }

    /// <summary>
    /// gap pinch roll entry rotary shear
    /// </summary>
    public short? SdPrenRs { get; set; }

    /// <summary>
    /// gap pinch roll exit flying shear
    /// </summary>
    public short? SdPrexFs { get; set; }

    /// <summary>
    /// gap pinch roll exit flying shear
    /// </summary>
    public short? SdPrexIh { get; set; }

    /// <summary>
    /// gap pinch roll exit pendulum shear
    /// </summary>
    public short? SdPrexPs { get; set; }

    /// <summary>
    /// gap pinch roll exit rotary shear
    /// </summary>
    public short? SdPrexRs { get; set; }

    /// <summary>
    /// induction heater sensitivity dTihx/dVentry  to keep HFM exit temp constant
    /// </summary>
    public short? SensIhdTdV { get; set; }

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
    /// Speed up rate for speed change 1 (after tail cut)
    /// </summary>
    public short? SpeedChangeRate1 { get; set; }

    /// <summary>
    /// Speed up rate for speed change 2
    /// </summary>
    public short? SpeedChangeRate2 { get; set; }

    /// <summary>
    /// flag for speedup start selection:0=no speedup, 1=speedup with LAS loaded, 2=speedup with coiler loaded, 4 =speedup with time
    /// </summary>
    public short? SpeedupFlag { get; set; }

    /// <summary>
    /// time after which the speedup starts
    /// </summary>
    public short? SpeedupTime { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-CS
    /// </summary>
    public short? SptlFaultCs { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-FM
    /// </summary>
    public short? SptlFaultHfm { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-RM
    /// </summary>
    public short? SptlFaultHrm { get; set; }

    /// <summary>
    /// standNo, from which speed down is driven
    /// </summary>
    public short? StandNoStartSpeedDown { get; set; }

    /// <summary>
    /// Starting point of wedge,given as distance from tail end of the slab
    /// </summary>
    public short? StartWedge { get; set; }

    /// <summary>
    /// Starting point of wedge HRM,given as distance from tail end of the slab
    /// </summary>
    public short? StartWedgeHrm { get; set; }

    /// <summary>
    /// strip temperature (exit finishing mill)
    /// </summary>
    public short? T { get; set; }

    /// <summary>
    /// entry temperature under measuring house
    /// </summary>
    public short? T0Mh { get; set; }

    /// <summary>
    /// temperature measuring house behind HRM
    /// </summary>
    public short? T0MhHrm { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd0 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd1 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd2 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd3 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd4 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd5 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd6 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd7 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd8 { get; set; }

    /// <summary>
    /// strip exit temperature at related length (for cooling model)
    /// </summary>
    public short? TAtLengthInd9 { get; set; }

    /// <summary>
    /// entry transfer bar temperature (roughing mill exit temperature)
    /// </summary>
    public short? TEntry { get; set; }

    /// <summary>
    /// slab entry temperature  (from MOS-RM for IVI-FM)
    /// </summary>
    public short? TEntryFrRm { get; set; }

    /// <summary>
    /// surface temperature at exit of inductive heater
    /// </summary>
    public short? TIhhfmx { get; set; }

    /// <summary>
    /// surface temperature at exit of inductive heater for tail end
    /// </summary>
    public short? TIhhfmxtail { get; set; }

    /// <summary>
    /// surface temperature at exit of inductive heater
    /// </summary>
    public short? TIhhrmx { get; set; }

    /// <summary>
    /// surface temperature at exit of inductive heater for tail end
    /// </summary>
    public short? TIhhrmxtail { get; set; }

    /// <summary>
    /// temperature speed up value
    /// </summary>
    public short? TSuValue { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd00 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd01 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd02 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd03 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd04 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd05 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd06 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd07 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd08 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd09 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd10 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd11 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd12 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd13 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd14 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd15 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd16 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd17 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd18 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd19 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd20 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd21 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd22 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd23 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd24 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd25 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd26 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd27 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd28 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd29 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd30 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd31 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd32 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd33 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd34 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd35 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd36 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd37 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd38 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd39 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd40 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd41 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd42 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd43 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd44 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd45 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd46 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd47 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd48 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd49 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd50 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd51 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd52 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd53 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd54 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd55 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd56 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd57 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd58 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd59 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd60 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd61 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd62 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd63 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd64 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd65 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd66 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd67 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd68 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd69 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd70 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd71 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd72 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd73 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd74 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd75 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd76 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd77 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd78 { get; set; }

    /// <summary>
    /// target flatness curve for L1 for MZC
    /// </summary>
    public short? TargetFlatnessCurveInd79 { get; set; }

    /// <summary>
    /// target speed for speed change 1  (after tail cut)
    /// </summary>
    public short? TargetSpeed1 { get; set; }

    /// <summary>
    /// target speed for speed change 2
    /// </summary>
    public short? TargetSpeed2 { get; set; }

    /// <summary>
    /// target temperature for strip tail behind IH after speed up
    /// </summary>
    public short? TargetTempTailIhhfm { get; set; }

    /// <summary>
    /// target temperature for strip tail behind IH after speed up
    /// </summary>
    public short? TargetTempTailIhhrm { get; set; }

    /// <summary>
    /// thickness gauge grade compensation
    /// </summary>
    public short? ThgCompGrade { get; set; }

    /// <summary>
    /// 0 - endless strip, 1 - thread in to FM
    /// </summary>
    public short? ThreadInFlag { get; set; }

    /// <summary>
    /// total thickness of the floor plate for the coiler (base plate + ripple thickness)
    /// </summary>
    public short? TotalHexit { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd0 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd1 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd2 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd3 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd4 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd5 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd6 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd7 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd8 { get; set; }

    /// <summary>
    /// strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public short? VAtLengthInd9 { get; set; }

    /// <summary>
    /// circumference roll speed F1 for reduced threadin speed F1
    /// </summary>
    public short? VCrs { get; set; }

    /// <summary>
    /// tension reel/coiler: LAS speed
    /// </summary>
    public short? VExitLas { get; set; }

    /// <summary>
    /// target strip exit speed
    /// </summary>
    public short? VExitTarg { get; set; }

    /// <summary>
    /// Max target strip exit speed
    /// </summary>
    public short? VExitTargMax { get; set; }

    /// <summary>
    /// speed with which the tail has to leave the mill
    /// </summary>
    public short? VTailOutFm { get; set; }

    /// <summary>
    /// strip thread in speed coiler
    /// </summary>
    public short? VThrCoiler { get; set; }

    /// <summary>
    /// target maximum circumference speed LAS threadin
    /// </summary>
    public short? VTmcLas { get; set; }

    /// <summary>
    /// target maximum circumference speed LAS after coiler threadin
    /// </summary>
    public short? VTmcLasAc { get; set; }

    /// <summary>
    /// second part of strip for side guide
    /// </summary>
    public short? W2sideGuide { get; set; }

    /// <summary>
    /// cast slab width hot
    /// </summary>
    public short? WCast { get; set; }

    /// <summary>
    /// width caster cold
    /// </summary>
    public short? WCastCold { get; set; }

    /// <summary>
    /// length of width change
    /// </summary>
    public short? WChangeLength { get; set; }

    /// <summary>
    /// position width change in front of F5
    /// </summary>
    public short? WChangePos { get; set; }

    /// <summary>
    /// tension reel/coiler: strip width (hot)
    /// </summary>
    public short? WCoiler { get; set; }

    /// <summary>
    /// entry width hot (rough strip width cold)
    /// </summary>
    public short? WEntryColdFm { get; set; }

    /// <summary>
    /// entry width hot (rough strip width hot)
    /// </summary>
    public short? WEntryHot { get; set; }

    /// <summary>
    /// strip width cold
    /// </summary>
    public short? WExitCold { get; set; }

    /// <summary>
    /// width behind FM hot
    /// </summary>
    public short? WExitFmHot { get; set; }

    /// <summary>
    /// width behind HRM hot
    /// </summary>
    public short? WExitHotHrm { get; set; }

    /// <summary>
    /// strip wedge target
    /// </summary>
    public short? WedgeX { get; set; }

    public short? WpcAsymBlocked { get; set; }

    public short? WpcSymBlocked { get; set; }

    /// <summary>
    /// tension reel/coiler: high temperature yield
    /// </summary>
    public short? YieldStressCoiler { get; set; }

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
