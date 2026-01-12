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
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
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
                Status = rec.EnPhStatus ?? -1
            };

            result.MapData(hmiVMatInfoShortList);

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<InLineMaterialDto>> GetInLineMaterials(FilteredRequestDto input)
        {
            return await ApplyFilter(_prdbContext.HmiVInlineMaterials.AsQueryable(), input, TrackingDataMapper.ToDto);
        }

        //public async Task<PagedResultDto<MaterialHeaderDto>> GetMaterialHeaderList(FilteredRequestDto input)
        //{
        //    var query = await ApplyFilterWithoutMapping(_prdbContext.HmiVMatInfoShorts.Where(x => x.EdOrSrc == "E" && x.EdLoSrc == "E" && x.EdPhySrc == "E"), input);
        //    var result = new List<MaterialHeaderDto>();

        //    foreach (var item in query.Items.DistinctBy(x => x.EnOrMeId))
        //    {
        //        var dto = new MaterialHeaderDto()
        //        {
        //            MeCode = new MeCodeDto()
        //            {
        //                Status = item.EnPhStatus,
        //                MeId = item.EnOrMeId,
        //                MatType = "OR",
        //                MesId = 1,
        //                ExtId = item.EnOrExtId
        //            },
        //        };

        //        dto.MapData([item]);

        //        result.Add(dto);
        //    }

        //    return new PagedResultDto<MaterialHeaderDto>(query.Items.Count, result.ToList());
        //}

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<MaterialHeaderDto>> GetMaterialHeaderList(FilteredRequestDto input)
        {
            return await ApplyFilter(_prdbContext.HmiVMatInfoShorts
                .Where(x => x.EdOrSrc == "E" && x.EdLoSrc == "E" && x.EdPhySrc == "E"), input, MaterialHeaderDtoMapper.MapToDto);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<MeCodeDto> GetNextMaterial(int meid, string matType)
        {
            MeCodeDto result = new() { MeId = -1 };

            var fullRollSeqColl = await _prdbContext.HmiVRollinghistoryseqs
                .OrderBy(f => f.Optstatdatetime)
                .ThenBy(f => f.Position)
                .ToListAsync();

            if (fullRollSeqColl.Count == 0)
                return result;

            bool actualFound = false;

            foreach (HmiVRollinghistoryseq el in fullRollSeqColl)
            {
                if (actualFound)
                {
                    result.MeId = el.Enormeid;
                    result.MatType = el.EnOrMeType;
                    result.ExtId = el.Enorextid;
                    break;
                }
                if (el.Enormeid == meid)
                {
                    actualFound = true;
                    continue;
                }
            }

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<MeCodeDto> GetPreviousMaterial(int meid, string matType)
        {
            MeCodeDto result = new() { MeId = -1 };

            var fullRollSeqColl = await _prdbContext.HmiVRollinghistoryseqs
                .OrderBy(f => f.Optstatdatetime)
                .ThenBy(f => f.Position)
                .ToListAsync();

            if (fullRollSeqColl.Count == 0)
                return result;

            HmiVRollinghistoryseq prevMat = null;

            foreach (HmiVRollinghistoryseq el in fullRollSeqColl)
            {
                if (el.Enormeid == meid)
                    break;
                else
                    prevMat = el;
            }

            if (prevMat != null)
            {
                result.MeId = prevMat.Enormeid;
                result.MatType = prevMat.EnOrMeType;
                result.ExtId = prevMat.Enorextid;
            }

            return result;
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetActualSequenceId()
        {
            var seq = (await _prdbContext.HmiVProdsequences
                .Select(x => new { x.SequenceId, x.Next })
                .FirstOrDefaultAsync(x => x.Next == 1));

            if (seq is null)
                return "-1";

            return seq.SequenceId;
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<string> GetPreviousSequenceId(string actuallyDisplayedSequenceId)
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
        public async Task<string> GetNextSequenceId(string actuallyDisplayedSequenceId)
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
        public async Task<PagedResultDto<SequenceIdDto>> GetAllSequenceIds(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter<string,SequenceIdDto>(context.EdPhyEnts
                .Where(x => x.Source == "E")
                .Select(x => x.SequenceId)
                .Distinct(), input, (u) => { return new SequenceIdDto() { Key = u }; });
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
                //{ "LTIRM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HRM")?.Strlongtimeinherblocked) },
                //{ "STIRM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HRM")?.Strshorttimeinherblocked) },
                //{ "RECRM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HRM")?.Strrecalculationblocked) },
                //{ "LTIFM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.Strlongtimeinherblocked) },
                //{ "STIFM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.Strshorttimeinherblocked) },
                //{ "ECFM", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.Strentrycalculationblocked) },
                //{ "LIPFC", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.Strlongtimeinherpfcblocked) },
                //{ "SIPFC", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.Strshorttimeinherpfcblocked) },
                //{ "ALPFC", () => ReverseMosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrswitchesInd0) },
                //{ "TORM", () => ProgparamsToHMISwitch(progparams.FirstOrDefault(m => m.Param == "SETPTRM_TAKEOVER_MANUAL")?.ParamNum) },
                //{ "TOFM", () =>  ProgparamsToHMISwitch(progparams.FirstOrDefault(m => m.Param == "SETPTFM_TAKEOVER_MANUAL")?.ParamNum) },
                //{ "WOPFC", () => MosswitchToHMISwitch(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.Strpfcwearshiftallowed) },
                //{ "TOCS", () => ProgparamsToHMISwitch(progparams.FirstOrDefault(x=> x.Param =="SETPTCS_TAKEOVER_MANUAL")?.ParamNum) },
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
                //{ "LTIRM", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HRM");
                //    if (mos != null) mos.Strlongtimeinherblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "STIRM", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HRM");
                //    if (mos != null) mos.Strshorttimeinherblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "RECRM", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HRM");
                //    if (mos != null) mos.Strrecalculationblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "LTIFM", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.Strlongtimeinherblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "STIFM", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.Strshorttimeinherblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "ECFM", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.Strentrycalculationblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "LIPFC", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.Strlongtimeinherpfcblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "SIPFC", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.Strshorttimeinherpfcblocked = HMIToMosswitchSwitch(x);
                //}},
                //{ "ALPFC", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.StrswitchesInd0 = ReverseHMIToMosswitchSwitch(x);
                //}},
                //{ "TORM", (x) => {
                //    var param = progparams.FirstOrDefault(m => m.Param == "SETPTRM_TAKEOVER_MANUAL");
                //    if (param != null) param.ParamNum = HMIToProgparamsSwitch(x);
                //}},
                //{ "TOFM", (x) => {
                //    var param = progparams.FirstOrDefault(m => m.Param == "SETPTFM_TAKEOVER_MANUAL");
                //    if (param != null) param.ParamNum = HMIToProgparamsSwitch(x);
                //}},
                //{ "WOPFC", (x) => {
                //    var mos = mosswitches.FirstOrDefault(m => m.PlantType == "HFM");
                //    if (mos != null) mos.Strpfcwearshiftallowed = HMIToMosswitchSwitch(x);
                //}},
                //{
                //  "TOCS", (x) => {
                //      var param = progparams.FirstOrDefault(x=>x.Param =="SETPTCS_TAKEOVER_MANUAL");
                //      if(param != null) param.ParamNum = HMIToProgparamsSwitch(x);
                //  }
                //}
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
            _ => null
        };

        private static short MosswitchToHMISwitch(int? value)
        {
            return (short)(value == 0 ? 1 : 0);
        }

        private static short ReverseMosswitchToHMISwitch(int? value)
        {
            return (short)(value == 0 ? 0 : 1);
        }

        private static short ProgparamsToHMISwitch(double? value)
        {
            return (short)(value == 1d ? 1 : 0);
        }

        private static int HMIToMosswitchSwitch(short value)
        {
            return value == 0 ? 1 : 0;
        }

        private static int ReverseHMIToMosswitchSwitch(short value)
        {
            return value == 0 ? 0 : 1;
        }

        private static double HMIToProgparamsSwitch(short value)
        {
            return value;
        }

    }
}
