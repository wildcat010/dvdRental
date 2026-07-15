using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsHFMApxDataBlob
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
        public List<AdOrd2PcStand> Adord2PcStands { get; set; } = new();
        public AdOrd2Pc Adord2Pc { get; set; } = new();
        public StatSpOrd2Pc StatSpord2pcs { get; set; }= new();
        public StatEdOrdEnt StatEdordents { get; set; }= new();
        public StatEdPhyEnt StatEdphyents { get; set; }= new();
        public StatDirFmPfcParaP StatDirFmPfcParaPs { get; set; }= new();
        public List<StatDirFmPfcParaPpass> StatDirFmPfcParaPasses { get; set; } = new();
        public List<StatSpOrd2PcStand> StatSpord2pcstands { get; set; }= new();
        public StatEdLogEnt StatEdlogents { get; set; }= new();
        public List<StatLppass> StatLppasses { get; set; }= new();
        public List<StatDirFmPfcCycShiftPpass> StatDirfmpfccycshiftppasses { get; set; }= new();
        public StatDirFmPfcCycShiftP StatDirfmpfccycshiftps { get; set; }= new();
        public StatAdOrd2Pc StatAdord2Pc { get; set; }= new();
        public List<StatAdOrd2PcStand> StatAdord2PcStands { get; set; } = new();
        public List<Ihp> Ihps { get; internal set; }
        public List<Srp> Srps { get; internal set; }
    }
}