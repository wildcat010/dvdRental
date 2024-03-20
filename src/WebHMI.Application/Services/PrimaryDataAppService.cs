using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.DataBlobs;
using WebHMI.Dtos;
using WebHMI.Dtos.PrimaryData;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
	public class PrimaryDataAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private readonly MatStructEntryService _matStructEntryService;

		private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

		public PrimaryDataAppService(
			IDbContextProvider<PrdbContext> prdbContextProvider,
			MatStructEntryService matStructEntryService)
		{
			_prdbContextProvider = prdbContextProvider;
			_matStructEntryService = matStructEntryService;
		}

		public async Task<PrimaryDataDto> GetPrimaryDataById(int meid, string matType)
		{
			var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

			var result = new PrimaryDataDto();
			var dataBlob = await GetDataBlob(entryMatStruct);

			result.MeCode = entryMatStruct.ToMeCodeDto();
			result.MapData(dataBlob);
			result.MapChemistryElements(dataBlob);

			return result;
		}

		public async Task UpdateAsync(PrimaryDataDto input)
		{
			var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, input.MeCode.MatType);

			var edphyentM = await _prdbContext.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnPhMeId && x.Source == "M");

			// TODO: add extension InsertIfNullAsync
			//edphyent = await _edphyentRepository.InsertIfNullAsync(edphyent, hmiVEntryMatStruct);

			if (edphyentM is null)
			{
				edphyentM = new EdPhyEnt
				{
					MeId = entryMatStruct.EnPhMeId,
					MesId = entryMatStruct.EnPhMesId ?? 1,
					MeCreator = entryMatStruct.EnPhCreator,
					Source = "M",
				};

				_prdbContext.EdPhyEnts.Add(edphyentM);
			}

			edphyentM.SequenceId = input.Data.SequenceId.M;
			edphyentM.HeatId = input.Data.HeatId.M;
			edphyentM.AimSlabThickness = input.Data.SlabThickness.M;
			edphyentM.SlabWidth = input.Data.SlabWidth.M;
			edphyentM.SlabLength = input.Data.SlabLength.M;
			edphyentM.SlabWeight = input.Data.SlabWeight.M;
			edphyentM.SteelCustomer = input.Data.AlloyCodeCustomer.M;
			edphyentM.SlabWidthHead = input.Data.SlabWidthHead.M;
			edphyentM.SlabWidthTail = input.Data.SlabWidthTail.M;
			edphyentM.WidthChangeFlag = input.Data.WidthChangeFlag.M;
			edphyentM.SlabPosWidthChangeStart = input.Data.WidthChangePosStart.M;
			edphyentM.SlabPosWidthChangeEnd = input.Data.WidthChangePosEnd.M;
			edphyentM.WidthChange = input.Data.WidthChange.M;
			edphyentM.MinSlabWeight = input.Data.MinSlabWeight.M;
			edphyentM.MaxSlabWeight = input.Data.MaxSlabWeight.M;
			edphyentM.PlateProduction = input.Data.PlateProductionFlag.M;
			edphyentM.SimMat = input.Data.SimulationFlag.M;
			edphyentM.HExitCustomer = input.Data.FMExitThicknessCustomer.M;
			edphyentM.WidthExitCustomer = input.Data.FMExitWidthCustomer.M;

			var edordentM = await _prdbContext.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnOrMeId && x.Source == "M");

			// TODO: add extension InsertIfNullAsync
			if (edordentM is null)
			{
				edordentM = new EdOrdEnt
				{
					MeId = entryMatStruct.EnOrMeId,
					MesId = entryMatStruct.EnOrMesId ?? 1,
					MeCreator = entryMatStruct.EnOrCreator,
					Source = "M",
				};

				_prdbContext.EdOrdEnts.Add(edordentM);
			}

			edordentM.FlagBatchRolling = input.Data.FlagBatchRolling.M;
			edordentM.AlloyCompensation = input.Data.AlloyCompensation.M;
			edordentM.CastSpeed = input.Data.CastSpeed.M;
			edordentM.CastSpeedMin = input.Data.MinCastSpeed.M;
			edordentM.HIntermediate = input.Data.FMEntryThickness.M;
			edordentM.HExit = input.Data.FMExitThickness.M;
			edordentM.HClassMinDelta = input.Data.FMExitThicknessDeltaMin.M;
			edordentM.HClassMaxDelta = input.Data.FMExitThicknessDeltaMax.M;
			edordentM.WidthExit = input.Data.FMExitWidth.M;
			edordentM.WClassMinDelta = input.Data.FMExitWidthDeltaMin.M;
			edordentM.WClassMaxDelta = input.Data.FMExitWidthDeltaMax.M;
			edordentM.ExitCrownC25 = input.Data.FMExitCrown.M;
			edordentM.ClassMinCrownDelta = input.Data.FMExitCrownDeltaMin.M;
			edordentM.ClassMaxCrownDelta = input.Data.FMExitCrownDeltaMax.M;
			edordentM.TExit = input.Data.FMExitTemp.M;
			edordentM.TClassMinDelta = input.Data.FMExitTempDeltaMin.M;
			edordentM.TClassMaxDelta = input.Data.FMExitTempDeltaMax.M;
			edordentM.Destination = input.Data.DestinationFlag.M;
			edordentM.ClassMaxFlatDeltaSym = input.Data.WedgeDeltaMin.M;
			edordentM.ClassMaxFlatDeltaAsym = input.Data.WedgeDeltaMax.M;
			edordentM.CoilTemp = input.Data.CoilerTemp.M;
			edordentM.CoilTempMinTol = input.Data.CoilerTempDeltaMin.M;
			edordentM.CoilTempMaxTol = input.Data.CoilerTempDeltaMax.M;
			edordentM.CoolRateTop = input.Data.CoolingRateTop.M;
			edordentM.CoolRateBot = input.Data.CoolingRateBottom.M;
			edordentM.StartValveTop = input.Data.StartingValveTop.M;
			edordentM.StartValveBot = input.Data.StartingValveBottom.M;
			edordentM.LengthUncooledHead = input.Data.UncooledLengthHead.M;
			edordentM.LengthUncooledTail = input.Data.UncooledLengthTail.M;
			edordentM.CoolStrategy = input.Data.CoolingStrategyFlag.M;
			edordentM.FlagDualPhase = input.Data.DualPhaseCoolingFlag.M;
			edordentM.HoldTemp = input.Data.HoldTemp.M;
			edordentM.HoldTime = input.Data.HoldTime.M;
			edordentM.AmountBindings = input.Data.AmountBindings.M;
			edordentM.InspectionCode = input.Data.InspectionCode.M;
			edordentM.DilatometerCurve = input.Data.DilatometerCurve.M;
			edordentM.CoolingStrategyModeSelection = input.Data.CoolingStrategyMode.M;

			var edlogentM = await _prdbContext.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnLoMeId && x.Source == "M");

			// TODO: add extension InsertIfNullAsync
			if (edlogentM is null)
			{
				edlogentM = new EdLogEnt
				{
					MeId = entryMatStruct.EnLoMeId,
					MesId = entryMatStruct.EnLoMesid ?? 1,
					MeCreator = entryMatStruct.EnLoCreator,
					Source = "M"
				};

				_prdbContext.EdLogEnts.Add(edlogentM);
			}

			edlogentM.AlloyCode = input.Data.AlloyCode.M;
			// TODO: update chemistry

			// TODO: override SaveChangesAsync and insert left ed records
		}

		private async Task<PrimaryDataDataBlob> GetDataBlob(VMatStructEntry entryMatStruct)
		{
			string[] sources = ["L", "M", "S", "E"];

			return new PrimaryDataDataBlob
			{
				EdPhyEnts = await _prdbContext.EdPhyEnts.Where(x => x.MeId == entryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
				EdOrdEnts = await _prdbContext.EdOrdEnts.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
				EdLogEnts = await _prdbContext.EdLogEnts.Where(x => x.MeId == entryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
			};
		}
	}
}
