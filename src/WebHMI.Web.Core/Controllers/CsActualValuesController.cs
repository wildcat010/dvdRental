using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebHMI.API.Services;
using WebHMI.Dtos;

namespace WebHMI.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CsActualValuesController : AbpController
    {
        private readonly CSActualValuesCacheService _csActualValuesCacheService;
        public CsActualValuesController(CSActualValuesCacheService csActualValuesCacheService)
        {
            _csActualValuesCacheService = csActualValuesCacheService;
        }

        [HttpGet]
        public async Task<List<LaminarCoolingActualValue>> GetTemperaturePlotData()
        {
            var result = await _csActualValuesCacheService.GetTemperaturePlotData();
            return result;
        }

        [HttpGet]
        public async Task FlushTrackingDataCaches()
        {
            await _csActualValuesCacheService.FlushCsActualValueCaches();
        }
    }
}
