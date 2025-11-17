using Abp.UI;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.ConnectionManagers;
using WebHMI.L2Adapter.Dtos;
using WebHMI.Message;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Senders
{
	internal class L2CappaCommunicationHandler : IL2CommunicationHandler
    {
		private readonly ILogger _logger;
        private readonly int _timeoutMs = 90;
        private IPdhStub _pdhStub;
        private XIDL.IOdaDbStub _dbStub;

        public L2CappaCommunicationHandler(ILogger logger)
		{
			_logger = logger;
            _pdhStub = CreateStub();
            _dbStub = CreateStubOdaDb();

        }
        public void EntryDataChange(VMatStructEntry matStruct, string connectionId)
        {
            ME_CODE meCode = ToL2MeCode(matStruct);

            HMI_RETURN hmiReturn = new HMI_RETURN();
            hmiReturn.HmiClientId = connectionId ?? "NoId";
            hmiReturn.FunctionName = "entryDataChange";
            hmiReturn.LfeName = "pdh";

            HandleL2Call(() =>
                _pdhStub.entryDataChange_async(null, _timeoutMs, meCode,2, hmiReturn) //meType = kind of material type 0 = physical 1 = logical, 2 = order
            );
        }

        public void SendProcessParametersUpdated(ParamsDto arguments)
        {
            HandleL2Call(() =>
                _dbStub.doParamLimitChange_async(null, _timeoutMs, arguments.PlantType, arguments.Name,arguments.OldUValue, arguments.OldLValue, arguments.NewUValue, arguments.NewLValue,arguments.DisplayName, arguments.UserName)
            );
        }

        public void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId)
        {
            throw new NotImplementedException();
        }

        public void MoveMaterialInSequence(VMatStructEntry matStructSrc, VMatStructEntry matStructDest, short location, string connectionId)
        {
            throw new NotImplementedException();
        }

        public void TakeoverActual4RevCurve(short standNo)
        {
            throw new NotImplementedException();
        }

        private ME_CODE ToL2MeCode(VMatStructEntry entryMatStruct)
        {
            ME_STRUCT meStruct = new()
            {
                MeId = entryMatStruct.EnOrMeId,
                MesId = entryMatStruct.EnOrMesId ?? -1,
                MeCreator = entryMatStruct.EnOrCreator
            };

            ME_CODE meCode = new()
            {
                BasId = entryMatStruct.EnOrBasId,
                ExtId = entryMatStruct.EnOrExtId,
                MeTyp = entryMatStruct.EnOrMeType,
                Actual = meStruct,
                Original = meStruct
            };

            return meCode;
        }

        private void HandleL2Call(Action action, [CallerMemberName] string method = "")
        {
            if (!ConnectionManager.IsL2CommunicationRunning)
            {
                _logger.Info($"[{method}] L2 call supressed, communication is not running");
                throw new UserFriendlyException("L2 communication is not running, trying to reconnect...");
            }

            _pdhStub ??= CreateStub();

            try
            {
                _logger.Info($"[{method}] Trying to send L2 call...");
                action();
                _logger.Info($"[{method}] L2 call sent");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[{method}] Error occured while sending L2 message", ex);
                throw new UserFriendlyException("Exception thrown when calling L2 Process");
            }
        }

        private IPdhStub CreateStub()
        {
            var request = new Request("AppPdh", "pdh", "EspNonControl", "IPdh", "hsmHmi");
            var stubHmiWeb = new IPdhStub(request);
            _logger.Info($"[CAPPA] {nameof(IPdhStub)} initialized");
            return stubHmiWeb;
        }

        private IOdaDbStub CreateStubOdaDb()
        {
            var request = new Request("AppOdaDb", "odaDb", "EspNonControl", "IOdaDb", "hsmHmi");
            var stubHmiWeb = new IOdaDbStub(request);
            _logger.Info($"[CAPPA] {nameof(IOdaDbStub)} initialized");
            return stubHmiWeb;
        }

        public void SetpointsCalculationHMI(VMatStructEntry matStruct, string aggregate, string connectionId)
        {
            throw new NotImplementedException();
        }
    }
}
