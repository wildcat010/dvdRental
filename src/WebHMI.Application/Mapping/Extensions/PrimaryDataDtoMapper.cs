using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.PrimaryData;

namespace WebHMI.Mapping.Extensions
{
	internal static class PrimaryDataDtoMapper
	{
		public static PrimaryDataDto MapData(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
		{
			result.Data.SequenceId.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Sequenceid;
			result.Data.SequenceId.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Sequenceid;
			result.Data.SequenceId.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Sequenceid;
			result.Data.SequenceId.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Sequenceid;
            result.Data.SequenceId.DbSource = "EdPhyEnt.SequenceId";
            result.Data.SequenceId.Status = dataBlob.StatEdPhyEnts?.Sequenceid;

            result.Data.HeatId.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Heatid;
			result.Data.HeatId.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Heatid;
			result.Data.HeatId.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Heatid;
			result.Data.HeatId.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Heatid;
            result.Data.HeatId.DbSource = "EdPhyEnt.HeatId";
            result.Data.HeatId.Status = dataBlob.StatEdPhyEnts?.Heatid;

            result.Data.SlabThickness.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Aimslabthickness;
			result.Data.SlabThickness.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Aimslabthickness;
			result.Data.SlabThickness.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Aimslabthickness;
			result.Data.SlabThickness.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Aimslabthickness;
            result.Data.SlabThickness.DbSource = "EdPhyEnt.AimSlabThickness";
            result.Data.SlabThickness.Status = dataBlob.StatEdPhyEnts?.Aimslabthickness;

            result.Data.SlabWidth.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slabwidth;
			result.Data.SlabWidth.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slabwidth;
			result.Data.SlabWidth.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slabwidth;
			result.Data.SlabWidth.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slabwidth;
            result.Data.SlabWidth.DbSource = "EdPhyEnt.SlabWidth";
            result.Data.SlabWidth.Status = dataBlob.StatEdPhyEnts?.Slabwidth;

            result.Data.SlabLength.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slablength;
			result.Data.SlabLength.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slablength;
			result.Data.SlabLength.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slablength;
			result.Data.SlabLength.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slablength;
            result.Data.SlabLength.DbSource = "EdPhyEnt.SlabLength";
            result.Data.SlabLength.Status = dataBlob.StatEdPhyEnts?.Slablength;

            result.Data.SlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slabweight;
			result.Data.SlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slabweight;
			result.Data.SlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slabweight;
			result.Data.SlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slabweight;
            result.Data.SlabWeight.DbSource = "EdPhyEnt.SlabWeight";
            result.Data.SlabWeight.Status = dataBlob.StatEdPhyEnts?.Slabweight;

            result.Data.AlloyCodeCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Steelcustomer;
			result.Data.AlloyCodeCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Steelcustomer;
			result.Data.AlloyCodeCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Steelcustomer;
			result.Data.AlloyCodeCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Steelcustomer;
            result.Data.AlloyCodeCustomer.DbSource = "EdPhyEnt.SteelCustomer";
            result.Data.AlloyCodeCustomer.Status = dataBlob.StatEdPhyEnts?.Steelcustomer;

            result.Data.SlabWidthHead.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slabwidthhead;
			result.Data.SlabWidthHead.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slabwidthhead;
			result.Data.SlabWidthHead.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slabwidthhead;
			result.Data.SlabWidthHead.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slabwidthhead;
            result.Data.SlabWidthHead.DbSource = "EdPhyEnt.SlabWidthHead";
            result.Data.SlabWidthHead.Status = dataBlob.StatEdPhyEnts?.Slabwidthhead;

            result.Data.SlabWidthTail.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slabwidthtail;
			result.Data.SlabWidthTail.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slabwidthtail;
			result.Data.SlabWidthTail.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slabwidthtail;
			result.Data.SlabWidthTail.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slabwidthtail;
            result.Data.SlabWidthTail.DbSource = "EdPhyEnt.SlabWidthTail";
            result.Data.SlabWidthTail.Status = dataBlob.StatEdPhyEnts?.Slabwidthtail;

            result.Data.WidthChangeFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Widthchangeflag;
			result.Data.WidthChangeFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Widthchangeflag;
			result.Data.WidthChangeFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Widthchangeflag;
			result.Data.WidthChangeFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Widthchangeflag;
            result.Data.WidthChangeFlag.DbSource = "EdPhyEnt.WidthChangeFlag";
            result.Data.WidthChangeFlag.Status = dataBlob.StatEdPhyEnts?.Widthchangeflag;

            result.Data.WidthChangePosStart.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slabposwidthchangestart;
			result.Data.WidthChangePosStart.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slabposwidthchangestart;
			result.Data.WidthChangePosStart.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slabposwidthchangestart;
			result.Data.WidthChangePosStart.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slabposwidthchangestart;
            result.Data.WidthChangePosStart.DbSource = "EdPhyEnt.SlabPosWidthChangeStart";
            result.Data.WidthChangePosStart.Status = dataBlob.StatEdPhyEnts?.Slabposwidthchangestart;

            result.Data.WidthChangePosEnd.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Slabposwidthchangeend;
			result.Data.WidthChangePosEnd.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Slabposwidthchangeend;
			result.Data.WidthChangePosEnd.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Slabposwidthchangeend;
			result.Data.WidthChangePosEnd.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Slabposwidthchangeend;
            result.Data.WidthChangePosEnd.DbSource = "EdPhyEnt.SlabPosWidthChangeEnd";
            result.Data.WidthChangePosEnd.Status = dataBlob.StatEdPhyEnts?.Slabposwidthchangeend;

            result.Data.WidthChange.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Widthchange;
			result.Data.WidthChange.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Widthchange;
			result.Data.WidthChange.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Widthchange;
			result.Data.WidthChange.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Widthchange;
            result.Data.WidthChange.DbSource = "EdPhyEnt.WidthChange";
            result.Data.WidthChange.Status = dataBlob.StatEdPhyEnts?.Widthchange;

            result.Data.MinSlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Minslabweight;
			result.Data.MinSlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Minslabweight;
			result.Data.MinSlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Minslabweight;
			result.Data.MinSlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Minslabweight;
            result.Data.MinSlabWeight.DbSource = "EdPhyEnt.MinSlabWeight";
            result.Data.MinSlabWeight.Status = dataBlob.StatEdPhyEnts?.Minslabweight;

            result.Data.MaxSlabWeight.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Maxslabweight;
			result.Data.MaxSlabWeight.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Maxslabweight;
			result.Data.MaxSlabWeight.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Maxslabweight;
			result.Data.MaxSlabWeight.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Maxslabweight;
            result.Data.MaxSlabWeight.DbSource = "EdPhyEnt.MaxSlabWeight";
            result.Data.MaxSlabWeight.Status = dataBlob.StatEdPhyEnts?.Maxslabweight;

            result.Data.PlateProductionFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Plateproduction;
			result.Data.PlateProductionFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Plateproduction;
			result.Data.PlateProductionFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Plateproduction;
			result.Data.PlateProductionFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Plateproduction;
            result.Data.PlateProductionFlag.DbSource = "EdPhyEnt.PlateProduction";
            result.Data.PlateProductionFlag.Status = dataBlob.StatEdPhyEnts?.Plateproduction;

            result.Data.SimulationFlag.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Simmat;
			result.Data.SimulationFlag.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Simmat;
			result.Data.SimulationFlag.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Simmat;
			result.Data.SimulationFlag.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Simmat;
            result.Data.SimulationFlag.DbSource = "EdPhyEnt.SimMat";
            result.Data.SimulationFlag.Status = dataBlob.StatEdPhyEnts?.Simmat;

            result.Data.FMExitThicknessCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Hexitcustomer;
			result.Data.FMExitThicknessCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Hexitcustomer;
			result.Data.FMExitThicknessCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Hexitcustomer;
			result.Data.FMExitThicknessCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Hexitcustomer;
            result.Data.FMExitThicknessCustomer.DbSource = "EdPhyEnt.HExitCustomer";
            result.Data.FMExitThicknessCustomer.Status = dataBlob.StatEdPhyEnts?.Hexitcustomer;

            result.Data.FMExitWidthCustomer.L = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "L")?.Widthexitcustomer;
			result.Data.FMExitWidthCustomer.M = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "M")?.Widthexitcustomer;
			result.Data.FMExitWidthCustomer.S = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "S")?.Widthexitcustomer;
			result.Data.FMExitWidthCustomer.E = dataBlob.EdPhyEnts.FirstOrDefault(x => x.Source == "E")?.Widthexitcustomer;
            result.Data.FMExitWidthCustomer.DbSource = "EdPhyEnt.WidthExitCustomer";
            result.Data.FMExitWidthCustomer.Status = dataBlob.StatEdPhyEnts?.Widthexitcustomer;

