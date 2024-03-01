using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebHMI.Configuration;

namespace WebHMI.Web.Host.Startup
{
    [DependsOn(
       typeof(WebHMIWebCoreModule))]
    public class WebHMIWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WebHMIWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebHMIWebHostModule).GetAssembly());
        }
    }
}


