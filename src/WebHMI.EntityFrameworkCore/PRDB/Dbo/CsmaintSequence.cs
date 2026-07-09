using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsmaintSequence
{
    public int Id { get; set; }

    public int MId { get; set; }

    public short? Novalves { get; set; }

    public short? Seqtype { get; set; }

    public short? Status { get; set; }

    public short? Valveend { get; set; }

    public short? Valvegroup { get; set; }

    public short? Valvestart { get; set; }

    public short? Valvetype { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
