using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal class TrackingDataMapper
	{
		public static InLineMaterialDto ToDto(HmiVInlineMaterial view) => new()
		{
         EnPhExtId = view.EnPhExtId,
			EnPhMeId = view.EnPhMeId,
			EdPhySrc = view.EdPhySrc,
			EnPhStatus = view.EnPhStatus,
			EnOrMeId = view.EnOrMeId,
			EnOrExtId = view.EnOrExtId,
			EnOrMeType = view.EnOrMeType,
			EnOrMesId = view.EnOrMesId,
			EnOrCreator = view.EnOrCreator,
			EdOrSrc = view.EdOrSrc,
			EnLoMeId = view.EnLoMeId,
			EdLoSrc = view.EdLoSrc,
			AlloyCode = view.AlloyCode,
			HEntry = view.HEntry,
			HExit = view.HExit,
			WEntry = view.WEntry,
			WeightEntry = view.WeightEntry,
			LEntry = view.LEntry,
			WExit = view.WExit,
			SequenceId = view.SequenceId,
			PdiStatus = view.PdiStatus,
			SetpointsPc2Ok = view.SetpointsPc2Ok,
			Sbaz = view.Sbaz,
           LastCalc = view.LastCalc,
			ApsKey = view.ApsKey,
			SimMat = view.SimMat,
			SetpointsCsOk = view.SetpointsCsOk,
			TEntryFm = view.TEntryFm,
			TExitFm = view.TExitFm,
			TExitCaster = view.TExitCaster,
			CoilTemp = view.CoilTemp,
			HeatId = view.HeatId,
			FlagBatchRolling = view.FlagBatchRolling,
			ProdStartTime = view.ProdStartTime,
			ProductType = view.PlateProduction
		};
	}
}
