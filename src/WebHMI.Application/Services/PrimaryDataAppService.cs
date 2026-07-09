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

			var edphyentM = await _prdbContext.Edphyents.FirstOrDefaultAsync(x => x.Meid == entryMatStruct.Enphmeid && x.Source == "M");
            edphyentM = _prdbContext.InsertIfNull(edphyentM, entryMatStruct);
            edphyentM.Sequenceid = input.Data.SequenceId.M;
			edphyentM.Heatid = input.Data.HeatId.M;
			edphyentM.Aimslabthickness = input.Data.SlabThickness.M;
			edphyentM.Slabwidth = input.Data.SlabWidth.M;
			edphyentM.Slablength = input.Data.SlabLength.M;
			edphyentM.Slabweight = input.Data.SlabWeight.M;
			edphyentM.Steelcustomer = input.Data.AlloyCodeCustomer.M;
			edphyentM.Slabwidthhead = input.Data.SlabWidthHead.M;
			edphyentM.Slabwidthtail = input.Data.SlabWidthTail.M;
			edphyentM.Widthchangeflag = input.Data.WidthChangeFlag.M;
			edphyentM.Slabposwidthchangestart = input.Data.WidthChangePosStart.M;
			edphyentM.Slabposwidthchangeend = input.Data.WidthChangePosEnd.M;
			edphyentM.Widthchange = input.Data.WidthChange.M;
			edphyentM.Minslabweight = input.Data.MinSlabWeight.M;
			edphyentM.Maxslabweight = input.Data.MaxSlabWeight.M;
			edphyentM.Plateproduction = input.Data.PlateProductionFlag.M;
			edphyentM.Simmat = input.Data.SimulationFlag.M;
			edphyentM.Hexitcustomer = input.Data.FMExitThicknessCustomer.M;
			edphyentM.Widthexitcustomer = input.Data.FMExitWidthCustomer.M;
            edphyentM.Sequenceid = input.Data.SequenceId.M;

            var edordentM = await _prdbContext.Edordents.FirstOrDefaultAsync(x => x.Meid == entryMatStruct.Enormeid && x.Source == "M");
            edordentM = _prdbContext.InsertIfNull(edordentM, entryMatStruct);
            edordentM.Flagbatchrolling = input.Data.FlagBatchRolling.M;
            edordentM.Alloycompensation = input.Data.AlloyCompensation.M;
            edordentM.Castspeed = input.Data.CastSpeed.M;
            edordentM.Castspeedmin = input.Data.MinCastSpeed.M;
            edordentM.Hintermediate = input.Data.FMEntryThickness.M;
            edordentM.Hexit = input.Data.FMExitThickness.M;
            edordentM.Hclassmindelta = input.Data.FMExitThicknessDeltaMin.M;
            edordentM.Hclassmaxdelta = input.Data.FMExitThicknessDeltaMax.M;
            edordentM.Widthexit = input.Data.FMExitWidth.M;
            edordentM.Wclassmindelta = input.Data.FMExitWidthDeltaMin.M;
            edordentM.Wclassmaxdelta = input.Data.FMExitWidthDeltaMax.M;
            edordentM.Exitcrownc25 = input.Data.FMExitCrown.M;
            edordentM.Classmincrowndelta = input.Data.FMExitCrownDeltaMin.M;
            edordentM.Classmaxcrowndelta = input.Data.FMExitCrownDeltaMax.M;
            edordentM.Texit = input.Data.FMExitTemp.M;
            edordentM.Tclassmindelta = input.Data.FMExitTempDeltaMin.M;
            edordentM.Tclassmaxdelta = input.Data.FMExitTempDeltaMax.M;
            edordentM.Destination = input.Data.DestinationFlag.M;
            edordentM.Classmaxflatdeltasym = input.Data.ClassFlatDeltaMin.M;
            edordentM.Classmaxflatdeltaasym = input.Data.ClassFlatDeltaMax.M;
            edordentM.Classmaxwedgedelta = input.Data.ClassWedgeDeltaMax.M;
            edordentM.Classminwedgedelta = input.Data.ClassWedgeDeltaMin.M;
            edordentM.Orderno = input.Data.OrderNo.M;

            //CSSection

            edordentM.Coiltemp = input.CSData.CoilTemp.M;
            edordentM.Coiltempmaxtol = input.CSData.CoilTempMax.M;
            edordentM.Coiltempmintol = input.CSData.CoilTempMin.M;
            edordentM.Coolstrategy = input.CSData.CoolMode.M;
            edordentM.Coolingstrategymodeselection = input.CSData.CoolModeSource.M;

            var edlogentM = await _prdbContext.Edlogents.FirstOrDefaultAsync(x => x.Meid == entryMatStruct.Enlomeid && x.Source == "M");
            edlogentM = _prdbContext.InsertIfNull(edlogentM, entryMatStruct);
            edlogentM.Alloycode = input.Data.AlloyCode.M;
            await UpdateChemistry(input, edlogentM, entryMatStruct);

            await _prdbContext.SaveChangesAsync();

            _l2CommunicationHandler.EntryDataChange(entryMatStruct,connectionid);
        }

		private async Task UpdateChemistry(PrimaryDataDto input, Edlogent edlogentManual, VMatStructEntry entryMatStruct)
		{
			var edlogentE = await _prdbContext.Edlogents.FirstOrDefaultAsync(x => x.Meid == entryMatStruct.Enlomeid && x.Source == "E");

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
            return await context.Matdats.Select(x=>x.Alloycode).ToListAsync();
        }

		private async Task<PrimaryDataDataBlob> GetDataBlob(VMatStructEntry entryMatStruct)
		{
			string[] sources = ["L", "M", "S", "E"];

			return new PrimaryDataDataBlob
			{
				EdPhyEnts = await _prdbContext.Edphyents.Where(x => x.Meid == entryMatStruct.Enphmeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
				EdOrdEnts = await _prdbContext.Edordents.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
				EdLogEnts = await _prdbContext.Edlogents.Where(x => x.Meid == entryMatStruct.Enlomeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),

                StatEdPhyEnts = await _prdbContext.StatEdphyents.Where(x => x.Meid == entryMatStruct.Enphmeid && x.Source=="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdOrdEnts = await _prdbContext.StatEdordents.Where(x => x.Meid == entryMatStruct.Enormeid && x.Source=="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdLogEnts = await _prdbContext.StatEdlogents.Where(x => x.Meid == entryMatStruct.Enlomeid && x.Source=="E").AsNoTracking().FirstOrDefaultAsync(),
            };
		}
	}
}
