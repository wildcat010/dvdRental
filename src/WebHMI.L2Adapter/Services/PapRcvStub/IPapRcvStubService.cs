using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;

namespace WebHMI.L2Adapter.Services.PapRcvStub
{
    public interface IPapRcvStubService
    {
        void PrimdCopyHMI(VMatStructEntry matStruct,string newExtId, short isTestMat);

    }
}
