
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Runtime.Caching;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.API.Helpers;
using WebHMI.Dtos;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.Services;

namespace WebHMI.API.BackgroundTask
{
    public class TrackingDataBackgroundTask : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly ITypedCache<string, MeCodeDto> _cacheMeCode;
        private readonly ITypedCache<string, Dictionary<string, MeCodeDto>> _cacheActualNext;
        private readonly ITypedCache<string, List<MeCodeDto>> _cacheNextSlabs;
        private const string _trackingDataCacheKey = "TrackingDataBackgroundTask";
        private readonly CommonAppService _commonService;

        private readonly ISignalRNotifier _signalRNotifier;

        private DateTime _lastHmiCoilUpdate = new();

        public TrackingDataBackgroundTask(IDbContextProvider<PrdbContext> dbContextProvider,
            AbpTimer timer,
            ICacheManager cacheManager,
            CommonAppService commonService,
            ISignalRNotifier signalRNotifier) : base(timer)
        {
            _dbContextProvider = dbContextProvider;
            Timer.Period = 2000;
            _cacheActualNext = cacheManager.GetCache<string, Dictionary<string, MeCodeDto>>("ActualNext");
            _cacheMeCode = cacheManager.GetCache<string, MeCodeDto>("MeCode");
            _cacheNextSlabs = cacheManager.GetCache<string, List<MeCodeDto>>("NextSlabs");
            _signalRNotifier = signalRNotifier;
            _commonService = commonService;
        }

        protected override void DoWork()
        {
            UpdateTrackingDataCaches().GetAwaiter().GetResult();
        }

        [UnitOfWork]
        public virtual async Task UpdateTrackingDataCaches()
        {
            await UpdateActualNextCachesAsync();
        }



        //function to update the actual and next caches
        private async Task UpdateActualNextCachesAsync()
        {
            var context = _dbContextProvider.GetDbContext();

            bool isCoilUpdated = await context.HmiCoils
                .AnyAsync(x => x.Tom > _lastHmiCoilUpdate);

            bool isCacheAvailable = (await _cacheActualNext.GetOrDefaultAsync(_trackingDataCacheKey)) is not null;

            if (!isCoilUpdated && isCacheAvailable)
                return;



            var result = new Dictionary<string, MeCodeDto>();

            var hmiCoils = await context.HmiCoils
                .Where(x => x.Id != null & x.Param != null)
                .ToListAsync();

            if (!hmiCoils.Any())
                return;

            foreach (var hmiCoil in hmiCoils)
            {
                var meCode = await GetMeCodeFromCaches(hmiCoil.Id);

                if (meCode is null)
                    continue;

                result.Add(hmiCoil.Param, meCode);
            }

            await _cacheActualNext.SetAsync(_trackingDataCacheKey, result);
            await _cacheNextSlabs.SetAsync(_trackingDataCacheKey, await GetNextSlabsCachesAsync());

            await _signalRNotifier.BroadcastToAllClientsAsync(result, "ActualNext");

            _lastHmiCoilUpdate = hmiCoils.Max(x => x.Tom) ?? default;
        }

        //function to get the next slabs caches
        private async Task<List<MeCodeDto>> GetNextSlabsCachesAsync()
        {
            var context = _dbContextProvider.GetDbContext();

            var result = new List<MeCodeDto>();

            var curSeqId = await _commonService.GetActualSequenceId();
            var nextSlabId = await context.HmiVProdsequences
                .Where(x => x.SequenceId == curSeqId)
                .OrderBy(x => x.Majorno)
                .ThenBy(x => x.Minorno)
                .Select(x => new { x.Majorno, x.Minorno })
                .FirstOrDefaultAsync();
            if (nextSlabId != null)
            {
                var tmp = context.HmiVProdsequences
                    .Where(x => x.Majorno >= nextSlabId.Majorno && x.Minorno >= nextSlabId.Minorno && x.SequenceId == curSeqId)
                    .OrderBy(x => x.Majorno)
                    .ThenBy(x => x.Minorno)
                    .Take(3);

                result = await tmp.Select(x => new MeCodeDto
                {
                    MeId = x.EnOrMeId,
                    MatType = "OR",
                    MesId = x.EnOrMesId ?? -1,
                    MeCreator = x.EnOrCreator,
                    ExtId = x.EnOrExtId,
                    Status = x.EnOrStatus
                })
                .ToListAsync();
            }

            await _signalRNotifier.BroadcastToAllClientsAsync(result, "NextSlabs");
            return result;
        }

        private async Task<MeCodeDto> GetMeCodeFromCaches(string enloextid)
        {
            var context = _dbContextProvider.GetDbContext();

            return await _cacheMeCode.GetAsync(enloextid, async () =>
            {
                return (await context.VMatStructEntries
                .FirstOrDefaultAsync(x => x.EnLoExtId == enloextid)
                )?.ToMeCodeDto();

            });
        }
    }
}
