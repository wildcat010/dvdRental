using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebHMI.Authorization;

namespace WebHMI
{
    [DependsOn(
        typeof(WebHMICoreModule), 
        typeof(AbpAutoMapperModule),
		typeof(WebHMIEntityFrameworkModule))]
    public class WebHMIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebHMIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebHMIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}


