using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.DataBlobs;
using WebHMI.Dtos.PrimaryData;

namespace WebHMI.Mapping.Extensions
{
	internal static class PrimaryDataDtoMapper
	{
		public static PrimaryDataDto MapData(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
		{
			result.Data.SequenceId.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SequenceId;
			result.Data.SequenceId.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SequenceId;
			result.Data.SequenceId.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SequenceId;
			result.Data.SequenceId.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SequenceId;

			result.Data.HeatId.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.HeatId;
			result.Data.HeatId.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.HeatId;
			result.Data.HeatId.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.HeatId;
			result.Data.HeatId.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.HeatId;

			result.Data.SlabThickness.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.AimSlabThickness;
			result.Data.SlabThickness.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.AimSlabThickness;
			result.Data.SlabThickness.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.AimSlabThickness;
			result.Data.SlabThickness.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.AimSlabThickness;

			result.Data.SlabWidth.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWidth;
			result.Data.SlabWidth.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWidth;
			result.Data.SlabWidth.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWidth;
			result.Data.SlabWidth.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWidth;

			result.Data.SlabLength.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabLength;
			result.Data.SlabLength.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabLength;
			result.Data.SlabLength.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabLength;
			result.Data.SlabLength.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabLength;

			result.Data.SlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWeight;
			result.Data.SlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWeight;
			result.Data.SlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWeight;
			result.Data.SlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWeight;

			result.Data.AlloyCodeCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SteelCustomer;
			result.Data.AlloyCodeCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SteelCustomer;
			result.Data.AlloyCodeCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SteelCustomer;
			result.Data.AlloyCodeCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SteelCustomer;

			result.Data.SlabWidthHead.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWidthHead;
			result.Data.SlabWidthHead.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWidthHead;
			result.Data.SlabWidthHead.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWidthHead;
			result.Data.SlabWidthHead.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWidthHead;

			result.Data.SlabWidthTail.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabWidthTail;
			result.Data.SlabWidthTail.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabWidthTail;
			result.Data.SlabWidthTail.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabWidthTail;
			result.Data.SlabWidthTail.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabWidthTail;

			result.Data.WidthChangeFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.WidthChangeFlag;
			result.Data.WidthChangeFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.WidthChangeFlag;
			result.Data.WidthChangeFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.WidthChangeFlag;
			result.Data.WidthChangeFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.WidthChangeFlag;

			result.Data.WidthChangePosStart.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabPosWidthChangeStart;
			result.Data.WidthChangePosStart.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabPosWidthChangeStart;
			result.Data.WidthChangePosStart.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabPosWidthChangeStart;
			result.Data.WidthChangePosStart.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabPosWidthChangeStart;

			result.Data.WidthChangePosEnd.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SlabPosWidthChangeEnd;
			result.Data.WidthChangePosEnd.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SlabPosWidthChangeEnd;
			result.Data.WidthChangePosEnd.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SlabPosWidthChangeEnd;
			result.Data.WidthChangePosEnd.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SlabPosWidthChangeEnd;

			result.Data.WidthChange.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.WidthChange;
			result.Data.WidthChange.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.WidthChange;
			result.Data.WidthChange.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.WidthChange;
			result.Data.WidthChange.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.WidthChange;

			result.Data.MinSlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.MinSlabWeight;
			result.Data.MinSlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.MinSlabWeight;
			result.Data.MinSlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.MinSlabWeight;
			result.Data.MinSlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.MinSlabWeight;

			result.Data.MaxSlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.MaxSlabWeight;
			result.Data.MaxSlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.MaxSlabWeight;
			result.Data.MaxSlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.MaxSlabWeight;
			result.Data.MaxSlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.MaxSlabWeight;

			result.Data.PlateProductionFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.PlateProduction;
			result.Data.PlateProductionFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.PlateProduction;
			result.Data.PlateProductionFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.PlateProduction;
			result.Data.PlateProductionFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.PlateProduction;

			result.Data.SimulationFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.SimMat;
			result.Data.SimulationFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.SimMat;
			result.Data.SimulationFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.SimMat;
			result.Data.SimulationFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.SimMat;

			result.Data.FMExitThicknessCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.HExitCustomer;
			result.Data.FMExitThicknessCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.HExitCustomer;
			result.Data.FMExitThicknessCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.HExitCustomer;
			result.Data.FMExitThicknessCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.HExitCustomer;

			result.Data.FMExitWidthCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.WidthExitCustomer;
			result.Data.FMExitWidthCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.WidthExitCustomer;
			result.Data.FMExitWidthCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.WidthExitCustomer;
			result.Data.FMExitWidthCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.WidthExitCustomer;

			result.Data.FlagBatchRolling.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.FlagBatchRolling;
			result.Data.FlagBatchRolling.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.FlagBatchRolling;
			result.Data.FlagBatchRolling.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.FlagBatchRolling;
			result.Data.FlagBatchRolling.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.FlagBatchRolling;

			result.Data.AlloyCompensation.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.AlloyCompensation;
			result.Data.AlloyCompensation.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.AlloyCompensation;
			result.Data.AlloyCompensation.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.AlloyCompensation;
			result.Data.AlloyCompensation.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.AlloyCompensation;

			result.Data.CastSpeed.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CastSpeed;
			result.Data.CastSpeed.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CastSpeed;
			result.Data.CastSpeed.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CastSpeed;
			result.Data.CastSpeed.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CastSpeed;

			result.Data.MinCastSpeed.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CastSpeedMin;
			result.Data.MinCastSpeed.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CastSpeedMin;
			result.Data.MinCastSpeed.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CastSpeedMin;
			result.Data.MinCastSpeed.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CastSpeedMin;

			result.Data.FMEntryThickness.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HIntermediate;
			result.Data.FMEntryThickness.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HIntermediate;
			result.Data.FMEntryThickness.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HIntermediate;
			result.Data.FMEntryThickness.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HIntermediate;

			result.Data.FMExitThickness.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HExit;
			result.Data.FMExitThickness.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HExit;
			result.Data.FMExitThickness.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HExit;
			result.Data.FMExitThickness.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HExit;

			result.Data.FMExitThicknessDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HClassMinDelta;
			result.Data.FMExitThicknessDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HClassMinDelta;
			result.Data.FMExitThicknessDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HClassMinDelta;
			result.Data.FMExitThicknessDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HClassMinDelta;

			result.Data.FMExitThicknessDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HClassMaxDelta;
			result.Data.FMExitThicknessDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HClassMaxDelta;
			result.Data.FMExitThicknessDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HClassMaxDelta;
			result.Data.FMExitThicknessDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HClassMaxDelta;

			result.Data.FMExitWidth.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WidthExit;
			result.Data.FMExitWidth.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WidthExit;
			result.Data.FMExitWidth.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WidthExit;
			result.Data.FMExitWidth.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WidthExit;

			result.Data.FMExitWidthDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WClassMinDelta;
			result.Data.FMExitWidthDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WClassMinDelta;
			result.Data.FMExitWidthDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WClassMinDelta;
			result.Data.FMExitWidthDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WClassMinDelta;

			result.Data.FMExitWidthDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.WClassMaxDelta;
			result.Data.FMExitWidthDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.WClassMaxDelta;
			result.Data.FMExitWidthDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.WClassMaxDelta;
			result.Data.FMExitWidthDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.WClassMaxDelta;

			result.Data.FMExitCrown.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ExitCrownC25;
			result.Data.FMExitCrown.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ExitCrownC25;
			result.Data.FMExitCrown.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ExitCrownC25;
			result.Data.FMExitCrown.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ExitCrownC25;

			result.Data.FMExitCrownDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMinCrownDelta;
			result.Data.FMExitCrownDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMinCrownDelta;
			result.Data.FMExitCrownDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMinCrownDelta;
			result.Data.FMExitCrownDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMinCrownDelta;

			result.Data.FMExitCrownDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxCrownDelta;
			result.Data.FMExitCrownDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxCrownDelta;
			result.Data.FMExitCrownDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxCrownDelta;
			result.Data.FMExitCrownDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxCrownDelta;

			result.Data.FMExitTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.TExit;
			result.Data.FMExitTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.TExit;
			result.Data.FMExitTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.TExit;
			result.Data.FMExitTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.TExit;

			result.Data.FMExitTempDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.TClassMinDelta;
			result.Data.FMExitTempDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.TClassMinDelta;
			result.Data.FMExitTempDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.TClassMinDelta;
			result.Data.FMExitTempDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.TClassMinDelta;

			result.Data.FMExitTempDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.TClassMaxDelta;
			result.Data.FMExitTempDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.TClassMaxDelta;
			result.Data.FMExitTempDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.TClassMaxDelta;
			result.Data.FMExitTempDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.TClassMaxDelta;

			result.Data.DestinationFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Destination;
			result.Data.DestinationFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Destination;
			result.Data.DestinationFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Destination;
			result.Data.DestinationFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Destination;

			result.Data.WedgeDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxFlatDeltaSym;
			result.Data.WedgeDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxFlatDeltaSym;
			result.Data.WedgeDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxFlatDeltaSym;
			result.Data.WedgeDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxFlatDeltaSym;

			result.Data.WedgeDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.ClassMaxFlatDeltaAsym;
			result.Data.WedgeDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.ClassMaxFlatDeltaAsym;
			result.Data.WedgeDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.ClassMaxFlatDeltaAsym;
			result.Data.WedgeDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.ClassMaxFlatDeltaAsym;

			result.Data.CoilerTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoilTemp;
			result.Data.CoilerTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoilTemp;
			result.Data.CoilerTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoilTemp;
			result.Data.CoilerTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoilTemp;

			result.Data.CoilerTempDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoilTempMinTol;
			result.Data.CoilerTempDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoilTempMinTol;
			result.Data.CoilerTempDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoilTempMinTol;
			result.Data.CoilerTempDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoilTempMinTol;

			result.Data.CoilerTempDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoilTempMaxTol;
			result.Data.CoilerTempDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoilTempMaxTol;
			result.Data.CoilerTempDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoilTempMaxTol;
			result.Data.CoilerTempDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoilTempMaxTol;

			result.Data.CoolingRateTop.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolRateTop;
			result.Data.CoolingRateTop.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolRateTop;
			result.Data.CoolingRateTop.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolRateTop;
			result.Data.CoolingRateTop.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolRateTop;

			result.Data.CoolingRateBottom.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolRateBot;
			result.Data.CoolingRateBottom.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolRateBot;
			result.Data.CoolingRateBottom.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolRateBot;
			result.Data.CoolingRateBottom.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolRateBot;

			result.Data.StartingValveTop.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.StartValveTop;
			result.Data.StartingValveTop.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.StartValveTop;
			result.Data.StartingValveTop.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.StartValveTop;
			result.Data.StartingValveTop.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.StartValveTop;

			result.Data.StartingValveBottom.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.StartValveBot;
			result.Data.StartingValveBottom.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.StartValveBot;
			result.Data.StartingValveBottom.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.StartValveBot;
			result.Data.StartingValveBottom.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.StartValveBot;

			result.Data.UncooledLengthHead.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.LengthUncooledHead;
			result.Data.UncooledLengthHead.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.LengthUncooledHead;
			result.Data.UncooledLengthHead.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.LengthUncooledHead;
			result.Data.UncooledLengthHead.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.LengthUncooledHead;

			result.Data.UncooledLengthTail.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.LengthUncooledTail;
			result.Data.UncooledLengthTail.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.LengthUncooledTail;
			result.Data.UncooledLengthTail.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.LengthUncooledTail;
			result.Data.UncooledLengthTail.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.LengthUncooledTail;

			result.Data.CoolingStrategyFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolStrategy;
			result.Data.CoolingStrategyFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolStrategy;
			result.Data.CoolingStrategyFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolStrategy;
			result.Data.CoolingStrategyFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolStrategy;

			result.Data.DualPhaseCoolingFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.FlagDualPhase;
			result.Data.DualPhaseCoolingFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.FlagDualPhase;
			result.Data.DualPhaseCoolingFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.FlagDualPhase;
			result.Data.DualPhaseCoolingFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.FlagDualPhase;

			result.Data.HoldTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HoldTemp;
			result.Data.HoldTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HoldTemp;
			result.Data.HoldTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HoldTemp;
			result.Data.HoldTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HoldTemp;

			result.Data.HoldTime.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.HoldTime;
			result.Data.HoldTime.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.HoldTime;
			result.Data.HoldTime.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.HoldTime;
			result.Data.HoldTime.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.HoldTime;

			result.Data.AmountBindings.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.AmountBindings;
			result.Data.AmountBindings.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.AmountBindings;
			result.Data.AmountBindings.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.AmountBindings;
			result.Data.AmountBindings.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.AmountBindings;

			result.Data.InspectionCode.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.InspectionCode;
			result.Data.InspectionCode.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.InspectionCode;
			result.Data.InspectionCode.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.InspectionCode;
			result.Data.InspectionCode.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.InspectionCode;

			result.Data.DilatometerCurve.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.DilatometerCurve;
			result.Data.DilatometerCurve.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.DilatometerCurve;
			result.Data.DilatometerCurve.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.DilatometerCurve;
			result.Data.DilatometerCurve.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.DilatometerCurve;

			result.Data.CoolingStrategyMode.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.CoolingStrategyModeSelection;
			result.Data.CoolingStrategyMode.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.CoolingStrategyModeSelection;
			result.Data.CoolingStrategyMode.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.CoolingStrategyModeSelection;
			result.Data.CoolingStrategyMode.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.CoolingStrategyModeSelection;

			result.Data.AlloyCode.L = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "L")?.AlloyCode;
			result.Data.AlloyCode.M = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "M")?.AlloyCode;
			result.Data.AlloyCode.S = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "S")?.AlloyCode;
			result.Data.AlloyCode.E = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "E")?.AlloyCode;

			return result;
		}

		public static PrimaryDataDto MapChemistryElements(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
		{
			// TODO: add mapping

			return result;
		}
	}
}
