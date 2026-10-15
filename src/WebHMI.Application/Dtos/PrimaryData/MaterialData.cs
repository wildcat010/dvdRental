using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebHMI.Dtos.PrimaryData
{
	public class MaterialData
	{
		public SourceSet<string> OrderNo { get; set; } = new();
		public SourceSet<string> SequenceId { get; set; } = new();
        public SourceSet<string> HeatId { get; set; } = new();
        public SourceSet<string> HeatName { get; set; } = new();
        public SourceSet<double?> SlabThickness { get; set; } = new();
		public SourceSet<double?> SlabWidth { get; set; } = new();
		public SourceSet<double?> SlabLength { get; set; } = new();
		public SourceSet<double?> SlabWeight { get; set; } = new();
        public SourceSet<string> AlloyCode { get; set; } = new();
        public SourceSet<string> AlloyCodeCustomer { get; set; } = new();
        public SourceSet<int?> FlagBatchRolling { get; set; } = new();
        public SourceSet<double?> SlabWidthHead { get; set; } = new();
		public SourceSet<double?> SlabWidthTail { get; set; } = new();
		public SourceSet<int?> WidthChangeFlag { get; set; } = new();
		public SourceSet<double?> WidthChangePosStart { get; set; } = new();
		public SourceSet<double?> WidthChangePosEnd { get; set; } = new();
		public SourceSet<double?> WidthChange { get; set; } = new();
		public SourceSet<double?> MinSlabWeight { get; set; } = new();
		public SourceSet<double?> MaxSlabWeight { get; set; } = new();
		public SourceSet<int?> PlateProductionFlag { get; set; } = new();
		public SourceSet<int?> SimulationFlag { get; set; } = new();
		public SourceSet<double?> FMExitThicknessCustomer { get; set; } = new();
		public SourceSet<double?> FMExitWidthCustomer { get; set; } = new(); // to be removed? 
		public SourceSet<double?> AlloyCompensation { get; set; } = new();
		public SourceSet<double?> CastSpeed { get; set; } = new();
		public SourceSet<double?> MinCastSpeed { get; set; } = new();
		public SourceSet<double?> FMEntryThickness { get; set; } = new();
		public SourceSet<double?> FMExitThickness { get; set; } = new();
		public SourceSet<double?> FMExitThicknessDeltaMin { get; set; } = new();
		public SourceSet<double?> FMExitThicknessDeltaMax { get; set; } = new();
		public SourceSet<double?> FMExitWidth { get; set; } = new();
		public SourceSet<double?> FMExitWidthDeltaMin { get; set; } = new();
		public SourceSet<double?> FMExitWidthDeltaMax { get; set; } = new();
		public SourceSet<double?> FMExitCrown { get; set; } = new();
		public SourceSet<double?> FMExitCrownDeltaMin { get; set; } = new();
		public SourceSet<double?> FMExitCrownDeltaMax { get; set; } = new();
		public SourceSet<double?> FMExitTemp { get; set; } = new();
		public SourceSet<double?> FMExitTempDeltaMin { get; set; } = new();
		public SourceSet<double?> FMExitTempDeltaMax { get; set; } = new();
		public SourceSet<int?> DestinationFlag { get; set; } = new();
        public SourceSet<double?> CoilerTemp { get; set; } = new();
        public SourceSet<double?> CoilerTempDeltaMin { get; set; } = new();
        public SourceSet<double?> CoilerTempDeltaMax { get; set; } = new();
        public SourceSet<double?> CoolingRateTop { get; set; } = new();
        public SourceSet<double?> CoolingRateBottom { get; set; } = new();
        public SourceSet<int?> CoolingStrategyFlag { get; set; } = new();
        public SourceSet<short?> CoolingStrategyMode { get; set; } = new();
        public SourceSet<double?> ClassWedgeDeltaMin { get; set; } = new();
		public SourceSet<double?> ClassWedgeDeltaMax { get; set; } = new();
        public SourceSet<double?> ClassFlatDeltaMin { get; set; } = new();
        public SourceSet<double?> ClassFlatDeltaMax { get; set; } = new();
        public SourceSet<double?> Flatness { get; set; } = new();
        public bool IsInlineRollChangeActive { get; set; }
    }
}
