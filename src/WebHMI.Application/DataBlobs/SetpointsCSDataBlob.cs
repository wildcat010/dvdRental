using System.Collections.Generic;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsCsDataBlob
    {
        public List<SpOrd2Pc> SpOrd2Pcs { get; internal set; }
        public List<CsPcResult> Cspcresults { get; internal set; }
        public List<CsStrategy> CsStrategies { get; internal set; }
        public List<CsProfile> CsProfiles { get; internal set; }
        public List<CspcCurve> CsPcCurves { get; internal set; }
        public CsPcResult CsPcResult { get; internal set; }
        public List<CsPcSpeedDiag> CsPcSpeedDiags { get; internal set; }
    }
}
