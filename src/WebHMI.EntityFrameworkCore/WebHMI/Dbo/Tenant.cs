using Abp.MultiTenancy;

namespace WebHMI.WebHMI.Dbo
{
	public class Tenant : AbpTenant<User>
	{
		public Tenant()
		{
		}

		public Tenant(string tenancyName, string name)
			: base(tenancyName, name)
		{
		}
	}
}


