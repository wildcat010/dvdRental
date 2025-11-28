using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using WebHMI.API.Services;
using WebHMI.Dtos;
using XIDL;
using WebHMI.Dtos.Application.Tracking;
using Abp.Auditing;

namespace WebHMI.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TrackingDataController : AbpController
    {
        private readonly TrackingDataCacheService _trackingDataCacheService;
        public TrackingDataController(TrackingDataCacheService trackingDataCacheService)
        {
            _trackingDataCacheService = trackingDataCacheService;
        }

        [HttpGet]
        public async Task<TrackingDataDto> GetTrackingData()
        {
            var result = await _trackingDataCacheService.GetTrackingStructCaches();
            return result;
        }
        [HttpGet]
        public async Task FlushTrackingDataCaches()
        {
            await _trackingDataCacheService.FlushTrackingDataCaches();
        }

        [HttpGet]
        public async Task<MaterialMVDataDto> GetMeasurements(int meid, string matType, string measurementName, short passNo)
        {
            return await _trackingDataCacheService.GetMeasurements(meid, matType, measurementName, passNo);
        }
    }
}
