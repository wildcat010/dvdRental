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
			var sourceL = matInfo.FirstOrDefault(x => x.Edorsrc == "L");
			var sourceM = matInfo.FirstOrDefault(x => x.Edorsrc == "M");
			var sourceS = matInfo.FirstOrDefault(x => x.Edorsrc == "S");
			var sourceE = matInfo.FirstOrDefault(x => x.Edorsrc == "E");

			result.Data.EnPhExtId.L = sourceL?.Enphextid;
			result.Data.EnPhExtId.M = sourceM?.Enphextid;
			result.Data.EnPhExtId.S = sourceS?.Enphextid;
			result.Data.EnPhExtId.E = sourceE?.Enphextid;

            result.Data.EnorBasId.L = sourceL?.Enorbasid;
            result.Data.EnorBasId.M = sourceM?.Enorbasid;
            result.Data.EnorBasId.S = sourceS?.Enorbasid;
            result.Data.EnorBasId.E = sourceE?.Enorbasid;

            result.Data.EnPhMeId.L = sourceL?.Enphmeid;
			result.Data.EnPhMeId.M = sourceM?.Enphmeid;
			result.Data.EnPhMeId.S = sourceS?.Enphmeid;
			result.Data.EnPhMeId.E = sourceE?.Enphmeid;

			result.Data.EdPhySrc.L = sourceL?.Edphysrc;
			result.Data.EdPhySrc.M = sourceM?.Edphysrc;
			result.Data.EdPhySrc.S = sourceS?.Edphysrc;
			result.Data.EdPhySrc.E = sourceE?.Edphysrc;

			result.Data.EnPhStatus.L = sourceL?.Enphstatus;
			result.Data.EnPhStatus.M = sourceM?.Enphstatus;
			result.Data.EnPhStatus.S = sourceS?.Enphstatus;
			result.Data.EnPhStatus.E = sourceE?.Enphstatus;

			result.Data.EdOrSrc.L = sourceL?.Edorsrc;
			result.Data.EdOrSrc.M = sourceM?.Edorsrc;
			result.Data.EdOrSrc.S = sourceS?.Edorsrc;
			result.Data.EdOrSrc.E = sourceE?.Edorsrc;

			result.Data.EnLoMeId.L = sourceL?.Enlomeid;
			result.Data.EnLoMeId.M = sourceM?.Enlomeid;
			result.Data.EnLoMeId.S = sourceS?.Enlomeid;
			result.Data.EnLoMeId.E = sourceE?.Enlomeid;

			result.Data.EdLoSrc.L = sourceL?.Edlosrc;
			result.Data.EdLoSrc.M = sourceM?.Edlosrc;
			result.Data.EdLoSrc.S = sourceS?.Edlosrc;
			result.Data.EdLoSrc.E = sourceE?.Edlosrc;

			result.Data.AlloyCode.L = sourceL?.Alloycode;
			result.Data.AlloyCode.M = sourceM?.Alloycode;
			result.Data.AlloyCode.S = sourceS?.Alloycode;
			result.Data.AlloyCode.E = sourceE?.Alloycode;

			result.Data.HEntry.L = sourceL?.Hentry;
			result.Data.HEntry.M = sourceM?.Hentry;
			result.Data.HEntry.S = sourceS?.Hentry;
			result.Data.HEntry.E = sourceE?.Hentry;

			result.Data.HExit.L = sourceL?.Hexit;
			result.Data.HExit.M = sourceM?.Hexit;
			result.Data.HExit.S = sourceS?.Hexit;
			result.Data.HExit.E = sourceE?.Hexit;

			result.Data.WEntry.L = sourceL?.Wentry;
			result.Data.WEntry.M = sourceM?.Wentry;
			result.Data.WEntry.S = sourceS?.Wentry;
			result.Data.WEntry.E = sourceE?.Wentry;

			result.Data.WeightEntry.L = sourceL?.Weightentry;
			result.Data.WeightEntry.M = sourceM?.Weightentry;
			result.Data.WeightEntry.S = sourceS?.Weightentry;
			result.Data.WeightEntry.E = sourceE?.Weightentry;

			result.Data.LEntry.L = sourceL?.Lentry;
			result.Data.LEntry.M = sourceM?.Lentry;
			result.Data.LEntry.S = sourceS?.Lentry;
			result.Data.LEntry.E = sourceE?.Lentry;

			result.Data.WExit.L = sourceL?.Wexit;
			result.Data.WExit.M = sourceM?.Wexit;
			result.Data.WExit.S = sourceS?.Wexit;
			result.Data.WExit.E = sourceE?.Wexit;

			result.Data.SequenceId.L = sourceL?.Sequenceid;
			result.Data.SequenceId.M = sourceM?.Sequenceid;
			result.Data.SequenceId.S = sourceS?.Sequenceid;
			result.Data.SequenceId.E = sourceE?.Sequenceid;

			result.Data.PdiStatus.L = sourceL?.Pdistatus;
			result.Data.PdiStatus.M = sourceM?.Pdistatus;
			result.Data.PdiStatus.S = sourceS?.Pdistatus;
			result.Data.PdiStatus.E = sourceE?.Pdistatus;

			result.Data.SetpointsPc2Ok.L = sourceL?.Setpointspc2ok;
			result.Data.SetpointsPc2Ok.M = sourceM?.Setpointspc2ok;
			result.Data.SetpointsPc2Ok.S = sourceS?.Setpointspc2ok;
			result.Data.SetpointsPc2Ok.E = sourceE?.Setpointspc2ok;

            result.Data.Setpointshrmok.L = sourceL?.Setpointshrmok;
            result.Data.Setpointshrmok.M = sourceM?.Setpointshrmok;
            result.Data.Setpointshrmok.S = sourceS?.Setpointshrmok;
            result.Data.Setpointshrmok.E = sourceE?.Setpointshrmok;

            result.Data.Sbaz.L = sourceL?.Sbaz;
			result.Data.Sbaz.M = sourceM?.Sbaz;
			result.Data.Sbaz.S = sourceS?.Sbaz;
			result.Data.Sbaz.E = sourceE?.Sbaz;

			result.Data.LastCalc.L = sourceL?.Lastcalc;
			result.Data.LastCalc.M = sourceM?.Lastcalc;
			result.Data.LastCalc.S = sourceS?.Lastcalc;
			result.Data.LastCalc.E = sourceE?.Lastcalc;

            result.Data.ModelInfoPc2.L = sourceL?.Sptlfaultfm;
            result.Data.ModelInfoPc2.M = sourceM?.Sptlfaultfm;
            result.Data.ModelInfoPc2.S = sourceS?.Sptlfaultfm;
            result.Data.ModelInfoPc2.E = sourceE?.Sptlfaultfm;

            result.Data.ModelInfoLC.L = sourceL?.Sptlfaultcs;
            result.Data.ModelInfoLC.M = sourceM?.Sptlfaultcs;
            result.Data.ModelInfoLC.S = sourceS?.Sptlfaultcs;
            result.Data.ModelInfoLC.E = sourceE?.Sptlfaultcs;

            result.Data.ApsKey.L = sourceL?.Apskey;
			result.Data.ApsKey.M = sourceM?.Apskey;
			result.Data.ApsKey.S = sourceS?.Apskey;
			result.Data.ApsKey.E = sourceE?.Apskey;

			result.Data.SimMat.L = sourceL?.Simmat;
			result.Data.SimMat.M = sourceM?.Simmat;
			result.Data.SimMat.S = sourceS?.Simmat;
			result.Data.SimMat.E = sourceE?.Simmat;

			result.Data.SetpointsCsOk.L = sourceL?.Setpointscsok;
			result.Data.SetpointsCsOk.M = sourceM?.Setpointscsok;
			result.Data.SetpointsCsOk.S = sourceS?.Setpointscsok;
			result.Data.SetpointsCsOk.E = sourceE?.Setpointscsok;

			result.Data.TEntryFm.L = sourceL?.Tentryfm;
			result.Data.TEntryFm.M = sourceM?.Tentryfm;
			result.Data.TEntryFm.S = sourceS?.Tentryfm;
			result.Data.TEntryFm.E = sourceE?.Tentryfm;

			result.Data.TExitFm.L = sourceL?.Texitfm;
			result.Data.TExitFm.M = sourceM?.Texitfm;
			result.Data.TExitFm.S = sourceS?.Texitfm;
			result.Data.TExitFm.E = sourceE?.Texitfm;

			result.Data.TExitCaster.L = sourceL?.Texitcaster;
			result.Data.TExitCaster.M = sourceM?.Texitcaster;
			result.Data.TExitCaster.S = sourceS?.Texitcaster;
			result.Data.TExitCaster.E = sourceE?.Texitcaster;

			result.Data.CoilTemp.L = sourceL?.Coiltemp;
			result.Data.CoilTemp.M = sourceM?.Coiltemp;
			result.Data.CoilTemp.S = sourceS?.Coiltemp;
			result.Data.CoilTemp.E = sourceE?.Coiltemp;

			result.Data.HeatId.L = sourceL?.Heatid;
			result.Data.HeatId.M = sourceM?.Heatid;
			result.Data.HeatId.S = sourceS?.Heatid;
			result.Data.HeatId.E = sourceE?.Heatid;

			result.Data.FlagBatchRolling.L = sourceL?.Flagbatchrolling;
			result.Data.FlagBatchRolling.M = sourceM?.Flagbatchrolling;
			result.Data.FlagBatchRolling.S = sourceS?.Flagbatchrolling;
			result.Data.FlagBatchRolling.E = sourceE?.Flagbatchrolling;

			result.Data.ProductType.L = sourceL?.Plateproduction;
			result.Data.ProductType.M = sourceM?.Plateproduction;
			result.Data.ProductType.S = sourceS?.Plateproduction;
			result.Data.ProductType.E = sourceE?.Plateproduction;

            result.Data.ProdStartTime.L = sourceL?.Prodstarttime;
            result.Data.ProdStartTime.M = sourceM?.Prodstarttime;
            result.Data.ProdStartTime.S = sourceS?.Prodstarttime;
            result.Data.ProdStartTime.E = sourceE?.Prodstarttime;

            result.Data.ProdEndTime.L = sourceL?.Prodendtime;
            result.Data.ProdEndTime.M = sourceM?.Prodendtime;
            result.Data.ProdEndTime.S = sourceS?.Prodendtime;
            result.Data.ProdEndTime.E = sourceE?.Prodendtime;

            return result;
		}

        public static MaterialHeaderDto MapToDto(this HmiVMatInfoShort matInfo)
        {
            var result = new MaterialHeaderDto();

            result.MeCode = new MeCodeDto()
            {
                Status = matInfo.Enorstatus,
                MeId = matInfo.Enormeid,
                MatType = "OR",
                MesId = 1,
                ExtId = matInfo.Enorextid
            };

            result.Data.EnPhExtId.E = matInfo?.Enphextid;

            result.Data.EnPhMeId.E = matInfo?.Enphmeid;

            result.Data.EdPhySrc.E = matInfo?.Edphysrc;

            result.Data.EnPhStatus.E = matInfo?.Enphstatus;

            result.Data.EdOrSrc.E = matInfo?.Edorsrc;

            result.Data.EnLoMeId.E = matInfo?.Enlomeid;

            result.Data.EdLoSrc.E = matInfo?.Edlosrc;

            result.Data.AlloyCode.E = matInfo?.Alloycode;

            result.Data.HEntry.E = matInfo?.Hentry;

            result.Data.HExit.E = matInfo?.Hexit;

            result.Data.WEntry.E = matInfo?.Wentry;

            result.Data.WeightEntry.E = matInfo?.Weightentry;

            result.Data.LEntry.E = matInfo?.Lentry;

            result.Data.WExit.E = matInfo?.Wexit;

            result.Data.SequenceId.E = matInfo?.Sequenceid;

            result.Data.PdiStatus.E = matInfo?.Pdistatus;

            result.Data.SetpointsPc2Ok.E = matInfo?.Setpointspc2ok;

            result.Data.Sbaz.E = matInfo?.Sbaz;

            result.Data.LastCalc.E = matInfo?.Lastcalc;

            result.Data.ApsKey.E = matInfo?.Apskey;

            result.Data.SimMat.E = matInfo?.Simmat;

            result.Data.SetpointsCsOk.E = matInfo?.Setpointscsok;

            result.Data.TEntryFm.E = matInfo?.Tentryfm;

            result.Data.TExitFm.E = matInfo?.Texitfm;

            result.Data.TExitCaster.E = matInfo?.Texitcaster;

            result.Data.CoilTemp.E = matInfo?.Coiltemp;

            result.Data.HeatId.E = matInfo?.Heatid;

            result.Data.FlagBatchRolling.E = matInfo?.Flagbatchrolling;

            result.Data.ProductType.E = matInfo?.Plateproduction;

            result.Data.ProdStartTime.E = matInfo?.Prodstarttime;

            result.Data.ProdEndTime.E = matInfo?.Prodendtime;

            return result;
        }
    }
}
