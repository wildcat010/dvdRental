using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.PrimaryData
{
	public class PrimaryDataDto
	{
		public MeCodeDto MeCode { get; set; } = new();
		public MaterialData Data { get; set; } = new();
		public List<ChemistryElement> ChemistryElements { get; set; } = [];
	}
}
