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

    public virtual ICollection<Aop> Aops { get; set; } = new List<Aop>();

    public virtual CastSlabStartPo CastSlabStartPo { get; set; }

    public virtual CastSlabStartPosL1 CastSlabStartPosL1 { get; set; }

    public virtual ICollection<CasterSndRequest> CasterSndRequests { get; set; } = new List<CasterSndRequest>();

    public virtual ICollection<CsCoilTempOffset> CsCoilTempOffsets { get; set; } = new List<CsCoilTempOffset>();

    public virtual ICollection<CsCr> CsCrs { get; set; } = new List<CsCr>();

    public virtual CsPcResult CsPcResult { get; set; }

    public virtual ICollection<CsPcSpeedDiag> CsPcSpeedDiags { get; set; } = new List<CsPcSpeedDiag>();

    public virtual ICollection<CsPerf> CsPerves { get; set; } = new List<CsPerf>();

    public virtual ICollection<CsProfile> CsProfiles { get; set; } = new List<CsProfile>();

    public virtual ICollection<CsRtCooling> CsRtCoolings { get; set; } = new List<CsRtCooling>();

    public virtual ICollection<CsStrategy> CsStrategies { get; set; } = new List<CsStrategy>();

    public virtual ICollection<CsccCurve> CsccCurves { get; set; } = new List<CsccCurve>();

    public virtual ICollection<Csdir> Csdirs { get; set; } = new List<Csdir>();

    public virtual ICollection<CspcCurve> CspcCurves { get; set; } = new List<CspcCurve>();

    public virtual ICollection<Defect> Defects { get; set; } = new List<Defect>();

    public virtual ICollection<DirFmPfcCycShiftPpass> DirFmPfcCycShiftPpasses { get; set; } = new List<DirFmPfcCycShiftPpass>();

    public virtual ICollection<DirFmPfcCycShiftP> DirFmPfcCycShiftPs { get; set; } = new List<DirFmPfcCycShiftP>();

    public virtual ICollection<DirFmPfcParaPpass> DirFmPfcParaPpasses { get; set; } = new List<DirFmPfcParaPpass>();

    public virtual ICollection<DirFmPfcParaP> DirFmPfcParaPs { get; set; } = new List<DirFmPfcParaP>();

    public virtual Dp Dp { get; set; }

    public virtual ICollection<Dpfm> Dpfms { get; set; } = new List<Dpfm>();

    public virtual ICollection<Dphrm> Dphrms { get; set; } = new List<Dphrm>();

    public virtual Dpramp Dpramp { get; set; }

    public virtual ICollection<DprampFm> DprampFms { get; set; } = new List<DprampFm>();

    public virtual ICollection<DprampHrm> DprampHrms { get; set; } = new List<DprampHrm>();

    public virtual ICollection<EdLogEnt> EdLogEnts { get; set; } = new List<EdLogEnt>();

    public virtual ICollection<EdOrdEnt> EdOrdEnts { get; set; } = new List<EdOrdEnt>();

    public virtual ICollection<EdPhyEnt> EdPhyEnts { get; set; } = new List<EdPhyEnt>();

    public virtual ICollection<EntryProfileMeasuring> EntryProfileMeasurings { get; set; } = new List<EntryProfileMeasuring>();

    public virtual ICollection<FlatnessMeasuring> FlatnessMeasurings { get; set; } = new List<FlatnessMeasuring>();

    public virtual ICollection<Ihp> Ihps { get; set; } = new List<Ihp>();

    public virtual ICollection<InspCut> InspCuts { get; set; } = new List<InspCut>();

    public virtual ICollection<Iscppass> Iscppasses { get; set; } = new List<Iscppass>();

    public virtual ICollection<Iscp> Iscps { get; set; } = new List<Iscp>();

    public virtual ICollection<Lppass> Lppasses { get; set; } = new List<Lppass>();

    public virtual ICollection<Lp> Lps { get; set; } = new List<Lp>();

    public virtual ICollection<MatActComment> MatActComments { get; set; } = new List<MatActComment>();

    public virtual ICollection<MatCutInfo> MatCutInfos { get; set; } = new List<MatCutInfo>();

    public virtual ICollection<MatHeat> MatHeats { get; set; } = new List<MatHeat>();

    public virtual ICollection<MatInspPhyPro> MatInspPhyPros { get; set; } = new List<MatInspPhyPro>();

    public virtual Me Me { get; set; }

    public virtual Me MeNavigation { get; set; }

    public virtual MipResult MipResult { get; set; }

    public virtual MosPqe MosPqe { get; set; }

    public virtual ICollection<MsmDir> MsmDirs { get; set; } = new List<MsmDir>();

    public virtual ICollection<OperTime> OperTimes { get; set; } = new List<OperTime>();

    public virtual ICollection<Pcramp> Pcramps { get; set; } = new List<Pcramp>();

    public virtual ICollection<Pc> Pcs { get; set; } = new List<Pc>();

    public virtual ICollection<PrLogPro> PrLogPros { get; set; } = new List<PrLogPro>();

    public virtual ICollection<PrOrdProStand> PrOrdProStands { get; set; } = new List<PrOrdProStand>();

    public virtual ICollection<PrOrdPro> PrOrdPros { get; set; } = new List<PrOrdPro>();

    public virtual ICollection<PrPhyPro> PrPhyPros { get; set; } = new List<PrPhyPro>();

    public virtual ICollection<PrRollDataPro> PrRollDataPros { get; set; } = new List<PrRollDataPro>();

    public virtual ICollection<PrSignalPro> PrSignalPros { get; set; } = new List<PrSignalPro>();

    public virtual ProdMe ProdMe { get; set; }

    public virtual Qemea Qemea { get; set; }

    public virtual ICollection<QemeasSeg> QemeasSegs { get; set; } = new List<QemeasSeg>();

    public virtual ICollection<Rcppass> Rcppasses { get; set; } = new List<Rcppass>();

    public virtual ICollection<Rcp> Rcps { get; set; } = new List<Rcp>();

    public virtual ICollection<Rglppass> Rglppasses { get; set; } = new List<Rglppass>();

    public virtual ICollection<Rglp> Rglps { get; set; } = new List<Rglp>();

    public virtual ICollection<RmcalcResToMsm> RmcalcResToMsms { get; set; } = new List<RmcalcResToMsm>();

    public virtual ICollection<RollCoolCurve> RollCoolCurves { get; set; } = new List<RollCoolCurve>();

    public virtual RoughStripTemp RoughStripTemp { get; set; }

    public virtual ICollection<ScrapCut> ScrapCuts { get; set; } = new List<ScrapCut>();

    public virtual SegDefPc1 SegDefPc1 { get; set; }

    public virtual SegDefPc2 SegDefPc2 { get; set; }

    public virtual ICollection<SpLogEnt> SpLogEnts { get; set; } = new List<SpLogEnt>();

    public virtual ICollection<SpOrd1PcStand> SpOrd1PcStands { get; set; } = new List<SpOrd1PcStand>();

    public virtual ICollection<SpOrd2PcStand> SpOrd2PcStands { get; set; } = new List<SpOrd2PcStand>();

    public virtual ICollection<SpOrd2Pc> SpOrd2Pcs { get; set; } = new List<SpOrd2Pc>();

    public virtual ICollection<SpOrdEnt> SpOrdEnts { get; set; } = new List<SpOrdEnt>();

    public virtual ICollection<SpPhyEnt> SpPhyEnts { get; set; } = new List<SpPhyEnt>();

    public virtual ICollection<Srppass> Srppasses { get; set; } = new List<Srppass>();

    public virtual ICollection<Srp> Srps { get; set; } = new List<Srp>();

    public virtual ICollection<StatCsCoilTempOffset> StatCsCoilTempOffsets { get; set; } = new List<StatCsCoilTempOffset>();

    public virtual ICollection<StatCsCr> StatCsCrs { get; set; } = new List<StatCsCr>();

    public virtual ICollection<StatCsPerf> StatCsPerves { get; set; } = new List<StatCsPerf>();

    public virtual ICollection<StatCsProfile> StatCsProfiles { get; set; } = new List<StatCsProfile>();

    public virtual ICollection<StatCsRtCooling> StatCsRtCoolings { get; set; } = new List<StatCsRtCooling>();

    public virtual ICollection<StatCsStrategy> StatCsStrategies { get; set; } = new List<StatCsStrategy>();

    public virtual ICollection<StatDirFmPfcCycShiftPpass> StatDirFmPfcCycShiftPpasses { get; set; } = new List<StatDirFmPfcCycShiftPpass>();

    public virtual ICollection<StatDirFmPfcCycShiftP> StatDirFmPfcCycShiftPs { get; set; } = new List<StatDirFmPfcCycShiftP>();

    public virtual ICollection<StatDirFmPfcParaPpass> StatDirFmPfcParaPpasses { get; set; } = new List<StatDirFmPfcParaPpass>();

    public virtual ICollection<StatDirFmPfcParaP> StatDirFmPfcParaPs { get; set; } = new List<StatDirFmPfcParaP>();

    public virtual ICollection<StatMsmDir> StatMsmDirs { get; set; } = new List<StatMsmDir>();

    public virtual ICollection<Tppass> Tppasses { get; set; } = new List<Tppass>();

    public virtual ICollection<Tp> Tps { get; set; } = new List<Tp>();

    public virtual ICollection<Wmppass> Wmppasses { get; set; } = new List<Wmppass>();

    public virtual ICollection<Wmp> Wmps { get; set; } = new List<Wmp>();
}
