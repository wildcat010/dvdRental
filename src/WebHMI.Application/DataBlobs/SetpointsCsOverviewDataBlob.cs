using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsCsOverviewDataBlob
    {
        public List<EdOrdEnt> Edordents { get; internal set; }
        public List<SpOrd2Pc> SpOrd2Pcs { get; internal set; }
        public List<CsStrategy> CsStrategies { get; internal set; }
        public List<CsProfile> CsProfiles { get; internal set; }
        public List<CsCr> CsCrs { get; internal set; }
        public List<CsRtCooling> CsRtCoolings { get; internal set; }
        public List<CsPerf> CsPerves { get; internal set; }
        public CsPcResult CsPcResult { get; internal set; }
    }
}
