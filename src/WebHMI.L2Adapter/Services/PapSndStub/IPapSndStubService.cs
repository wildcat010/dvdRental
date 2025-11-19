using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Services.PapSndStub
{
    public interface IPapSndStubService
    {
        void RequestRollData(string plantType, string rollId, short standNo, string rollType);
    }
}
