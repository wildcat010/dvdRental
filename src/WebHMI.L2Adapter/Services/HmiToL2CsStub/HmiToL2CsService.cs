using Abp.UI;
using Castle.Core.Logging;
using System.Runtime.CompilerServices;
using WebHMI.L2Adapter.Services;
using WebHMI.L2Adapter.Services.HmiToL2CsStub;
using XIDL;

namespace WebHMI.API.L2Adapter.CAPPA
{
    public class HmiToL2CsService : StubServiceBase<IHmiToL2CsStub>, IHmiToL2CsService
    {
        public HmiToL2CsService(ILogger logger, Func<IHmiToL2CsStub> stubFactory)
            : base(logger, stubFactory)
        {
        }

        public void fillCsConfigurationSync(ref HmiCsConfigData configData)
        {
            try
            {
                _logger.Info($"[fillCsConfigurationSync] Trying to send L2 call...");
                Stub.fillCsConfigurationSync(ref configData);
                _logger.Info($"[fillCsConfigurationSync] L2 call sent");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[fillCsConfigurationSync] Error occured while sending L2 message", ex);
                throw new UserFriendlyException("Exception thrown when calling L2 Process");
            }
        }

        public void takeOverManualValveState(int idx, HmiCsValveColors manualValveState, int type)
        {
            HandleL2Call(() =>
                _stub.takeOverManualValveState_async(null, 0, idx, manualValveState, type)
            );
        }

        public void startMaintainanceManualTest(HmiCsMaintenanceManualConfig testData)
        {
            HandleL2Call(() =>
                _stub.startMaintainanceManualTest_async(null, 0, testData)
            );
        }

        public void startMaintainanceWaterTest(short testId)
        {
            HandleL2Call(() =>
                _stub.startMaintainanceWaterTest_async(null, 0, testId)
            );
        }

        public void startMaintainanceWorm(HmiCsMaintenanceWormConfig testData)
        {
            HandleL2Call(() =>
                _stub.startMaintainanceWorm_async(null, 0, testData)
            );
        }

        public void startTestSpecificValves(HmiCsMaintenanceSequenceConfig testData)
        {
            HandleL2Call(() =>
                _stub.startTestSpecificValves_async(null, 0, testData)
            );
        }

        public void fillValveCalibrationMode(ref bool mode)
        {
            HandleL2Call(
                _stub.fillValveCalibrationMode, ref mode
            );
        }


        public void startValveCalibration(HmiCsMaintenanceCalibrConfig[] testData)
        {
            HandleL2Call(() =>
                _stub.startValveCalibration_async(null, 0, testData)
            );
        }

        public void stopMaintainanceManualTest()
        {
            HandleL2Call(() =>
                _stub.stopMaintainanceManualTest_async(null, 0)
            );
        }

        public void stopMaintainanceWaterTest(short testId)
        {
            HandleL2Call(() =>
                _stub.stopMaintainanceWaterTest_async(null, 0, testId)
            );
        }

        public void stopMaintainanceWorm()
        {
            HandleL2Call(() =>
                _stub.stopMaintainanceWorm_async(null, 0)
            );
        }

        public void stopMaintainanceWormPowerCooling()
        {
            HandleL2Call(() =>
                _stub.stopMaintainanceWormPowerCooling_async(null, 0)
            );
        }

        public void stopTestSpecificValves()
        {
            HandleL2Call(() =>
                _stub.stopTestSpecificValves_async(null, 0)
            );
        }

        public void stopValveCalibration()
        {
            HandleL2Call(() =>
                _stub.stopValveCalibration_async(null, 0)
            );
        }

        public void takeOverL2Mode(HmiCsL2ModeEnum mode)
        {
            HandleL2Call(() =>
                _stub.takeOverL2Mode_async(null, 0, mode)
            );
        }

        public void startMaintainanceWormPowerCooling(HmiCsMaintenanceWormConfig config, double pressureDes4MaintenanceWormPc, double numberOfValves4MaintenanceWormPc)
        {
            pressureDes4MaintenanceWormPc /= 100_000; // Pa -> Bar, because L2 expects Bar unit

            HandleL2Call(() =>
                _stub.startMaintainanceWormPowerCooling_async(null, 0, config, pressureDes4MaintenanceWormPc, numberOfValves4MaintenanceWormPc)
            );
        }

        public void takeOverSliderF4t(HmiCsSliderF4t sliderF4t)
        {
            HandleL2Call(() =>
                _stub.takeOverSliderF4t_async(null, 0, sliderF4t)
            );
        }

        public delegate void RefAction<T>(ref T item);

        private void HandleL2Call<T>(RefAction<T> action, ref T item, [CallerMemberName] string method = "")
        {
            try
            {
                _logger.Info($"[{method}] Trying to send L2 call...");
                action(ref item);
                _logger.Info($"[{method}] L2 call sent");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[{method}] Error occured while sending L2 message", ex);
                throw new UserFriendlyException("Exception thrown when calling L2 Process");
            }
        }
    }
}
