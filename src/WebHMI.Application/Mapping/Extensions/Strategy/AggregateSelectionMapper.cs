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
        public static AggregateSelectionDto MapToDto(this Aggregateselection entity)
        {
            var dto = new AggregateSelectionDto();

            dto.Active = entity.Active;
            dto.Aggregate = entity.Aggregate;
            dto.RecId = entity.Recid;
            dto.AlloyCode = entity.Alloycode;
            dto.AlloyGroup = entity.Alloygroup;

            dto.AlloyValueAlFrom = entity.Alloyvaluealfrom;
            dto.AlloyValueAlTo = entity.Alloyvaluealto;
            dto.AlloyValueAsFrom = entity.Alloyvalueasfrom;
            dto.AlloyValueAsTo = entity.Alloyvalueasto;
            dto.AlloyValueBFrom = entity.Alloyvaluebfrom;
            dto.AlloyValueBTo = entity.Alloyvaluebto;
            dto.AlloyValueCFrom = entity.Alloyvaluecfrom;
            dto.AlloyValueCTo = entity.Alloyvaluecto;
            dto.AlloyValueCoFrom = entity.Alloyvaluecofrom;
            dto.AlloyValueCoTo = entity.Alloyvaluecoto;
            dto.AlloyValueCrFrom = entity.Alloyvaluecrfrom;
            dto.AlloyValueCrTo = entity.Alloyvaluecrto;
            dto.AlloyValueCuFrom = entity.Alloyvaluecufrom;
            dto.AlloyValueCuTo = entity.Alloyvaluecuto;
            dto.AlloyValueMgFrom = entity.Alloyvaluemgfrom;
            dto.AlloyValueMgTo = entity.Alloyvaluemgto;
            dto.AlloyValueMnFrom = entity.Alloyvaluemnfrom;
            dto.AlloyValueMnTo = entity.Alloyvaluemnto;
            dto.AlloyValueMoFrom = entity.Alloyvaluemofrom;
            dto.AlloyValueMoTo = entity.Alloyvaluemoto;
            dto.AlloyValueNFrom = entity.Alloyvaluenfrom;
            dto.AlloyValueNTo = entity.Alloyvaluento;
            dto.AlloyValueNbFrom = entity.Alloyvaluenbfrom;
            dto.AlloyValueNbTo = entity.Alloyvaluenbto;
            dto.AlloyValueNiFrom = entity.Alloyvaluenifrom;
            dto.AlloyValueNiTo = entity.Alloyvaluenito;
            dto.AlloyValuePFrom = entity.Alloyvaluepfrom;
            dto.AlloyValuePTo = entity.Alloyvaluepto;
            dto.AlloyValuePbFrom = entity.Alloyvaluepbfrom;
            dto.AlloyValuePbTo = entity.Alloyvaluepbto;
            dto.AlloyValueSFrom = entity.Alloyvaluesfrom;
            dto.AlloyValueSTo = entity.Alloyvaluesto;
            dto.AlloyValueSiFrom = entity.Alloyvaluesifrom;
            dto.AlloyValueSiTo = entity.Alloyvaluesito;
            dto.AlloyValueSnFrom = entity.Alloyvaluesnfrom;
            dto.AlloyValueSnTo = entity.Alloyvaluesnto;
            dto.AlloyValueTiFrom = entity.Alloyvaluetifrom;
            dto.AlloyValueTiTo = entity.Alloyvaluetito;
            dto.AlloyValueVFrom = entity.Alloyvaluevfrom;
            dto.AlloyValueVTo = entity.Alloyvaluevto;
            dto.AlloyValueZnFrom = entity.Alloyvalueznfrom;
            dto.AlloyValueZnTo = entity.Alloyvalueznto;

            dto.ApsKey = entity.Apskey;
            dto.CoolPlanNo = entity.Coolplanno;

            dto.CheckerHeightFrom = entity.Checkerheightfrom;
            dto.CheckerHeightTo = entity.Checkerheightto;

            dto.ClassMaxCrownDeltaFrom = entity.Classmaxcrowndeltafrom;
            dto.ClassMaxCrownDeltaTo = entity.Classmaxcrowndeltato;
            dto.ClassMinCrownDeltaFrom = entity.Classmincrowndeltafrom;
            dto.ClassMinCrownDeltaTo = entity.Classmincrowndeltato;

            dto.CoilTempFrom = entity.Coiltempfrom;
            dto.CoilTempTo = entity.Coiltempto;

            dto.DeltaWidthFrom = entity.Deltawidthfrom;
            dto.DeltaWidthTo = entity.Deltawidthto;

            dto.Dependence = entity.Dependence;
            dto.Description = entity.Description;

            dto.FurnaceNoFrom = entity.Furnacenofrom;
            dto.FurnaceNoTo = entity.Furnacenoto;

            dto.HentryFmFrom = entity.Hentryfmfrom;
            dto.HentryFmTo = entity.Hentryfmto;
            dto.HentryFrom = entity.Hentryfrom;
            dto.HentryPreFrom = entity.Hentryprefrom;
            dto.HentryPreTo = entity.Hentrypreto;
            dto.HentryTo = entity.Hentryto;

            dto.HexitFrom = entity.Hexitfrom;
            dto.HexitTo = entity.Hexitto;

            dto.LentryWedgeFrom = entity.Lentrywedgefrom;
            dto.LentryWedgeTo = entity.Lentrywedgeto;

            dto.PlanNoInd0 = entity.PlannoInd0;
            dto.PlanNoInd1 = entity.PlannoInd1;
            dto.PlanNoInd2 = entity.PlannoInd2;
            dto.PlanNoInd3 = entity.PlannoInd3;

            dto.SetpointsInd0 = entity.SetpointsInd0;
            dto.SetpointsInd1 = entity.SetpointsInd1;
            dto.SetpointsInd2 = entity.SetpointsInd2;
            dto.SetpointsInd3 = entity.SetpointsInd3;

            dto.SlabLengthGroupFrom = entity.Slablengthgroupfrom;
            dto.SlabLengthGroupTo = entity.Slablengthgroupto;

            dto.SortId = entity.Sortid;

            dto.TentryFmFrom = entity.Tentryfmfrom;
            dto.TentryFmTo = entity.Tentryfmto;
            dto.TentryFrom = entity.Tentryfrom;
            dto.TentryTo = entity.Tentryto;

            dto.TexitFrom = entity.Texitfrom;
            dto.TexitTo = entity.Texitto;

            dto.WentryFrom = entity.Wentryfrom;
            dto.WentryTo = entity.Wentryto;
            dto.WexitFrom = entity.Wexitfrom;
            dto.WexitTo = entity.Wexitto;

            dto.WeightEntryFrom = entity.Weightentryfrom;
            dto.WeightEntryTo = entity.Weightentryto;

            dto.SpareEqChar01 = entity.Spareeqchar01;
            dto.SpareFloat01From = entity.Sparefloat01from;
            dto.SpareFloat01To = entity.Sparefloat01to;
            dto.SpareFloat02From = entity.Sparefloat02from;
            dto.SpareFloat02To = entity.Sparefloat02to;
            dto.SpareFloat03From = entity.Sparefloat03from;
            dto.SpareFloat03To = entity.Sparefloat03to;
            dto.SpareFloat04From = entity.Sparefloat04from;
            dto.SpareFloat04To = entity.Sparefloat04to;
            dto.SpareFloat05From = entity.Sparefloat05from;
            dto.SpareFloat05To = entity.Sparefloat05to;
            dto.SpareFloat06From = entity.Sparefloat06from;
            dto.SpareFloat06To = entity.Sparefloat06to;
            dto.SpareFloat07From = entity.Sparefloat07from;
            dto.SpareFloat07To = entity.Sparefloat07to;
            dto.SpareFloat08From = entity.Sparefloat08from;
            dto.SpareFloat08To = entity.Sparefloat08to;

            dto.Mop = entity.Mop;
            dto.Toc = entity.Toc;
            dto.Tom = entity.Tom;

            return dto;
        }
        public static Aggregateselection MapFromDto(this Aggregateselection entity, AggregateSelectionDto dto)
        {
            entity.Active = dto.Active;
            entity.Aggregate = dto.Aggregate;
            entity.Recid = dto.RecId;
            entity.Alloycode = dto.AlloyCode;
            entity.Alloygroup = dto.AlloyGroup;


            entity.Alloyvaluealfrom = dto.AlloyValueAlFrom;
            entity.Alloyvaluealto = dto.AlloyValueAlTo;
            entity.Alloyvalueasfrom = dto.AlloyValueAsFrom;
            entity.Alloyvalueasto = dto.AlloyValueAsTo;
            entity.Alloyvaluebfrom = dto.AlloyValueBFrom;
            entity.Alloyvaluebto = dto.AlloyValueBTo;
            entity.Alloyvaluecfrom = dto.AlloyValueCFrom;
            entity.Alloyvaluecto = dto.AlloyValueCTo;
            entity.Alloyvaluecofrom = dto.AlloyValueCoFrom;
            entity.Alloyvaluecoto = dto.AlloyValueCoTo;
            entity.Alloyvaluecrfrom = dto.AlloyValueCrFrom;
            entity.Alloyvaluecrto = dto.AlloyValueCrTo;
            entity.Alloyvaluecufrom = dto.AlloyValueCuFrom;
            entity.Alloyvaluecuto = dto.AlloyValueCuTo;
            entity.Alloyvaluemgfrom = dto.AlloyValueMgFrom;
            entity.Alloyvaluemgto = dto.AlloyValueMgTo;
            entity.Alloyvaluemnfrom = dto.AlloyValueMnFrom;
            entity.Alloyvaluemnto = dto.AlloyValueMnTo;
            entity.Alloyvaluemofrom = dto.AlloyValueMoFrom;
            entity.Alloyvaluemoto = dto.AlloyValueMoTo;
            entity.Alloyvaluenfrom = dto.AlloyValueNFrom;
            entity.Alloyvaluento = dto.AlloyValueNTo;
            entity.Alloyvaluenbfrom = dto.AlloyValueNbFrom;
            entity.Alloyvaluenbto = dto.AlloyValueNbTo;
            entity.Alloyvaluenifrom = dto.AlloyValueNiFrom;
            entity.Alloyvaluenito = dto.AlloyValueNiTo;
            entity.Alloyvaluepfrom = dto.AlloyValuePFrom;
            entity.Alloyvaluepto = dto.AlloyValuePTo;
            entity.Alloyvaluepbfrom = dto.AlloyValuePbFrom;
            entity.Alloyvaluepbto = dto.AlloyValuePbTo;
            entity.Alloyvaluesfrom = dto.AlloyValueSFrom;
            entity.Alloyvaluesto = dto.AlloyValueSTo;
            entity.Alloyvaluesifrom = dto.AlloyValueSiFrom;
            entity.Alloyvaluesito = dto.AlloyValueSiTo;
            entity.Alloyvaluesnfrom = dto.AlloyValueSnFrom;
            entity.Alloyvaluesnto = dto.AlloyValueSnTo;
            entity.Alloyvaluetifrom = dto.AlloyValueTiFrom;
            entity.Alloyvaluetito = dto.AlloyValueTiTo;
            entity.Alloyvaluevfrom = dto.AlloyValueVFrom;
            entity.Alloyvaluevto = dto.AlloyValueVTo;
            entity.Alloyvalueznfrom = dto.AlloyValueZnFrom;
            entity.Alloyvalueznto = dto.AlloyValueZnTo;
            entity.Coolplanno = dto.CoolPlanNo;

            entity.Apskey = dto.ApsKey;

            entity.Checkerheightfrom = dto.CheckerHeightFrom;
            entity.Checkerheightto = dto.CheckerHeightTo;

            entity.Classmaxcrowndeltafrom = dto.ClassMaxCrownDeltaFrom;
            entity.Classmaxcrowndeltato = dto.ClassMaxCrownDeltaTo;
            entity.Classmincrowndeltafrom = dto.ClassMinCrownDeltaFrom;
            entity.Classmincrowndeltato = dto.ClassMinCrownDeltaTo;

            entity.Coiltempfrom = dto.CoilTempFrom;
            entity.Coiltempto = dto.CoilTempTo;

            entity.Deltawidthfrom = dto.DeltaWidthFrom;
            entity.Deltawidthto = dto.DeltaWidthTo;

            entity.Dependence = dto.Dependence;
            entity.Description = dto.Description;

            entity.Furnacenofrom = dto.FurnaceNoFrom;
            entity.Furnacenoto = dto.FurnaceNoTo;

            entity.Hentryfmfrom = dto.HentryFmFrom;
            entity.Hentryfmto = dto.HentryFmTo;
            entity.Hentryfrom = dto.HentryFrom;
            entity.Hentryprefrom = dto.HentryPreFrom;
            entity.Hentrypreto = dto.HentryPreTo;
            entity.Hentryto = dto.HentryTo;

            entity.Hexitfrom = dto.HexitFrom;
            entity.Hexitto = dto.HexitTo;

            entity.Lentrywedgefrom = dto.LentryWedgeFrom;
            entity.Lentrywedgeto = dto.LentryWedgeTo;

            entity.PlannoInd0 = dto.PlanNoInd0;
            entity.PlannoInd1 = dto.PlanNoInd1;
            entity.PlannoInd2 = dto.PlanNoInd2;
            entity.PlannoInd3 = dto.PlanNoInd3;

            entity.SetpointsInd0 = dto.SetpointsInd0;
            entity.SetpointsInd1 = dto.SetpointsInd1;
            entity.SetpointsInd2 = dto.SetpointsInd2;
            entity.SetpointsInd3 = dto.SetpointsInd3;

            entity.Slablengthgroupfrom = dto.SlabLengthGroupFrom;
            entity.Slablengthgroupto = dto.SlabLengthGroupTo;

            entity.Sortid = dto.SortId;

            entity.Tentryfmfrom = dto.TentryFmFrom;
            entity.Tentryfmto = dto.TentryFmTo;
            entity.Tentryfrom = dto.TentryFrom;
            entity.Tentryto = dto.TentryTo;

            entity.Texitfrom = dto.TexitFrom;
            entity.Texitto = dto.TexitTo;

            entity.Wentryfrom = dto.WentryFrom;
            entity.Wentryto = dto.WentryTo;
            entity.Wexitfrom = dto.WexitFrom;
            entity.Wexitto = dto.WexitTo;

            entity.Weightentryfrom = dto.WeightEntryFrom;
            entity.Weightentryto = dto.WeightEntryTo;

            entity.Spareeqchar01 = dto.SpareEqChar01;
            entity.Sparefloat01from = dto.SpareFloat01From;
            entity.Sparefloat01to = dto.SpareFloat01To;
            entity.Sparefloat02from = dto.SpareFloat02From;
            entity.Sparefloat02to = dto.SpareFloat02To;
            entity.Sparefloat03from = dto.SpareFloat03From;
            entity.Sparefloat03to = dto.SpareFloat03To;
            entity.Sparefloat04from = dto.SpareFloat04From;
            entity.Sparefloat04to = dto.SpareFloat04To;
            entity.Sparefloat05from = dto.SpareFloat05From;
            entity.Sparefloat05to = dto.SpareFloat05To;
            entity.Sparefloat06from = dto.SpareFloat06From;
            entity.Sparefloat06to = dto.SpareFloat06To;
            entity.Sparefloat07from = dto.SpareFloat07From;
            entity.Sparefloat07to = dto.SpareFloat07To;
            entity.Sparefloat08from = dto.SpareFloat08From;
            entity.Sparefloat08to = dto.SpareFloat08To;

            entity.Mop = dto.Mop;
            entity.Toc = dto.Toc;
            entity.Tom = dto.Tom;

            return entity;
        }
        public static Aggregateselection ToEntity(this AggregateSelectionDto dto, int recId)
        {
            dto.RecId = recId + 1; // to be changed after changing recId to autoincrement in database
            return new Aggregateselection().MapFromDto(dto);
        }
    }
}
