using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebHMI.Configuration;
using Abp.Auditing;
using Abp.Configuration.Startup;
using WebHMI.Web.Host.Auditing;
using Castle.Core.Logging;

namespace WebHMI.Web.Host
{
	[DependsOn(
	   typeof(WebHMIWebCoreModule))]
	public class WebHMIWebHostModule : AbpModule
	{
		private readonly ILogger _logger;

		public WebHMIWebHostModule(ILogger logger)
		{
			_logger = logger;
		}

		public override void PreInitialize()
		{
			Configuration.Auditing.IsEnabledForAnonymousUsers = true;
			// Needed to disable audit log save by default, and saves only with AuditedAttribute applied
			Configuration.Auditing.Selectors.Clear();
			Configuration.ReplaceService<IAuditingStore, CustomAuditingStore>();
			Configuration.ReplaceService<IAuditingHelper, IgnoreDefaultAuditingHelper>();

			_logger.Info("================================== Application is starting ==================================");
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(WebHMIWebHostModule).GetAssembly());
		}

		public override void Shutdown()
		{
			_logger.Info("================================== Application is shutting down ==================================");
		}
	}
}
