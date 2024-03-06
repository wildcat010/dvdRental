using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using WebHMI.Authorization.Roles;
using WebHMI.Configuration;
using WebHMI.Localization;
using WebHMI.Timing;
using WebHMI.WebHMI.Dbo;

namespace WebHMI
{
	[DependsOn(typeof(AbpZeroCoreModule),
		typeof(WebHMIEntityFrameworkModule))]
    public class WebHMICoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            WebHMILocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = WebHMIConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            // TODO: study this, English?
            Configuration.Localization.Languages.Add(new LanguageInfo("de", "Deutsch"));

            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = WebHMIConsts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = WebHMIConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebHMICoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}


