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
    public float? WFgLiCoefC { get; set; }

    /// <summary>
    /// Reference Linear Coefficient Head
    /// </summary>
    public float? WFgLiCoefH { get; set; }

    /// <summary>
    /// Reference Square Coefficient Coiler
    /// </summary>
    public float? WFgSqCoefC { get; set; }

    /// <summary>
    /// Reference Square Coefficient Head
    /// </summary>
    public float? WFgSqCoefH { get; set; }

    /// <summary>
    /// 1 = absolut cut at end of material (limitation)
    /// </summary>
    public short? AbsCutInfo { get; set; }

    /// <summary>
    /// Unit[m/s2] power speed down for strip tail
    /// </summary>
    public float? AccRateSdtail { get; set; }

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
    public float? CheckerHeight { get; set; }

    /// <summary>
    /// Unit[%] CS:  percentage of autenite
    /// </summary>
    public float? CsAustenite { get; set; }

    /// <summary>
    /// Unit[%] CS: bottom valve volume flow (0-100) , 44 laminar cooling valves
    /// </summary>
    public byte[] CsBotValve { get; set; }

    /// <summary>
    /// Unit[%] CS:  percentage of cementite
    /// </summary>
    public float? CsCementite { get; set; }

    /// <summary>
    /// CS: correction factor heat transfer
    /// </summary>
    public float? CsCofaHeat { get; set; }

    /// <summary>
    /// CS: cofa factor phase transformation
    /// </summary>
    public float? CsCofaPhase { get; set; }

    /// <summary>
    /// Unit[C] CS: calculated coiler temperature
    /// </summary>
    public float? CsCoilTempCalc { get; set; }

    /// <summary>
    /// CS: coil setpoint temperature
    /// </summary>
    public float? CsCoilTempSetp { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd0 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd1 { get; set; }

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
    public short? CsCrossSprayInd2 { get; set; }

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
    public short? CsCrossSprayInd3 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd30 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd31 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd4 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd5 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd6 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd7 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd8 { get; set; }

    /// <summary>
    /// CS: longitudinal spray/ cross spray
    /// </summary>
    public short? CsCrossSprayInd9 { get; set; }

    /// <summary>
    /// Unit[%] CS: percentage of ferrite
    /// </summary>
    public float? CsFerrite { get; set; }

    /// <summary>
    /// Unit[%] CS:  percentage of perlite
    /// </summary>
    public float? CsPerlite { get; set; }

    /// <summary>
    /// Unit[m] CS: profile head length
    /// </summary>
    public float? CsProfHeadLength { get; set; }

    /// <summary>
    /// Unit[_C] CS: profile head temperature
    /// </summary>
    public float? CsProfHeadTemp { get; set; }

    /// <summary>
    /// Unit[m] CS:profile tail length
    /// </summary>
    public float? CsProfTailLength { get; set; }

    /// <summary>
    /// Unit[_C] CS: profile tail temperature
    /// </summary>
    public float? CsProfTailTemp { get; set; }

    /// <summary>
    /// CS: roller table mode: 0 - auto, 1 - manual
    /// </summary>
    public float? CsRollerTableMode { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd0 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd1 { get; set; }

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
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd2 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd3 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd4 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd5 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd6 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd7 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd8 { get; set; }

    /// <summary>
    /// CS: roll out table (bit mapped)
    /// </summary>
    public short? CsRollerTableInd9 { get; set; }

    /// <summary>
    /// CS: error code from MOS-CS
    /// </summary>
    public short? CsSbaz { get; set; }

    /// <summary>
    /// Unit[%] CS: top valve volume flow (0-100)  , 44 laminar cooling valves
    /// </summary>
    public byte[] CsTopValve { get; set; }

    /// <summary>
    /// Unit[m] CS uncooled head length
    /// </summary>
    public float? CsUncHeadLength { get; set; }

    /// <summary>
    /// Unit[m] CS uncooled tail length
    /// </summary>
    public float? CsUncTailLength { get; set; }

    /// <summary>
    /// Unit[m] cut length counted from actual material head, related to material thickness at shear position
    /// </summary>
    public float? CutLen { get; set; }

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
    public float? DPrXdFb1Las1 { get; set; }

    /// <summary>
    /// spare
    /// </summary>
    public float? DPrXdFb1Las2 { get; set; }

    /// <summary>
    /// flatness controll 2LAS/PR_2LAS
    /// </summary>
    public float? DPrXdFb2Las1 { get; set; }

    /// <summary>
    /// flatness controll 3LAS/PR_2LAS
    /// </summary>
    public float? DPrXdFb2Las2 { get; set; }

    /// <summary>
    /// flatness controll 3LAS/PR_3LAS
    /// </summary>
    public float? DPrXdFb3Las1 { get; set; }

    /// <summary>
    /// flatness controll 4LAS/PR_4LAS
    /// </summary>
    public float? DPrXdFb3Las2 { get; set; }

    /// <summary>
    /// flatness controll 4LAS/PR_4LAS
    /// </summary>
    public float? DPrXdFb4Las1 { get; set; }

    /// <summary>
    /// flatness controll 5LAS/PR_4LAS
    /// </summary>
    public float? DPrXdFb4Las2 { get; set; }

    /// <summary>
    /// flatness controll 5LAS/PR_5LAS
    /// </summary>
    public float? DPrXdFb5Las1 { get; set; }

    /// <summary>
    /// flatness controll 6LAS/PR_5LAS
    /// </summary>
    public float? DPrXdFb5Las2 { get; set; }

    /// <summary>
    /// flatness controll 6LAS/PR_6LAS
    /// </summary>
    public float? DPrXdFb6Las1 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_6LAS
    /// </summary>
    public float? DPrXdFb6Las2 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_7LAS
    /// </summary>
    public float? DPrXdFb7Las1 { get; set; }

    /// <summary>
    /// flatness controll 7LAS/PR_6LAS
    /// </summary>
    public float? DPrXdFb7Las2 { get; set; }

    /// <summary>
    /// Unit[m/s] poportional speed change (TC)
    /// </summary>
    public float? DSpeedProp { get; set; }

    /// <summary>
    /// secondary descaler: entry top and bottom off/on (0/1)
    /// </summary>
    public short? DescEntryFm { get; set; }

    /// <summary>
    /// primary descaler HRM: entry top and bottom off/on (0/1)
    /// </summary>
    public short? DescEntryHrm { get; set; }

    /// <summary>
    /// only for HMI: primary descaler HRM: entry top and bottom off/on (0/1) status
    /// </summary>
    public short? DescEntryHrmstat { get; set; }

    /// <summary>
    /// only for HMI: secondary descaler: entry top and bottom off/on (0/1) status
    /// </summary>
    public short? DescEntryStatFm { get; set; }

    /// <summary>
    /// secondary descaler: exit top and bottom off/on (0/1)
    /// </summary>
    public short? DescExitFm { get; set; }

    /// <summary>
    /// primary descaler HRM: exit top and bottom off/on (0/1)
    /// </summary>
    public short? DescExitHrm { get; set; }

    /// <summary>
    /// only for HMI: primary descaler HRM: exit top and bottom off/on (0/1)
    /// </summary>
    public short? DescExitHrmstat { get; set; }

    /// <summary>
    /// only for HMI: secondary descaler: exit top and bottom off/on (0/1) status
    /// </summary>
    public short? DescExitStatFm { get; set; }

    /// <summary>
    /// Unit[m] strip edge distance I
    /// </summary>
    public float? DistanceE1 { get; set; }

    /// <summary>
    /// Unit[m] strip edge distance II
    /// </summary>
    public float? DistanceE2 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd0 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd1 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd10 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd11 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd12 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd13 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd2 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd3 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd4 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd5 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd6 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd7 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd8 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhtailInd9 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd0 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd1 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd10 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd11 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd12 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd13 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd2 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd3 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd4 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd5 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd6 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd7 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd8 { get; set; }

    /// <summary>
    /// Unit[_C] delta temperature for coil x of inductive heater
    /// </summary>
    public float? DtIhInd9 { get; set; }

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

    /// <summary>
    /// flatness curve number default=0
    /// </summary>
    public short? FlatCurveNr { get; set; }

    public short? FlcAsymBlocked { get; set; }

    public short? FlcSymBlocked { get; set; }

    /// <summary>
    /// Unit[%/m] secondary descaler: entry top and bottom flow
    /// </summary>
    public float? FlowDescEntryFm { get; set; }

    /// <summary>
    /// Unit[%/m] primary descaler HRM: entry top and bottom flow
    /// </summary>
    public float? FlowDescEntryHrm { get; set; }

    /// <summary>
    /// Unit[%/m] secondary descaler: exit top and bottom flow
    /// </summary>
    public float? FlowDescExitFm { get; set; }

    /// <summary>
    /// Unit[%/m] primary descaler HRM: exit top and bottom flow
    /// </summary>
    public float? FlowDescExitHrm { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference entry bottom
    /// </summary>
    public float? FlowPcEntryB { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference entry top
    /// </summary>
    public float? FlowPcEntryT { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference exit bottom
    /// </summary>
    public float? FlowPcExitB { get; set; }

    /// <summary>
    /// Unit[%/m]  power cooling flow reference exit top
    /// </summary>
    public float? FlowPcExitT { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry flying shear
    /// </summary>
    public float? FrPrenFs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry inductive heating furnace
    /// </summary>
    public float? FrPrenIh { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry pendulum shear
    /// </summary>
    public float? FrPrenPs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll entry rotary shear
    /// </summary>
    public float? FrPrenRs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit flying shear
    /// </summary>
    public float? FrPrexFs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit inductive heating furnace
    /// </summary>
    public float? FrPrexIh { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit pendulum shear
    /// </summary>
    public float? FrPrexPs { get; set; }

    /// <summary>
    /// Unit[N] force pinch roll exit rotary shear
    /// </summary>
    public float? FrPrexRs { get; set; }

    /// <summary>
    /// Unit[N/m2] tension reel/coiler: specific tension
    /// </summary>
    public float? FtCoiler { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry flying shear
    /// </summary>
    public float? FtPrenFs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry inductive heating furnace
    /// </summary>
    public float? FtPrenIh { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry pendulum shear
    /// </summary>
    public float? FtPrenPs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll entry rotary shear
    /// </summary>
    public float? FtPrenRs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit flying shear
    /// </summary>
    public float? FtPrexFs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit inductive heating furnace
    /// </summary>
    public float? FtPrexIh { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit pendulum shear
    /// </summary>
    public float? FtPrexPs { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension pinch roll exit rotary shear
    /// </summary>
    public float? FtPrexRs { get; set; }

    /// <summary>
    /// Unit[m] cast slab thickness (hot)
    /// </summary>
    public float? HCast { get; set; }

    /// <summary>
    /// Unit[m] cast slab thickness cold
    /// </summary>
    public float? HCastCold { get; set; }

    /// <summary>
    /// Unit[m] tension reel/coiler: strip thickness (hot)
    /// </summary>
    public float? HCoiler { get; set; }

    /// <summary>
    /// Unit[m] entry thickness (rough strip thickness cold)
    /// </summary>
    public float? HEntryColdFm { get; set; }

    /// <summary>
    /// Unit[m] entry thickness (rough strip thickness hot)
    /// </summary>
    public float? HEntryFm { get; set; }

    /// <summary>
    /// Unit[m] strip thickness cold
    /// </summary>
    public float? HExitCold { get; set; }

    /// <summary>
    /// only for HMI: Strip thickness cold status
    /// </summary>
    public short? HExitColdStat { get; set; }

    /// <summary>
    /// Unit[_C] ih total power
    /// </summary>
    public float? IHtotalPower { get; set; }

    /// <summary>
    /// Unit[_C] Required  Induction Heater exit temperature to reach HFM exit Temperature
    /// </summary>
    public float? IHtExit { get; set; }

    /// <summary>
    /// Flag for inheritance, 0 = Long time, 2 = short time exact, 3 = short time similar
    /// </summary>
    public int? InherPfc { get; set; }

    /// <summary>
    /// Material Id from short time inheritance
    /// </summary>
    public string InherPfcId { get; set; }

    /// <summary>
    /// Unit[m] length after FM
    /// </summary>
    public float? LExit { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd0 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd1 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd2 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd3 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd4 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd5 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd6 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd7 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd8 { get; set; }

    /// <summary>
    /// Unit[m] related length for speed and temperature (for cooling model)
    /// </summary>
    public float? LPointRefInd9 { get; set; }

    /// <summary>
    /// Unit[m] roughed strip length (ONLY FOR SIMULATION!!!)
    /// </summary>
    public float? LRoughedStrip { get; set; }

    /// <summary>
    /// Unit[m] length of the wedge (slab related)
    /// </summary>
    public float? LWedge { get; set; }

    /// <summary>
    /// Unit[m] length of the wedge  HRM (slab related)
    /// </summary>
    public float? LWedgeHrm { get; set; }

    /// <summary>
    /// Unit[m] length of transfer bar with acceleration
    /// </summary>
    public float? LenTrBarAccel { get; set; }

    /// <summary>
    /// Unit[m] length of transfer bar with which the speed up starts
    /// </summary>
    public float? Length2Spup { get; set; }

    /// <summary>
    /// Unit[%] mandrel expansion factor  0-1
    /// </summary>
    public float? MandrelExpFac { get; set; }

    /// <summary>
    /// Unit[m/s] minimum speed caster (for next material enter FM)
    /// </summary>
    public float? MinSpeedCas { get; set; }

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
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd0 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd1 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd10 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd11 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd12 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd13 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd2 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd3 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd4 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd5 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd6 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd7 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd8 { get; set; }

    /// <summary>
    /// Unit[W] active power tail inductive heater coil x
    /// </summary>
    public float? PIhtailInd9 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd0 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd1 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd10 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd11 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd12 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd13 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd2 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd3 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd4 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd5 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd6 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd7 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd8 { get; set; }

    /// <summary>
    /// Unit[W] active power inductive heater coil x
    /// </summary>
    public float? PIhInd9 { get; set; }

    /// <summary>
    /// Unit[m/s2] power speed up value
    /// </summary>
    public float? PSuValue { get; set; }

    /// <summary>
    /// only for HMI: Power speedup value status
    /// </summary>
    public short? PSuValueStat { get; set; }

    /// <summary>
    /// Unit[m] strip position for speed change end 1
    /// </summary>
    public float? PosSpeedChangeEnd2 { get; set; }

    /// <summary>
    /// Unit[m] calculated exit profile
    /// </summary>
    public float? Profexcalc { get; set; }

    /// <summary>
    /// Unit[m] calculated(measured) profile of HRM
    /// </summary>
    public float? ProfexcalcHrm { get; set; }

    /// <summary>
    /// only for HMI: calculated exit profile status
    /// </summary>
    public short? ProfexcalcStat { get; set; }

    /// <summary>
    /// Unit[m] PFC target profile of HRM
    /// </summary>
    public float? ProfextargetHrm { get; set; }

    /// <summary>
    /// Unit[m] strip profile max
    /// </summary>
    public float? ProfileMaxX { get; set; }

    /// <summary>
    /// Unit[m] strip profile min
    /// </summary>
    public float? ProfileMinX { get; set; }

    /// <summary>
    /// Unit[m] strip profile
    /// </summary>
    public float? ProfileX { get; set; }

    /// <summary>
    /// only for HMI: Calculated profile value status
    /// </summary>
    public short? ProfileXstat { get; set; }

    /// <summary>
    /// error code from MOS-FM
    /// </summary>
    public int? Sbaz { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry flying shear
    /// </summary>
    public float? SdPrenIh { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry pendulum shear
    /// </summary>
    public float? SdPrenPs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry rotary shear
    /// </summary>
    public float? SdPrenRs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll entry flying shear
    /// </summary>
    public float? SdPrenRs2 { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit flying shear
    /// </summary>
    public float? SdPrexFs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit flying shear
    /// </summary>
    public float? SdPrexIh { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit pendulum shear
    /// </summary>
    public float? SdPrexPs { get; set; }

    /// <summary>
    /// Unit[m] gap pinch roll exit rotary shear
    /// </summary>
    public float? SdPrexRs { get; set; }

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
    public float? SpeedChangeRate1 { get; set; }

    /// <summary>
    /// Unit[m/s2] Speed up rate for speed change 2
    /// </summary>
    public float? SpeedChangeRate2 { get; set; }

    /// <summary>
    /// flag for speedup start selection:0=no speedup, 1=speedup with LAS loaded, 2=speedup with coiler loaded, 4 =speedup with time
    /// </summary>
    public short? SpeedupFlag { get; set; }

    /// <summary>
    /// only for HMI: flag for speedup start selection status
    /// </summary>
    public short? SpeedupFlagStat { get; set; }

    /// <summary>
    /// Unit[s] time after which the speedup starts
    /// </summary>
    public float? SpeedupTime { get; set; }

    /// <summary>
    /// only for HMI: time after which the speedup starts status
    /// </summary>
    public short? SpeedupTimeStat { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-CS
    /// </summary>
    public string SptlFaultCs { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-CS status
    /// </summary>
    public short? SptlFaultCsstat { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-FM
    /// </summary>
    public string SptlFaultFm { get; set; }

    /// <summary>
    /// ONLY FOR HMI: additional information from MOS-FM status
    /// </summary>
    public short? SptlFaultFmstat { get; set; }

    /// <summary>
    /// standNo, from which speed down is driven
    /// </summary>
    public float? StandNoStartSpeedDown { get; set; }

    /// <summary>
    /// Unit[m] Starting point of wedge,given as distance from tail end of the slab
    /// </summary>
    public float? StartWedge { get; set; }

    /// <summary>
    /// Unit[m] Starting point of wedge HRM,given as distance from tail end of the slab
    /// </summary>
    public float? StartWedgeHrm { get; set; }

    /// <summary>
    /// Unit[_C] strip temperature (exit finishing mill)
    /// </summary>
    public float? T { get; set; }

    /// <summary>
    /// Unit[_C] entry temperature under measuring house
    /// </summary>
    public float? T0Mh { get; set; }

    /// <summary>
    /// Unit[_C] temperature measuring house behind HRM
    /// </summary>
    public float? T0MhHrm { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd0 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd1 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd2 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd3 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd4 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd5 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd6 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd7 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd8 { get; set; }

    /// <summary>
    /// Unit[_C] strip exit temperature at related length (for cooling model)
    /// </summary>
    public float? TAtLengthInd9 { get; set; }

    /// <summary>
    /// Unit[_C] entry transfer bar temperature (roughing mill exit temperature)
    /// </summary>
    public float? TEntry { get; set; }

    /// <summary>
    /// Unit[_C] slab entry temperature  (from MOS-RM for IVI-FM)
    /// </summary>
    public float? TEntryFrRm { get; set; }

    /// <summary>
    /// Unit[_C] surface temperature at exit of inductive heater
    /// </summary>
    public float? TIhx { get; set; }

    /// <summary>
    /// Unit[_C] surface temperature at exit of inductive heater for tail end
    /// </summary>
    public float? TIhxtail { get; set; }

    /// <summary>
    /// only for HMI: Strip temperature (exit finishing mill) status
    /// </summary>
    public short? TStat { get; set; }

    /// <summary>
    /// Unit[m/s2] temperature speed up value
    /// </summary>
    public float? TSuValue { get; set; }

    /// <summary>
    /// only for HMI: Temperature speedup value status
    /// </summary>
    public short? TSuValueStat { get; set; }

    /// <summary>
    /// Unit[m/s] target speed for speed change 1  (after tail cut)
    /// </summary>
    public float? TargetSpeed1 { get; set; }

    /// <summary>
    /// Unit[m/s] target speed for speed change 2
    /// </summary>
    public float? TargetSpeed2 { get; set; }

    /// <summary>
    /// Unit[_C] target temperature for strip tail behind IH after speed up
    /// </summary>
    public float? TargetTempTailIh { get; set; }

    /// <summary>
    /// thickness gauge grade compensation
    /// </summary>
    public float? ThgCompGrade { get; set; }

    /// <summary>
    /// 0 - endless strip, 1 - thread in to FM
    /// </summary>
    public short? ThreadInFlag { get; set; }

    /// <summary>
    /// Unit[m] total thickness of the floor plate for the coiler (base plate + ripple thickness)
    /// </summary>
    public float? TotalHexit { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd0 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd1 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd2 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd3 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd4 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd5 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd6 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd7 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd8 { get; set; }

    /// <summary>
    /// Unit[m/s] strip exit speed at this length under the measuring location for mill exit temp ( for cooling model)
    /// </summary>
    public float? VAtLengthInd9 { get; set; }

    /// <summary>
    /// Unit[m/s] circumference roll speed F1 for reduced threadin speed F1
    /// </summary>
    public float? VCrs { get; set; }

    /// <summary>
    /// Unit[m/s] tension reel/coiler: LAS speed
    /// </summary>
    public float? VExitLas { get; set; }

    /// <summary>
    /// only for HMI: tension reel/coiler: LAS speed status
    /// </summary>
    public short? VExitLasStat { get; set; }

    /// <summary>
    /// Unit[m/s] target strip exit speed
    /// </summary>
    public float? VExitTarg { get; set; }

    /// <summary>
    /// Unit[m/s] Max target strip exit speed
    /// </summary>
    public float? VExitTargMax { get; set; }

    /// <summary>
    /// only for HMI: Max target strip exit speed status
    /// </summary>
    public short? VExitTargMaxStat { get; set; }

    /// <summary>
    /// only for HMI: Target strip exit speed status
    /// </summary>
    public short? VExitTargStat { get; set; }

    /// <summary>
    /// Unit[m/s] speed with which the tail has to leave the mill
    /// </summary>
    public float? VTailOutFm { get; set; }

    /// <summary>
    /// Unit[m/s] strip thread in speed coiler
    /// </summary>
    public float? VThrCoiler { get; set; }

    /// <summary>
    /// only for HMI: Strip thread speed coiler status
    /// </summary>
    public short? VThrCoilerStat { get; set; }

    /// <summary>
    /// Unit[m/s] target maximum circumference speed LAS threadin
    /// </summary>
    public float? VTmcLas { get; set; }

    /// <summary>
    /// Unit[m/s] target maximum circumference speed LAS after coiler threadin
    /// </summary>
    public float? VTmcLasAc { get; set; }

    /// <summary>
    /// Unit[m] second part of strip for side guide
    /// </summary>
    public float? W2sideGuide { get; set; }

    /// <summary>
    /// Unit[m] cast slab width hot
    /// </summary>
    public float? WCast { get; set; }

    /// <summary>
    /// Unit[m] width caster cold
    /// </summary>
    public float? WCastCold { get; set; }

    /// <summary>
    /// Unit[m] length of width change
    /// </summary>
    public float? WChangeLength { get; set; }

    /// <summary>
    /// Unit[m] position width change in front of F5
    /// </summary>
    public float? WChangePos { get; set; }

    /// <summary>
    /// Unit[m] tension reel/coiler: strip width (hot)
    /// </summary>
    public float? WCoiler { get; set; }

    /// <summary>
    /// Unit[m] entry width hot (rough strip width cold)
    /// </summary>
    public float? WEntryColdFm { get; set; }

    /// <summary>
    /// Unit[m] entry width hot (rough strip width hot)
    /// </summary>
    public float? WEntryHot { get; set; }

    /// <summary>
    /// Unit[m] strip width cold
    /// </summary>
    public float? WExitCold { get; set; }

    /// <summary>
    /// only for HMI: Strip width cold status
    /// </summary>
    public short? WExitColdStat { get; set; }

    /// <summary>
    /// Unit[m] width behind FM hot
    /// </summary>
    public float? WExitFmHot { get; set; }

    /// <summary>
    /// Unit[m] strip wedge max
    /// </summary>
    public float? WedgeMaxX { get; set; }

    /// <summary>
    /// Unit[m] strip wedge min
    /// </summary>
    public float? WedgeMinX { get; set; }

    /// <summary>
    /// Unit[m] strip wedge target
    /// </summary>
    public float? WedgeX { get; set; }

    public short? WpcAsymBlocked { get; set; }

    public short? WpcSymBlocked { get; set; }

    /// <summary>
    /// Unit[N/m2] tension reel/coiler: high temperature yield
    /// </summary>
    public float? YieldStress { get; set; }

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
