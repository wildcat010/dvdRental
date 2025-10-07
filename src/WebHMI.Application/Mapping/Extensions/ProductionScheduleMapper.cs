using System;
using System.Net.NetworkInformation;
using WebHMI.Dtos;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.PRDB.Dbo;
using static System.Net.Mime.MediaTypeNames;

namespace WebHMI.Mapping.Extensions
{
	internal class ProductionScheduleMapper
	{
        internal static ScheduledMaterialsDto ToScheduledMaterialsDto(HmiVProdsequenceComplete dbo) => new()
		{
			EnOrMeCode = new MeCodeDto
			{
				MeId = dbo.EnOrMeId,
				MatType = "OR",
				ExtId = dbo.EnOrExtId,
                Status = dbo.EnOrStatus,

            },
			EnLogMeCode = new MeCodeDto
			{
				MeId = dbo.EnLoMeId,
				MatType = "LO",
				ExtId = dbo.EnLoExtId,
                Status = dbo.EnLoStatus,
            },
			EnPhMeCode = new MeCodeDto
			{
				MeId = dbo.EnPhMeId,
				MatType = "PH",
				ExtId = dbo.EnPhExtId,
				Status = dbo.EnPhStatus,
			},
            HExitHrm = dbo.HExitHrm,
          //  HExitHrmCalc = dbo.HExitHrmcalc,
            ProfileHRM = dbo.ProfileHrm,
            OrderNo = dbo.OrderNo,
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
			CoolStrategy = dbo.CoolStrategy,
            HeatId = dbo.HeatId,
			FlagBatchRolling = dbo.FlagBatchRolling,
            ProductType = dbo.PlateProduction
        };

        internal static GhostDischargedMaterialsDto ToGhostDischargedMaterialsDto(HmiVProdsequenceComplete dbo) => new()
        {
            EnOrMeCode = new MeCodeDto
            {
                MeId = dbo.EnOrMeId,
                MatType = "OR",
                ExtId = dbo.EnOrExtId,
                Status = dbo.EnOrStatus,
            },
            EnLogMeCode = new MeCodeDto
            {
                MeId = dbo.EnLoMeId,
                MatType = "LO",
                ExtId = dbo.EnLoExtId,
                Status = dbo.EnLoStatus,
            },
            EnPhMeCode = new MeCodeDto
            {
                MeId = dbo.EnPhMeId,
                MatType = "PH",
                ExtId = dbo.EnPhExtId,
                Status = dbo.EnPhStatus,
            },
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
            CoolStrategy = dbo.CoolStrategy,
            HeatId = dbo.HeatId,
            FlagBatchRolling = dbo.FlagBatchRolling,
            PlateProduction = dbo.PlateProduction
        };

    }
}
