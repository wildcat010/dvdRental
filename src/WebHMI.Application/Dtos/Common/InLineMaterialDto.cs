using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Common
{
	public class InLineMaterialDto
	{
		public string EnPhExtId { get; set; }

		public int EnPhMeId { get; set; }

		public string EdPhySrc { get; set; }

		public short? EnPhStatus { get; set; }

		public int EnOrMeId { get; set; }

		public string EnOrExtId { get; set; }

		public string EnOrMeType { get; set; }

		public short? EnOrMesId { get; set; }

		public string EnOrCreator { get; set; }

		public string EdOrSrc { get; set; }

		public int EnLoMeId { get; set; }

		public string EdLoSrc { get; set; }

		public string AlloyCode { get; set; }

		public double? HEntry { get; set; }

		public double? HExit { get; set; }

		public double? WEntry { get; set; }

		public double? WeightEntry { get; set; }

		public double? LEntry { get; set; }

		public double? WExit { get; set; }

		public string SequenceId { get; set; }

		public short? PdiStatus { get; set; }

		public short? SetpointsPc2Ok { get; set; }

		public int? Sbaz { get; set; }

		public DateTime? LastCalc { get; set; }

		public string ApsKey { get; set; }

		public int? SimMat { get; set; }

		public short? SetpointsCsOk { get; set; }

		public double? TEntryFm { get; set; }

		public double? TExitFm { get; set; }

		public double? TExitCaster { get; set; }

		public double? CoilTemp { get; set; }

		public string HeatId { get; set; }

		public int? FlagBatchRolling { get; set; }

		public DateTime? ProdStartTime { get; set; }
		public int? ProductType { get; set; }
	}
}
