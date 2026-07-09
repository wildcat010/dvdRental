using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsHRMDataBlob
    {
        public Adord2pc adordPc2 { get; set; } = new();
        public List<Adord2pcstand> adordPc2Stands { get; set; } = new();

        public List<Srppass> Srppasses { get; set; } = new();
        public List<Spord2pcstand> Spord2pcstands { get; set; } = new();
        public List<Aoppass> Aoppasses { get; set; } = new();
        public List<Iscppass> Iscpasses { get; set; } = new();
        public List<Rcppass> Rcppasses { get; set; } = new();
        public List<Lppass> Lppasses { get; set; } = new();
        public List<Tppass> Tppasses { get; set; } = new();
        public List<Dirfmpfccycshiftppass> Dirfmpfccycshiftppasses { get; set; } = new();
        public List<Dirfmpfccycshiftp> Dirfmpfccycshiftps { get; set; } = new();
        public List<Iscp> Iscps { get; set; } = new();
        public List<Rglp> Rglps { get; set; } = new();
        public List<Tp> Tps { get; set; } = new();
        public List<Rcp> Rcps { get; set; } = new();
        public List<Dphrm> DpRms { get; set; } = new();
        public List<Dpramphrm> Dpramprms { get; set; } = new();
        public List<Lp> Lps { get; set; } = new();
        public List<Spord2pc> Spord2pcs { get; set; } = new();
        public List<Edordent> Edordents { get; set; } = new();
        public List<Edphyent> Edphyents { get; set; } = new();
        public List<Edlogent> Edlogents { get; set; } = new();
        public List<Me> Mes { get; set; } = new();
        public List<Dirfmpfcparap> DirFmPfcParaPs { get; set; } = new();
        public List<Dirfmpfcparappass> DirFmPfcParapPasses { get; set; } = new();
        public List<StatSpord2pcstand> StatSpord2pcstands { get; set; } = new();
        public List<StatLppass> StatLppasses { get; set; } = new();
        public StatDirfmpfccycshiftp StatDirfmpfccycshiftps { get; set; } = new();
        public List<StatDirfmpfccycshiftppass> StatDirfmpfccycshiftppasses { get; set; } = new();
        public StatSpord2pc StatSpord2pcs { get; set; } = new();
        public StatEdordent StatEdordents { get; set; } = new();
        public StatEdphyent StatEdphyents { get; set; } = new();
        public StatEdlogent StatEdlogents { get; set; } = new();
        public StatDirfmpfcparap StatDirFmPfcParaPs { get; set; } = new();
        public List<StatDirfmpfcparappass> StatDirFmPfcParapPasses { get; set; } = new();
        public StatAdord2pc StatadordPc2 { get; set; } = new();
        public List<StatAdord2pcstand> StatadordPc2Stands { get; set; } = new();
    }
}