using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntBofHeatReport
{
    public int Id { get; set; }

    /// <summary>
    /// Unit[min] O2 blowing duration
    /// </summary>
    public int? BlowingDuration { get; set; }

    /// <summary>
    /// Blowing scheme
    /// </summary>
    public string BlowingScheme { get; set; }

    /// <summary>
    /// Unit[Nm3] O2 blowing volume
    /// </summary>
    public int? BlowingVolume { get; set; }

    /// <summary>
    /// Unit[min] Blowstart to tap duration - From blowing start to tapping start
    /// </summary>
    public int? BlowStartToTap { get; set; }

    /// <summary>
    /// Unit[min] Bubbling after blowing
    /// </summary>
    public int? BubblingAftBlowing { get; set; }

    /// <summary>
    /// Unit[min] Bubbling duration
    /// </summary>
    public int? BubblingDuration { get; set; }

    /// <summary>
    /// Unit[Nm3] Bubbling gas volume
    /// </summary>
    public int? BubblingGasVol { get; set; }

    /// <summary>
    /// Unit[%] Charged hot metal
    /// </summary>
    public int? ChgHotMetal { get; set; }

    /// <summary>
    /// Unit[kg] Metal charged weight
    /// </summary>
    public int? ChgMetalWeight { get; set; }

    /// <summary>
    /// Unit[%] Charged return steel
    /// </summary>
    public int? ChgReturnSteel { get; set; }

    /// <summary>
    /// Unit[%] Charged scrap total
    /// </summary>
    public int? ChgScrap { get; set; }

    /// <summary>
    /// 1 = True     0 = False
    /// </summary>
    public short? DeslaggingDone { get; set; }

    /// <summary>
    /// Deslagging done in KR station  1 = True    0  = False
    /// </summary>
    public short? DeslaggingDoneKr { get; set; }

    /// <summary>
    /// Heat number
    /// </summary>
    public string HeatNumber { get; set; }

    /// <summary>
    /// Unit[ppm] Oxygen at end - measured in casting ladle (after killing if applied)
    /// </summary>
    public int? OxygenAtEnd { get; set; }

    /// <summary>
    /// Unit[ppm] Oxygen before tapping - measured/calculated in BOF vessel
    /// </summary>
    public int? OxygenBefTapping { get; set; }

    /// <summary>
    /// BOF Number
    /// </summary>
    public int? PlantNumber { get; set; }

    /// <summary>
    /// Unit[min] reblowing duration
    /// </summary>
    public int? ReblowingDuration { get; set; }

    /// <summary>
    /// Reblowing time
    /// </summary>
    public int? ReblowingTimes { get; set; }

    /// <summary>
    /// Unit[Nm3] O2 reblowing volume
    /// </summary>
    public int? ReblowingVolume { get; set; }

    /// <summary>
    /// Unit[min] Gas flow &lt;= limit
    /// </summary>
    public int? RinsingDuration { get; set; }

    /// <summary>
    /// Unit[min] Any addition Al, alloys or scrap; gas flow &lt;= limit
    /// </summary>
    public int? RinsingDurLastAdd { get; set; }

    /// <summary>
    /// Unit[Nm3] Gas flow &lt;= limit
    /// </summary>
    public int? RinsingGasVolume { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// The status means whether the slag stopping is OK or not
    /// </summary>
    public int? SlagStopStatus { get; set; }

    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[s] Tapping duration - Stream started to stream stopped.
    /// </summary>
    public int? TappingDuration { get; set; }

    /// <summary>
    /// Unit[_C] Temperature at end - measured in casting ladle after tapping additions
    /// </summary>
    public int? TempAtEnd { get; set; }

    /// <summary>
    /// Unit[_C] Temperature before tapping - measured/calculated in BOF vessel
    /// </summary>
    public int? TempBefTapping { get; set; }

    /// <summary>
    /// Time when ladle left station
    /// </summary>
    public DateTime? TreatmentEndTime { get; set; }

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
