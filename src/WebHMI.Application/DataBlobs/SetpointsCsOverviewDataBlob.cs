using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsCsOverviewDataBlob
    {
        public List<Edordent> Edordents { get; internal set; }
        public List<Spord2pc> SpOrd2Pcs { get; internal set; }
        public List<Csstrategy> CsStrategies { get; internal set; }
        public List<Csprofile> CsProfiles { get; internal set; }
        public List<Cscr> CsCrs { get; internal set; }
        public List<Csrtcooling> CsRtCoolings { get; internal set; }
        public List<Csperf> CsPerves { get; internal set; }
        public Cspcresult CsPcResult { get; internal set; }
    }
}
