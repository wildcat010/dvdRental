using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsRmApxDataBlob
    {
        public List<Lppass> LpPasses { get; set; }
        public List<Dirfmpfcparappass> DirFmPfcParaPpasses { get; set; }
        public List<Dirfmpfccycshiftppass> DirFmPfcCycShiftPpasses { get; set; }
        public List<Spord2pcstand> SpOrd2PcStands { get; set; }
        public List<Srppass> SrpPasses { get; set; }
        public List<Stddirfmpfcparappass> StatDirFmPfcParaPpassEffective { get; set; }
        public List<Dirfmpfccycshiftp> DirFmPfcCycShiftPs { get; set; }
        public List<Dirfmpfcparap> DirFmPfcParaPs { get; set; }
    }
}