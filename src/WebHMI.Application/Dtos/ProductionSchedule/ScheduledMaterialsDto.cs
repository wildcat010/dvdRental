using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.ProductionSchedule
{
	public class ScheduledMaterialsDto
	{
		public MeCodeDto EnOrMeCode { get; set; }
		public MeCodeDto EnLogMeCode { get; set; }
		public MeCodeDto EnPhMeCode { get; set; }

        public double? HExitHrm {  get; set; } 
        public double? HExitHrmCalc {  get; set; }
        public double? ProfileHRM {  get; set; }
        public string OrderNo {  get; set; }

        public long? Position { get; set; }

		public short? Next { get; set; }

		public string AlloyCode { get; set; }

		public double? HEntry { get; set; }

		public double? HExit { get; set; }

		public double? WEntry { get; set; }

		public double? WeightEntry { get; set; }

		public double? LEntry { get; set; }
		public double? LExit { get; set; }

        public double? WExit { get; set; }

		public string SequenceId { get; set; }

		public int? PdiStatus { get; set; }

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
		public double? CoolStrategy { get; set; }

        public string HeatId { get; set; }

		public string FlagBatchRolling { get; set; }
		public string EdPhySrc { get; set; }
		public string EdOrSrc { get; set; }
        public int? ProductType { get; set; }
        public string HeatName { get; set; }
        public short? calcFlag { get; set; }
    }
}
