using System.Linq;
using WebHMI.Dtos.Strategy.AggregateDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public static class AggregateSelectionMapper
    {
        public static AggregateSelectionDto MapToDto(this AggregateSelection entity)
        {
            var dTo = new AggregateSelectionDto();

            dTo.Active = entity.Active;
            dTo.Aggregate = entity.Aggregate;
            dTo.RecId = entity.RecId;
            dTo.AlloyCode = entity.AlloyCode;
            dTo.AlloyGroup = entity.AlloyGroup;

            dTo.AlloyValueAlFrom = entity.AlloyValueAlFrom;
            dTo.AlloyValueAlTo = entity.AlloyValueAlTo;
            dTo.AlloyValueAsFrom = entity.AlloyValueAsFrom;
            dTo.AlloyValueAsTo = entity.AlloyValueAsTo;
            dTo.AlloyValueBFrom = entity.AlloyValueBfrom;
            dTo.AlloyValueBTo = entity.AlloyValueBto;
            dTo.AlloyValueCFrom = entity.AlloyValueCfrom;
            dTo.AlloyValueCTo = entity.AlloyValueCto;
            dTo.AlloyValueCoFrom = entity.AlloyValueCoFrom;
            dTo.AlloyValueCoTo = entity.AlloyValueCoTo;
            dTo.AlloyValueCrFrom = entity.AlloyValueCrFrom;
            dTo.AlloyValueCrTo = entity.AlloyValueCrTo;
            dTo.AlloyValueCuFrom = entity.AlloyValueCuFrom;
            dTo.AlloyValueCuTo = entity.AlloyValueCuTo;
            dTo.AlloyValueMgFrom = entity.AlloyValueMgFrom;
            dTo.AlloyValueMgTo = entity.AlloyValueMgTo;
            dTo.AlloyValueMnFrom = entity.AlloyValueMnFrom;
            dTo.AlloyValueMnTo = entity.AlloyValueMnTo;
            dTo.AlloyValueMoFrom = entity.AlloyValueMoFrom;
            dTo.AlloyValueMoTo = entity.AlloyValueMoTo;
            dTo.AlloyValueNFrom = entity.AlloyValueNfrom;
            dTo.AlloyValueNTo = entity.AlloyValueNto;
            dTo.AlloyValueNbFrom = entity.AlloyValueNbFrom;
            dTo.AlloyValueNbTo = entity.AlloyValueNbTo;
            dTo.AlloyValueNiFrom = entity.AlloyValueNiFrom;
            dTo.AlloyValueNiTo = entity.AlloyValueNiTo;
            dTo.AlloyValuePFrom = entity.AlloyValuePfrom;
            dTo.AlloyValuePTo = entity.AlloyValuePto;
            dTo.AlloyValuePbFrom = entity.AlloyValuePbFrom;
            dTo.AlloyValuePbTo = entity.AlloyValuePbTo;
            dTo.AlloyValueSFrom = entity.AlloyValueSfrom;
            dTo.AlloyValueSTo = entity.AlloyValueSto;
            dTo.AlloyValueSiFrom = entity.AlloyValueSiFrom;
            dTo.AlloyValueSiTo = entity.AlloyValueSiTo;
            dTo.AlloyValueSnFrom = entity.AlloyValueSnFrom;
            dTo.AlloyValueSnTo = entity.AlloyValueSnTo;
            dTo.AlloyValueTiFrom = entity.AlloyValueTiFrom;
            dTo.AlloyValueTiTo = entity.AlloyValueTiTo;
            dTo.AlloyValueVFrom = entity.AlloyValueVfrom;
            dTo.AlloyValueVTo = entity.AlloyValueVto;
            dTo.AlloyValueZnFrom = entity.AlloyValueZnFrom;
            dTo.AlloyValueZnTo = entity.AlloyValueZnTo;
            
            dTo.ApsKey = entity.ApsKey;
            dTo.CoolPlanNo = entity.CoolPlanNo;

            dTo.CheckerHeightFrom = entity.CheckerHeightFrom;
            dTo.CheckerHeightTo = entity.CheckerHeightTo;

            dTo.ClassMaxCrownDeltaFrom = entity.ClassMaxCrownDeltaFrom;
            dTo.ClassMaxCrownDeltaTo = entity.ClassMaxCrownDeltaTo;
            dTo.ClassMinCrownDeltaFrom = entity.ClassMinCrownDeltaFrom;
            dTo.ClassMinCrownDeltaTo = entity.ClassMinCrownDeltaTo;

            dTo.CoilTempFrom = entity.CoilTempFrom;
            dTo.CoilTempTo = entity.CoilTempTo;

            dTo.DeltaWidthFrom = entity.DeltaWidthFrom;
            dTo.DeltaWidthTo = entity.DeltaWidthTo;

            dTo.Dependence = entity.Dependence;
            dTo.Description = entity.Description;

            dTo.FurnaceNoFrom = entity.FurnaceNoFrom;
            dTo.FurnaceNoTo = entity.FurnaceNoTo;

            dTo.HentryFmFrom = entity.HEntryFmfrom;
            dTo.HentryFmTo = entity.HEntryFmto;
            dTo.HentryFrom = entity.HEntryFrom;
            dTo.HentryPreFrom = entity.HEntryPreFrom;
            dTo.HentryPreTo = entity.HEntryPreTo;
            dTo.HentryTo = entity.HEntryTo;

            dTo.HexitFrom = entity.HExitFrom;
            dTo.HexitTo = entity.HExitTo;

            dTo.LentryWedgeFrom = entity.LEntryWedgeFrom;
            dTo.LentryWedgeTo = entity.LEntryWedgeTo;

            dTo.PlanNoInd0 = entity.PlanNoInd0;
            dTo.PlanNoInd1 = entity.PlanNoInd1;
            dTo.PlanNoInd2 = entity.PlanNoInd2;
            dTo.PlanNoInd3 = entity.PlanNoInd3;

            dTo.SetpointsInd0 = entity.SetpointsInd0;
            dTo.SetpointsInd1 = entity.SetpointsInd1;
            dTo.SetpointsInd2 = entity.SetpointsInd2;
            dTo.SetpointsInd3 = entity.SetpointsInd3;

            dTo.SlabLengthGroupFrom = entity.SlabLengthGroupFrom;
            dTo.SlabLengthGroupTo = entity.SlabLengthGroupTo;

            dTo.SortId = entity.SortId;

            dTo.TentryFmFrom = entity.TEntryFmfrom;
            dTo.TentryFmTo = entity.TEntryFmto;
            dTo.TentryFrom = entity.TEntryFrom;
            dTo.TentryTo = entity.TEntryTo;

            dTo.TexitFrom = entity.TExitFrom;
            dTo.TexitTo = entity.TExitTo;

            dTo.WentryFrom = entity.WEntryFrom;
            dTo.WentryTo = entity.WEntryTo;
            dTo.WexitFrom = entity.WExitFrom;
            dTo.WexitTo = entity.WExitTo;

            dTo.WeightEntryFrom = entity.WeightEntryFrom;
            dTo.WeightEntryTo = entity.WeightEntryTo;

            dTo.SpareEqChar01 = entity.SpareEqChar01;
            dTo.SpareFloat01From = entity.SpareFloat01From;
            dTo.SpareFloat01To = entity.SpareFloat01To;
            dTo.SpareFloat02From = entity.SpareFloat02From;
            dTo.SpareFloat02To = entity.SpareFloat02To;
            dTo.SpareFloat03From = entity.SpareFloat03From;
            dTo.SpareFloat03To = entity.SpareFloat03To;
            dTo.SpareFloat04From = entity.SpareFloat04From;
            dTo.SpareFloat04To = entity.SpareFloat04To;
            dTo.SpareFloat05From = entity.SpareFloat05From;
            dTo.SpareFloat05To = entity.SpareFloat05To;
            dTo.SpareFloat06From = entity.SpareFloat06From;
            dTo.SpareFloat06To = entity.SpareFloat06To;
            dTo.SpareFloat07From = entity.SpareFloat07From;
            dTo.SpareFloat07To = entity.SpareFloat07To;
            dTo.SpareFloat08From = entity.SpareFloat08From;
            dTo.SpareFloat08To = entity.SpareFloat08To;

            dTo.Mop = entity.Mop;
            dTo.Toc = entity.Toc;
            dTo.Tom = entity.Tom;

            return dTo;
        }
        public static AggregateSelection MapFromDto(this AggregateSelection entity, AggregateSelectionDto dTo)
        {
            entity.Active = dTo.Active;
            entity.Aggregate = dTo.Aggregate;
            entity.RecId = dTo.RecId;
            entity.AlloyCode = dTo.AlloyCode;
            entity.AlloyGroup = dTo.AlloyGroup;


            entity.AlloyValueAlFrom = dTo.AlloyValueAlFrom;
            entity.AlloyValueAlTo = dTo.AlloyValueAlTo;
            entity.AlloyValueAsFrom = dTo.AlloyValueAsFrom;
            entity.AlloyValueAsTo = dTo.AlloyValueAsTo;
            entity.AlloyValueBfrom = dTo.AlloyValueBFrom;
            entity.AlloyValueBto = dTo.AlloyValueBTo;
            entity.AlloyValueCfrom = dTo.AlloyValueCFrom;
            entity.AlloyValueCto = dTo.AlloyValueCTo;
            entity.AlloyValueCoFrom = dTo.AlloyValueCoFrom;
            entity.AlloyValueCoTo = dTo.AlloyValueCoTo;
            entity.AlloyValueCrFrom = dTo.AlloyValueCrFrom;
            entity.AlloyValueCrTo = dTo.AlloyValueCrTo;
            entity.AlloyValueCuFrom = dTo.AlloyValueCuFrom;
            entity.AlloyValueCuTo = dTo.AlloyValueCuTo;
            entity.AlloyValueMgFrom = dTo.AlloyValueMgFrom;
            entity.AlloyValueMgTo = dTo.AlloyValueMgTo;
            entity.AlloyValueMnFrom = dTo.AlloyValueMnFrom;
            entity.AlloyValueMnTo = dTo.AlloyValueMnTo;
            entity.AlloyValueMoFrom = dTo.AlloyValueMoFrom;
            entity.AlloyValueMoTo = dTo.AlloyValueMoTo;
            entity.AlloyValueNfrom = dTo.AlloyValueNFrom;
            entity.AlloyValueNto = dTo.AlloyValueNTo;
            entity.AlloyValueNbFrom = dTo.AlloyValueNbFrom;
            entity.AlloyValueNbTo = dTo.AlloyValueNbTo;
            entity.AlloyValueNiFrom = dTo.AlloyValueNiFrom;
            entity.AlloyValueNiTo = dTo.AlloyValueNiTo;
            entity.AlloyValuePfrom = dTo.AlloyValuePFrom;
            entity.AlloyValuePto = dTo.AlloyValuePTo;
            entity.AlloyValuePbFrom = dTo.AlloyValuePbFrom;
            entity.AlloyValuePbTo = dTo.AlloyValuePbTo;
            entity.AlloyValueSfrom = dTo.AlloyValueSFrom;
            entity.AlloyValueSto = dTo.AlloyValueSTo;
            entity.AlloyValueSiFrom = dTo.AlloyValueSiFrom;
            entity.AlloyValueSiTo = dTo.AlloyValueSiTo;
            entity.AlloyValueSnFrom = dTo.AlloyValueSnFrom;
            entity.AlloyValueSnTo = dTo.AlloyValueSnTo;
            entity.AlloyValueTiFrom = dTo.AlloyValueTiFrom;
            entity.AlloyValueTiTo = dTo.AlloyValueTiTo;
            entity.AlloyValueVfrom = dTo.AlloyValueVFrom;
            entity.AlloyValueVto = dTo.AlloyValueVTo;
            entity.AlloyValueZnFrom = dTo.AlloyValueZnFrom;
            entity.AlloyValueZnTo = dTo.AlloyValueZnTo;
            entity.CoolPlanNo = dTo.CoolPlanNo;

            entity.ApsKey = dTo.ApsKey;

            entity.CheckerHeightFrom = dTo.CheckerHeightFrom;
            entity.CheckerHeightTo = dTo.CheckerHeightTo;

            entity.ClassMaxCrownDeltaFrom = dTo.ClassMaxCrownDeltaFrom;
            entity.ClassMaxCrownDeltaTo = dTo.ClassMaxCrownDeltaTo;
            entity.ClassMinCrownDeltaFrom = dTo.ClassMinCrownDeltaFrom;
            entity.ClassMinCrownDeltaTo = dTo.ClassMinCrownDeltaTo;

            entity.CoilTempFrom = dTo.CoilTempFrom;
            entity.CoilTempTo = dTo.CoilTempTo;

            entity.DeltaWidthFrom = dTo.DeltaWidthFrom;
            entity.DeltaWidthTo = dTo.DeltaWidthTo;

            entity.Dependence = dTo.Dependence;
            entity.Description = dTo.Description;

            entity.FurnaceNoFrom = dTo.FurnaceNoFrom;
            entity.FurnaceNoTo = dTo.FurnaceNoTo;

            entity.HEntryFmfrom = dTo.HentryFmFrom;
            entity.HEntryFmto = dTo.HentryFmTo;
            entity.HEntryFrom = dTo.HentryFrom;
            entity.HEntryPreFrom = dTo.HentryPreFrom;
            entity.HEntryPreTo = dTo.HentryPreTo;
            entity.HEntryTo = dTo.HentryTo;

            entity.HExitFrom = dTo.HexitFrom;
            entity.HExitTo = dTo.HexitTo;

            entity.LEntryWedgeFrom = dTo.LentryWedgeFrom;
            entity.LEntryWedgeTo = dTo.LentryWedgeTo;

            entity.PlanNoInd0 = dTo.PlanNoInd0;
            entity.PlanNoInd1 = dTo.PlanNoInd1;
            entity.PlanNoInd2 = dTo.PlanNoInd2;
            entity.PlanNoInd3 = dTo.PlanNoInd3;

            entity.SetpointsInd0 = dTo.SetpointsInd0;
            entity.SetpointsInd1 = dTo.SetpointsInd1;
            entity.SetpointsInd2 = dTo.SetpointsInd2;
            entity.SetpointsInd3 = dTo.SetpointsInd3;

            entity.SlabLengthGroupFrom = dTo.SlabLengthGroupFrom;
            entity.SlabLengthGroupTo = dTo.SlabLengthGroupTo;

            entity.SortId = dTo.SortId;

            entity.TEntryFmfrom = dTo.TentryFmFrom;
            entity.TEntryFmto = dTo.TentryFmTo;
            entity.TEntryFrom = dTo.TentryFrom;
            entity.TEntryTo = dTo.TentryTo;

            entity.TExitFrom = dTo.TexitFrom;
            entity.TExitTo = dTo.TexitTo;

            entity.WEntryFrom = dTo.WentryFrom;
            entity.WEntryTo = dTo.WentryTo;
            entity.WExitFrom = dTo.WexitFrom;
            entity.WExitTo = dTo.WexitTo;

            entity.WeightEntryFrom = dTo.WeightEntryFrom;
            entity.WeightEntryTo = dTo.WeightEntryTo;

            entity.SpareEqChar01 = dTo.SpareEqChar01;
            entity.SpareFloat01From = dTo.SpareFloat01From;
            entity.SpareFloat01To = dTo.SpareFloat01To;
            entity.SpareFloat02From = dTo.SpareFloat02From;
            entity.SpareFloat02To = dTo.SpareFloat02To;
            entity.SpareFloat03From = dTo.SpareFloat03From;
            entity.SpareFloat03To = dTo.SpareFloat03To;
            entity.SpareFloat04From = dTo.SpareFloat04From;
            entity.SpareFloat04To = dTo.SpareFloat04To;
            entity.SpareFloat05From = dTo.SpareFloat05From;
            entity.SpareFloat05To = dTo.SpareFloat05To;
            entity.SpareFloat06From = dTo.SpareFloat06From;
            entity.SpareFloat06To = dTo.SpareFloat06To;
            entity.SpareFloat07From = dTo.SpareFloat07From;
            entity.SpareFloat07To = dTo.SpareFloat07To;
            entity.SpareFloat08From = dTo.SpareFloat08From;
            entity.SpareFloat08To = dTo.SpareFloat08To;

            entity.Mop = dTo.Mop;
            entity.Toc = dTo.Toc;
            entity.Tom = dTo.Tom;

            return entity;
        }
        public static AggregateSelection ToEntity(this AggregateSelectionDto dTo, int recId)
        {
            dTo.RecId = recId + 1; // To be changed after changing recId To auToincrement in database
            return new AggregateSelection().MapFromDto(dTo);
        }
    }
}
