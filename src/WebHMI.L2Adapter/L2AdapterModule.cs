using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.ConnectionManagers;
using WebHMI.L2Adapter.Dtos;
using WebHMI.L2Adapter.Senders;
using WebHMI.L2Adapter.Services;
using WebHMI.L2Adapter.Services.LdsStub;
using WebHMI.L2Adapter.Services.MosRcStub;
using WebHMI.L2Adapter.Services.OdaDbStub;
using WebHMI.L2Adapter.Services.PapRcvStub;
using WebHMI.L2Adapter.Services.PapSndStub;
using WebHMI.L2Adapter.Services.PdhCusStub;
using WebHMI.L2Adapter.Services.PdhStub;
using WebHMI.L2Adapter.Services.RollChangeStub;
using WebHMI.L2Adapter.Services.StaStub;
using XIDL;

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

                IocManager.IocContainer.Register(
                    Component.For<Func<IPdhStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IPdhStub>(() => new IPdhStub(new Request("AppPdh", "pdh", "EspNonControl", "IPdh", "hsmHmi"))))
                             .LifestyleTransient()
                );

                IocManager.Register<IPdhStubService, PdhStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IPdhCusStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IPdhCusStub>(() => new IPdhCusStub(new Request("AppPdh", "pdh", "EspNonControl", "IPdhCus", "hsmHmi"))))
                             .LifestyleTransient()
                );
                IocManager.Register<IPdhCusStubService, PdhCusStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IOdaDbStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IOdaDbStub>(() => new IOdaDbStub(new Request("AppOdaDb", "odaDb", "EspNonControl", "IOdaDb", "hsmHmi"))))
                             .LifestyleTransient()
                );

                IocManager.Register<IOdaDbStubService, OdaDbStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IRollChangeStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IRollChangeStub>(() => new IRollChangeStub(new Request("AppOdaDb", "odaDb", "EspNonControl", "IRollChange", "hsmHmi"))))
                             .LifestyleTransient()
                );

                IocManager.Register<IRollChangeStubService, RollChangeStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IMosRcStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IMosRcStub>(() => new IMosRcStub(new Request("AppMosRc", "mosRc", "EspControl", "IMosRc", "hsmHmi"))))
                             .LifestyleTransient()
                );
                IocManager.Register<IMosRcStubService, MosRcStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IStaStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IStaStub>(() => new IStaStub(new Request("AppStaPc2", "sta", "EspControl", "ISta", "hsmHmi"))))
                             .LifestyleTransient()
                );
                IocManager.Register<IStaStubService, StaStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IPapRcvStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IPapRcvStub>(() => new IPapRcvStub(new Request("AppPapRcv", "papRcv", "EspNonControl", "IPapRcv", "hsmHmi"))))
                             .LifestyleTransient()
                );
                IocManager.Register<IPapRcvStubService, PapRcvStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<IPapSndStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<IPapSndStub>(() => new IPapSndStub(new Request("AppPapSnd", "papSnd", "EspNonControl", "IPapSnd", "hsmHmi"))))
                             .LifestyleTransient()
                );
                IocManager.Register<IPapSndStubService, PapSndStubService>(DependencyLifeStyle.Transient);

                IocManager.IocContainer.Register(
                    Component.For<Func<ILdsStub>>()
                             .UsingFactoryMethod(() =>
                                 new Func<ILdsStub>(() => new ILdsStub(new Request("AppLds", "lds", "Project", "ILds", "hsmHmi"))))
                             .LifestyleTransient()
                );
                IocManager.Register<ILdsStubService, LdsStubService>(DependencyLifeStyle.Transient);

                IocManager.Register<IServiceFactory, ServiceFactory>(DependencyLifeStyle.Singleton);

                //new handler
                IocManager.Register<IL2CommunicationHandler, L2CommunicationHandler>(DependencyLifeStyle.Singleton);
                //IocManager.Register<IL2CommunicationHandler, L2CappaCommunicationHandler>(DependencyLifeStyle.Singleton);
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

        private void RegisterStubFactory(StubInfo s)
        {
            var stubType = s.StubType;
            var serviceType = s.ServiceType;
            var interfaceType = s.InterfaceType;
            var requestArgs = s.RequestArgs;

            IocManager.IocContainer.Register(
                Component.For(typeof(Func<>).MakeGenericType(stubType))
                         .UsingFactoryMethod(() =>
                            new Func<object>(() =>
                                Activator.CreateInstance(stubType, new Request(requestArgs[0], requestArgs[1], requestArgs[2], requestArgs[3], requestArgs[4]))
                            )
                         )
                         .LifestyleTransient()
            );

            IocManager.Register(interfaceType, serviceType, DependencyLifeStyle.Transient);

        }
    }
}