            result.Data.OrderNo.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Orderno;
            result.Data.OrderNo.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Orderno;
            result.Data.OrderNo.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Orderno;
            result.Data.OrderNo.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Orderno;
            result.Data.OrderNo.DbSource = "EdOrdEnt.OrderNo";
            result.Data.OrderNo.Status = dataBlob.StatEdOrdEnts?.Orderno;

            result.Data.FlagBatchRolling.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Flagbatchrolling;
			result.Data.FlagBatchRolling.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Flagbatchrolling;
			result.Data.FlagBatchRolling.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Flagbatchrolling;
			result.Data.FlagBatchRolling.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Flagbatchrolling;
            result.Data.FlagBatchRolling.DbSource = "EdOrdEnt.FlagBatchRolling";
            result.Data.FlagBatchRolling.Status = dataBlob.StatEdOrdEnts?.Flagbatchrolling;

            result.Data.AlloyCompensation.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Alloycompensation;
			result.Data.AlloyCompensation.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Alloycompensation;
			result.Data.AlloyCompensation.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Alloycompensation;
			result.Data.AlloyCompensation.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Alloycompensation;
            result.Data.AlloyCompensation.DbSource = "EdOrdEnt.AlloyCompensation";
            result.Data.AlloyCompensation.Status = dataBlob.StatEdOrdEnts?.Alloycompensation;

