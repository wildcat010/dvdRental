using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVRollinghistoryseq
{
    public long? Position { get; set; }

    public int? Enphmeid { get; set; }

    public int Enormeid { get; set; }

    public string EnOrMeType { get; set; }

    public string Enorextid { get; set; }

    public string Enorcreator { get; set; }

    public short? Enorstatus { get; set; }

    public DateTime? Optstatdatetime { get; set; }
}
