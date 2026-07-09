using XIDL;

namespace WebHMI.L2Adapter.Services.HmiToL2CsStub
{
    internal interface IHmiToL2CsService
    {
        void fillCsConfigurationSync(ref HmiCsConfigData configData);
        void takeOverManualValveState(int idx, HmiCsValveColors manualValveState, int type);
        void startMaintainanceManualTest(HmiCsMaintenanceManualConfig testData);
        void startMaintainanceWaterTest(short testId);
        void startMaintainanceWorm(HmiCsMaintenanceWormConfig testData);
        void startTestSpecificValves(HmiCsMaintenanceSequenceConfig testData);
        void fillValveCalibrationMode(ref bool mode);
        void startValveCalibration(HmiCsMaintenanceCalibrConfig[] testData);
        void stopMaintainanceManualTest();
        void stopMaintainanceWaterTest(short testId);
        void stopMaintainanceWorm();
        void stopMaintainanceWormPowerCooling();
        void stopTestSpecificValves();
        void stopValveCalibration();
        void takeOverL2Mode(HmiCsL2ModeEnum mode);
        void startMaintainanceWormPowerCooling(HmiCsMaintenanceWormConfig config, double pressureDes4MaintenanceWormPc, double numberOfValves4MaintenanceWormPc);
        void takeOverSliderF4t(HmiCsSliderF4t sliderF4t);
    }
}