            result.Data.CastSpeed.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Castspeed;
			result.Data.CastSpeed.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Castspeed;
			result.Data.CastSpeed.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Castspeed;
			result.Data.CastSpeed.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Castspeed;
            result.Data.CastSpeed.DbSource = "EdOrdEnt.CastSpeed";
            result.Data.CastSpeed.Status = dataBlob.StatEdOrdEnts?.Castspeed;

            result.Data.MinCastSpeed.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Castspeedmin;
			result.Data.MinCastSpeed.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Castspeedmin;
			result.Data.MinCastSpeed.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Castspeedmin;
			result.Data.MinCastSpeed.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Castspeedmin;
            result.Data.MinCastSpeed.DbSource = "EdOrdEnt.CastSpeedMin";
            result.Data.MinCastSpeed.Status = dataBlob.StatEdOrdEnts?.Castspeedmin;

            result.Data.FMEntryThickness.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Hintermediate;
			result.Data.FMEntryThickness.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Hintermediate;
			result.Data.FMEntryThickness.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Hintermediate;
			result.Data.FMEntryThickness.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Hintermediate;
            result.Data.FMEntryThickness.DbSource = "EdOrdEnt.HIntermediate";
            result.Data.FMEntryThickness.Status = dataBlob.StatEdOrdEnts?.Hintermediate;

            result.Data.FMExitThickness.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Hexit;
			result.Data.FMExitThickness.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Hexit;
			result.Data.FMExitThickness.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Hexit;
			result.Data.FMExitThickness.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Hexit;
            result.Data.FMExitThickness.DbSource = "EdOrdEnt.HExit";
            result.Data.FMExitThickness.Status = dataBlob.StatEdOrdEnts?.Hexit;

            result.Data.FMExitThicknessDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Hclassmindelta;
			result.Data.FMExitThicknessDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Hclassmindelta;
			result.Data.FMExitThicknessDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Hclassmindelta;
			result.Data.FMExitThicknessDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Hclassmindelta;
            result.Data.FMExitThicknessDeltaMin.DbSource = "EdOrdEnt.HClassMinDelta";
            result.Data.FMExitThicknessDeltaMin.Status = dataBlob.StatEdOrdEnts?.Hclassmindelta;

            result.Data.FMExitThicknessDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Hclassmaxdelta;
			result.Data.FMExitThicknessDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Hclassmaxdelta;
			result.Data.FMExitThicknessDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Hclassmaxdelta;
			result.Data.FMExitThicknessDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Hclassmaxdelta;
            result.Data.FMExitThicknessDeltaMax.DbSource = "EdOrdEnt.HClassMaxDelta";
            result.Data.FMExitThicknessDeltaMax.Status = dataBlob.StatEdOrdEnts?.Hclassmaxdelta;

            result.Data.FMExitWidth.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Widthexit;
			result.Data.FMExitWidth.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Widthexit;
			result.Data.FMExitWidth.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Widthexit;
			result.Data.FMExitWidth.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Widthexit;
            result.Data.FMExitWidth.DbSource = "EdOrdEnt.WidthExit";
            result.Data.FMExitWidth.Status = dataBlob.StatEdOrdEnts?.Widthexit;

