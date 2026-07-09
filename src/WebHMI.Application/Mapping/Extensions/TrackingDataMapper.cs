using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal class TrackingDataMapper
	{
		public static InLineMaterialDto ToDto(HmiVInlineMaterial view) => new()
		{
			EnPhExtId = view.Enphextid,
			EnPhMeId = view.Enphmeid,
			EdPhySrc = view.Edphysrc,
			EnPhStatus = view.Enphstatus,
			EnOrMeId = view.Enormeid,
			EnOrExtId = view.Enorextid,
			EnOrMeType = view.Enormetype,
			EnOrMesId = view.Enormesid,
			EnOrCreator = view.Enorcreator,
			EdOrSrc = view.Edorsrc,
			EnLoMeId = view.Enlomeid,
			EdLoSrc = view.Edlosrc,
			AlloyCode = view.Alloycode,
			HEntry = view.Hentry,
			HExit = view.Hexit,
			WEntry = view.Wentry,
			WeightEntry = view.Weightentry,
			LEntry = view.Lentry,
			WExit = view.Wexit,
			SequenceId = view.Sequenceid,
			PdiStatus = view.Pdistatus,
			SetpointsPc2Ok = view.Setpointspc2ok,
			Sbaz = view.Sbaz,
			LastCalc = view.Lastcalc,
			ApsKey = view.Apskey,
			SimMat = view.Simmat,
			SetpointsCsOk = view.Setpointscsok,
			TEntryFm = view.Tentryfm,
			TExitFm = view.Texitfm,
			TExitCaster = view.Texitcaster,
			CoilTemp = view.Coiltemp,
			HeatId = view.Heatid,
			FlagBatchRolling = view.Flagbatchrolling,
			ProdStartTime = view.Prodstarttime,
            ProductType = view.Plateproduction
		};
	}
}
