using System.Collections.Generic;
using WebHMI.Dtos.Common;
using WebHMI.Interface;

namespace WebHMI.Dtos.PrimaryData
{
	public class PrimaryDataDto : IAuditLogRelatedIdGetter
    {
		public MeCodeDto OrMeCode { get; set; } = new();
        public MeCodeDto PhMeCode { get; set; }
        public MaterialData Data { get; set; } = new();
        public CSDataDto CSData { get; set; } = new();
        public List<ChemistryElement> ChemistryElements { get; set; } = [];

        public string GetAuditLogRelatedId()
        {
            return OrMeCode.GetAuditLogRelatedId();
        }
    }
}