            result.Data.FMExitWidthDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Wclassmindelta;
			result.Data.FMExitWidthDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Wclassmindelta;
			result.Data.FMExitWidthDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Wclassmindelta;
			result.Data.FMExitWidthDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Wclassmindelta;
            result.Data.FMExitWidthDeltaMin.DbSource = "EdOrdEnt.WClassMinDelta";
            result.Data.FMExitWidthDeltaMin.Status = dataBlob.StatEdOrdEnts?.Wclassmindelta;

            result.Data.FMExitWidthDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Wclassmaxdelta;
			result.Data.FMExitWidthDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Wclassmaxdelta;
			result.Data.FMExitWidthDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Wclassmaxdelta;
			result.Data.FMExitWidthDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Wclassmaxdelta;
            result.Data.FMExitWidthDeltaMax.DbSource = "EdOrdEnt.WClassMaxDelta";
            result.Data.FMExitWidthDeltaMax.Status = dataBlob.StatEdOrdEnts?.Wclassmaxdelta;

            result.Data.FMExitCrown.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Exitcrownc25;
			result.Data.FMExitCrown.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Exitcrownc25;
			result.Data.FMExitCrown.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Exitcrownc25;
			result.Data.FMExitCrown.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Exitcrownc25;
            result.Data.FMExitCrown.DbSource = "EdOrdEnt.ExitCrownC25";
            result.Data.FMExitCrown.Status = dataBlob.StatEdOrdEnts?.Exitcrownc25;

            result.Data.FMExitCrownDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Classmincrowndelta;
			result.Data.FMExitCrownDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Classmincrowndelta;
			result.Data.FMExitCrownDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Classmincrowndelta;
			result.Data.FMExitCrownDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Classmincrowndelta;
            result.Data.FMExitCrownDeltaMin.DbSource = "EdOrdEnt.ClassMinCrownDelta";
            result.Data.FMExitCrownDeltaMin.Status = dataBlob.StatEdOrdEnts?.Classmincrowndelta;

            result.Data.FMExitCrownDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Classmaxcrowndelta;
			result.Data.FMExitCrownDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Classmaxcrowndelta;
			result.Data.FMExitCrownDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Classmaxcrowndelta;
			result.Data.FMExitCrownDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Classmaxcrowndelta;
            result.Data.FMExitCrownDeltaMax.DbSource = "EdOrdEnt.ClassMaxCrownDelta";
            result.Data.FMExitCrownDeltaMax.Status = dataBlob.StatEdOrdEnts?.Classmaxcrowndelta;

            result.Data.FMExitTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Texit;
			result.Data.FMExitTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Texit;
			result.Data.FMExitTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Texit;
			result.Data.FMExitTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Texit;
            result.Data.FMExitTemp.DbSource = "EdOrdEnt.TExit";
            result.Data.FMExitTemp.Status = dataBlob.StatEdOrdEnts?.Texit;

            result.Data.FMExitTempDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Tclassmindelta;
			result.Data.FMExitTempDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Tclassmindelta;
			result.Data.FMExitTempDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Tclassmindelta;
			result.Data.FMExitTempDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Tclassmindelta;
            result.Data.FMExitTempDeltaMin.DbSource = "EdOrdEnt.TClassMinDelta";
            result.Data.FMExitTempDeltaMin.Status = dataBlob.StatEdOrdEnts?.Tclassmindelta;

            result.Data.FMExitTempDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Tclassmaxdelta;
			result.Data.FMExitTempDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Tclassmaxdelta;
			result.Data.FMExitTempDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Tclassmaxdelta;
			result.Data.FMExitTempDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Tclassmaxdelta;
            result.Data.FMExitTempDeltaMax.DbSource = "EdOrdEnt.TClassMaxDelta";
            result.Data.FMExitTempDeltaMax.Status = dataBlob.StatEdOrdEnts?.Tclassmaxdelta;

            result.Data.DestinationFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Destination;
			result.Data.DestinationFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Destination;
			result.Data.DestinationFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Destination;
			result.Data.DestinationFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Destination;
            result.Data.DestinationFlag.DbSource = "EdOrdEnt.Destination";
            result.Data.DestinationFlag.Status = dataBlob.StatEdOrdEnts?.Destination;

            result.Data.ClassWedgeDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Classminwedgedelta;
			result.Data.ClassWedgeDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Classminwedgedelta;
			result.Data.ClassWedgeDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Classminwedgedelta;
			result.Data.ClassWedgeDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Classminwedgedelta;
            result.Data.ClassWedgeDeltaMin.DbSource = "EdOrdEnt.ClassMinWedgeDelta";
            result.Data.ClassWedgeDeltaMin.Status = dataBlob.StatEdOrdEnts?.Classminwedgedelta;

