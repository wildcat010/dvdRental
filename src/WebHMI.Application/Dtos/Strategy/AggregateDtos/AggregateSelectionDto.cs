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

        public double? AlloyValueAlFrom { get; set; }
        public double? AlloyValueAlTo { get; set; }
        public double? AlloyValueAsFrom { get; set; }
        public double? AlloyValueAsTo { get; set; }
        public double? AlloyValueBFrom { get; set; }
        public double? AlloyValueBTo { get; set; }
        public double? AlloyValueCFrom { get; set; }
        public double? AlloyValueCTo { get; set; }
        public double? AlloyValueCoFrom { get; set; }
        public double? AlloyValueCoTo { get; set; }
        public double? AlloyValueCrFrom { get; set; }
        public double? AlloyValueCrTo { get; set; }
        public double? AlloyValueCuFrom { get; set; }
        public double? AlloyValueCuTo { get; set; }
        public double? AlloyValueMgFrom { get; set; }
        public double? AlloyValueMgTo { get; set; }
        public double? AlloyValueMnFrom { get; set; }
        public double? AlloyValueMnTo { get; set; }
        public double? AlloyValueMoFrom { get; set; }
        public double? AlloyValueMoTo { get; set; }
        public double? AlloyValueNFrom { get; set; }
        public double? AlloyValueNTo { get; set; }
        public double? AlloyValueNbFrom { get; set; }
        public double? AlloyValueNbTo { get; set; }
        public double? AlloyValueNiFrom { get; set; }
        public double? AlloyValueNiTo { get; set; }
        public double? AlloyValuePFrom { get; set; }
        public double? AlloyValuePTo { get; set; }
        public double? AlloyValuePbFrom { get; set; }
        public double? AlloyValuePbTo { get; set; }
        public double? AlloyValueSFrom { get; set; }
        public double? AlloyValueSTo { get; set; }
        public double? AlloyValueSiFrom { get; set; }
        public double? AlloyValueSiTo { get; set; }
        public double? AlloyValueSnFrom { get; set; }
        public double? AlloyValueSnTo { get; set; }
        public double? AlloyValueTiFrom { get; set; }
        public double? AlloyValueTiTo { get; set; }
        public double? AlloyValueVFrom { get; set; }
        public double? AlloyValueVTo { get; set; }
        public double? AlloyValueZnFrom { get; set; }
        public double? AlloyValueZnTo { get; set; }

        public string? ApsKey { get; set; }

        public double? CheckerHeightFrom { get; set; }
        public double? CheckerHeightTo { get; set; }

        public double? ClassMaxCrownDeltaFrom { get; set; }
        public double? ClassMaxCrownDeltaTo { get; set; }
        public double? ClassMinCrownDeltaFrom { get; set; }
        public double? ClassMinCrownDeltaTo { get; set; }

        public double? CoilTempFrom { get; set; }
        public double? CoilTempTo { get; set; }

        public double? DeltaWidthFrom { get; set; }
        public double? DeltaWidthTo { get; set; }

        public string? Dependence { get; set; }
        public string? Description { get; set; }

        public int? FurnaceNoFrom { get; set; }
        public int? FurnaceNoTo { get; set; }

        public double? HentryFmFrom { get; set; }
        public double? HentryFmTo { get; set; }
        public double? HentryFrom { get; set; }
        public double? HentryPreFrom { get; set; }
        public double? HentryPreTo { get; set; }
        public double? HentryTo { get; set; }

        public double? HexitFrom { get; set; }
        public double? HexitTo { get; set; }

        public double? LentryWedgeFrom { get; set; }
        public double? LentryWedgeTo { get; set; }

        public int? PlanNoInd0 { get; set; }
        public int? PlanNoInd1 { get; set; }
        public int? PlanNoInd2 { get; set; }
        public int? PlanNoInd3 { get; set; }

        public double? SetpointsInd0 { get; set; }
        public double? SetpointsInd1 { get; set; }
        public double? SetpointsInd2 { get; set; }
        public double? SetpointsInd3 { get; set; }

        public int? SlabLengthGroupFrom { get; set; }
        public int? SlabLengthGroupTo { get; set; }

        public int SortId { get; set; }

        public double? TentryFmFrom { get; set; }
        public double? TentryFmTo { get; set; }
        public double? TentryFrom { get; set; }
        public double? TentryTo { get; set; }

        public double? TexitFrom { get; set; }
        public double? TexitTo { get; set; }

        public double? WentryFrom { get; set; }
        public double? WentryTo { get; set; }
        public double? WexitFrom { get; set; }
        public double? WexitTo { get; set; }

        public double? WeightEntryFrom { get; set; }
        public double? WeightEntryTo { get; set; }

        public string Mop { get; set; }
        public DateTime? Toc { get; set; } = new();
        public DateTime? Tom { get; set; } = new();

        public double? SpareFloat01From { get; set; }
        public double? SpareFloat01To { get; set; }
        public double? SpareFloat02From { get; set; }
        public double? SpareFloat02To { get; set; }
        public double? SpareFloat03From { get; set; }
        public double? SpareFloat03To { get; set; }
        public double? SpareFloat04From { get; set; }
        public double? SpareFloat04To { get; set; }
        public double? SpareFloat05From { get; set; }
        public double? SpareFloat05To { get; set; }
        public double? SpareFloat06From { get; set; }
        public double? SpareFloat06To { get; set; }
        public double? SpareFloat07From { get; set; }
        public double? SpareFloat07To { get; set; }
        public double? SpareFloat08From { get; set; }
        public double? SpareFloat08To { get; set; }

        public short? CoolPlanNo { get; set; }
        public string SpareEqChar01 { get; set; }

    }
}
