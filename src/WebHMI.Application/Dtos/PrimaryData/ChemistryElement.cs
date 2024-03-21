using System.Collections.Generic;

namespace WebHMI.Dtos.PrimaryData
{
	public class ChemistryElement
	{
		public string Name { get; set; }
		public SourceSet<float?> Value { get; set; } = new();
	}
}
