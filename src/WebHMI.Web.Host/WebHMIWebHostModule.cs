using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebHMI.Configuration;
using Abp.Auditing;
using Abp.Configuration.Startup;
using WebHMI.Web.Host.Auditing;

namespace WebHMI.Web.Host
{
	[DependsOn(
	   typeof(WebHMIWebCoreModule))]
	public class WebHMIWebHostModule : AbpModule
	{
		public override void PreInitialize()
		{
			Configuration.Auditing.IsEnabledForAnonymousUsers = true;
			// Needed to disable audit log save by default, and saves only with AuditedAttribute applied
			Configuration.Auditing.Selectors.Clear();
			Configuration.ReplaceService<IAuditingStore, CustomAuditingStore>();
			Configuration.ReplaceService<IAuditingHelper, IgnoreDefaultAuditingHelper>();
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(WebHMIWebHostModule).GetAssembly());
		}
	}
}
