using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Core.Logging;
using Microsoft.Extensions.Configuration;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.ConnectionManagers;
using WebHMI.L2Adapter.Senders;

namespace WebHMI.L2Adapter
{
	public class L2AdapterModule : AbpModule
	{
		private readonly IConfiguration _configuration;
		private L2CommunicationConfiguration _l2CommunicationConfiguration;
		private readonly ILogger _logger;

		public L2AdapterModule(
			IConfiguration configuration, 
			ILogger logger)
		{
			_configuration = configuration;
			_logger = logger;
		}

		public override void PreInitialize()
		{
			_logger.Info("================================== Application is starting ==================================");

			IocManager.Register<L2CommunicationConfiguration>(); // add manually before Initialize method
			_l2CommunicationConfiguration = IocManager.Resolve<L2CommunicationConfiguration>();
			_configuration.Bind("L2Communication", _l2CommunicationConfiguration);
		}

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(L2AdapterModule).GetAssembly());

            if (_l2CommunicationConfiguration.IsEnabled)
            {
                IocManager.Register<IL2CommunicationHandler, L2CappaCommunicationHandler>(DependencyLifeStyle.Singleton);
                IocManager.Register<IConnectionManager, ConnectionManager>(DependencyLifeStyle.Singleton);
            }
            else
            {
                IocManager.Register<IL2CommunicationHandler, NullCommunicationHandler>();
                IocManager.Register<IConnectionManager, NullConnectionManager>();
            }
        }

		public override void PostInitialize()
		{
			IocManager.Resolve<IConnectionManager>();
		}

		public override void Shutdown()
		{
			_logger.Info("================================== Application is shutting down ==================================");
		}
	}
}
