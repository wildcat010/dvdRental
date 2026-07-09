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
				MeId = dbo.Enormeid ?? -1,
				MatType = "OR",
				ExtId = dbo.Enorextid,
                Status = dbo.Enorstatus,

            },
			EnLogMeCode = new MeCodeDto
			{
				MeId = dbo.Enlomeid ?? -1,
				MatType = "LO",
				ExtId = dbo.Enloextid,
                Status = dbo.Enlostatus,
            },
			EnPhMeCode = new MeCodeDto
			{
				MeId = dbo.Enphmeid ?? -1,
				MatType = "PH",
				ExtId = dbo.Enphextid,
				Status = dbo.Enphstatus,
			},
            HExitHrm = dbo.Hexithrm,
          //  HExitHrmCalc = dbo.HExitHrmcalc,
            ProfileHRM = dbo.Profilehrm,
            OrderNo = dbo.Orderno,
            Position = (long?)dbo.Position,
			Next = dbo.Pnext,
			EdPhySrc = dbo.Edphysrc,
			EdOrSrc = dbo.Edorsrc,
			AlloyCode = dbo.Alloycode,
			HEntry = dbo.Hentry,
			HExit = dbo.Hexit,
			WEntry = dbo.Wentry,
			WeightEntry = dbo.Weightentry,
			LEntry = dbo.Lentry,
			LExit = dbo.Lexit,
            WExit = dbo.Wexit,
			SequenceId = dbo.Sequenceid,
			PdiStatus = dbo.Pdistatus,
			SetpointsPc2Ok = dbo.Setpointspc2ok,
			Sbaz = dbo.Sbaz,
			LastCalc = dbo.Lastcalc,
			ApsKey = dbo.Apskey,
			SimMat = dbo.Simmat,
			SetpointsCsOk = dbo.Setpointscsok,
			TEntryFm = dbo.Tentryfm,
			TExitFm = dbo.Texitfm,
			TExitCaster = dbo.Texitcaster,
			CoilTemp = dbo.Coiltemp,
			CoolStrategy = dbo.Coolstrategy,
            HeatId = dbo.Heatid,
			FlagBatchRolling = dbo.Flagbatchrolling,
            ProductType = dbo.Plateproduction
        };

        internal static ScheduledMaterialsDto ToScheduledMaterialsDto(HmiVProdsequence dbo) => new()
        {
            EnOrMeCode = new MeCodeDto
            {
                MeId = dbo.Enormeid,
                MatType = "OR",
                ExtId = dbo.Enorextid,
                Status = dbo.Enorstatus,

            },
            EnLogMeCode = new MeCodeDto
            {
                MeId = dbo.Enlomeid,
                MatType = "LO",
                ExtId = dbo.Enloextid,
                Status = dbo.Enlostatus,
            },
            EnPhMeCode = new MeCodeDto
            {
                MeId = dbo.Enphmeid,
                MatType = "PH",
                ExtId = dbo.Enphextid,
                Status = dbo.Enphstatus,
            },
            HExitHrm = dbo.Hexithrm,
            //  HExitHrmCalc = dbo.HExitHrmcalc,
            ProfileHRM = dbo.Profilehrm,
            OrderNo = dbo.Orderno,
            Position = (long?)dbo.Position,
            Next = dbo.Pnext,
            EdPhySrc = dbo.Edphysrc,
            EdOrSrc = dbo.Edorsrc,
            AlloyCode = dbo.Alloycode,
            HEntry = dbo.Hentry,
            HExit = dbo.Hexit,
            WEntry = dbo.Wentry,
            WeightEntry = dbo.Weightentry,
            LEntry = dbo.Lentry,
            LExit = dbo.Lexit,
            WExit = dbo.Wexit,
            SequenceId = dbo.Sequenceid,
            PdiStatus = dbo.Pdistatus,
            SetpointsPc2Ok = dbo.Setpointspc2ok,
            Sbaz = dbo.Sbaz,
            LastCalc = dbo.Lastcalc,
            ApsKey = dbo.Apskey,
            SimMat = dbo.Simmat,
            SetpointsCsOk = dbo.Setpointscsok,
            TEntryFm = dbo.Tentryfm,
            TExitFm = dbo.Texitfm,
            TExitCaster = dbo.Texitcaster,
            CoilTemp = dbo.Coiltemp,
            CoolStrategy = dbo.Coolstrategy,
            HeatId = dbo.Heatid,
            FlagBatchRolling = dbo.Flagbatchrolling,
            ProductType = dbo.Plateproduction
        };

        internal static GhostDischargedMaterialsDto ToGhostDischargedMaterialsDto(HmiVProdsequenceComplete dbo) => new()
        {
            EnOrMeCode = new MeCodeDto
            {
                MeId = dbo.Enormeid ?? -1,
                MatType = "OR",
                ExtId = dbo.Enorextid,
                Status = dbo.Enorstatus,
            },
            EnLogMeCode = new MeCodeDto
            {
                MeId = dbo.Enlomeid ?? -1,
                MatType = "LO",
                ExtId = dbo.Enloextid,
                Status = dbo.Enlostatus,
            },
            EnPhMeCode = new MeCodeDto
            {
                MeId = dbo.Enphmeid ?? -1,
                MatType = "PH",
                ExtId = dbo.Enphextid,
                Status = dbo.Enphstatus,
            },
            AlloyCode = dbo.Alloycode,
            HEntry = dbo.Hentry,
            HExit = dbo.Hexit,
            WEntry = dbo.Wentry,
            WeightEntry = dbo.Weightentry,
			LExit = dbo.Lexit,
            LEntry = dbo.Lentry,
            WExit = dbo.Wexit,
            SequenceId = dbo.Sequenceid,
            PdiStatus = dbo.Pdistatus,
            SetpointsPc2Ok = dbo.Setpointspc2ok,
            Sbaz = dbo.Sbaz,
            LastCalc = dbo.Lastcalc,
            ApsKey = dbo.Apskey,
            SimMat = dbo.Simmat,
            SetpointsCsOk = dbo.Setpointscsok,
            TEntryFm = dbo.Tentryfm,
            TExitFm = dbo.Texitfm,
            TExitCaster = dbo.Texitcaster,
            CoilTemp = dbo.Coiltemp,
            CoolStrategy = dbo.Coolstrategy,
            HeatId = dbo.Heatid,
            FlagBatchRolling = dbo.Flagbatchrolling,
            PlateProduction = dbo.Plateproduction
        };

    }
}
