using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos
{
	public class MeCodeDto
	{
		/// <summary>
		/// Refers to table ME.MEID (material key)
		/// </summary>
		public long MeId { get; set; }

		/// <summary>
		/// Refers to table ME.CURMESID (material key)  1 - ENTRY MATERIAL, 2 - EXIT MATEIRAL (PRODUCT)
		/// </summary>
		public long MesId { get; set; }

		/// <summary>
		/// L3 - Created by MES/L3 system, PC - created by L2, OD - created by L2 after material has been divided
		/// </summary>
		public string MeCreator { get; set; }

		/// <summary>
		/// External material Id
		/// </summary>
		public string ExtId { get; set; }

		/// <summary>
		/// OR(der) or PH(yscial) or LO(gical)
		/// </summary>
		public string MatType { get; set; }

		/// <summary>
		/// Material status
		/// </summary>
		public short? Status { get; set; }
	}
}
