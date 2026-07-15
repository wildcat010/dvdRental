
using Abp.Dependency;
using Abp.Domain.Repositories;
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
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.API.BackgroundTask
{
    public class TrackingDataBackgroundTask : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly ITypedCache<string, MeCodeDto> _cacheMeCode;
        private readonly ITypedCache<string, Dictionary<string, MeCodeDto>> _cacheActualNext;
        //private readonly ITypedCache<string, List<MeCodeDto>> _cacheProducedCoils;
        private const string _trackingDataCacheKey = "TrackingDataBackgroundTask";

        private readonly ISignalRNotifier _signalRNotifier;

        private DateTime _lastHmiCoilUpdate = new();

        public TrackingDataBackgroundTask(IDbContextProvider<PrdbContext> dbContextProvider,
            AbpTimer timer,
            ICacheManager cacheManager,
            ISignalRNotifier signalRNotifier) : base(timer)
        {
            _dbContextProvider = dbContextProvider;
            Timer.Period = 2000;
            _cacheActualNext = cacheManager.GetCache<string, Dictionary<string, MeCodeDto>>("ActualNext");
            //_cacheProducedCoils = cacheManager.GetCache<string, List<MeCodeDto>>("ProducedCoils");
            _cacheMeCode = cacheManager.GetCache<string, MeCodeDto>("MeCode");
            _signalRNotifier = signalRNotifier;
        }

        protected override void DoWork()
        {
            UpdateTrackingDataCaches().GetAwaiter().GetResult();
        }

        [UnitOfWork]
        public virtual async Task UpdateTrackingDataCaches()
        {
            //await UpdateProducedCoilsCachesAsync();
            await UpdateActualNextCachesAsync();
        }

        //private async Task UpdateProducedCoilsCachesAsync()
        //{
        //    var currentCaches = await _cacheProducedCoils.TryGetValueAsync(_trackingDataCacheKey);
        //    if (currentCaches.HasValue && !await _hmiVProductionDataRepository.GetAll().Where(x => x.Productionstarttime.HasValue)
        //        .OrderByDescending(x => x.Productionstarttime).Take(5).AnyAsync(x => !currentCaches.Value.Select(x => x.ExtId).Contains(x.Enloextid)))
        //        return;

        //    var result = new List<MeCodeDto>();
        //    var nextSlabs = await _hmiVProductionDataRepository.GetAll().Where(x => x.Productionstarttime.HasValue)
        //        .OrderByDescending(x => x.Productionstarttime).Take(5).ToListAsync();
        //    foreach (var slab in nextSlabs)
        //        result.Add(await GetMeCodeFromCaches(slab.Enloextid));
        //    await _cacheProducedCoils.SetAsync(_trackingDataCacheKey, result);
        //    await _signalRNotifier.BroadcastToAllClientsAsync(result, "ProducedCoils");

        //}

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
            await _signalRNotifier.BroadcastToAllClientsAsync(result, "ActualNext");

            _lastHmiCoilUpdate = hmiCoils.Max(x => x.Tom) ?? default;
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
