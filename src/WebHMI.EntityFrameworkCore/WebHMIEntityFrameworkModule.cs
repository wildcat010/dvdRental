using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using System.Transactions;
using WebHMI.PRDB;
using WebHMI.WebHMI;
using WebHMI.WebHMI.Seed;

namespace WebHMI
{
	[DependsOn(
		typeof(AbpZeroCoreEntityFrameworkCoreModule))]
	public class WebHMIEntityFrameworkModule : AbpModule
	{
		/* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
		public bool SkipDbContextRegistration { get; set; }

		public bool SkipDbSeed { get; set; }

		public override void PreInitialize()
		{
			Configuration.ReplaceService<IConnectionStringResolver, CustomConnectionStringResolver>();

			if (!SkipDbContextRegistration)
			{
				Configuration.UnitOfWork.IsolationLevel = IsolationLevel.ReadCommitted;
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


