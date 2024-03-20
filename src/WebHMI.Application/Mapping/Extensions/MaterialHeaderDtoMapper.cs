using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.PRDB.Dbo;
using static System.Net.Mime.MediaTypeNames;

namespace WebHMI.Mapping.Extensions
{
	internal static class MaterialHeaderDtoMapper
	{
        public static MaterialHeaderDto MapData(this MaterialHeaderDto result, List<HmiVMatInfoShort> matInfo)
		{
			var sourceL = matInfo.FirstOrDefault(x => x.EdOrSrc == "L");
			var sourceM = matInfo.FirstOrDefault(x => x.EdOrSrc == "M");
			var sourceS = matInfo.FirstOrDefault(x => x.EdOrSrc == "S");
			var sourceE = matInfo.FirstOrDefault(x => x.EdOrSrc == "E");

			result.Data.EnPhExtId.L = sourceL?.EnPhExtId;
			result.Data.EnPhExtId.M = sourceM?.EnPhExtId;
			result.Data.EnPhExtId.S = sourceS?.EnPhExtId;
			result.Data.EnPhExtId.E = sourceE?.EnPhExtId;

			result.Data.EnPhMeId.L = sourceL?.EnPhMeId;
			result.Data.EnPhMeId.M = sourceM?.EnPhMeId;
			result.Data.EnPhMeId.S = sourceS?.EnPhMeId;
			result.Data.EnPhMeId.E = sourceE?.EnPhMeId;

			result.Data.EdPhySrc.L = sourceL?.EdPhySrc;
			result.Data.EdPhySrc.M = sourceM?.EdPhySrc;
			result.Data.EdPhySrc.S = sourceS?.EdPhySrc;
			result.Data.EdPhySrc.E = sourceE?.EdPhySrc;

			result.Data.EnPhStatus.L = sourceL?.EnPhStatus;
			result.Data.EnPhStatus.M = sourceM?.EnPhStatus;
			result.Data.EnPhStatus.S = sourceS?.EnPhStatus;
			result.Data.EnPhStatus.E = sourceE?.EnPhStatus;

			result.Data.EnOrMeId.L = sourceL?.EnOrMeId;
			result.Data.EnOrMeId.M = sourceM?.EnOrMeId;
			result.Data.EnOrMeId.S = sourceS?.EnOrMeId;
			result.Data.EnOrMeId.E = sourceE?.EnOrMeId;

			result.Data.EnOrExtId.L = sourceL?.EnOrExtId;
			result.Data.EnOrExtId.M = sourceM?.EnOrExtId;
			result.Data.EnOrExtId.S = sourceS?.EnOrExtId;
			result.Data.EnOrExtId.E = sourceE?.EnOrExtId;

			result.Data.EnOrMeType.L = sourceL?.EnOrMeType;
			result.Data.EnOrMeType.M = sourceM?.EnOrMeType;
			result.Data.EnOrMeType.S = sourceS?.EnOrMeType;
			result.Data.EnOrMeType.E = sourceE?.EnOrMeType;

			result.Data.EnOrMesId.L = sourceL?.EnOrMesId;
			result.Data.EnOrMesId.M = sourceM?.EnOrMesId;
			result.Data.EnOrMesId.S = sourceS?.EnOrMesId;
			result.Data.EnOrMesId.E = sourceE?.EnOrMesId;

			result.Data.EnOrCreator.L = sourceL?.EnOrCreator;
			result.Data.EnOrCreator.M = sourceM?.EnOrCreator;
			result.Data.EnOrCreator.S = sourceS?.EnOrCreator;
			result.Data.EnOrCreator.E = sourceE?.EnOrCreator;

			result.Data.EdOrSrc.L = sourceL?.EdOrSrc;
			result.Data.EdOrSrc.M = sourceM?.EdOrSrc;
			result.Data.EdOrSrc.S = sourceS?.EdOrSrc;
			result.Data.EdOrSrc.E = sourceE?.EdOrSrc;

			result.Data.EnLoMeId.L = sourceL?.EnLoMeId;
			result.Data.EnLoMeId.M = sourceM?.EnLoMeId;
			result.Data.EnLoMeId.S = sourceS?.EnLoMeId;
			result.Data.EnLoMeId.E = sourceE?.EnLoMeId;

			result.Data.EdLoSrc.L = sourceL?.EdLoSrc;
			result.Data.EdLoSrc.M = sourceM?.EdLoSrc;
			result.Data.EdLoSrc.S = sourceS?.EdLoSrc;
			result.Data.EdLoSrc.E = sourceE?.EdLoSrc;

			result.Data.AlloyCode.L = sourceL?.AlloyCode;
			result.Data.AlloyCode.M = sourceM?.AlloyCode;
			result.Data.AlloyCode.S = sourceS?.AlloyCode;
			result.Data.AlloyCode.E = sourceE?.AlloyCode;

			result.Data.HEntry.L = sourceL?.HEntry;
			result.Data.HEntry.M = sourceM?.HEntry;
			result.Data.HEntry.S = sourceS?.HEntry;
			result.Data.HEntry.E = sourceE?.HEntry;

			result.Data.HExit.L = sourceL?.HExit;
			result.Data.HExit.M = sourceM?.HExit;
			result.Data.HExit.S = sourceS?.HExit;
			result.Data.HExit.E = sourceE?.HExit;

			result.Data.WEntry.L = sourceL?.WEntry;
			result.Data.WEntry.M = sourceM?.WEntry;
			result.Data.WEntry.S = sourceS?.WEntry;
			result.Data.WEntry.E = sourceE?.WEntry;

			result.Data.WeightEntry.L = sourceL?.WeightEntry;
			result.Data.WeightEntry.M = sourceM?.WeightEntry;
			result.Data.WeightEntry.S = sourceS?.WeightEntry;
			result.Data.WeightEntry.E = sourceE?.WeightEntry;

			result.Data.LEntry.L = sourceL?.LEntry;
			result.Data.LEntry.M = sourceM?.LEntry;
			result.Data.LEntry.S = sourceS?.LEntry;
			result.Data.LEntry.E = sourceE?.LEntry;

			result.Data.WExit.L = sourceL?.WExit;
			result.Data.WExit.M = sourceM?.WExit;
			result.Data.WExit.S = sourceS?.WExit;
			result.Data.WExit.E = sourceE?.WExit;

			result.Data.SequenceId.L = sourceL?.SequenceId;
			result.Data.SequenceId.M = sourceM?.SequenceId;
			result.Data.SequenceId.S = sourceS?.SequenceId;
			result.Data.SequenceId.E = sourceE?.SequenceId;

			result.Data.PdiStatus.L = sourceL?.PdiStatus;
			result.Data.PdiStatus.M = sourceM?.PdiStatus;
			result.Data.PdiStatus.S = sourceS?.PdiStatus;
			result.Data.PdiStatus.E = sourceE?.PdiStatus;

			result.Data.SetpointsPc2Ok.L = sourceL?.SetpointsPc2Ok;
			result.Data.SetpointsPc2Ok.M = sourceM?.SetpointsPc2Ok;
			result.Data.SetpointsPc2Ok.S = sourceS?.SetpointsPc2Ok;
			result.Data.SetpointsPc2Ok.E = sourceE?.SetpointsPc2Ok;

			result.Data.Sbaz.L = sourceL?.Sbaz;
			result.Data.Sbaz.M = sourceM?.Sbaz;
			result.Data.Sbaz.S = sourceS?.Sbaz;
			result.Data.Sbaz.E = sourceE?.Sbaz;

			result.Data.LastCalc.L = sourceL?.LastCalc;
			result.Data.LastCalc.M = sourceM?.LastCalc;
			result.Data.LastCalc.S = sourceS?.LastCalc;
			result.Data.LastCalc.E = sourceE?.LastCalc;

			result.Data.ApsKey.L = sourceL?.ApsKey;
			result.Data.ApsKey.M = sourceM?.ApsKey;
			result.Data.ApsKey.S = sourceS?.ApsKey;
			result.Data.ApsKey.E = sourceE?.ApsKey;

			result.Data.SimMat.L = sourceL?.SimMat;
			result.Data.SimMat.M = sourceM?.SimMat;
			result.Data.SimMat.S = sourceS?.SimMat;
			result.Data.SimMat.E = sourceE?.SimMat;

			result.Data.SetpointsCsOk.L = sourceL?.SetpointsCsOk;
			result.Data.SetpointsCsOk.M = sourceM?.SetpointsCsOk;
			result.Data.SetpointsCsOk.S = sourceS?.SetpointsCsOk;
			result.Data.SetpointsCsOk.E = sourceE?.SetpointsCsOk;

			result.Data.TEntryFm.L = sourceL?.TEntryFm;
			result.Data.TEntryFm.M = sourceM?.TEntryFm;
			result.Data.TEntryFm.S = sourceS?.TEntryFm;
			result.Data.TEntryFm.E = sourceE?.TEntryFm;

			result.Data.TExitFm.L = sourceL?.TExitFm;
			result.Data.TExitFm.M = sourceM?.TExitFm;
			result.Data.TExitFm.S = sourceS?.TExitFm;
			result.Data.TExitFm.E = sourceE?.TExitFm;

			result.Data.TExitCaster.L = sourceL?.TExitCaster;
			result.Data.TExitCaster.M = sourceM?.TExitCaster;
			result.Data.TExitCaster.S = sourceS?.TExitCaster;
			result.Data.TExitCaster.E = sourceE?.TExitCaster;

			result.Data.CoilTemp.L = sourceL?.CoilTemp;
			result.Data.CoilTemp.M = sourceM?.CoilTemp;
			result.Data.CoilTemp.S = sourceS?.CoilTemp;
			result.Data.CoilTemp.E = sourceE?.CoilTemp;

			result.Data.HeatId.L = sourceL?.HeatId;
			result.Data.HeatId.M = sourceM?.HeatId;
			result.Data.HeatId.S = sourceS?.HeatId;
			result.Data.HeatId.E = sourceE?.HeatId;

			result.Data.FlagBatchRolling.L = sourceL?.FlagBatchRolling;
			result.Data.FlagBatchRolling.M = sourceM?.FlagBatchRolling;
			result.Data.FlagBatchRolling.S = sourceS?.FlagBatchRolling;
			result.Data.FlagBatchRolling.E = sourceE?.FlagBatchRolling;

			return result;
		}
	}
}
