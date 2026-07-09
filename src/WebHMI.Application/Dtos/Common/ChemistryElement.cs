using System.Collections.Generic;

namespace WebHMI.Dtos.Common
{
	public class ChemistryElement
	{
		public string Name { get; set; }
		public SourceSet<double?> Value { get; set; } = new();
	}

    public class ApsChemistryElement
    {
        public string Name { get; set; }
        public double? Value { get; set; }
    }
}
