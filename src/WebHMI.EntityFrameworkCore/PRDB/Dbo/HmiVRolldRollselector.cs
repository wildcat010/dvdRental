using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRolldRollselector
{
    public string RollId { get; set; }

    public string PlantType { get; set; }

    public string RollType { get; set; }

    public string StandRange { get; set; }

    public int? StandId { get; set; }

    public int? Grinding { get; set; }

    public float Diameter { get; set; }

    public float? RolledLength { get; set; }

    public float? RolledWeight { get; set; }

    public string Stat { get; set; }

    public int? Rollclass { get; set; }

    public string RollclassDescr { get; set; }

    public int RollPropertyClass { get; set; }

    public string RollPropertyDescr { get; set; }

    public int? ShapeType { get; set; }

    public short RollShapeCode { get; set; }

    public string ShapeCodeDescr { get; set; }
}
