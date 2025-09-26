using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.AggregateDtos
{
    public class AggregateSelectionDto
    {
        public int Active { get; set; }
        public string Aggregate { get; set; }
        public int RecId { get; set; }
        public string AlloyCode { get; set; }
        public string AlloyGroup { get; set; }

        public float? AlloyValueAlFrom { get; set; }
        public float? AlloyValueAlTo { get; set; }
        public float? AlloyValueAsFrom { get; set; }
        public float? AlloyValueAsTo { get; set; }
        public float? AlloyValueBFrom { get; set; }
        public float? AlloyValueBTo { get; set; }
        public float? AlloyValueCFrom { get; set; }
        public float? AlloyValueCTo { get; set; }
        public float? AlloyValueCoFrom { get; set; }
        public float? AlloyValueCoTo { get; set; }
        public float? AlloyValueCrFrom { get; set; }
        public float? AlloyValueCrTo { get; set; }
        public float? AlloyValueCuFrom { get; set; }
        public float? AlloyValueCuTo { get; set; }
        public float? AlloyValueMgFrom { get; set; }
        public float? AlloyValueMgTo { get; set; }
        public float? AlloyValueMnFrom { get; set; }
        public float? AlloyValueMnTo { get; set; }
        public float? AlloyValueMoFrom { get; set; }
        public float? AlloyValueMoTo { get; set; }
        public float? AlloyValueNFrom { get; set; }
        public float? AlloyValueNTo { get; set; }
        public float? AlloyValueNbFrom { get; set; }
        public float? AlloyValueNbTo { get; set; }
        public float? AlloyValueNiFrom { get; set; }
        public float? AlloyValueNiTo { get; set; }
        public float? AlloyValuePFrom { get; set; }
        public float? AlloyValuePTo { get; set; }
        public float? AlloyValuePbFrom { get; set; }
        public float? AlloyValuePbTo { get; set; }
        public float? AlloyValueSFrom { get; set; }
        public float? AlloyValueSTo { get; set; }
        public float? AlloyValueSiFrom { get; set; }
        public float? AlloyValueSiTo { get; set; }
        public float? AlloyValueSnFrom { get; set; }
        public float? AlloyValueSnTo { get; set; }
        public float? AlloyValueTiFrom { get; set; }
        public float? AlloyValueTiTo { get; set; }
        public float? AlloyValueVFrom { get; set; }
        public float? AlloyValueVTo { get; set; }
        public float? AlloyValueZnFrom { get; set; }
        public float? AlloyValueZnTo { get; set; }

        public string? ApsKey { get; set; }

        public float? CheckerHeightFrom { get; set; }
        public float? CheckerHeightTo { get; set; }

        public float? ClassMaxCrownDeltaFrom { get; set; }
        public float? ClassMaxCrownDeltaTo { get; set; }
        public float? ClassMinCrownDeltaFrom { get; set; }
        public float? ClassMinCrownDeltaTo { get; set; }

        public float? CoilTempFrom { get; set; }
        public float? CoilTempTo { get; set; }

        public float? DeltaWidthFrom { get; set; }
        public float? DeltaWidthTo { get; set; }

        public string? Dependence { get; set; }
        public string? Description { get; set; }

        public int? FurnaceNoFrom { get; set; }
        public int? FurnaceNoTo { get; set; }

        public float? HentryFmFrom { get; set; }
        public float? HentryFmTo { get; set; }
        public float? HentryFrom { get; set; }
        public float? HentryPreFrom { get; set; }
        public float? HentryPreTo { get; set; }
        public float? HentryTo { get; set; }

        public float? HexitFrom { get; set; }
        public float? HexitTo { get; set; }

        public float? LentryWedgeFrom { get; set; }
        public float? LentryWedgeTo { get; set; }

        public int? PlanNoInd0 { get; set; }
        public int? PlanNoInd1 { get; set; }
        public int? PlanNoInd2 { get; set; }
        public int? PlanNoInd3 { get; set; }

        public float? SetpointsInd0 { get; set; }
        public float? SetpointsInd1 { get; set; }
        public float? SetpointsInd2 { get; set; }
        public float? SetpointsInd3 { get; set; }

        public int? SlabLengthGroupFrom { get; set; }
        public int? SlabLengthGroupTo { get; set; }

        public int SortId { get; set; }

        public float? TentryFmFrom { get; set; }
        public float? TentryFmTo { get; set; }
        public float? TentryFrom { get; set; }
        public float? TentryTo { get; set; }

        public float? TexitFrom { get; set; }
        public float? TexitTo { get; set; }

        public float? WentryFrom { get; set; }
        public float? WentryTo { get; set; }
        public float? WexitFrom { get; set; }
        public float? WexitTo { get; set; }

        public float? WeightEntryFrom { get; set; }
        public float? WeightEntryTo { get; set; }

        public string Mop { get; set; }
        public DateTime? Toc { get; set; } = new();
        public DateTime? Tom { get; set; } = new();

        public float? SpareFloat01From { get; set; }
        public float? SpareFloat01To { get; set; }
        public float? SpareFloat02From { get; set; }
        public float? SpareFloat02To { get; set; }
        public float? SpareFloat03From { get; set; }
        public float? SpareFloat03To { get; set; }
        public float? SpareFloat04From { get; set; }
        public float? SpareFloat04To { get; set; }
        public float? SpareFloat05From { get; set; }
        public float? SpareFloat05To { get; set; }
        public float? SpareFloat06From { get; set; }
        public float? SpareFloat06To { get; set; }
        public float? SpareFloat07From { get; set; }
        public float? SpareFloat07To { get; set; }
        public float? SpareFloat08From { get; set; }
        public float? SpareFloat08To { get; set; }

        public string CoolPlanNo { get; set; }
        public string SpareEqChar01 { get; set; }

    }
}
