using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Me
{
    /// <summary>
    /// creator of material
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// material identification
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Basis Id of material
    /// </summary>
    public short BasId { get; set; }

    /// <summary>
    /// Unit[Unit] actual workstep of the material
    /// </summary>
    public short? CurMesId { get; set; }

    /// <summary>
    /// working step, with that come the material into the plant
    /// </summary>
    public short? EntMesId { get; set; }

    /// <summary>
    /// external material identification
    /// </summary>
    public string ExtId { get; set; }

    /// <summary>
    /// type of material
    /// </summary>
    public string MeTyp { get; set; }

    /// <summary>
    /// working step, with which the material left the plant.
    /// </summary>
    public short? OutMesId { get; set; }

    /// <summary>
    /// operation status  -1 = planed, 0= requested, 1=inline (entry), 2= in production, 3= produced, 4 finish prod., 5 = outline
    /// </summary>
    public short? Status { get; set; }

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

    public virtual ICollection<Me1> Me1MeNavigations { get; set; } = new List<Me1>();

    public virtual ICollection<Me1> Me1Mes { get; set; } = new List<Me1>();
}
