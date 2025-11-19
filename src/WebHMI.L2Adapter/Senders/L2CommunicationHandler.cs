using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Services;
using WebHMI.L2Adapter.Dtos;
using WebHMI.L2Adapter.Services.MosRcStub;
using WebHMI.L2Adapter.Services.OdaDbStub;
using WebHMI.L2Adapter.Services.PdhStub;
using WebHMI.L2Adapter.Services.StaStub;
using WebHMI.PRDB.Dbo;
using XIDL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using WebHMI.L2Adapter.Services.PapRcvStub;
using WebHMI.L2Adapter.Services.RollChangeStub;
using WebHMI.L2Adapter.Services.PapSndStub;
using Microsoft.VisualBasic;
using WebHMI.L2Adapter.Services.PdhCusStub;

namespace WebHMI.L2Adapter.Senders
{
    internal class L2CommunicationHandler : IL2CommunicationHandler
    {
        private readonly IServiceFactory _factory;
        public L2CommunicationHandler(IServiceFactory factory)
        {
            _factory = factory;
        }

        //private readonly IPdhStubService _pdhService;
        //private readonly IOdaDbStubService _odaDbService;
        //private readonly IMosRcStubService _mosRcService;
        //private readonly IStaStubService _staService;

        //public L2CommunicationHandler(
        //    //IPdhStubService pdhService,
        //    IOdaDbStubService odaDbService,
        //    IMosRcStubService mosRcService,
        //    IStaStubService staService)
        //{
        //    //_pdhService = pdhService;
        //    _odaDbService = odaDbService;
        //    _mosRcService = mosRcService;
        //    _staService = staService;
        //}

        //PDH

        public void EntryDataChange(VMatStructEntry matStruct, string connectionId)
        {
            var pdhService = _factory.Create<IPdhStubService>();
            try { pdhService.EntryDataChange(matStruct, connectionId); }
            finally { _factory.Release(pdhService); }
            
        }

        public void MoveMaterialInSequence(VMatStructEntry matStructSrc, VMatStructEntry matStructDest , short location, string connectionId)
        {
            //_pdhService.MoveMaterialInSequence(matStructSrc, matStructDest,location,connectionId);
            var pdhService = _factory.Create<IPdhStubService>();
            try { pdhService.MoveMaterialInSequence(matStructSrc, matStructDest, location, connectionId); }
            finally { _factory.Release(pdhService); }
        }

        public void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId)
        {
            // _pdhService.SetNextMaterialInSchedule(matStruct, connectionId);

            var pdhService = _factory.Create<IPdhStubService>();
            try { pdhService.SetNextMaterialInSchedule(matStruct, connectionId); }
            finally { _factory.Release(pdhService); }
        }

        //ODADB
        public void SendProcessParametersUpdated(ParamsDto args)
        {
            //  _odaDbService.SendProcessParametersUpdated(args);

            var odaDbService = _factory.Create<IOdaDbStubService>();
            try { odaDbService.SendProcessParametersUpdated(args); }
            finally { _factory.Release(odaDbService); }
        }

        public void SendRollData(string plantType, short standId)
        {
            var odaDbService = _factory.Create<IOdaDbStubService>();
            try { odaDbService.SendRollData(plantType, standId); }
            finally { _factory.Release(odaDbService); }
        }

        //MOSRC
        public void TakeoverActual4RevCurve(short standNo)
        {
            //  _mosRcService.TakeoverActual4RevCurve(standNo);
            var mosRcService = _factory.Create<IMosRcStubService>();
            try { mosRcService.TakeoverActual4RevCurve(standNo); }
            finally { _factory.Release(mosRcService); }
        }

        //STA 

        public void SetpointsCalculationHMI(VMatStructEntry matStruct, string aggregate, string connectionId) 
        {
            // _staService.SetpointsCalculationHMI(matStruct, aggregate,connectionId);

            var staService = _factory.Create<IStaStubService>();
            try { staService.SetpointsCalculationHMI(matStruct, aggregate, connectionId); }
            finally { _factory.Release(staService); }
        }
        //PAPRCV
        public void PrimdCopyHMI(VMatStructEntry matStruct, string newExtId, short isTestMat)
        {
            // _papRcvService.PrimdCopyHMI(matStruct, newExtId, isTestMat, connectionId);

            var papRcvService = _factory.Create<IPapRcvStubService>();
            try { papRcvService.PrimdCopyHMI(matStruct, newExtId, isTestMat); }
            finally { _factory.Release(papRcvService); }

        }

        //CHANGEROLL
        public void RollChange(RollChangeDto dto)
        {
            // _rollChangeService.RollChange(dto);

            var rollChangeService = _factory.Create<IRollChangeStubService>();
            try { rollChangeService.RollChange(dto); }
            finally { _factory.Release(rollChangeService); }

        }

        //PAPSND

        public void RequestRollData(string plantType, string rollId, short standNo, string rollType)
        {
            var papSndService = _factory.Create<IPapSndStubService>();
            try { papSndService.RequestRollData(plantType, rollId, standNo, rollType); }
            finally { _factory.Release(papSndService); }
        }

        //PDHCUS

        public void NewHeatSimulation(string heatId, string sequenceId, short heatStart, float length)
        {
            var pdhCusService = _factory.Create<IPdhCusStubService>();
            try { pdhCusService.NewHeatSimulation(heatId, sequenceId, heatStart, length); }
            finally { _factory.Release(pdhCusService); }
        }
        public void NewHeatOperation(string heatId, string sequenceId, short heatStart, float length)
        {
            var pdhCusService = _factory.Create<IPdhCusStubService>();
            try { pdhCusService.NewHeatOperation(heatId, sequenceId, heatStart, length); }
            finally { _factory.Release(pdhCusService); }
        }

    }
}
