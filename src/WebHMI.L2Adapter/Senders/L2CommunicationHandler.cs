using Abp.Authorization;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.L2Adapter.Services;
using WebHMI.L2Adapter.Services.HmiToL2CsStub;
using WebHMI.L2Adapter.Services.LdsStub;
using WebHMI.L2Adapter.Services.MosRcStub;
using WebHMI.L2Adapter.Services.OdaDbStub;
using WebHMI.L2Adapter.Services.PapRcvStub;
using WebHMI.L2Adapter.Services.PapSndStub;
using WebHMI.L2Adapter.Services.PdhCusStub;
using WebHMI.L2Adapter.Services.PdhStub;
using WebHMI.L2Adapter.Services.RollChangeStub;
using WebHMI.L2Adapter.Services.StaStub;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Senders
{
    internal class L2CommunicationHandler : IL2CommunicationHandler
    {
        private readonly IServiceFactory _factory;
        public L2CommunicationHandler(IServiceFactory factory)
        {
            _factory = factory;
        }

        //PDH

        public void EntryDataChange(VMatStructEntry matStruct, string connectionId)
        {
            var pdhService = _factory.Create<IPdhStubService>();
            try { pdhService.EntryDataChange(matStruct, connectionId); }
            finally { _factory.Release(pdhService); }
        }

        public void MoveMaterialInSequence(VMatStructEntry matStructSrc, VMatStructEntry matStructDest, short location, string connectionId)
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

        public void AssignApsKey(string apsKey, string alloyCode)
        {
            // _pdhService.SetNextMaterialInSchedule(matStruct, connectionId);

            var pdhService = _factory.Create<IPdhStubService>();
            try { pdhService.AssignApsKey(apsKey, alloyCode); }
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

        //LDS

        public void UpdateConfig(string aggregateName)
        {
            var ldsService = _factory.Create<ILdsStubService>();
            try { ldsService.UpdateConfig(aggregateName); }
            finally { _factory.Release(ldsService); }
        }

        //CS

        public void fillCsConfigurationSync(ref HmiCsConfigData configData)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.fillCsConfigurationSync(ref configData); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void takeOverManualValveState(int idx, HmiCsValveColors manualValveState, int type)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.takeOverManualValveState(idx, manualValveState, type); }
            finally { _factory.Release(hmiToL2CsService); }
        }


        public void StartMaintainanceWorm(HmiCsMaintenanceWormConfig input)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.startMaintainanceWorm(input); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StopMaintainanceWorm()
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.stopMaintainanceWorm(); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StartMaintainanceWormPowerCooling(HmiCsMaintenanceWormConfig config, double pressureDes4MaintenanceWormPc, double numberOfValves4MaintenanceWormPc)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.startMaintainanceWormPowerCooling(config, pressureDes4MaintenanceWormPc, numberOfValves4MaintenanceWormPc); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StopMaintainanceWormPowerCooling()
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.stopMaintainanceWormPowerCooling(); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StartMaintainanceWaterTest(short testId)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.startMaintainanceWaterTest(testId); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StopMaintainanceWaterTest(short testId)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.stopMaintainanceWaterTest(testId); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StartMaintainanceManualTest(HmiCsMaintenanceManualConfig input)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.startMaintainanceManualTest(input); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StopMaintainanceManualTest()
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.stopMaintainanceManualTest(); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StartTestSpecificValves(HmiCsMaintenanceSequenceConfig input)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.startTestSpecificValves(input); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void StopTestSpecificValves()
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.stopTestSpecificValves(); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void takeOverL2Mode(HmiCsL2ModeEnum mode)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.takeOverL2Mode(mode); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void fillValveCalibrationMode(ref bool mode)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.fillValveCalibrationMode(ref mode); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void stopValveCalibration()
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.stopValveCalibration(); }
            finally { _factory.Release(hmiToL2CsService); }
        }

        public void startValveCalibration(HmiCsMaintenanceCalibrConfig[] testData)
        {
            var hmiToL2CsService = _factory.Create<IHmiToL2CsService>();
            try { hmiToL2CsService.startValveCalibration(testData); }
            finally { _factory.Release(hmiToL2CsService); }
        }
    }
}
