using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.DataBlobs;
using WebHMI.Dtos;
using WebHMI.Dtos.PrimaryData;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.Services
{
	public class PrimaryDataAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private readonly MatStructEntryService _matStructEntryService;
		private readonly IL2CommunicationHandler _l2CommunicationHandler;

        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

		public PrimaryDataAppService(
			IDbContextProvider<PrdbContext> prdbContextProvider,
			MatStructEntryService matStructEntryService,
            IL2CommunicationHandler l2CommunicationHandler)
		{
			_prdbContextProvider = prdbContextProvider;
			_matStructEntryService = matStructEntryService;
            _l2CommunicationHandler = l2CommunicationHandler;
		}

		public async Task<PrimaryDataDto> GetPrimaryDataById(int meid, string matType)
		{
			var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

			var result = new PrimaryDataDto();
			var dataBlob = await GetDataBlob(entryMatStruct);

			result.OrMeCode = entryMatStruct.ToOrMeCodeDto();
            result.PhMeCode = entryMatStruct.ToPhyMeCodeDto();
			result.MapData(dataBlob);
			result.MapChemistryElements(dataBlob);
			result.MapCSData(dataBlob);

            return result;
		}

        [Audited]
        public async Task UpdateAsync(PrimaryDataDto input, string connectionid)
		{
			var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(input.OrMeCode.MeId, input.OrMeCode.MatType);

			var edphyentM = await _prdbContext.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnPhMeId && x.Source == "M");
            edphyentM = _prdbContext.InsertIfNull(edphyentM, entryMatStruct);
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
            edphyentM.SequenceId = input.Data.SequenceId.M;

            var edordentM = await _prdbContext.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnOrMeId && x.Source == "M");
            edordentM = _prdbContext.InsertIfNull(edordentM, entryMatStruct);
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
            edordentM.ClassMaxFlatDeltaSym = input.Data.ClassFlatDeltaMin.M;
            edordentM.ClassMaxFlatDeltaAsym = input.Data.ClassFlatDeltaMax.M;
            edordentM.ClassMaxWedgeDelta = input.Data.ClassWedgeDeltaMax.M;
            edordentM.ClassMinWedgeDelta = input.Data.ClassWedgeDeltaMin.M;
            edordentM.OrderNo = input.Data.OrderNo.M;

            //CSSection

            edordentM.CoilTemp = input.CSData.CoilTemp.M;
            edordentM.CoilTempMaxTol = input.CSData.CoilTempMax.M;
			edordentM.CoilTempMinTol = input.CSData.CoilTempMin.M;
            edordentM.CoolStrategy = input.CSData.CoolMode.M;
            edordentM.CoolingStrategyModeSelection = input.CSData.CoolModeSource.M;

            var edlogentM = await _prdbContext.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnLoMeId && x.Source == "M");
            edlogentM = _prdbContext.InsertIfNull(edlogentM, entryMatStruct);
            edlogentM.AlloyCode = input.Data.AlloyCode.M;
            await UpdateChemistry(input, edlogentM, entryMatStruct);

            await _prdbContext.SaveChangesAsync();

            _l2CommunicationHandler.EntryDataChange(entryMatStruct,connectionid);
        }

       private async Task UpdateChemistry(PrimaryDataDto input, EdLogEnt edlogentManual, VMatStructEntry entryMatStruct)
		{
			var edlogentE = await _prdbContext.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnLoMeId && x.Source == "E");

			if (edlogentE is null)
				throw new EntityNotFoundException("Chemistry entity original record not found");

			var properties = edlogentE.GetType().GetProperties().Where(prop => prop.Name.StartsWith("AlloyNameInd", StringComparison.OrdinalIgnoreCase));
			foreach (var prop in properties)
			{
				var manualProp = edlogentManual.GetType().GetProperty(prop.Name);
				if (manualProp is null)
					continue;

				var value = prop.GetValue(edlogentE);
				manualProp.SetValue(edlogentManual, value);
			}

			foreach (var chemistryElement in input.ChemistryElements)
			{
				var namePropertyInfo = edlogentManual.GetType()
					.GetProperties()
					.FirstOrDefault(prop => prop.Name.StartsWith("AlloyNameInd", StringComparison.OrdinalIgnoreCase) &&
									prop.GetValue(edlogentManual)?.ToString() == chemistryElement.Name);

				var valuePropertyInfo = edlogentManual.GetType()
					.GetProperties()
					.FirstOrDefault(prop => prop.Name.Equals($"AlloyValueInd{namePropertyInfo.Name["AlloyNameInd".Length..]}", StringComparison.OrdinalIgnoreCase));

				if (namePropertyInfo is null || valuePropertyInfo is null)
					throw new UserFriendlyException($"Chemistry element '{chemistryElement.Name}' not found");

				var sourceValueProperty = chemistryElement.Value.GetType().GetProperty(edlogentManual.Source);

				var sentValue = (float?)sourceValueProperty.GetValue(chemistryElement.Value);
				valuePropertyInfo.SetValue(edlogentManual, sentValue);
			}
		}

        public async Task CopyMaterial(int meid, string matType, string newExtId, short isTestMat)
        {
            var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            if (entryMatStruct is null ) throw new UserFriendlyException("Material not found.");

            _l2CommunicationHandler.PrimdCopyHMI(entryMatStruct, newExtId, isTestMat);

        }

        public async Task<List<string>> GetAllSteelGrades()
        {
            var context =await _prdbContextProvider.GetDbContextAsync();
            return await context.MatDats.Select(x=>x.AlloyCode).ToListAsync();
        }

		private async Task<PrimaryDataDataBlob> GetDataBlob(VMatStructEntry entryMatStruct)
		{
			string[] sources = ["L", "M", "S", "E"];

			return new PrimaryDataDataBlob
			{
				EdPhyEnts = await _prdbContext.EdPhyEnts.Where(x => x.MeId == entryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
				EdOrdEnts = await _prdbContext.EdOrdEnts.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
				EdLogEnts = await _prdbContext.EdLogEnts.Where(x => x.MeId == entryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),

                StatEdPhyEnts = await _prdbContext.StatEdPhyEnts.Where(x => x.MeId == entryMatStruct.EnPhMeId && x.Source=="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdOrdEnts = await _prdbContext.StatEdOrdEnts.Where(x => x.MeId == entryMatStruct.EnOrMeId && x.Source=="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdLogEnts = await _prdbContext.StatEdLogEnts.Where(x => x.MeId == entryMatStruct.EnLoMeId && x.Source=="E").AsNoTracking().FirstOrDefaultAsync(),
            };
		}
	}
}
