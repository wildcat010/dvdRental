using WebHMI.Dtos;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal class ProductionScheduleDtoMapper
	{
		internal static ProductionScheduleDto ToDtoFromDbo(HmiVProdsequence dbo) => new()
		{
			EnOrMeCode = new MeCodeDto
			{
				MeId = dbo.EnOrMeId,
				MatType = "OR",
				ExtId = dbo.EnOrExtId
			},
			EnLogMeCode = new MeCodeDto
			{
				MeId = dbo.EnLoMeId,
				MatType = "LO",
			},
			EnPhMeCode = new MeCodeDto
			{
				MeId = dbo.EnPhMeId,
				MatType = "PH",
				ExtId = dbo.EnPhExtId,
				Status = dbo.EnPhStatus,
			},
			Position = dbo.Position,
			Next = dbo.Next,
			EdPhySrc = dbo.EdPhySrc,
			EdOrSrc = dbo.EdOrSrc,
			AlloyCode = dbo.AlloyCode,
			HEntry = dbo.HEntry,
			HExit = dbo.HExit,
			WEntry = dbo.WEntry,
			WeightEntry = dbo.WeightEntry,
			LEntry = dbo.LEntry,
			WExit = dbo.WExit,
			SequenceId = dbo.SequenceId,
			PdiStatus = dbo.PdiStatus,
			SetpointsPc2Ok = dbo.SetpointsPc2Ok,
			Sbaz = dbo.Sbaz,
			LastCalc = dbo.LastCalc,
			ApsKey = dbo.ApsKey,
			SimMat = dbo.SimMat,
			SetpointsCsOk = dbo.SetpointsCsOk,
			TEntryFm = dbo.TEntryFm,
			TExitFm = dbo.TExitFm,
			TExitCaster = dbo.TExitCaster,
			CoilTemp = dbo.CoilTemp,
			HeatId = dbo.HeatId,
			FlagBatchRolling = dbo.FlagBatchRolling,
            ProductType = dbo.PlateProduction
        };
	}
}
