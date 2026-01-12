using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Me1
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
    /// Unit[Unit] MeCreator of parent material
    /// </summary>
    public string CompMeCreator { get; set; }

    /// <summary>
    /// Unit[Unit] MeId of parent material
    /// </summary>
    public int? CompMeId { get; set; }

    /// <summary>
    /// Unit[Unit] MesId of parent material
    /// </summary>
    public short? CompMesId { get; set; }

    /// <summary>
    /// Unit[Unit] Position in parent material
    /// </summary>
    public short? CompPos { get; set; }

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

    public virtual ICollection<Aoppass> Aoppasses { get; set; } = new List<Aoppass>();

    public virtual ICollection<CsCr> CsCrs { get; set; } = new List<CsCr>();

    public virtual CsPcResult CsPcResult { get; set; }

    public virtual ICollection<CsPerf> CsPerves { get; set; } = new List<CsPerf>();

    public virtual ICollection<CsProfile> CsProfiles { get; set; } = new List<CsProfile>();

    public virtual ICollection<CsRtCooling> CsRtCoolings { get; set; } = new List<CsRtCooling>();

    public virtual ICollection<CsStrategy> CsStrategies { get; set; } = new List<CsStrategy>();

    public virtual ICollection<Defect> Defects { get; set; } = new List<Defect>();

    public virtual ICollection<DirFmPfcCycShiftPpass> DirFmPfcCycShiftPpasses { get; set; } = new List<DirFmPfcCycShiftPpass>();

    public virtual ICollection<DirFmPfcCycShiftP> DirFmPfcCycShiftPs { get; set; } = new List<DirFmPfcCycShiftP>();

    public virtual ICollection<DirFmPfcParaPpass> DirFmPfcParaPpasses { get; set; } = new List<DirFmPfcParaPpass>();

    public virtual ICollection<DirFmPfcParaP> DirFmPfcParaPs { get; set; } = new List<DirFmPfcParaP>();

    public virtual ICollection<Dpfm> Dpfms { get; set; } = new List<Dpfm>();

    public virtual ICollection<Dphrm> Dphrms { get; set; } = new List<Dphrm>();

    public virtual ICollection<DprampFm> DprampFms { get; set; } = new List<DprampFm>();

    public virtual ICollection<DprampHrm> DprampHrms { get; set; } = new List<DprampHrm>();

    public virtual ICollection<EdLogEnt> EdLogEnts { get; set; } = new List<EdLogEnt>();

    public virtual ICollection<EdOrdEnt> EdOrdEnts { get; set; } = new List<EdOrdEnt>();

    public virtual ICollection<EdPhyEnt> EdPhyEnts { get; set; } = new List<EdPhyEnt>();

    public virtual ICollection<Ihp> Ihps { get; set; } = new List<Ihp>();

    public virtual ICollection<Iscppass> Iscppasses { get; set; } = new List<Iscppass>();

    public virtual ICollection<Iscp> Iscps { get; set; } = new List<Iscp>();

    public virtual ICollection<Lppass> Lppasses { get; set; } = new List<Lppass>();

    public virtual ICollection<Lp> Lps { get; set; } = new List<Lp>();

    public virtual Me Me { get; set; }

    public virtual Me MeNavigation { get; set; }

    public virtual ICollection<Rcppass> Rcppasses { get; set; } = new List<Rcppass>();

    public virtual ICollection<Rcp> Rcps { get; set; } = new List<Rcp>();

    public virtual ICollection<Rglppass> Rglppasses { get; set; } = new List<Rglppass>();

    public virtual ICollection<Rglp> Rglps { get; set; } = new List<Rglp>();

    public virtual ICollection<SpOrd2PcStand> SpOrd2PcStands { get; set; } = new List<SpOrd2PcStand>();

    public virtual ICollection<SpOrd2Pc> SpOrd2Pcs { get; set; } = new List<SpOrd2Pc>();

    public virtual ICollection<Srppass> Srppasses { get; set; } = new List<Srppass>();

    public virtual ICollection<Srp> Srps { get; set; } = new List<Srp>();

    public virtual ICollection<StatDirFmPfcParaPpass> StatDirFmPfcParaPpasses { get; set; } = new List<StatDirFmPfcParaPpass>();

    public virtual ICollection<Tppass> Tppasses { get; set; } = new List<Tppass>();

    public virtual ICollection<Tp> Tps { get; set; } = new List<Tp>();

    public virtual ICollection<Wmppass> Wmppasses { get; set; } = new List<Wmppass>();
}
