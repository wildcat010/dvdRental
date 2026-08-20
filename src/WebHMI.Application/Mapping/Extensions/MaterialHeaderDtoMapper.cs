using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.ProductionSchedule;
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

            result.Data.EnorBasId.L = sourceL?.EnOrBasId;
            result.Data.EnorBasId.M = sourceM?.EnOrBasId;
            result.Data.EnorBasId.S = sourceS?.EnOrBasId;
            result.Data.EnorBasId.E = sourceE?.EnOrBasId;

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

            result.Data.Setpointshrmok.L = sourceL?.SetpointsHrmOk;
            result.Data.Setpointshrmok.M = sourceM?.SetpointsHrmOk;
            result.Data.Setpointshrmok.S = sourceS?.SetpointsHrmOk;
            result.Data.Setpointshrmok.E = sourceE?.SetpointsHrmOk;

            result.Data.Sbaz.L = sourceL?.Sbaz;
            result.Data.Sbaz.M = sourceM?.Sbaz;
            result.Data.Sbaz.S = sourceS?.Sbaz;
            result.Data.Sbaz.E = sourceE?.Sbaz;

            result.Data.LastCalc.L = sourceL?.LastCalc;
            result.Data.LastCalc.M = sourceM?.LastCalc;
            result.Data.LastCalc.S = sourceS?.LastCalc;
            result.Data.LastCalc.E = sourceE?.LastCalc;

            result.Data.ModelInfoPc1.L = sourceL?.SptlFaultHrm;
            result.Data.ModelInfoPc1.M = sourceM?.SptlFaultHrm;
            result.Data.ModelInfoPc1.S = sourceS?.SptlFaultHrm;
            result.Data.ModelInfoPc1.E = sourceE?.SptlFaultHrm;

            result.Data.ModelInfoPc2.L = sourceL?.SptlFaultHfm;
            result.Data.ModelInfoPc2.M = sourceM?.SptlFaultHfm;
            result.Data.ModelInfoPc2.S = sourceS?.SptlFaultHfm;
            result.Data.ModelInfoPc2.E = sourceE?.SptlFaultHfm;

            result.Data.ModelInfoLC.L = sourceL?.SptlFaultCs;
            result.Data.ModelInfoLC.M = sourceM?.SptlFaultCs;
            result.Data.ModelInfoLC.S = sourceS?.SptlFaultCs;
            result.Data.ModelInfoLC.E = sourceE?.SptlFaultCs;

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

            result.Data.HeatName.L = sourceL?.HeatName;
            result.Data.HeatName.M = sourceM?.HeatName;
            result.Data.HeatName.S = sourceS?.HeatName;
            result.Data.HeatName.E = sourceE?.HeatName;

            result.Data.FlagBatchRolling.L = sourceL?.FlagBatchRolling;
            result.Data.FlagBatchRolling.M = sourceM?.FlagBatchRolling;
            result.Data.FlagBatchRolling.S = sourceS?.FlagBatchRolling;
            result.Data.FlagBatchRolling.E = sourceE?.FlagBatchRolling;

            result.Data.ProductType.L = sourceL?.PlateProduction;
            result.Data.ProductType.M = sourceM?.PlateProduction;
            result.Data.ProductType.S = sourceS?.PlateProduction;
            result.Data.ProductType.E = sourceE?.PlateProduction;

            result.Data.ProdStartTime.L = sourceL?.ProdStartTime;
            result.Data.ProdStartTime.M = sourceM?.ProdStartTime;
            result.Data.ProdStartTime.S = sourceS?.ProdStartTime;
            result.Data.ProdStartTime.E = sourceE?.ProdStartTime;

            result.Data.ProdEndTime.L = sourceL?.ProdEndTime;
            result.Data.ProdEndTime.M = sourceM?.ProdEndTime;
            result.Data.ProdEndTime.S = sourceS?.ProdEndTime;
            result.Data.ProdEndTime.E = sourceE?.ProdEndTime;

            return result;
        }

        public static MaterialHeaderDto MapToDto(this HmiVMatInfoShort matInfo)
        {
            var result = new MaterialHeaderDto();

            result.MeCode = new MeCodeDto()
            {
                Status = matInfo.EnOrStatus,
                MeId = matInfo.EnOrMeId,
                MatType = "OR",
                MesId = 1,
                ExtId = matInfo.EnOrExtId
            };

            result.Data.EnPhExtId.E = matInfo?.EnPhExtId;

            result.Data.EnPhMeId.E = matInfo?.EnPhMeId;

            result.Data.EdPhySrc.E = matInfo?.EdPhySrc;

            result.Data.EnPhStatus.E = matInfo?.EnPhStatus;

            result.Data.EdOrSrc.E = matInfo?.EdOrSrc;

            result.Data.EnLoMeId.E = matInfo?.EnLoMeId;

            result.Data.EdLoSrc.E = matInfo?.EdLoSrc;

            result.Data.AlloyCode.E = matInfo?.AlloyCode;

            result.Data.HEntry.E = matInfo?.HEntry;

            result.Data.HExit.E = matInfo?.HExit;

            result.Data.WEntry.E = matInfo?.WEntry;

            result.Data.WeightEntry.E = matInfo?.WeightEntry;

            result.Data.LEntry.E = matInfo?.LEntry;

            result.Data.WExit.E = matInfo?.WExit;

            result.Data.SequenceId.E = matInfo?.SequenceId;

            result.Data.PdiStatus.E = matInfo?.PdiStatus;

            result.Data.SetpointsPc2Ok.E = matInfo?.SetpointsPc2Ok;

            result.Data.Sbaz.E = matInfo?.Sbaz;

            result.Data.LastCalc.E = matInfo?.LastCalc;

            result.Data.ApsKey.E = matInfo?.ApsKey;

            result.Data.SimMat.E = matInfo?.SimMat;

            result.Data.SetpointsCsOk.E = matInfo?.SetpointsCsOk;

            result.Data.TEntryFm.E = matInfo?.TEntryFm;

            result.Data.TExitFm.E = matInfo?.TExitFm;

            result.Data.TExitCaster.E = matInfo?.TExitCaster;

            result.Data.CoilTemp.E = matInfo?.CoilTemp;

            result.Data.HeatId.E = matInfo?.HeatId;

            result.Data.HeatName.E = matInfo?.HeatName;

            result.Data.FlagBatchRolling.E = matInfo?.FlagBatchRolling;

            result.Data.ProductType.E = matInfo?.PlateProduction;

            result.Data.ProdStartTime.E = matInfo?.ProdStartTime;

            result.Data.ProdEndTime.E = matInfo?.ProdEndTime;

            return result;
        }

        internal static ScheduledMaterialsDto ToPlannedMaterialsDto(HmiVProdsequence dbo) => new ScheduledMaterialsDto()
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
            Position = (long?)dbo.Position,
            Next = dbo.Pnext,
            EdPhySrc = dbo.EdPhySrc,
            EdOrSrc = dbo.EdOrSrc,
            AlloyCode = dbo.AlloyCode,
            HEntry = dbo.HEntry,
            HExit = dbo.HExit,
            WEntry = dbo.WEntry,
            WeightEntry = dbo.WeightEntry,
            LEntry = dbo.LEntry,
            LExit = dbo.LExit,
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
            ProductType = dbo.PlateProduction,
            HeatName = dbo.HeatName,
            calcFlag = dbo.CalcFlag
        };
    }
}
