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
        public List<StatDirFmPfcParaPpass> DirFmPfcParaPasses { get; set; } = new();
        public List<Srppass> Srppasses { get; set; } = new();
        public List<Wmppass> Wmppasses { get; set; } = new();
        public List<SpOrd2PcStand> Spord2pcstands { get; set; } = new();
        public List<Lppass> Lppasses { get; set; } = new();
        public List<DirFmPfcCycShiftPpass> Dirfmpfccycshiftppasses { get; set; } = new();
        public List<DirFmPfcCycShiftP> Dirfmpfccycshiftps { get; set; } = new();

    }
}