using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Services
{
    public interface IServiceFactory
    {
        T Create<T>();
        void Release<T>(T service);
    }

    public class ServiceFactory : IServiceFactory
    {
        public T Create<T>()
        {
            return IocManager.Instance.Resolve<T>();
        }

        public void Release<T>(T service)
        {
            IocManager.Instance.Release(service);
        }
    }
}
