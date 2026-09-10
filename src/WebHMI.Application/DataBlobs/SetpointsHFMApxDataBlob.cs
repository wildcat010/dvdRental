using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsHRMApxDataBlob
    {
        public List<SpOrd2Pc> Spord2pcs { get; set; } = new();
        public List<EdOrdEnt> Edordents { get; set; } = new();
        public List<EdPhyEnt> Edphyents { get; set; } = new();
        public List<EdLogEnt> Edlogents { get; set; } = new();
        public List<Me> Mes { get; set; } = new();
        public List<DirFmPfcParaP> DirFmPfcParaPs { get; set; } = new();
        public List<DirFmPfcParaPpass> DirFmPfcParaPasses { get; set; } = new();
        public List<Srppass> Srppasses { get; set; } = new();
        public List<Wmppass> Wmppasses { get; set; } = new();
        public List<SpOrd2PcStand> Spord2pcstands { get; set; } = new();
        public List<Lppass> Lppasses { get; set; } = new();
        public List<DirFmPfcCycShiftPpass> Dirfmpfccycshiftppasses { get; set; } = new();
        public List<DirFmPfcCycShiftP> Dirfmpfccycshiftps { get; set; } = new();
        public List<Lp> Lps { get; set; } = new();
        public AdOrd2Pc AdordPc2 { get; set; } = new();
        public List<AdOrd2PcStand> AdordPc2Stands { get; set; } = new();
        public StatSpOrd2Pc StatSpord2pcs { get; set; } = new();
        public StatEdOrdEnt StatEdordents { get; set; } = new();
        public StatEdPhyEnt StatEdphyents { get; set; } = new();
        public StatEdLogEnt StatEdlogents { get; set; } = new();
        public StatDirFmPfcParaP StatDirFmPfcParaPs { get; set; } = new();
        public List<StatDirFmPfcParaPpass> StatDirFmPfcParapPasses { get; set; } = new();
        public List<StatSpOrd2PcStand> StatSpord2pcstands { get; set; } = new();
        public List<StatLppass> StatLppasses { get; set; } = new();
        public List<StatDirFmPfcCycShiftPpass> StatDirfmpfccycshiftppasses { get; set; } = new();
        public StatDirFmPfcCycShiftP StatDirfmpfccycshiftps { get; set; } = new();
        public StatAdOrd2Pc StatAdordPc2 { get; set; } = new();
        public List<StatAdOrd2PcStand> StatAdordPc2Stands { get; set; } = new();
        public List<Srp> Srp { get; set; } = new();
        public List<Rcp> Rcps { get; set; } = new();
        public List<Wmp> Wmp { get; set; } = new();
    }
}