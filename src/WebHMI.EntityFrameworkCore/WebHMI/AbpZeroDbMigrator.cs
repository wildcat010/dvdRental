using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Zero.EntityFrameworkCore;

namespace WebHMI.WebHMI
{
	public class AbpZeroDbMigrator : AbpZeroDbMigrator<WebHMIDbContext>
	{
		public AbpZeroDbMigrator(
			IUnitOfWorkManager unitOfWorkManager,
			IDbPerTenantConnectionStringResolver connectionStringResolver,
			IDbContextResolver dbContextResolver)
			: base(
				unitOfWorkManager,
				connectionStringResolver,
				dbContextResolver)
		{
		}
	}
}


