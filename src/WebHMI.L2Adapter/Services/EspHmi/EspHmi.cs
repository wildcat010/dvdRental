using Abp.Dependency;
using Abp.Runtime.Caching;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter.Services.EspHmi
{
    public class EspHmi : IEspHmi, ISingletonDependency
    {
        private readonly ILogger _logger;

        public EspHmi(
            ILogger logger)
        {
            _logger = logger;
        }

        public override void takeOverTrackingData(HmiTrackingData trackingData)
        {

            _logger.Info($"{nameof(takeOverTrackingData)} received data");


        }

        public override void takeOverTWMData(HmiTwmData data)
        {
            _logger.Info($"{nameof(takeOverTWMData)} received data");

        }
    }
}
