using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVApsepfm
{
    public int Planno { get; set; }

    public int Activeflag { get; set; }

    public int? EncoswitchInd0 { get; set; }

    public int? EncoswitchInd1 { get; set; }

    public int? EncoswitchInd2 { get; set; }

    public int? EncoswitchInd3 { get; set; }
}
