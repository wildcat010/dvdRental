using Abp.Application.Services.Dto;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.Events;
using WebHMI.EventBus;
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

        public async Task<PagedResultDto<MaterialHeaderDto>> GetMaterialHeaderList(FilteredRequestDto input)
        {
            return await ApplyFilter(_prdbContext.HmiVMatInfoShorts
                .Where(x => x.EdOrSrc == "E" && x.EdLoSrc == "E" && x.EdPhySrc == "E"), input, MaterialHeaderDtoMapper.MapToDto);
        }

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

        public async Task<string> GetActualSequenceId()
        {
            var seq = (await _prdbContext.HmiVProdsequences
                .Select(x => new { x.SequenceId, x.Next })
                .FirstOrDefaultAsync(x => x.Next == 1));

            if (seq is null)
                return "-1";

            return seq.SequenceId;
        }

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

        public async Task<PagedResultDto<SequenceIdDto>> GetAllSequenceIds(FilteredRequestDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

            return await ApplyFilter<string,SequenceIdDto>(context.EdPhyEnts
                .Where(x => x.Source == "E")
                .Select(x => x.SequenceId)
                .Distinct(), input, (u) => { return new SequenceIdDto() { Key = u }; });
        }

    }
}
