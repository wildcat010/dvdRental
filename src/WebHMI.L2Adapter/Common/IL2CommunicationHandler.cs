using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Dtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.L2Adapter.Common
{
    public interface IL2CommunicationHandler
    {
        //void AppendMaterial(VMatStructEntry matStruct, string connectionId);
        //void ClearAllManualInputs(VMatStructEntry matStruct, string connectionId);
        //void DeleteMaterial(VMatStructEntry matStruct, string connectionId);
        //void MoveMaterialInSequence(VMatStructEntry matStruct1, VMatStructEntry matStruct2, string connectionId);
        //void MoveMaterialUpOrDown(VMatStructEntry matStruct, int direction, string connectionId);
        //void SetNext(VMatStructEntry matStruct, string connectionId);
        //void UpdateSetpointsFm(VMatStructEntry matStruct, string connectionId, short pdiChanged = 0);
        //void UpdatePrimaryData(VMatStructEntry matStruct, string connectionId);
        //void UpdateSetpointsRm(VMatStructEntry matStruct, string connectionId, short pdiChanged = 0);
        //Task SyncMaterialAsync(VMatStructEntry hmiVEntryMatStruct, string plantType, string connectionId);
        //void RequestCalculation(VMatStructEntry entryMatStruct, short areaNo, short pdiChanged, string connectionId);
        //void RemoveMaterial(VMatStructEntry entryMatStruct, string operatorComment, int reasonId, string connectionId);
        //void RequestPrimaryData(short eventId, string coilId, string slabId, string scheduleName, double param1, string connectionId);
        void EntryDataChange(VMatStructEntry matStruct, string connectionId);
        void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId);
        void MoveMaterialInSequence(VMatStructEntry matStructSrc, VMatStructEntry matStructDest, short location, string connectionId);
        void SendProcessParametersUpdated(ParamsDto arguments);
        void TakeoverActual4RevCurve(short standNo);
        void SetpointsCalculationHMI(VMatStructEntry matStruct, string aggregate, string connectionId);
        void PrimdCopyHMI(VMatStructEntry matStruct, string newExtId, short isTestMat);
        void RollChange(RollChangeDto dto);
        void SendRollData(string plantType, short standId);
        //void SendProcessParametersCreated(ParamsDto arguments);
        //void SendProcessParametersDeleted(ParamsDto arguments);

    }
}
