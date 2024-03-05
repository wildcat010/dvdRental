using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using Abp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB;

namespace WebHMI
{
	public class CustomConnectionStringResolver : DefaultConnectionStringResolver
	{
		private readonly IAbpStartupConfiguration _configuration;

		public CustomConnectionStringResolver(IAbpStartupConfiguration configuration)
						 : base(configuration)
		{
			_configuration = configuration;
		}

		public override string GetNameOrConnectionString(ConnectionStringResolveArgs args)
		{
			if (args["DbContextConcreteType"] as Type == typeof(PrdbContext))
			{
				return _configuration.Get<string>(WebHMIConsts.PRDBConnectionStringName);
			}

			return base.GetNameOrConnectionString(args);
		}
	}
}
