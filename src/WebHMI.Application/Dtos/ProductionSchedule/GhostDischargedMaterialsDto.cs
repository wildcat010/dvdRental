using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.ProductionSchedule
{
    public class GhostDischargedMaterialsDto
    {
        public MeCodeDto EnOrMeCode { get; set; }
        public MeCodeDto EnLogMeCode { get; set; }
        public MeCodeDto EnPhMeCode { get; set; }

        public string AlloyCode { get; set; }

        public float? HEntry { get; set; }

        public float? HExit { get; set; }

        public float? WEntry { get; set; }

        public float? WeightEntry { get; set; }

        public float? LEntry { get; set; }

        public float? WExit { get; set; }

        public string SequenceId { get; set; }

        public short? PdiStatus { get; set; }

        public short? SetpointsPc2Ok { get; set; }

        public int? Sbaz { get; set; }

        public DateTime? LastCalc { get; set; }

        public string ApsKey { get; set; }

        public int? SimMat { get; set; }

        public short? SetpointsCsOk { get; set; }

        public float? TEntryFm { get; set; }

        public float? TExitFm { get; set; }

        public float? TExitCaster { get; set; }

        public float? CoilTemp { get; set; }
        public float? CoolStrategy { get; set; }

        public string HeatId { get; set; }

        public int? FlagBatchRolling { get; set; }

        public int? PlateProduction { get; set; }

        public DateTime? ProdStartTime { get; set; }

        public DateTime? ProdEndTime { get; set; }
    }
}
