using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Senders
{
	/// <summary>
	/// Null object pattern for L2 communication sender to disable it for example for development.
	/// </summary>
	internal class NullCommunicationHandler : IL2CommunicationHandler
	{
        public void EntryDataChange(VMatStructEntry matStruct, string connectionId) 
        {
            throw new NotImplementedException();

        }
        public void MoveMaterialInSequence(VMatStructEntry matStructSrc, VMatStructEntry matStructDest, short location, string connectionId)
        {
            throw new NotImplementedException();
        }

        public void NewHeatOperation(string heatId, string sequenceId, short heatStart, float length)
        {
            throw new NotImplementedException();
        }

        public void NewHeatSimulation(string heatId, string sequenceId, short heatStart, float length)
        {
            throw new NotImplementedException();
        }

        public void PrimdCopyHMI(VMatStructEntry matStruct, string newExtId, short isTestMat)
        {
            throw new NotImplementedException();
        }

        public void RequestRollData(string plantType, string rollId, short standNo, string rollType)
        {
            throw new NotImplementedException();
        }

        public void RollChange(RollChangeDto dto)
        {
            throw new NotImplementedException();
        }

        public void SendProcessParametersUpdated(ParamsDto arguments)
        {
            throw new NotImplementedException();

        }

        public void SendRollData(string plantType, short standId)
        {
            throw new NotImplementedException();
        }

        public void SetNextMaterialInSchedule(VMatStructEntry matStruct, string connectionId)
        {
            throw new NotImplementedException();
        }

        public void SetpointsCalculationHMI(VMatStructEntry matStruct, string aggregate, string connectionId)
        {
            throw new NotImplementedException();
        }

        public void TakeoverActual4RevCurve(short standNo)
        {
            throw new NotImplementedException();
        }

        public void UpdateConfig(string aggregateName)
        {
            throw new NotImplementedException();
        }
    }
}
