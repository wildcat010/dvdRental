using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Common
{
	public class MaterialHeaderDto
	{
		public MeCodeDto MeCode { get; set; }
		public MaterialHeaderData Data { get; set; } = new();
	}

	public class MaterialHeaderData
	{

	}
}
