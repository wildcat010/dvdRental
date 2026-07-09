using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsCsDataBlob
    {
        public List<Spord2pc> SpOrd2Pcs { get; internal set; }
        public List<Cspcresult> Cspcresults { get; internal set; }
        public List<Csstrategy> CsStrategies { get; internal set; }
        public List<Csprofile> CsProfiles { get; internal set; }
        public List<Cspccurve> CsPcCurves { get; internal set; }
        public Cspcresult CsPcResult { get; internal set; }
        public List<Cspcspeeddiag> CsPcSpeedDiags { get; internal set; }
    }
}
