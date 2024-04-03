using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using WebHMI.L2Adapter.ConnectionManagers;
using WebHMI.L2Adapter.Senders;

namespace WebHMI.L2Adapter
{
    public class L2AdapterModule : AbpModule
    {
        private readonly IConfiguration _configuration;
        private L2CommunicationConfiguration _l2CommunicationConfiguration;

        public L2AdapterModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override void PreInitialize()
        {
            IocManager.Register<L2CommunicationConfiguration>(); // add manually before Initialize method
            _l2CommunicationConfiguration = IocManager.Resolve<L2CommunicationConfiguration>();
            _configuration.Bind("L2Communication", _l2CommunicationConfiguration);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(L2AdapterModule).GetAssembly());

            if (_l2CommunicationConfiguration.IsEnabled)
            {
                IocManager.Register<IL2Sender, L2Sender>();
                IocManager.Register<IConnectionManager, ConnectionManager>();
            }
            else
            {
                IocManager.Register<IL2Sender, NullL2Sender>();
                IocManager.Register<IConnectionManager, NullConnectionManager>();
            }
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<IConnectionManager>();
        }
    }
}
