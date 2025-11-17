using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Services.MosRcStub
{
    public interface IMosRcStubService
    {
        void TakeoverActual4RevCurve(short standNo);
    }
}
