using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.AggregateDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public static class AggregateSelectionMapper
    {
        public static AggregateSelectionDto MapToDto(this AggregateSelection entity)
        {
            var dto = new AggregateSelectionDto();

            dto.Active = entity.Active;
            dto.Aggregate = entity.Aggregate;
            dto.RecId = entity.RecId;
            dto.AlloyCode = entity.AlloyCode;
            dto.AlloyGroup = entity.AlloyGroup;

            dto.AlloyValueAlFrom = entity.AlloyValueAlFrom;
            dto.AlloyValueAlTo = entity.AlloyValueAlTo;
            dto.AlloyValueAsFrom = entity.AlloyValueAsFrom;
            dto.AlloyValueAsTo = entity.AlloyValueAsTo;
            dto.AlloyValueBFrom = entity.AlloyValueBfrom;
            dto.AlloyValueBTo = entity.AlloyValueBto;
            dto.AlloyValueCFrom = entity.AlloyValueCfrom;
            dto.AlloyValueCTo = entity.AlloyValueCto;
            dto.AlloyValueCoFrom = entity.AlloyValueCoFrom;
            dto.AlloyValueCoTo = entity.AlloyValueCoTo;
            dto.AlloyValueCrFrom = entity.AlloyValueCrFrom;
            dto.AlloyValueCrTo = entity.AlloyValueCrTo;
            dto.AlloyValueCuFrom = entity.AlloyValueCuFrom;
            dto.AlloyValueCuTo = entity.AlloyValueCuTo;
            dto.AlloyValueMgFrom = entity.AlloyValueMgFrom;
            dto.AlloyValueMgTo = entity.AlloyValueMgTo;
            dto.AlloyValueMnFrom = entity.AlloyValueMnFrom;
            dto.AlloyValueMnTo = entity.AlloyValueMnTo;
            dto.AlloyValueMoFrom = entity.AlloyValueMoFrom;
            dto.AlloyValueMoTo = entity.AlloyValueMoTo;
            dto.AlloyValueNFrom = entity.AlloyValueNfrom;
            dto.AlloyValueNTo = entity.AlloyValueNto;
            dto.AlloyValueNbFrom = entity.AlloyValueNbFrom;
            dto.AlloyValueNbTo = entity.AlloyValueNbTo;
            dto.AlloyValueNiFrom = entity.AlloyValueNiFrom;
            dto.AlloyValueNiTo = entity.AlloyValueNiTo;
            dto.AlloyValuePFrom = entity.AlloyValuePfrom;
            dto.AlloyValuePTo = entity.AlloyValuePto;
            dto.AlloyValuePbFrom = entity.AlloyValuePbFrom;
            dto.AlloyValuePbTo = entity.AlloyValuePbTo;
            dto.AlloyValueSFrom = entity.AlloyValueSfrom;
            dto.AlloyValueSTo = entity.AlloyValueSto;
            dto.AlloyValueSiFrom = entity.AlloyValueSiFrom;
            dto.AlloyValueSiTo = entity.AlloyValueSiTo;
            dto.AlloyValueSnFrom = entity.AlloyValueSnFrom;
            dto.AlloyValueSnTo = entity.AlloyValueSnTo;
            dto.AlloyValueTiFrom = entity.AlloyValueTiFrom;
            dto.AlloyValueTiTo = entity.AlloyValueTiTo;
            dto.AlloyValueVFrom = entity.AlloyValueVfrom;
            dto.AlloyValueVTo = entity.AlloyValueVto;
            dto.AlloyValueZnFrom = entity.AlloyValueZnFrom;
            dto.AlloyValueZnTo = entity.AlloyValueZnTo;

            dto.ApsKey = entity.ApsKey;

            dto.CheckerHeightFrom = entity.CheckerHeightFrom;
            dto.CheckerHeightTo = entity.CheckerHeightTo;

            dto.ClassMaxCrownDeltaFrom = entity.ClassMaxCrownDeltaFrom;
            dto.ClassMaxCrownDeltaTo = entity.ClassMaxCrownDeltaTo;
            dto.ClassMinCrownDeltaFrom = entity.ClassMinCrownDeltaFrom;
            dto.ClassMinCrownDeltaTo = entity.ClassMinCrownDeltaTo;

            dto.CoilTempFrom = entity.CoilTempFrom;
            dto.CoilTempTo = entity.CoilTempTo;

            dto.DeltaWidthFrom = entity.DeltaWidthFrom;
            dto.DeltaWidthTo = entity.DeltaWidthTo;

            dto.Dependence = entity.Dependence;
            dto.Description = entity.Description;

            dto.FurnaceNoFrom = entity.FurnaceNoFrom;
            dto.FurnaceNoTo = entity.FurnaceNoTo;

            dto.HentryFmFrom = entity.HEntryFmfrom;
            dto.HentryFmTo = entity.HEntryFmto;
            dto.HentryFrom = entity.HEntryFrom;
            dto.HentryPreFrom = entity.HEntryPreFrom;
            dto.HentryPreTo = entity.HEntryPreTo;
            dto.HentryTo = entity.HEntryTo;

            dto.HexitFrom = entity.HExitFrom;
            dto.HexitTo = entity.HExitTo;

            dto.LentryWedgeFrom = entity.LEntryWedgeFrom;
            dto.LentryWedgeTo = entity.LEntryWedgeTo;

            dto.PlanNoInd0 = entity.PlanNoInd0;
            dto.PlanNoInd1 = entity.PlanNoInd1;
            dto.PlanNoInd2 = entity.PlanNoInd2;
            dto.PlanNoInd3 = entity.PlanNoInd3;

            dto.SetpointsInd0 = entity.SetpointsInd0;
            dto.SetpointsInd1 = entity.SetpointsInd1;
            dto.SetpointsInd2 = entity.SetpointsInd2;
            dto.SetpointsInd3 = entity.SetpointsInd3;

            dto.SlabLengthGroupFrom = entity.SlabLengthGroupFrom;
            dto.SlabLengthGroupTo = entity.SlabLengthGroupTo;

            dto.SortId = entity.SortId;

            dto.TentryFmFrom = entity.TEntryFmfrom;
            dto.TentryFmTo = entity.TEntryFmto;
            dto.TentryFrom = entity.TEntryFrom;
            dto.TentryTo = entity.TEntryTo;

            dto.TexitFrom = entity.TExitFrom;
            dto.TexitTo = entity.TExitTo;

            dto.WentryFrom = entity.WEntryFrom;
            dto.WentryTo = entity.WEntryTo;
            dto.WexitFrom = entity.WExitFrom;
            dto.WexitTo = entity.WExitTo;

            dto.WeightEntryFrom = entity.WeightEntryFrom;
            dto.WeightEntryTo = entity.WeightEntryTo;

            dto.Mop = entity.Mop;
            dto.Toc = entity.Toc;
            dto.Tom = entity.Tom;

            //dto.SpareFloat01From = entity.SpareFloat01From;
            //dto.SpareFloat01To = entity.SpareFloat01To;
            //dto.SpareFloat02From = entity.SpareFloat02From;
            //dto.SpareFloat02To = entity.SpareFloat02To;
            //dto.SpareFloat03From = entity.SpareFloat03From;
            //dto.SpareFloat03To = entity.SpareFloat03To;
            //dto.SpareFloat04From = entity.SpareFloat04From;
            //dto.SpareFloat04To = entity.SpareFloat04To;
            //dto.SpareFloat05From = entity.SpareFloat05From;
            //dto.SpareFloat05To = entity.SpareFloat05To;
            //dto.SpareFloat06From = entity.SpareFloat06From;
            //dto.SpareFloat06To = entity.SpareFloat06To;
            //dto.SpareFloat07From = entity.SpareFloat07From;
            //dto.SpareFloat07To = entity.SpareFloat07To;
            //dto.SpareFloat08From = entity.SpareFloat08From;
            //dto.SpareFloat08To = entity.SpareFloat08To;

            //dto.CoolPlanNo = entity.CoolPlanNo;
            //dto.SpareEqChar01 = entity.SpareEqChar01;

            return dto;
        }
        public static AggregateSelection MapFromDto(this AggregateSelection entity, AggregateSelectionDto dto) 
        {
            entity.Active = dto.Active;
            entity.Aggregate = dto.Aggregate;
            entity.RecId = dto.RecId;
            entity.AlloyCode = dto.AlloyCode;
            entity.AlloyGroup = dto.AlloyGroup;

            entity.AlloyValueAlFrom = dto.AlloyValueAlFrom;
            entity.AlloyValueAlTo = dto.AlloyValueAlTo;
            entity.AlloyValueAsFrom = dto.AlloyValueAsFrom;
            entity.AlloyValueAsTo = dto.AlloyValueAsTo;
            entity.AlloyValueBfrom = dto.AlloyValueBFrom;
            entity.AlloyValueBto = dto.AlloyValueBTo;
            entity.AlloyValueCfrom = dto.AlloyValueCFrom;
            entity.AlloyValueCto = dto.AlloyValueCTo;
            entity.AlloyValueCoFrom = dto.AlloyValueCoFrom;
            entity.AlloyValueCoTo = dto.AlloyValueCoTo;
            entity.AlloyValueCrFrom = dto.AlloyValueCrFrom;
            entity.AlloyValueCrTo = dto.AlloyValueCrTo;
            entity.AlloyValueCuFrom = dto.AlloyValueCuFrom;
            entity.AlloyValueCuTo = dto.AlloyValueCuTo;
            entity.AlloyValueMgFrom = dto.AlloyValueMgFrom;
            entity.AlloyValueMgTo = dto.AlloyValueMgTo;
            entity.AlloyValueMnFrom = dto.AlloyValueMnFrom;
            entity.AlloyValueMnTo = dto.AlloyValueMnTo;
            entity.AlloyValueMoFrom = dto.AlloyValueMoFrom;
            entity.AlloyValueMoTo = dto.AlloyValueMoTo;
            entity.AlloyValueNfrom = dto.AlloyValueNFrom;
            entity.AlloyValueNto = dto.AlloyValueNTo;
            entity.AlloyValueNbFrom = dto.AlloyValueNbFrom;
            entity.AlloyValueNbTo = dto.AlloyValueNbTo;
            entity.AlloyValueNiFrom = dto.AlloyValueNiFrom;
            entity.AlloyValueNiTo = dto.AlloyValueNiTo;
            entity.AlloyValuePfrom = dto.AlloyValuePFrom;
            entity.AlloyValuePto = dto.AlloyValuePTo;
            entity.AlloyValuePbFrom = dto.AlloyValuePbFrom;
            entity.AlloyValuePbTo = dto.AlloyValuePbTo;
            entity.AlloyValueSfrom = dto.AlloyValueSFrom;
            entity.AlloyValueSto = dto.AlloyValueSTo;
            entity.AlloyValueSiFrom = dto.AlloyValueSiFrom;
            entity.AlloyValueSiTo = dto.AlloyValueSiTo;
            entity.AlloyValueSnFrom = dto.AlloyValueSnFrom;
            entity.AlloyValueSnTo = dto.AlloyValueSnTo;
            entity.AlloyValueTiFrom = dto.AlloyValueTiFrom;
            entity.AlloyValueTiTo = dto.AlloyValueTiTo;
            entity.AlloyValueVfrom = dto.AlloyValueVFrom;
            entity.AlloyValueVto = dto.AlloyValueVTo;
            entity.AlloyValueZnFrom = dto.AlloyValueZnFrom;
            entity.AlloyValueZnTo = dto.AlloyValueZnTo;

            entity.ApsKey = dto.ApsKey;

            entity.CheckerHeightFrom = dto.CheckerHeightFrom;
            entity.CheckerHeightTo = dto.CheckerHeightTo;

            entity.ClassMaxCrownDeltaFrom = dto.ClassMaxCrownDeltaFrom;
            entity.ClassMaxCrownDeltaTo = dto.ClassMaxCrownDeltaTo;
            entity.ClassMinCrownDeltaFrom = dto.ClassMinCrownDeltaFrom;
            entity.ClassMinCrownDeltaTo = dto.ClassMinCrownDeltaTo;

            entity.CoilTempFrom = dto.CoilTempFrom;
            entity.CoilTempTo = dto.CoilTempTo;

            entity.DeltaWidthFrom = dto.DeltaWidthFrom;
            entity.DeltaWidthTo = dto.DeltaWidthTo;

            entity.Dependence = dto.Dependence;
            entity.Description = dto.Description;

            entity.FurnaceNoFrom = dto.FurnaceNoFrom;
            entity.FurnaceNoTo = dto.FurnaceNoTo;

            entity.HEntryFmfrom = dto.HentryFmFrom;
            entity.HEntryFmto = dto.HentryFmTo;
            entity.HEntryFrom = dto.HentryFrom;
            entity.HEntryPreFrom = dto.HentryPreFrom;
            entity.HEntryPreTo = dto.HentryPreTo;
            entity.HEntryTo = dto.HentryTo;

            entity.HExitFrom = dto.HexitFrom;
            entity.HExitTo = dto.HexitTo;

            entity.LEntryWedgeFrom = dto.LentryWedgeFrom;
            entity.LEntryWedgeTo = dto.LentryWedgeTo;

            entity.PlanNoInd0 = dto.PlanNoInd0;
            entity.PlanNoInd1 = dto.PlanNoInd1;
            entity.PlanNoInd2 = dto.PlanNoInd2;
            entity.PlanNoInd3 = dto.PlanNoInd3;

            entity.SetpointsInd0 = dto.SetpointsInd0;
            entity.SetpointsInd1 = dto.SetpointsInd1;
            entity.SetpointsInd2 = dto.SetpointsInd2;
            entity.SetpointsInd3 = dto.SetpointsInd3;

            entity.SlabLengthGroupFrom = dto.SlabLengthGroupFrom;
            entity.SlabLengthGroupTo = dto.SlabLengthGroupTo;

            entity.SortId = dto.SortId;

            entity.TEntryFmfrom = dto.TentryFmFrom;
            entity.TEntryFmto = dto.TentryFmTo;
            entity.TEntryFrom = dto.TentryFrom;
            entity.TEntryTo = dto.TentryTo;

            entity.TExitFrom = dto.TexitFrom;
            entity.TExitTo = dto.TexitTo;

            entity.WEntryFrom = dto.WentryFrom;
            entity.WEntryTo = dto.WentryTo;
            entity.WExitFrom = dto.WexitFrom;
            entity.WExitTo = dto.WexitTo;

            entity.WeightEntryFrom = dto.WeightEntryFrom;
            entity.WeightEntryTo = dto.WeightEntryTo;

            entity.Mop = dto.Mop;
            entity.Toc = dto.Toc;
            entity.Tom = dto.Tom;

            //entity.SpareFloat01From = dto.SpareFloat01From;
            //entity.SpareFloat01To = dto.SpareFloat01To;
            //entity.SpareFloat02From = dto.SpareFloat02From;
            //entity.SpareFloat02To = dto.SpareFloat02To;
            //entity.SpareFloat03From = dto.SpareFloat03From;
            //entity.SpareFloat03To = dto.SpareFloat03To;
            //entity.SpareFloat04From = dto.SpareFloat04From;
            //entity.SpareFloat04To = dto.SpareFloat04To;
            //entity.SpareFloat05From = dto.SpareFloat05From;
            //entity.SpareFloat05To = dto.SpareFloat05To;
            //entity.SpareFloat06From = dto.SpareFloat06From;
            //entity.SpareFloat06To = dto.SpareFloat06To;
            //entity.SpareFloat07From = dto.SpareFloat07From;
            //entity.SpareFloat07To = dto.SpareFloat07To;
            //entity.SpareFloat08From = dto.SpareFloat08From;
            //entity.SpareFloat08To = dto.SpareFloat08To;

            //entity.CoolPlanNo = dto.CoolPlanNo;
            //entity.SpareEqChar01 = dto.SpareEqChar01;

            return entity;
        }
        public static AggregateSelection ToEntity(this AggregateSelectionDto dto, int recId)
        {
            dto.RecId = recId + 1; // to be changed after changing recId to autoincrement in database
            return new AggregateSelection().MapFromDto(dto);
        }
    }
}
