using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsRmDataBlob
    {
        public List<Lppass> LpPasses { get; set; }
        public List<Spord2pcstand> SpOrd2PcStands { get; set; }
        public List<Tppass> Tppasses { get; set; }
        public List<Dirfmpfcparappass> DirFmPfcParaPpasses { get; set; }
        public List<Stddirfmpfcparappass> StatDirFmPfcParaPpassEffective { get; set; }
        public List<Lp> Lps { get; set; }
        public List<Dphrm> Dphrms { get; set; }
        public List<Rcp> Rcps { get; set; }
        public List<Tp> Tps { get; set; }
        public List<Rglp> Rglps { get; set; }
        public List<Iscp> Iscps { get; set; }
        public List<Srppass> SrpPasses { get; set; }
    }
}