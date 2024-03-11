using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class AltMat
{
    /// <summary>
    /// record id
    /// </summary>
    public int RecId { get; set; }

    /// <summary>
    /// Unit[kg] Planned weight
    /// </summary>
    public float? AimCoilWeight { get; set; }

    /// <summary>
    /// Amount of bindings circumferential
    /// </summary>
    public int? AmountBindingsC { get; set; }

    /// <summary>
    /// amount of products that can be rolled (will be decreased by L2 automatically)
    /// </summary>
    public int? AmountOfProducts { get; set; }

    /// <summary>
    /// batch rolling in FM default = 1
    /// </summary>
    public int? BatchRolling { get; set; }

    /// <summary>
    /// Unit[m/s] minimun casting speed to roll product
    /// </summary>
    public float CastSpeedMin { get; set; }

    /// <summary>
    /// Cooling intensity bottom (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public float? CoolRateBot { get; set; }

    /// <summary>
    /// Cooling intensity  top (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public float? CoolRateTop { get; set; }

    /// <summary>
    /// CoolingSection: 1=early cooling, 2=late cooling, 4=dual phase cooling
    /// </summary>
    public int? CoolStrategy { get; set; }

    /// <summary>
    /// 0=Use directives  from Look up table deposited in the L2, 1= Use directives of the PDI  (L3)
    /// </summary>
    public int? CoolingMode { get; set; }

    /// <summary>
    /// Unit[m] Classif. maximal strip crown delta from aim C25
    /// </summary>
    public float? CrownClasMax { get; set; }

    /// <summary>
    /// 0=no dual phase steel, 1=dual phase steel
    /// </summary>
    public int? DualPhase { get; set; }

    /// <summary>
    /// Unit[m] Finished strip crown C25
    /// </summary>
    public float? ExitCrownC25 { get; set; }

    /// <summary>
    /// First valve to be switched lower side,(laminar cooling section) (NULL -&gt; use L2 strategy)
    /// </summary>
    public int? FirstValveSwitchLo { get; set; }

    /// <summary>
    /// First valve to be switched upper side (laminar cooling section) (NULL -&gt; use L2 strategy)
    /// </summary>
    public int? FirstValveSwitchUp { get; set; }

    /// <summary>
    /// Flag delivery specification, 0=Coil Yard, 1=cold rolling mill, 2 = Shipping client 1, only for operator information
    /// </summary>
    public int? FlagDelivery { get; set; }

    /// <summary>
    /// Unit[I-Unit] Classif. max. asymmetric strip flatness delta from 0
    /// </summary>
    public float? FlatAsymClasMax { get; set; }

    /// <summary>
    /// Unit[I-Unit] Classif. max. symmetric strip flatness delta from 0
    /// </summary>
    public float? FlatSymclasMax { get; set; }

    /// <summary>
    /// from basket default =1
    /// </summary>
    public int? FromBasket { get; set; }

    /// <summary>
    /// Unit[m] max.strip thickness delta from aim for classification purpose
    /// </summary>
    public float? HClasMax { get; set; }

    /// <summary>
    /// Unit[m] min.strip thickness delta from aim for classification purpose
    /// </summary>
    public float? HClasMin { get; set; }

    /// <summary>
    /// Unit[m] Finished strip/plate thickness
    /// </summary>
    public float HExit { get; set; }

    /// <summary>
    /// thickness  ordered by customer
    /// </summary>
    public float? HExitCustomer { get; set; }

    /// <summary>
    /// Unit[m] thickness at exit of HRM ( if NULL L2 decides automatically)
    /// </summary>
    public float? HIntermediate { get; set; }

    /// <summary>
    /// dual phase steel: hold temperature
    /// </summary>
    public float? HoldTemperature { get; set; }

    /// <summary>
    /// dual phase steel: hold time
    /// </summary>
    public float? HoldTime { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public int? InspectionCode { get; set; }

    /// <summary>
    /// Unit[m] Length of uncooled head (NULL -&gt; use L2 strategy)
    /// </summary>
    public float? LengthUncooledHead { get; set; }

    /// <summary>
    /// Unit[m] Length of uncooled tail (NULL -&gt; use L2 strategy)
    /// </summary>
    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// Unit[m] minimum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MaxCoilWeight { get; set; }

    /// <summary>
    /// Unit[m] maximum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MinCoilWeight { get; set; }

    /// <summary>
    /// 1=product should not be counted, is the product, which is always rollable
    /// </summary>
    public int? NotCountable { get; set; }

    /// <summary>
    /// 0: strip, 1: plate
    /// </summary>
    public int? PlateProduction { get; set; }

    /// <summary>
    /// priority 1 to 10 (1 - highest priority, is calculated first), additional selection criterion
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// steelgrade ordered by customer
    /// </summary>
    public string SteelCustomer { get; set; }

    /// <summary>
    /// Steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[_C] Classif. max. strip temperature delta
    /// </summary>
    public float? TClasMax { get; set; }

    /// <summary>
    /// Unit[_C] Classif. min. strip temperature delta
    /// </summary>
    public float? TClasMin { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section exit strip temperature
    /// </summary>
    public float? TCoolExit { get; set; }

    /// <summary>
    /// Unit[_C] Max. cooling section exit strip temperature delta
    /// </summary>
    public float? TCoolMax { get; set; }

    /// <summary>
    /// Unit[_C] Min. cooling section exit strip temperature delta
    /// </summary>
    public float? TCoolMin { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip wedge delta from 0
    /// </summary>
    public float? WedgeClasMax { get; set; }

    /// <summary>
    /// Unit[mm] maximal strip width delta from aim for classification purpose
    /// </summary>
    public float? WidthClasMax { get; set; }

    /// <summary>
    /// Unit[mm] minimal strip width delta from aim for classification purpose
    /// </summary>
    public float? WidthClasMin { get; set; }

    /// <summary>
    /// Unit[m] Finished strip customer width
    /// </summary>
    public float? WidthExit { get; set; }

    /// <summary>
    /// width ordered by customer
    /// </summary>
    public float? WidthExitCustomer { get; set; }

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
}
