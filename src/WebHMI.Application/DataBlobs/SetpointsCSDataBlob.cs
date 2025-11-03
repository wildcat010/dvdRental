using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
    public class SetpointsCSDataBlob
    {
        public List<EdOrdEnt> Edordents { get; set; } = new();
        public List<SpOrd2Pc> SpOrd2Pcs { get; set; } = new();
        public List<CsStrategy> CsStrategies { get; set; } = new();
        public List<CsProfile> CsProfiles { get; set; } = new();
        public List<CsCr> CsCrs { get; set; } = new();
        public List<CsRtCooling> CsRtCoolings { get; set; } = new();
        public List<CsPerf> CsPerves { get; set; } = new();
        public List<CsPcResult> CsPcResults { get; set; } = new();
        //public List<CsEdgeMasking> CsEdgeMaskings { get; set; } = new();
    }
}
