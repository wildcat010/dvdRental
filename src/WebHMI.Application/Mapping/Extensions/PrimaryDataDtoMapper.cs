using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.PrimaryData;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal static class PrimaryDataDtoMapper
	{
        //Function which maps the data from the PrimaryDataDataBlob to the PrimaryDataDto
        public static PrimaryDataDto MapData(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
		{
			result.Data.SequenceId.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SequenceId;
			result.Data.SequenceId.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SequenceId;
			result.Data.SequenceId.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SequenceId;
			result.Data.SequenceId.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SequenceId;
            result.Data.SequenceId.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SequenceId)}";
            result.Data.SequenceId.Status = dataBlob.StatEdPhyEnts?.SequenceId;

            result.Data.HeatId.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.HeatId;
			result.Data.HeatId.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.HeatId;
			result.Data.HeatId.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.HeatId;
			result.Data.HeatId.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.HeatId;
            result.Data.HeatId.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.HeatId)}";
            result.Data.HeatId.Status = dataBlob.StatEdPhyEnts?.HeatId;

            result.Data.SlabThickness.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.AimSlabThickness;
			result.Data.SlabThickness.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.AimSlabThickness;
			result.Data.SlabThickness.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.AimSlabThickness;
			result.Data.SlabThickness.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.AimSlabThickness;
            result.Data.SlabThickness.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.AimSlabThickness)}";
            result.Data.SlabThickness.Status = dataBlob.StatEdPhyEnts?.AimSlabThickness;

            result.Data.SlabWidth.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWidth;
			result.Data.SlabWidth.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWidth;
			result.Data.SlabWidth.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWidth;
			result.Data.SlabWidth.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWidth;
            result.Data.SlabWidth.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabWidth)}";
            result.Data.SlabWidth.Status = dataBlob.StatEdPhyEnts?.SlabWidth;

            result.Data.SlabLength.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabLength;
			result.Data.SlabLength.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabLength;
			result.Data.SlabLength.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabLength;
			result.Data.SlabLength.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabLength;
            result.Data.SlabLength.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabLength)}";
            result.Data.SlabLength.Status = dataBlob.StatEdPhyEnts?.SlabLength;

            result.Data.SlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWeight;
			result.Data.SlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWeight;
			result.Data.SlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWeight;
			result.Data.SlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWeight;
            result.Data.SlabWeight.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabWeight)}";
            result.Data.SlabWeight.Status = dataBlob.StatEdPhyEnts?.SlabWeight;

            result.Data.AlloyCodeCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SteelCustomer;
			result.Data.AlloyCodeCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SteelCustomer;
			result.Data.AlloyCodeCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SteelCustomer;
			result.Data.AlloyCodeCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SteelCustomer;
            result.Data.AlloyCodeCustomer.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SteelCustomer)}";
            result.Data.AlloyCodeCustomer.Status = dataBlob.StatEdPhyEnts?.SteelCustomer;

            result.Data.SlabWidthHead.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWidthHead;
			result.Data.SlabWidthHead.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWidthHead;
			result.Data.SlabWidthHead.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWidthHead;
			result.Data.SlabWidthHead.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWidthHead;
            result.Data.SlabWidthHead.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabWidthHead)}";
            result.Data.SlabWidthHead.Status = dataBlob.StatEdPhyEnts?.SlabWidthHead;

            result.Data.SlabWidthTail.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWidthTail;
			result.Data.SlabWidthTail.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWidthTail;
			result.Data.SlabWidthTail.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWidthTail;
			result.Data.SlabWidthTail.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWidthTail;
            result.Data.SlabWidthTail.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabWidthTail)}";
            result.Data.SlabWidthTail.Status = dataBlob.StatEdPhyEnts?.SlabWidthTail;

            result.Data.WidthChangeFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.WidthChangeFlag;
			result.Data.WidthChangeFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.WidthChangeFlag;
			result.Data.WidthChangeFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.WidthChangeFlag;
			result.Data.WidthChangeFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.WidthChangeFlag;
            result.Data.WidthChangeFlag.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.WidthChangeFlag)}";
            result.Data.WidthChangeFlag.Status = dataBlob.StatEdPhyEnts?.WidthChangeFlag;

            result.Data.WidthChangePosStart.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabPosWidthChangeStart;
			result.Data.WidthChangePosStart.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabPosWidthChangeStart;
			result.Data.WidthChangePosStart.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabPosWidthChangeStart;
			result.Data.WidthChangePosStart.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabPosWidthChangeStart;
            result.Data.WidthChangePosStart.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabPosWidthChangeStart)}";
            result.Data.WidthChangePosStart.Status = dataBlob.StatEdPhyEnts?.SlabPosWidthChangeStart;

            result.Data.WidthChangePosEnd.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabPosWidthChangeEnd;
			result.Data.WidthChangePosEnd.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabPosWidthChangeEnd;
			result.Data.WidthChangePosEnd.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabPosWidthChangeEnd;
			result.Data.WidthChangePosEnd.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabPosWidthChangeEnd;
            result.Data.WidthChangePosEnd.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabPosWidthChangeEnd)}";
            result.Data.WidthChangePosEnd.Status = dataBlob.StatEdPhyEnts?.SlabPosWidthChangeEnd;

            result.Data.WidthChange.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.WidthChange;
			result.Data.WidthChange.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.WidthChange;
			result.Data.WidthChange.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.WidthChange;
			result.Data.WidthChange.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.WidthChange;
            result.Data.WidthChange.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.WidthChange)}";
            result.Data.WidthChange.Status = dataBlob.StatEdPhyEnts?.WidthChange;

            result.Data.MinSlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.MinSlabWeight;
			result.Data.MinSlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.MinSlabWeight;
			result.Data.MinSlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.MinSlabWeight;
			result.Data.MinSlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.MinSlabWeight;
            result.Data.MinSlabWeight.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.MinSlabWeight)}";
            result.Data.MinSlabWeight.Status = dataBlob.StatEdPhyEnts?.MinSlabWeight;

            result.Data.MaxSlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.MaxSlabWeight;
			result.Data.MaxSlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.MaxSlabWeight;
			result.Data.MaxSlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.MaxSlabWeight;
			result.Data.MaxSlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.MaxSlabWeight;
            result.Data.MaxSlabWeight.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.MaxSlabWeight)}";
            result.Data.MaxSlabWeight.Status = dataBlob.StatEdPhyEnts?.MaxSlabWeight;

            result.Data.PlateProductionFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.PlateProduction;
			result.Data.PlateProductionFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.PlateProduction;
			result.Data.PlateProductionFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.PlateProduction;
			result.Data.PlateProductionFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.PlateProduction;
            result.Data.PlateProductionFlag.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.PlateProduction)}";
            result.Data.PlateProductionFlag.Status = dataBlob.StatEdPhyEnts?.PlateProduction;

            result.Data.SimulationFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SimMat;
			result.Data.SimulationFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SimMat;
			result.Data.SimulationFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SimMat;
			result.Data.SimulationFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SimMat;
            result.Data.SimulationFlag.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SimMat)}";
            result.Data.SimulationFlag.Status = dataBlob.StatEdPhyEnts?.SimMat;

            result.Data.FMExitThicknessCustomer.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HExitCus;
			result.Data.FMExitThicknessCustomer.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HExitCus;
			result.Data.FMExitThicknessCustomer.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HExitCus;
			result.Data.FMExitThicknessCustomer.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HExitCus;
            result.Data.FMExitThicknessCustomer.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HExitCus)}";
            result.Data.FMExitThicknessCustomer.Status = dataBlob.StatEdOrdEnts?.HExitCus;

            result.Data.FMExitWidthCustomer.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WidthExitCus   ;
			result.Data.FMExitWidthCustomer.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WidthExitCus;
			result.Data.FMExitWidthCustomer.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WidthExitCus;
			result.Data.FMExitWidthCustomer.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WidthExitCus;
            result.Data.FMExitWidthCustomer.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.WidthExitCus)}";
            result.Data.FMExitWidthCustomer.Status = dataBlob.StatEdPhyEnts?.WidthExitCustomer;

            result.Data.OrderNo.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.OrderNo;
            result.Data.OrderNo.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.OrderNo;
            result.Data.OrderNo.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.OrderNo;
            result.Data.OrderNo.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.OrderNo;
            result.Data.OrderNo.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.OrderNo)}";
            result.Data.OrderNo.Status = dataBlob.StatEdOrdEnts?.OrderNo;

            result.Data.FlagBatchRolling.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.FlagBatchRolling;
			result.Data.FlagBatchRolling.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.FlagBatchRolling;
			result.Data.FlagBatchRolling.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.FlagBatchRolling;
			result.Data.FlagBatchRolling.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.FlagBatchRolling;
            result.Data.FlagBatchRolling.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.FlagBatchRolling)}";
            result.Data.FlagBatchRolling.Status = dataBlob.StatEdOrdEnts?.FlagBatchRolling;

            result.Data.AlloyCompensation.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.AlloyCompensation;
			result.Data.AlloyCompensation.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.AlloyCompensation;
			result.Data.AlloyCompensation.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.AlloyCompensation;
			result.Data.AlloyCompensation.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.AlloyCompensation;
            result.Data.AlloyCompensation.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.AlloyCompensation)}";
            result.Data.AlloyCompensation.Status = dataBlob.StatEdOrdEnts?.AlloyCompensation;

            result.Data.CastSpeed.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CastSpeed;
			result.Data.CastSpeed.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CastSpeed;
			result.Data.CastSpeed.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CastSpeed;
			result.Data.CastSpeed.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CastSpeed;
            result.Data.CastSpeed.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CastSpeed)}";
            result.Data.CastSpeed.Status = dataBlob.StatEdOrdEnts?.CastSpeed;

            result.Data.MinCastSpeed.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CastSpeedMin;
			result.Data.MinCastSpeed.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CastSpeedMin;
			result.Data.MinCastSpeed.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CastSpeedMin;
			result.Data.MinCastSpeed.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CastSpeedMin;
            result.Data.MinCastSpeed.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CastSpeedMin)}";
            result.Data.MinCastSpeed.Status = dataBlob.StatEdOrdEnts?.CastSpeedMin;

            result.Data.FMEntryThickness.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HIntermediate;
			result.Data.FMEntryThickness.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HIntermediate;
			result.Data.FMEntryThickness.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HIntermediate;
			result.Data.FMEntryThickness.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HIntermediate;
            result.Data.FMEntryThickness.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HIntermediate)}";
            result.Data.FMEntryThickness.Status = dataBlob.StatEdOrdEnts?.HIntermediate;

            result.Data.FMExitThickness.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HExit;
			result.Data.FMExitThickness.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HExit;
			result.Data.FMExitThickness.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HExit;
			result.Data.FMExitThickness.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HExit;
            result.Data.FMExitThickness.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HExit)}";
            result.Data.FMExitThickness.Status = dataBlob.StatEdOrdEnts?.HExit;

            result.Data.FMExitThicknessDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HClassMinDelta;
			result.Data.FMExitThicknessDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HClassMinDelta;
			result.Data.FMExitThicknessDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HClassMinDelta;
			result.Data.FMExitThicknessDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HClassMinDelta;
            result.Data.FMExitThicknessDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HClassMinDelta)}";
            result.Data.FMExitThicknessDeltaMin.Status = dataBlob.StatEdOrdEnts?.HClassMinDelta;

            result.Data.FMExitThicknessDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HClassMaxDelta;
			result.Data.FMExitThicknessDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HClassMaxDelta;
			result.Data.FMExitThicknessDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HClassMaxDelta;
			result.Data.FMExitThicknessDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HClassMaxDelta;
            result.Data.FMExitThicknessDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HClassMaxDelta)}";
            result.Data.FMExitThicknessDeltaMax.Status = dataBlob.StatEdOrdEnts?.HClassMaxDelta;

            result.Data.FMExitWidth.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WidthExit;
			result.Data.FMExitWidth.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WidthExit;
			result.Data.FMExitWidth.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WidthExit;
			result.Data.FMExitWidth.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WidthExit;
            result.Data.FMExitWidth.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.WidthExit)}";
            result.Data.FMExitWidth.Status = dataBlob.StatEdOrdEnts?.WidthExit;

            result.Data.FMExitWidthDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WClassMinDelta;
			result.Data.FMExitWidthDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WClassMinDelta;
			result.Data.FMExitWidthDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WClassMinDelta;
			result.Data.FMExitWidthDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WClassMinDelta;
            result.Data.FMExitWidthDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.WClassMinDelta)}";
            result.Data.FMExitWidthDeltaMin.Status = dataBlob.StatEdOrdEnts?.WClassMinDelta;

            result.Data.FMExitWidthDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WClassMaxDelta;
			result.Data.FMExitWidthDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WClassMaxDelta;
			result.Data.FMExitWidthDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WClassMaxDelta;
			result.Data.FMExitWidthDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WClassMaxDelta;
            result.Data.FMExitWidthDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.WClassMaxDelta)}";
            result.Data.FMExitWidthDeltaMax.Status = dataBlob.StatEdOrdEnts?.WClassMaxDelta;

            result.Data.FMExitCrown.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ExitCrownC25;
			result.Data.FMExitCrown.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ExitCrownC25;
			result.Data.FMExitCrown.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ExitCrownC25;
			result.Data.FMExitCrown.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ExitCrownC25;
            result.Data.FMExitCrown.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ExitCrownC25)}";
            result.Data.FMExitCrown.Status = dataBlob.StatEdOrdEnts?.ExitCrownC25;

            result.Data.FMExitCrownDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMinCrownDelta;
			result.Data.FMExitCrownDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMinCrownDelta;
			result.Data.FMExitCrownDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMinCrownDelta;
			result.Data.FMExitCrownDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMinCrownDelta;
            result.Data.FMExitCrownDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ClassMinCrownDelta)}";
            result.Data.FMExitCrownDeltaMin.Status = dataBlob.StatEdOrdEnts?.ClassMinCrownDelta;

            result.Data.FMExitCrownDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxCrownDelta;
			result.Data.FMExitCrownDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxCrownDelta;
			result.Data.FMExitCrownDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxCrownDelta;
			result.Data.FMExitCrownDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxCrownDelta;
            result.Data.FMExitCrownDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ClassMaxCrownDelta)}";
            result.Data.FMExitCrownDeltaMax.Status = dataBlob.StatEdOrdEnts?.ClassMaxCrownDelta;

            result.Data.FMExitTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.TExit;
			result.Data.FMExitTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.TExit;
			result.Data.FMExitTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.TExit;
			result.Data.FMExitTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.TExit;
            result.Data.FMExitTemp.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.TExit)}";
            result.Data.FMExitTemp.Status = dataBlob.StatEdOrdEnts?.TExit;

            result.Data.FMExitTempDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.TClassMinDelta;
			result.Data.FMExitTempDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.TClassMinDelta;
			result.Data.FMExitTempDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.TClassMinDelta;
			result.Data.FMExitTempDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.TClassMinDelta;
            result.Data.FMExitTempDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.TClassMinDelta)}";
            result.Data.FMExitTempDeltaMin.Status = dataBlob.StatEdOrdEnts?.TClassMinDelta;

            result.Data.FMExitTempDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.TClassMaxDelta;
			result.Data.FMExitTempDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.TClassMaxDelta;
			result.Data.FMExitTempDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.TClassMaxDelta;
			result.Data.FMExitTempDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.TClassMaxDelta;
            result.Data.FMExitTempDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.TClassMaxDelta)}";
            result.Data.FMExitTempDeltaMax.Status = dataBlob.StatEdOrdEnts?.TClassMaxDelta;

            result.Data.DestinationFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Destination;
			result.Data.DestinationFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Destination;
			result.Data.DestinationFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Destination;
			result.Data.DestinationFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Destination;
            result.Data.DestinationFlag.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.Destination)}";
            result.Data.DestinationFlag.Status = dataBlob.StatEdOrdEnts?.Destination;

            result.Data.ClassWedgeDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMinWedgeDelta;
			result.Data.ClassWedgeDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMinWedgeDelta;
			result.Data.ClassWedgeDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMinWedgeDelta;
			result.Data.ClassWedgeDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMinWedgeDelta;
            result.Data.ClassWedgeDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ClassMinWedgeDelta)}";
            result.Data.ClassWedgeDeltaMin.Status = dataBlob.StatEdOrdEnts?.ClassMinWedgeDelta;

            result.Data.ClassWedgeDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxWedgeDelta;
            result.Data.ClassWedgeDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxWedgeDelta;
            result.Data.ClassWedgeDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxWedgeDelta;
            result.Data.ClassWedgeDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxWedgeDelta;
            result.Data.ClassWedgeDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ClassMaxWedgeDelta)}";
            result.Data.ClassWedgeDeltaMax.Status = dataBlob.StatEdOrdEnts?.ClassMaxWedgeDelta;

            result.Data.ClassFlatDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxFlatDeltaSym;
            result.Data.ClassFlatDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxFlatDeltaSym;
            result.Data.ClassFlatDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxFlatDeltaSym;
            result.Data.ClassFlatDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxFlatDeltaSym;
            result.Data.ClassFlatDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ClassMaxFlatDeltaSym)}";
            result.Data.ClassFlatDeltaMin.Status = dataBlob.StatEdOrdEnts?.ClassMaxFlatDeltaSym;

            result.Data.ClassFlatDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxFlatDeltaAsym;
            result.Data.ClassFlatDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxFlatDeltaAsym;
            result.Data.ClassFlatDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxFlatDeltaAsym;
            result.Data.ClassFlatDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxFlatDeltaAsym;
            result.Data.ClassFlatDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ClassMaxFlatDeltaAsym)}";
            result.Data.ClassFlatDeltaMax.Status = dataBlob.StatEdOrdEnts?.ClassMaxFlatDeltaAsym;

            result.Data.CoilerTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoilTemp;
            result.Data.CoilerTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoilTemp;
            result.Data.CoilerTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoilTemp;
            result.Data.CoilerTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoilTemp;
            result.Data.CoilerTemp.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoilTemp)}";

            result.Data.CoilerTempDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoilTempMinTol;
            result.Data.CoilerTempDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoilTempMinTol;
            result.Data.CoilerTempDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoilTempMinTol;
            result.Data.CoilerTempDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoilTempMinTol;
            result.Data.CoilerTempDeltaMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoilTempMinTol)}";

            result.Data.CoilerTempDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoilTempMaxTol;
            result.Data.CoilerTempDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoilTempMaxTol;
            result.Data.CoilerTempDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoilTempMaxTol;
            result.Data.CoilerTempDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoilTempMaxTol;
            result.Data.CoilerTempDeltaMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoilTempMaxTol)}";

            result.Data.CoolingRateTop.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolRateTop;
            result.Data.CoolingRateTop.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolRateTop;
            result.Data.CoolingRateTop.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolRateTop;
            result.Data.CoolingRateTop.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolRateTop;
            result.Data.CoolingRateTop.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoolRateTop)}";

            result.Data.CoolingRateBottom.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolRateBot;
            result.Data.CoolingRateBottom.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolRateBot;
            result.Data.CoolingRateBottom.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolRateBot;
            result.Data.CoolingRateBottom.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolRateBot;
            result.Data.CoolingRateBottom.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoolRateBot)}";

            result.Data.CoolingStrategyFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolStrategy;
            result.Data.CoolingStrategyFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolStrategy;
            result.Data.CoolingStrategyFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolStrategy;
            result.Data.CoolingStrategyFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolStrategy;
            result.Data.CoolingStrategyFlag.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoolStrategy)}";

            result.Data.CoolingStrategyMode.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolingStrategyModeSelection;
            result.Data.CoolingStrategyMode.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolingStrategyModeSelection;
            result.Data.CoolingStrategyMode.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolingStrategyModeSelection;
            result.Data.CoolingStrategyMode.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolingStrategyModeSelection;
            result.Data.CoolingStrategyMode.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoolingStrategyModeSelection)}";

            result.Data.AlloyCode.L = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "L")?.AlloyCode;
			result.Data.AlloyCode.M = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "M")?.AlloyCode;
			result.Data.AlloyCode.S = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "S")?.AlloyCode;
			result.Data.AlloyCode.E = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "E")?.AlloyCode;
            result.Data.AlloyCode.DbSource = $"{nameof(EdLogEnt)}.{nameof(EdLogEnt.AlloyCode)}";
            result.Data.AlloyCode.Status = dataBlob.StatEdLogEnts?.AlloyCode;

            return result;
		}

        //Function to map the CSData from the PrimaryDataDataBlob to the PrimaryDataDto
        public static PrimaryDataDto MapCSData(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
        {
            var edOrdEntL = dataBlob.EdOrdEnts.Where(x => x.Source == "L").FirstOrDefault();
            var edOrdEntM = dataBlob.EdOrdEnts.Where(x => x.Source == "M").FirstOrDefault();
            var edOrdEntS = dataBlob.EdOrdEnts.Where(x => x.Source == "S").FirstOrDefault();
            var edOrdEntE = dataBlob.EdOrdEnts.Where(x => x.Source == "E").FirstOrDefault();

            var edPhyEntL = dataBlob.EdPhyEnts.Where(x => x.Source == "L").FirstOrDefault();
            var edPhyEntM = dataBlob.EdPhyEnts.Where(x => x.Source == "M").FirstOrDefault();
            var edPhyEntS = dataBlob.EdPhyEnts.Where(x => x.Source == "S").FirstOrDefault();
            var edPhyEntE = dataBlob.EdPhyEnts.Where(x => x.Source == "E").FirstOrDefault();

            var edLogEntL = dataBlob.EdLogEnts.Where(x => x.Source == "L").FirstOrDefault();
            var edLogEntM = dataBlob.EdLogEnts.Where(x => x.Source == "M").FirstOrDefault();
            var edLogEntS = dataBlob.EdLogEnts.Where(x => x.Source == "S").FirstOrDefault();
            var edLogEntE = dataBlob.EdLogEnts.Where(x => x.Source == "E").FirstOrDefault();

            result.CSData.CoilTemp.L = edOrdEntL?.CoilTemp;
            result.CSData.CoilTemp.M = edOrdEntM?.CoilTemp;
            result.CSData.CoilTemp.S = edOrdEntS?.CoilTemp;
            result.CSData.CoilTemp.E = edOrdEntE?.CoilTemp;
            result.CSData.CoilTemp.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoilTemp)}";
            result.CSData.CoilTemp.Status = dataBlob.StatEdOrdEnts?.CoilTemp;

            result.CSData.CoilTempMax.L = edOrdEntL?.CoilTempMaxTol;
            result.CSData.CoilTempMax.M = edOrdEntM?.CoilTempMaxTol;
            result.CSData.CoilTempMax.S = edOrdEntS?.CoilTempMaxTol;
            result.CSData.CoilTempMax.E = edOrdEntE?.CoilTempMaxTol;
            result.CSData.CoilTempMax.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoilTempMaxTol)}";
            result.CSData.CoilTempMax.Status = dataBlob.StatEdOrdEnts?.CoilTempMaxTol;

            result.CSData.CoilTempMin.L = edOrdEntL?.CoilTempMinTol;
            result.CSData.CoilTempMin.M = edOrdEntM?.CoilTempMinTol;
            result.CSData.CoilTempMin.S = edOrdEntS?.CoilTempMinTol;
            result.CSData.CoilTempMin.E = edOrdEntE?.CoilTempMinTol;
            result.CSData.CoilTempMin.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoilTempMinTol)}";
            result.CSData.CoilTempMin.Status = dataBlob.StatEdOrdEnts?.CoilTempMinTol;

            result.CSData.CoolMode.L = edOrdEntL?.CoolStrategy;
            result.CSData.CoolMode.M = edOrdEntM?.CoolStrategy;
            result.CSData.CoolMode.S = edOrdEntS?.CoolStrategy;
            result.CSData.CoolMode.E = edOrdEntE?.CoolStrategy;
            result.CSData.CoolMode.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoolStrategy)}";
            result.CSData.CoolMode.Status = dataBlob.StatEdOrdEnts?.CoolStrategy;

            result.CSData.CoolModeSource.L = edOrdEntL?.CoolingStrategyModeSelection;
            result.CSData.CoolModeSource.M = edOrdEntM?.CoolingStrategyModeSelection;
            result.CSData.CoolModeSource.S = edOrdEntS?.CoolingStrategyModeSelection;
            result.CSData.CoolModeSource.E = edOrdEntE?.CoolingStrategyModeSelection;
            result.CSData.CoolModeSource.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.CoolingStrategyModeSelection)}";
            result.CSData.CoolModeSource.Status = dataBlob.StatEdOrdEnts?.CoolingStrategyModeSelection;

            return result;
        }
		public static PrimaryDataDto MapChemistryElements(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
		{
			foreach (var edlogent in dataBlob.EdLogEnts)
			{
				var nameProperties = edlogent.GetType()
					.GetProperties()
					.Where(prop => prop.Name.StartsWith("AlloyName_Ind", StringComparison.OrdinalIgnoreCase))
					.Select(prop => new { Number = prop.Name["AlloyName_Ind".Length..], ElementName = prop.GetValue(edlogent)?.ToString() });

				var valueProperties = edlogent.GetType()
					.GetProperties()
					.Where(prop => prop.Name.StartsWith("AlloyValue_Ind", StringComparison.OrdinalIgnoreCase))
					.Select(prop => new { Number = prop.Name["AlloyValue_Ind".Length..], ElementValue = (double?)prop.GetValue(edlogent) });

				foreach (var nameProperty in nameProperties.Where(x => x.ElementName is not null))
				{
					var resultElement = result.ChemistryElements.FirstOrDefault(x => x.Name == nameProperty.ElementName);

					if (resultElement is null)
					{
						ChemistryElement newElement = new() { Name = nameProperty.ElementName };
						result.ChemistryElements.Add(newElement);
						resultElement = newElement;
					}

					double? matchedValue = valueProperties.FirstOrDefault(x => x.Number == nameProperty.Number).ElementValue;

					var sourceProperty = resultElement.Value.GetType().GetProperty(edlogent.Source);
					sourceProperty?.SetValue(resultElement.Value, matchedValue);
				}
			}

			return result;
		}
	}
}