            result.Data.ClassWedgeDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Classmaxwedgedelta;
            result.Data.ClassWedgeDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Classmaxwedgedelta;
            result.Data.ClassWedgeDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Classmaxwedgedelta;
            result.Data.ClassWedgeDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Classmaxwedgedelta;
            result.Data.ClassWedgeDeltaMax.DbSource = "EdOrdEnt.ClassMaxWedgeDelta";
            result.Data.ClassWedgeDeltaMax.Status = dataBlob.StatEdOrdEnts?.Classmaxwedgedelta;

            result.Data.ClassFlatDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Classmaxflatdeltasym;
            result.Data.ClassFlatDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Classmaxflatdeltasym;
            result.Data.ClassFlatDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Classmaxflatdeltasym;
            result.Data.ClassFlatDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Classmaxflatdeltasym;
            result.Data.ClassFlatDeltaMin.DbSource = "EdOrdEnt.ClassMaxFlatDeltaSym";
            result.Data.ClassFlatDeltaMin.Status = dataBlob.StatEdOrdEnts?.Classmaxflatdeltasym;

            result.Data.ClassFlatDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Classmaxflatdeltaasym;
            result.Data.ClassFlatDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Classmaxflatdeltaasym;
            result.Data.ClassFlatDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Classmaxflatdeltaasym;
            result.Data.ClassFlatDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Classmaxflatdeltaasym;
            result.Data.ClassFlatDeltaMax.DbSource = "EdOrdEnt.ClassMaxFlatDeltaAsym";
            result.Data.ClassFlatDeltaMax.Status = dataBlob.StatEdOrdEnts?.Classmaxflatdeltaasym;

            result.Data.CoilerTemp.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coiltemp;
            result.Data.CoilerTemp.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coiltemp;
            result.Data.CoilerTemp.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coiltemp;
            result.Data.CoilerTemp.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coiltemp;
            result.Data.CoilerTemp.DbSource = "EdOrdEnt.CoilTemp";

            result.Data.CoilerTempDeltaMin.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coiltempmintol;
            result.Data.CoilerTempDeltaMin.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coiltempmintol;
            result.Data.CoilerTempDeltaMin.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coiltempmintol;
            result.Data.CoilerTempDeltaMin.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coiltempmintol;
            result.Data.CoilerTempDeltaMin.DbSource = "EdOrdEnt.CoilTempMinTol";

            result.Data.CoilerTempDeltaMax.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coiltempmaxtol;
            result.Data.CoilerTempDeltaMax.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coiltempmaxtol;
            result.Data.CoilerTempDeltaMax.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coiltempmaxtol;
            result.Data.CoilerTempDeltaMax.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coiltempmaxtol;
            result.Data.CoilerTempDeltaMax.DbSource = "EdOrdEnt.CoilTempMaxTol";

            result.Data.CoolingRateTop.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coolratetop;
            result.Data.CoolingRateTop.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coolratetop;
            result.Data.CoolingRateTop.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coolratetop;
            result.Data.CoolingRateTop.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coolratetop;
            result.Data.CoolingRateTop.DbSource = "EdOrdEnt.CoolRateTop";

            result.Data.CoolingRateBottom.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coolratebot;
            result.Data.CoolingRateBottom.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coolratebot;
            result.Data.CoolingRateBottom.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coolratebot;
            result.Data.CoolingRateBottom.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coolratebot;
            result.Data.CoolingRateBottom.DbSource = "EdOrdEnt.CoolRateBot";

            result.Data.CoolingStrategyFlag.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coolstrategy;
            result.Data.CoolingStrategyFlag.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coolstrategy;
            result.Data.CoolingStrategyFlag.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coolstrategy;
            result.Data.CoolingStrategyFlag.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coolstrategy;
            result.Data.CoolingStrategyFlag.DbSource = "EdOrdEnt.CoolStrategy";

