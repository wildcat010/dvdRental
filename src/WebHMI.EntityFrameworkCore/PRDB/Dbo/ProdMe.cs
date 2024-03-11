using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ProdMe
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
    /// BasId at entry time
    /// </summary>
    public short OriBasId { get; set; }

    /// <summary>
    /// ExtId at entry time
    /// </summary>
    public string OriExtId { get; set; }

    /// <summary>
    /// Me Creator at entry time
    /// </summary>
    public string OriMeCreator { get; set; }

    /// <summary>
    /// Me Id at entry time
    /// </summary>
    public int OriMeId { get; set; }

    /// <summary>
    /// MeTyp at entry time
    /// </summary>
    public string OriMeTyp { get; set; }

    /// <summary>
    /// MesId at entry time
    /// </summary>
    public short OriMesId { get; set; }

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
