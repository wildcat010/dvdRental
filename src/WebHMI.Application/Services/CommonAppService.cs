using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
    public class CommonAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IEventBus _eventBus;
        private readonly ISignalRNotifier _signalRNotifier;

        public CommonAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IEventBus eventBus,
            ISignalRNotifier signalRNotifier)
        {
            _prdbContextProvider = prdbContextProvider;
            _eventBus = eventBus;
            _signalRNotifier = signalRNotifier;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<MaterialHeaderDto> GetMaterialHeaderDataById(int meid, string matType)
        {
            var result = new MaterialHeaderDto();
            List<HmiVMatInfoShort> hmiVMatInfoShortList = null;

            switch (matType)
            {
                case "OR":
                    hmiVMatInfoShortList = await _prdbContext.HmiVMatInfoShorts.Where(x => x.EnOrMeId == meid).ToListAsync();
                    break;
                case "PH":
                    hmiVMatInfoShortList = await _prdbContext.HmiVMatInfoShorts.Where(x => x.EnPhMeId == meid).ToListAsync();
                    break;
                case "LO":
                    hmiVMatInfoShortList = await _prdbContext.HmiVMatInfoShorts.Where(x => x.EnLoMeId == meid).ToListAsync();
                    break;
            }

            var rec = hmiVMatInfoShortList.FirstOrDefault();

            if (rec is null)
                throw new UserFriendlyException($"Material info not found for material with meid: '{meid}' and matType: '{matType}'");

            result.MeCode = new MeCodeDto
            {
                ExtId = rec.EnOrExtId,
                MatType = "OR",
                MeCreator = rec.EnOrCreator,
                MeId = rec.EnOrMeId,
                MesId = 1,
                Status = rec.EnOrStatus ?? -1
            };

            result.MapData(hmiVMatInfoShortList);

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<MaterialHeaderDto>> GetMaterialHeaderList(FilteredRequestDto input)
        {
            return await ApplyFilter(_prdbContext.HmiVMatInfoShorts
                .Where(x => x.EdOrSrc == "E" && x.EdLoSrc == "E" && x.EdPhySrc == "E")
                .OrderBy(x => x.SequenceId)
                .ThenBy(x=> x.IdSeq)
                .ThenBy(x => x.IdRiga), input, MaterialHeaderDtoMapper.MapToDto);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<ScheduledMaterialsDto>> GetPlannedMaterialList(FilteredRequestDto input)
        {
            var actualSequenceId = await GetActualSequenceId();

            return await ApplyFilter(_prdbContext.HmiVProdsequences
                    .Where(x => x.SimMat == 0 && x.SequenceId != actualSequenceId)
                    .OrderBy(x => x.Majorno)
                    .ThenBy(x => x.Minorno), input, MaterialHeaderDtoMapper.ToPlannedMaterialsDto);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<MaterialHeaderDto>> GetGhostMaterialHeaderList(FilteredRequestDto input)
        {
            return await ApplyFilter(_prdbContext.HmiVMatInfoShorts
                .Where(x => x.EdOrSrc == "E" && x.EdLoSrc == "E" && x.EdPhySrc == "E" && x.SimMat == 1)
                .OrderBy(x => x.IdSeq)
                .ThenByDescending(x => x.IdRiga), input, MaterialHeaderDtoMapper.MapToDto);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<MeCodeDto> GetNextMaterial(int meid, string matType)
        {
            MeCodeDto result = new() { MeId = -1 };

            //var actSeq = await GetActualSequenceId();

            var actualMaterial = await _prdbContext.HmiVProdsequenceCompletes
                //.Where(x => x.SequenceId == actSeq)
                .Where(x => x.EnOrMeId == meid)
                //.OrderBy(x => x.Majorno)
                //.ThenBy(x => x.Minorno)
                //.ThenBy(x => x.Position)
                .FirstOrDefaultAsync();

            if (actualMaterial == null)
                return result;

            //bool actualFound = false;

            //foreach (var el in fullRollSeqColl)
            //{
            //    if (actualFound)
            //    {
            //        result.MeId = el.EnOrMeId ?? -1;
            //        result.MatType = el.EnOrMeType;
            //        result.ExtId = el.EnOrExtId;
            //        break;
            //    }
            //    if (el.EnOrMeId == meid)
            //    {
            //        actualFound = true;
            //        continue;
            //    }
            //}

            var nextMaterial = await _prdbContext.HmiVProdsequenceCompletes
                .Where(x => x.SequenceId == actualMaterial.SequenceId)
                .Where(x => x.Position == actualMaterial.Position + 1)
                .FirstOrDefaultAsync();

            if (nextMaterial == null)
                return result;

            result.MeId = nextMaterial.EnOrMeId;
            result.MatType = nextMaterial.EnOrMeType;
            result.ExtId = nextMaterial.EnOrExtId;
            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<MeCodeDto> GetPreviousMaterial(int meid, string matType)
        {
            MeCodeDto result = new() { MeId = -1 };

            //var actSeq = await GetActualSequenceId();

            var actualMaterial = await _prdbContext.HmiVProdsequenceCompletes
                //.Where(x => x.SequenceId == actSeq)
                .Where(x => x.EnOrMeId == meid)
                //.OrderBy(x => x.Majorno)
                //.ThenBy(x => x.Minorno)
                //.ThenBy(x => x.Position)
                .FirstOrDefaultAsync();

            if (actualMaterial == null)
                return result;

            //HmiVProdsequenceComplete prevMat = null;

            //foreach (var el in actualMaterial)
            //{
            //    if (el.EnOrMeId == meid)
            //        break;
            //    else
            //        prevMat = el;
            //}

            //if (prevMat != null)
            //{
            //    result.MeId = prevMat.EnOrMeId ?? -1;
            //    result.MatType = prevMat.EnOrMeType;
            //    result.ExtId = prevMat.EnOrExtId;
            //}
            var prevMaterial = await _prdbContext.HmiVProdsequenceCompletes
                .Where(x => x.SequenceId == actualMaterial.SequenceId)
                .Where(x => x.Position == actualMaterial.Position - 1)
                .FirstOrDefaultAsync();

            if (prevMaterial == null)
                return result;

            result.MeId = prevMaterial.EnOrMeId;
            result.MatType = prevMaterial.EnOrMeType;
            result.ExtId = prevMaterial.EnOrExtId;
            return result;
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetActualSequenceId()
        {
            var seq = (await _prdbContext.HmiVActualsequences
               .Select(x => new { x.GetCurrentSequence })
               .FirstOrDefaultAsync());

            return seq.GetCurrentSequence ?? "No actual sequence found";
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetPreviousSequenceIdFromAll(string actuallyDisplayedSequenceId)
        {
            var sequences = await _prdbContext.EdPhyEnts
                .Where(x => x.Source == "E")
                .Select(x => x.SequenceId)
                .Distinct()
                .OrderBy(x => x)
                .ToListAsync();

            var actualIndex = sequences.IndexOf(actuallyDisplayedSequenceId);

            // Doesn't contain or first
            if (actualIndex < 1)
                return "-1";

            return sequences[--actualIndex];
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetPreviousSequenceId(string actuallyDisplayedSequenceId)
        {
            var sequences = await _prdbContext.HmiVProdsequences
                 .Select(x => x.SequenceId)
                .Distinct()
                .OrderBy(x => x)
                .ToListAsync();

            var actualIndex = sequences.IndexOf(actuallyDisplayedSequenceId);

            // Doesn't contain or first
            if (actualIndex < 1)
                return "-1";

            return sequences[--actualIndex];
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetNextSequenceIdFromAll(string actuallyDisplayedSequenceId)
        {
            var sequences = await _prdbContext.EdPhyEnts
                .Where(x => x.Source == "E")
                .Select(x => x.SequenceId)
                .Distinct()
                .OrderBy(x => x)
                .ToListAsync();

            var actualIndex = sequences.IndexOf(actuallyDisplayedSequenceId);

            // Doesn't contain or last
            if (actualIndex == -1 || actualIndex == sequences.Count - 1)
                return "-1";

            return sequences[++actualIndex];
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetNextSequenceId(string actuallyDisplayedSequenceId)
        {
            var sequences = await _prdbContext.HmiVProdsequences
                 .Select(x => x.SequenceId)
                .Distinct()
                .OrderBy(x => x)
                .ToListAsync();

            var actualIndex = sequences.IndexOf(actuallyDisplayedSequenceId);

            // Doesn't contain or last
            if (actualIndex == -1 || actualIndex == sequences.Count - 1)
                return "-1";

            return sequences[++actualIndex];
        }

        public async Task<PagedResultDto<SequenceIdDto>> GetAllProducedSequenceIds(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(context.EdPhyEnts

                .Where(x => x.Source == "E")
                .Select(x => x.SequenceId)
                .Distinct()
                .OrderByDescending(x => x)                
                , input, (u) => { return new SequenceIdDto() { Key = u }; });
        }

        public async Task<PagedResultDto<SequenceIdDto>> GetAllGhostSequenceIds(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(context.EdPhyEnts
                .Where(x => x.Source == "E" && x.SimMat == 1)
                .Select(x => x.SequenceId)
                .Distinct()
                .OrderByDescending(x => x), input, (u) => { return new SequenceIdDto() { Key = u }; });
        }

        public async Task<PagedResultDto<string>> GetAllHeatIds(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter(context.EdPhyEnts
                .Where(x => x.Source == "E")
                .Select(x => x.HeatId)
                .Distinct()
                .OrderByDescending(x => x), input, (heatId) => heatId);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<List<SingleMosFlagDto>> GetMosFlagByIds(List<string> ids)
        {
            var context = await _prdbContextProvider.GetDbContextAsync();
            var mosswitches = await context.MosSwitches.Where(x => x.RecNo == 0).ToListAsync();
            var mappedIds = ids.Select(x => NameToParam(x))
                .Where(x => x is not null)
                .ToList();
            var progparams = await context.ProgParameters.Where(x => mappedIds.Contains(x.Param)).ToListAsync();

            var flags = new Dictionary<string, Func<short>>()
            {
                { "AUTOMATICBENDINGRM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd17) },
                { "AUTOMATICBENDINGFM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd16) },
                { "PRIORITY", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd34) },
                { "LTIPFC", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd23) },
                { "IED", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd20) },
                { "WOS", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd19) },


                { "TAKOM", () => ProgparamsToHMISwitch(progparams.FirstOrDefault(m => m.Param == "SETPT_TAKEOVER_MANUAL")?.ParamNum) },
                { "LTI", () => ReverseMosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd06) },
                { "STI", () => ReverseMosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd05) },

                { "STIPFCRM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd45) },
                { "STIPFCFM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd22) },
                { "TOCS", () => ProgparamsToHMISwitch(progparams.FirstOrDefault(x => x.Param == "SETPTCS_TAKEOVER_MANUAL")?.ParamNum) },

                { "TAKOMCS", () => ProgparamsToHMISwitch(progparams.FirstOrDefault(m => m.Param == "SETPTCS_TAKEOVER_MANUAL")?.ParamNum) }
            };

            var result = ids
                .Where(id => flags.ContainsKey(id))
                .Select(id => new SingleMosFlagDto(id, flags[id]()))
                .ToList();

            return result;
        }

        [UnitOfWork]
        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        //[AbpAuthorize(Permissions.Pages_Setpoints_Edit)]
        public async Task<List<SingleMosFlagDto>> UpdateMosFlagByIds(List<SingleMosFlagDto> ids)
        {
            var context = await _prdbContextProvider.GetDbContextAsync();
            var mosswitches = await context.MosSwitches.Where(x => x.RecNo == 0).ToListAsync();
            var mappedIds = ids.Select(x => NameToParam(x.Name))
                .Where(x => x is not null)
                .ToList();
            var progparams = await context.ProgParameters.Where(x => mappedIds.Contains(x.Param)).ToListAsync();

            var flags = new Dictionary<string, Action<short>>()
            {
                { "AUTOMATICBENDINGRM", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd17 = HMIToMosswitchSwitch(x);
                }},
                { "AUTOMATICBENDINGFM", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd16 = HMIToMosswitchSwitch(x);
                }},
                { "PRIORITY", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd34 = HMIToMosswitchSwitch(x);
                }},
                { "IED", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd20 = HMIToMosswitchSwitch(x);
                }},
                { "WOS", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd19 = HMIToMosswitchSwitch(x);
                }},
                { "TOCS", (x) => {
                    var param = progparams.FirstOrDefault(m => m.Param == "SETPTCS_TAKEOVER_MANUAL");
                    if (param != null) param.ParamNum = HMIToProgparamsSwitch(x);
                }},
                { "TAKOM", (x) => {
                    var param = progparams.FirstOrDefault(m => m.Param == "SETPT_TAKEOVER_MANUAL");
                    if (param != null) param.ParamNum = HMIToProgparamsSwitch(x);
                }},
                { "TAKOMCS", (x) => {
                    var param = progparams.FirstOrDefault(m => m.Param == "SETPTCS_TAKEOVER_MANUAL");
                    if (param != null) param.ParamNum = HMIToProgparamsSwitch(x);
                }},
                { "LTI", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd06 = ReverseHMIToMosswitchSwitch(x);
                }},
                { "STI", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd05 = ReverseHMIToMosswitchSwitch(x);
                }},
                { "LTIPFC", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd23 = HMIToMosswitchSwitch(x);
                }},
                { "STIPFCRM", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd45 = HMIToMosswitchSwitch(x);
                }},
                { "STIPFCFM", (x) => {
                    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                    if (mos != null) mos.StrSwitchesInd22 = HMIToMosswitchSwitch(x);
                }},
            };

            var toUpdate = ids
                .Where(id => flags.ContainsKey(id.Name))
                .Select(x => new { Action = flags[x.Name], x.Value });

            foreach (var item in toUpdate)
            {
                item.Action.Invoke(item.Value);
            }

            return ids;
        }

        private static string NameToParam(string s) => s switch
        {
            "TORM" => "SETPTRM_TAKEOVER_MANUAL",
            "TOFM" => "SETPTFM_TAKEOVER_MANUAL",
            "TOCS" => "SETPTCS_TAKEOVER_MANUAL",
            "TAKOM" => "SETPT_TAKEOVER_MANUAL",

            _ => null
        };

        private static short MosswitchToHMISwitch(int? value)
        {
            return (short)(value == 1 ? 1 : 0);
        }

        private static short ReverseMosswitchToHMISwitch(int? value)
        {
            return (short)(value == 0 ? 1 : 0);
        }

        private static short ProgparamsToHMISwitch(double? value)
        {
            return (short)(value == 1d ? 1 : 0);
        }

        private static int HMIToMosswitchSwitch(short value)
        {
            return value == 1 ? 1 : 0;
        }

        private static int ReverseHMIToMosswitchSwitch(short value)
        {
            return value == 1 ? 0 : 1;
        }

        private static float HMIToProgparamsSwitch(short value)
        {
            return value;
        }

    }
}
