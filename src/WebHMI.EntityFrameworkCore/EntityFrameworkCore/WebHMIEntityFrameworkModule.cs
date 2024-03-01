using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using WebHMI.EntityFrameworkCore.PRDB;
using WebHMI.EntityFrameworkCore.WebHMI;
using WebHMI.EntityFrameworkCore.WebHMI.Seed;

namespace WebHMI.EntityFrameworkCore
{
    [DependsOn(
        typeof(WebHMICoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class WebHMIEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.UnitOfWork.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                Configuration.UnitOfWork.IsTransactional = false;

				// Add WebHMI database
                Configuration.Modules.AbpEfCore().AddDbContext<WebHMIDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        WebHMIDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        WebHMIDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });

				// Add PRDB database
				Configuration.Modules.AbpEfCore().AddDbContext<PrdbContext>(options =>
				{
					if (options.ExistingConnection != null)
					{
						PrdbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
					}
					else
					{
						PrdbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
					}
				});
			}
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebHMIEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}


