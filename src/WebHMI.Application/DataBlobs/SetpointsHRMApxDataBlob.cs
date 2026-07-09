using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsHFMApxDataBlob
    {
        public List<Spord2pc> Spord2pcs { get; set; } = new();
        public List<Edordent> Edordents { get; set; } = new();
        public List<Edphyent> Edphyents { get; set; } = new();
        public List<Edlogent> Edlogents { get; set; } = new();
        public List<Me> Mes { get; set; } = new();
        public List<Dirfmpfcparap> DirFmPfcParaPs { get; set; } = new();
        public List<Dirfmpfcparappass> DirFmPfcParaPasses { get; set; } = new();
        public List<Srppass> Srppasses { get; set; } = new();
        public List<Wmppass> Wmppasses { get; set; } = new();
        public List<Spord2pcstand> Spord2pcstands { get; set; } = new();
        public List<Lppass> Lppasses { get; set; } = new();
        public List<Dirfmpfccycshiftppass> Dirfmpfccycshiftppasses { get; set; } = new();
        public List<Dirfmpfccycshiftp> Dirfmpfccycshiftps { get; set; } = new();
        public List<Lp> Lps { get; set; } = new();
        public List<Adord2pcstand> Adord2PcStands { get; set; } = new();
        public Adord2pc Adord2Pc { get; set; } = new();
        public StatSpord2pc StatSpord2pcs { get; set; }= new();
        public StatEdordent StatEdordents { get; set; }= new();
        public StatEdphyent StatEdphyents { get; set; }= new();
        public StatDirfmpfcparap StatDirFmPfcParaPs { get; set; }= new();
        public List<StatDirfmpfcparappass> StatDirFmPfcParaPasses { get; set; } = new();
        public List<StatSpord2pcstand> StatSpord2pcstands { get; set; }= new();
        public StatEdlogent StatEdlogents { get; set; }= new();
        public List<StatLppass> StatLppasses { get; set; }= new();
        public List<StatDirfmpfccycshiftppass> StatDirfmpfccycshiftppasses { get; set; }= new();
        public StatDirfmpfccycshiftp StatDirfmpfccycshiftps { get; set; }= new();
        public StatAdord2pc StatAdord2Pc { get; set; }= new();
        public List<StatAdord2pcstand> StatAdord2PcStands { get; set; } = new();
        public List<Ihp> Ihps { get; internal set; }
        public List<Srp> Srps { get; internal set; }
    }
}