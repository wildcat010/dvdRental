using Castle.Core.Logging;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Services.PdhStub
{
    internal class PdhStubService : StubServiceBase<IPdhStub>, IPdhStubService
    {
        public PdhStubService(ILogger logger, Func<IPdhStub> stubFactory)
        : base(logger, stubFactory)
        {
        }

        public void EntryDataChange(VMatStructEntry matStruct, string connectionId)
        {
            ME_CODE meCode = ToL2PhyMeCode(matStruct);

            HMI_RETURN hmiReturn = new HMI_RETURN();
            hmiReturn.HmiClientId = connectionId ?? "NoId";
            hmiReturn.FunctionName = "entryDataChange";
            hmiReturn.LfeName = "pdh";

            HandleL2Call(() =>
                _stub.entryDataChange_async(null, _timeoutMs, meCode, 2, hmiReturn) //meType = kind of material type 0 = physical 1 = logical, 2 = order
            );
        }

        public void MoveMaterialInSequence(VMatStructEntry matStructSource, VMatStructEntry matStructDest, short location, string connectionId)
        {
            ME_CODE meCodeSrc = ToL2PhyMeCode(matStructSource);
            ME_CODE meCodeDest = ToL2PhyMeCode(matStructDest);

            HMI_RETURN hmiReturn = new HMI_RETURN();
            hmiReturn.HmiClientId = connectionId ?? "NoId";
            hmiReturn.FunctionName = "moveMatInSchedule";
            hmiReturn.LfeName = "pdh";

            HandleL2Call(() =>
                _stub.moveMatInSchedule_async(null, _timeoutMs, meCodeSrc, meCodeDest, location, hmiReturn)
            );
        }

        public void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId)
        {
            ME_CODE meCode = ToL2PhyMeCode(matStruct);

            HMI_RETURN hmiReturn = new HMI_RETURN();
            hmiReturn.HmiClientId = connectionId ?? "NoId";
            hmiReturn.FunctionName = "setNextMatInSchedule";
            hmiReturn.LfeName = "pdh";

            HandleL2Call(() =>
                _stub.setNextMatInSchedule_async(null, _timeoutMs, meCode, hmiReturn)
            );
        }

        //public void AssignApsKey(string apsKey, string alloyCode, string connectionId)
        //{

        //    //HMI_RETURN hmiReturn = new HMI_RETURN();
        //    //hmiReturn.HmiClientId = connectionId ?? "NoId";
        //    //hmiReturn.FunctionName = "entryDataChange";
        //    //hmiReturn.LfeName = "pdh";

        //    HandleL2Call(() =>
        //        _stub.(null, _timeoutMs, meCode, 2, hmiReturn) //meType = kind of material type 0 = physical 1 = logical, 2 = order
        //    );
        //}

        

    }
}
