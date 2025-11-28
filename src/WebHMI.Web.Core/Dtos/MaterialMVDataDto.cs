using System.Collections.Generic;

namespace WebHMI.Dtos
{
    public class MaterialMVDataDto
    {
        public MeCodeDto MeCode { get; set; }

        /// <summary>
        /// L1 measurement name. Example "Rfr": roll force in RM, "RtX1": RM exit temperature #1, "Fwi1X": FM exit width
        /// </summary>
        public string MVName { get; set; }

        /// <summary>
        /// Optional. Initialized when first element is added to a buffer for a given material. To be read from PRDB 
        /// </summary>
        public double? SetpointValue { get; set; }

        /// <summary>
        /// Optional. Initialized when first element is added to a buffer for a given material. To be read from PRDB 
        /// </summary>
        public double? LimitMax { get; set; }

        /// <summary>
        /// Optional. Initialized when first element is added to a buffer for a given material. To be read from PRDB 
        /// </summary>
        public double? LimitMin { get; set; }

        /// <summary>
        /// Optional. Initialized when first element is added to a buffer for a given material. To be read from PRDB 
        /// </summary>
        public double? WarningMax { get; set; }

        /// <summary>
        /// Optional. Initialized when first element is added to a buffer for a given material. To be read from PRDB 
        /// </summary>
        public double? WarningMin { get; set; }

        /// <summary>
        /// Actual buffer for all stored measured values. New values to be added here
        /// </summary>
        public List<MVPoint> MVSeries { get; set; } = new();

        /// <summary>
        /// Number of Y values per one X. Standard values like temperature or thickness have 1. More than 1 expected for profile and flatness type of measurments
        /// </summary>
        public int ArraySize { get; set; }
    }
}