            result.Data.CoolingStrategyMode.L = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "L")?.Coolingstrategymodeselection;
            result.Data.CoolingStrategyMode.M = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "M")?.Coolingstrategymodeselection;
            result.Data.CoolingStrategyMode.S = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "S")?.Coolingstrategymodeselection;
            result.Data.CoolingStrategyMode.E = dataBlob.EdOrdEnts.FirstOrDefault(x => x.Source == "E")?.Coolingstrategymodeselection;
            result.Data.CoolingStrategyMode.DbSource = "EdOrdEnt.CoolingStrategyModeSelection";

            result.Data.AlloyCode.L = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "L")?.Alloycode;
			result.Data.AlloyCode.M = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "M")?.Alloycode;
			result.Data.AlloyCode.S = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "S")?.Alloycode;
			result.Data.AlloyCode.E = dataBlob.EdLogEnts.FirstOrDefault(x => x.Source == "E")?.Alloycode;
            result.Data.AlloyCode.DbSource = "EdLogEnt.AlloyCode";
            result.Data.AlloyCode.Status = dataBlob.StatEdLogEnts?.Alloycode;

            return result;
		}

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

            result.CSData.CoilTemp.L = edOrdEntL?.Coiltemp;
            result.CSData.CoilTemp.M = edOrdEntM?.Coiltemp;
            result.CSData.CoilTemp.S = edOrdEntS?.Coiltemp;
            result.CSData.CoilTemp.E = edOrdEntE?.Coiltemp;
            result.CSData.CoilTemp.DbSource = "EdOrdEnt.CoilTemp";
            result.CSData.CoilTemp.Status = dataBlob.StatEdOrdEnts?.Coiltemp;

            result.CSData.CoilTempMax.L = edOrdEntL?.Coiltempmaxtol;
            result.CSData.CoilTempMax.M = edOrdEntM?.Coiltempmaxtol;
            result.CSData.CoilTempMax.S = edOrdEntS?.Coiltempmaxtol;
            result.CSData.CoilTempMax.E = edOrdEntE?.Coiltempmaxtol;
            result.CSData.CoilTempMax.DbSource = "EdOrdEnt.CoilTempMaxTol";
            result.CSData.CoilTempMax.Status = dataBlob.StatEdOrdEnts?.Coiltempmaxtol;

            result.CSData.CoilTempMin.L = edOrdEntL?.Coiltempmintol;
            result.CSData.CoilTempMin.M = edOrdEntM?.Coiltempmintol;
            result.CSData.CoilTempMin.S = edOrdEntS?.Coiltempmintol;
            result.CSData.CoilTempMin.E = edOrdEntE?.Coiltempmintol;
            result.CSData.CoilTempMin.DbSource = "EdOrdEnt.CoilTempMinTol";
            result.CSData.CoilTempMin.Status = dataBlob.StatEdOrdEnts?.Coiltempmintol;

            result.CSData.CoolMode.L = edOrdEntL?.Coolstrategy;
            result.CSData.CoolMode.M = edOrdEntM?.Coolstrategy;
            result.CSData.CoolMode.S = edOrdEntS?.Coolstrategy;
            result.CSData.CoolMode.E = edOrdEntE?.Coolstrategy;
            result.CSData.CoolMode.DbSource = "EdOrdEnt.CoolStrategy";
            result.CSData.CoolMode.Status = dataBlob.StatEdOrdEnts?.Coolstrategy;

            result.CSData.CoolModeSource.L = edOrdEntL?.Coolingstrategymodeselection;
            result.CSData.CoolModeSource.M = edOrdEntM?.Coolingstrategymodeselection;
            result.CSData.CoolModeSource.S = edOrdEntS?.Coolingstrategymodeselection;
            result.CSData.CoolModeSource.E = edOrdEntE?.Coolingstrategymodeselection;
            result.CSData.CoolModeSource.DbSource = "EdOrdEnt.CoolingStrategyModeSelection";
            result.CSData.CoolModeSource.Status = dataBlob.StatEdOrdEnts?.Coolingstrategymodeselection;

            return result;
        }
		public static PrimaryDataDto MapChemistryElements(this PrimaryDataDto result, PrimaryDataDataBlob dataBlob)
		{
			foreach (var edlogent in dataBlob.EdLogEnts)
			{
				var nameProperties = edlogent.GetType()
					.GetProperties()
					.Where(prop => prop.Name.StartsWith("AlloynameInd", StringComparison.OrdinalIgnoreCase))
					.Select(prop => new { Number = prop.Name["AlloynameInd".Length..], ElementName = prop.GetValue(edlogent)?.ToString() });

				var valueProperties = edlogent.GetType()
					.GetProperties()
					.Where(prop => prop.Name.StartsWith("AlloyvalueInd", StringComparison.OrdinalIgnoreCase))
					.Select(prop => new { Number = prop.Name["AlloyvalueInd".Length..], ElementValue = (double?)prop.GetValue(edlogent) });

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
