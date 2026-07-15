using System;

namespace WebHMI.Dtos.ProductData
{
    public class ProductionHistoryDto
    {
        public string CoilID { get; set; }
        public string SequenceID { get; set; }
        public string HeatID1 { get; set; }
        public int? FlagBatchRolling { get; set; }
        public string SlabId { get; set; }
        public string AlloyCode { get; set; }
        public DateTime? Prodend { get; set; }
        public double? ExitWidthSP { get; set; }
        public double? ExitWidth { get; set; }
        public double? ExitWidthMin { get; set; }
        public double? ExitWidthMax { get; set; }
        public double? ExitThicknessSP { get; set; }
        public double? ExitThickness { get; set; }
        public double? ExitThicknessMin { get; set; }
        public double? ExitThicknessMax { get; set; }
        public double? CSExitTempSP { get; set; }
        public double? CSExitTemp { get; set; }
        public double? CSExitTempMin { get; set; }
        public double? CSExitTempMax { get; set; }
        public double? CoilLength { get; set; }
        public DateTime? Prodstart { get; set; }
    }
}
