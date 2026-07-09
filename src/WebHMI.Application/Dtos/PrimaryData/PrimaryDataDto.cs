using System.Collections.Generic;
using WebHMI.Dtos.Common;

namespace WebHMI.Dtos.PrimaryData
{
	public class PrimaryDataDto
	{
		public MeCodeDto OrMeCode { get; set; } = new();
        public MeCodeDto PhMeCode { get; internal set; }
        public MaterialData Data { get; set; } = new();
        public CSDataDto CSData { get; set; } = new();
        public List<ChemistryElement> ChemistryElements { get; set; } = [];
    }
}
