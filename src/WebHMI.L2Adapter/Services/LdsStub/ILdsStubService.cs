using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Services.LdsStub
{
    public interface ILdsStubService
    {
        void UpdateConfig(string aggregateName);
    }
}
