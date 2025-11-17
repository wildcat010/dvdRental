using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.L2Adapter.Services.OdaDbStub;
using WebHMI.L2Adapter.Services.PdhStub;
using WebHMI.PRDB.Dbo;

namespace WebHMI.L2Adapter.Senders
{
    internal class L2CommunicationHandler : IL2CommunicationHandler
    {
        private readonly IPdhStubService _pdhService;
        private readonly IOdaDbStubService _odaDbService;

        public L2CommunicationHandler(
            IPdhStubService pdhService,
            IOdaDbStubService odaDbService)
        {
            _pdhService = pdhService;
            _odaDbService = odaDbService;
        }

        public void EntryDataChange(VMatStructEntry matStruct, string connectionId)
        {
            _pdhService.EntryDataChange(matStruct, connectionId);
        }

        public void SendProcessParametersUpdated(ParamsDto args)
        {
            _odaDbService.SendProcessParametersUpdated(args);
        }

        public void MoveMaterialInSequence(VMatStructEntry matStructSrc, VMatStructEntry matStructDest , short location, string connectionId)
        {
            _pdhService.MoveMaterialInSequence(matStructSrc, matStructDest,location,connectionId);
        }

        public void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId)
        {
            _pdhService.SetNextMaterialInSchedule(matStruct, connectionId);
        }
        
    }
}
