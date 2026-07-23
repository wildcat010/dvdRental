using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard interstand cooling plan pass
/// </summary>
public partial class StdIscppass
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// Unit[0...999] i s c p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[0..1] descaler auto AUTO = 0 MAN = 1
    /// </summary>
    public int? DescalerAuto { get; set; }

    /// <summary>
    /// Unit[0 / 1] descaler state: ON=0, OFF=1
    /// </summary>
    public int? DescalerState { get; set; }

    /// <summary>
    /// Unit[0...1] descaler factor from maximum cooling flow
    /// </summary>
    public double? DescalerVolume { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[0...1] fume (dust) suppresion spray
    /// </summary>
    public double? FumeSuppSprayBefor { get; set; }

    /// <summary>
    /// Unit[0...1] fume (dust) suppresion spray
    /// </summary>
    public double? FumeSuppSprayBehind { get; set; }

    /// <summary>
    /// Unit[0...1] intermediate beam cooling
    /// </summary>
    public double? IntermBeamCool { get; set; }

    /// <summary>
    /// Unit[0 / 1] ISC automatic mode: AUTO=0, MAN=1
    /// </summary>
    public int? IscAuto { get; set; }

    /// <summary>
    /// Unit[0...1] ISC maximum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMaxVolumeInd0 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC maximum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMaxVolumeInd1 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC maximum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMaxVolumeInd2 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC maximum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMaxVolumeInd3 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC minimum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMinVolumeInd0 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC minimum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMinVolumeInd1 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC minimum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMinVolumeInd2 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC minimum volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscMinVolumeInd3 { get; set; }

    /// <summary>
    /// Unit[0 / 1] ISC state: ON=0, OFF=1
    /// </summary>
    public int? IscState { get; set; }

    /// <summary>
    /// Unit[0...1] ISC volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscVolumeInd0 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscVolumeInd1 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscVolumeInd2 { get; set; }

    /// <summary>
    /// Unit[0...1] ISC volume factor from maximum cooling flow (plant par). [0]= isc 0, [1]= isc 1, [2]= mill stand power cooling
    /// </summary>
    public double? IscVolumeInd3 { get; set; }

    /// <summary>
    /// Unit[0...1] looper cooling
    /// </summary>
    public double? LooperCool { get; set; }

    /// <summary>
    /// Unit[0 .... n] behind pass X, priority: -1: do not switch, 0,1,2,3,.....: lowest number is switched on first and switched off last
    /// </summary>
    public int? PrioDescaler { get; set; }

    /// <summary>
    /// Unit[0 ..... n] ISC, priority: -1: do not switch, 0,1,2,3,.....: lowest number is switched on first and switched off last
    /// </summary>
    public int? PrioIsc { get; set; }

    /// <summary>
    /// Unit[0...1] special spray, before pass X, roll gap spray
    /// </summary>
    public double? RollGapSpray { get; set; }

    /// <summary>
    /// Unit[0...1] strip spraying
    /// </summary>
    public double? StripSprayBefor { get; set; }

    /// <summary>
    /// Unit[0...1] strip spraying
    /// </summary>
    public double? StripSprayBehind { get; set; }

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

    /// <summary>
    /// Unit[0...1] longitudinal spraying
    /// </summary>
    public double? LongCrossSpray { get; set; }
}
