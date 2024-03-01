using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebHMI.EntityFrameworkCore;
using WebHMI.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace WebHMI.Web.Tests
{
    [DependsOn(
        typeof(WebHMIWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class WebHMIWebTestModule : AbpModule
    {
        public WebHMIWebTestModule(WebHMIEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebHMIWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(WebHMIWebMvcModule).Assembly);
        }
    }
}

