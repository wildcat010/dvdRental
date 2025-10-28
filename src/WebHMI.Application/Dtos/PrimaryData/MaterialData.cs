using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebHMI.Dtos.PrimaryData
{
	public class MaterialData
	{
		public SourceSet<string> OrderNo { get; set; } = new();
		public SourceSet<string> SequenceId { get; set; } = new();
        public SourceSet<string> HeatId { get; set; } = new();
		public SourceSet<float?> SlabThickness { get; set; } = new();
		public SourceSet<float?> SlabWidth { get; set; } = new();
		public SourceSet<float?> SlabLength { get; set; } = new();
		public SourceSet<float?> SlabWeight { get; set; } = new();
        public SourceSet<string> AlloyCode { get; set; } = new();
        public SourceSet<string> AlloyCodeCustomer { get; set; } = new();
        public SourceSet<int?> FlagBatchRolling { get; set; } = new();
        public SourceSet<float?> SlabWidthHead { get; set; } = new();
		public SourceSet<float?> SlabWidthTail { get; set; } = new();
		public SourceSet<int?> WidthChangeFlag { get; set; } = new();
		public SourceSet<float?> WidthChangePosStart { get; set; } = new();
		public SourceSet<float?> WidthChangePosEnd { get; set; } = new();
		public SourceSet<float?> WidthChange { get; set; } = new();
		public SourceSet<float?> MinSlabWeight { get; set; } = new();
		public SourceSet<float?> MaxSlabWeight { get; set; } = new();
		public SourceSet<int?> PlateProductionFlag { get; set; } = new();
		public SourceSet<int?> SimulationFlag { get; set; } = new();
		public SourceSet<float?> FMExitThicknessCustomer { get; set; } = new();
		public SourceSet<float?> FMExitWidthCustomer { get; set; } = new(); // to be removed? 
		public SourceSet<float?> AlloyCompensation { get; set; } = new();
		public SourceSet<float?> CastSpeed { get; set; } = new();
		public SourceSet<float?> MinCastSpeed { get; set; } = new();
		public SourceSet<float?> FMEntryThickness { get; set; } = new();
		public SourceSet<float?> FMExitThickness { get; set; } = new();
		public SourceSet<float?> FMExitThicknessDeltaMin { get; set; } = new();
		public SourceSet<float?> FMExitThicknessDeltaMax { get; set; } = new();
		public SourceSet<float?> FMExitWidth { get; set; } = new();
		public SourceSet<float?> FMExitWidthDeltaMin { get; set; } = new();
		public SourceSet<float?> FMExitWidthDeltaMax { get; set; } = new();
		public SourceSet<float?> FMExitCrown { get; set; } = new();
		public SourceSet<float?> FMExitCrownDeltaMin { get; set; } = new();
		public SourceSet<float?> FMExitCrownDeltaMax { get; set; } = new();
		public SourceSet<float?> FMExitTemp { get; set; } = new();
		public SourceSet<float?> FMExitTempDeltaMin { get; set; } = new();
		public SourceSet<float?> FMExitTempDeltaMax { get; set; } = new();
		public SourceSet<int?> DestinationFlag { get; set; } = new();
		//public SourceSet<float?> CoilerTemp { get; set; } = new();
		//public SourceSet<float?> CoilerTempDeltaMin { get; set; } = new();
		//public SourceSet<float?> CoilerTempDeltaMax { get; set; } = new();
		//public SourceSet<float?> CoolingRateTop { get; set; } = new();
		//public SourceSet<float?> CoolingRateBottom { get; set; } = new();
		//public SourceSet<int?> CoolingStrategyFlag { get; set; } = new();
		//public SourceSet<short?> CoolingStrategyMode { get; set; } = new();
		public SourceSet<float?> ClassWedgeDeltaMin { get; set; } = new();
		public SourceSet<float?> ClassWedgeDeltaMax { get; set; } = new();
        public SourceSet<float?> ClassFlatDeltaMin { get; set; } = new();
        public SourceSet<float?> ClassFlatDeltaMax { get; set; } = new();

    }
}
