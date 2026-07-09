using WebHMI.PRDB.Dbo;

namespace WebHMI.L2Adapter.Services.PdhStub
{
    public interface IPdhStubService
    {
        void EntryDataChange(VMatStructEntry matStruct, string connectionId);
        void MoveMaterialInSequence(VMatStructEntry matStructSource, VMatStructEntry matStructDest, short location, string connectionId);
        void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId);
        void AssignApsKey(string apsKey, string alloyCode);
    }
}
