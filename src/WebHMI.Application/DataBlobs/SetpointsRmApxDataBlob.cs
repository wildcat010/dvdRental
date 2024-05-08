using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsRmApxDataBlob
    {
        public List<Lppass> LpPasses { get; set; }
        public List<DirFmPfcParaPpass> DirFmPfcParaPpasses { get; set; }
        public List<DirFmPfcCycShiftPpass> DirFmPfcCycShiftPpasses { get; set; }
        public List<SpOrd2PcStand> SpOrd2PcStands { get; set; }
        public List<Srppass> SrpPasses { get; set; }
        public List<StatDirFmPfcParaPpass> StatDirFmPfcParaPpassEffective { get; set; }
        public List<DirFmPfcCycShiftP> DirFmPfcCycShiftPs { get; set; }
        public List<DirFmPfcParaP> DirFmPfcParaPs { get; set; }
    }
}