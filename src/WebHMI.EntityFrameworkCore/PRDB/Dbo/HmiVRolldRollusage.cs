using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRolldRollusage
{
    public int Installct { get; set; }

    public string Rollid { get; set; }

    public float? Rolledweight { get; set; }

    public float? Rolledlength { get; set; }

    public short? Standid { get; set; }

    public string Rolltype { get; set; }

    public string Rollpos { get; set; }
}
