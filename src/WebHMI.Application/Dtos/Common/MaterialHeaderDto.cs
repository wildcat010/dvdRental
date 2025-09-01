using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Common
{
	public class MaterialHeaderDto
	{
		public MeCodeDto MeCode { get; set; }
		public MaterialHeaderData Data { get; set; } = new();
	}

	public class MaterialHeaderData
	{
		public SourceSet<string> EnPhExtId { get; set; } = new();
		public SourceSet<int?> EnPhMeId { get; set; } = new();
		public SourceSet<string> EdPhySrc { get; set; } = new();
		public SourceSet<short?> EnPhStatus { get; set; } = new();
		public SourceSet<string> EdOrSrc { get; set; } = new();
		public SourceSet<int?> EnLoMeId { get; set; } = new();
		public SourceSet<string> EdLoSrc { get; set; } = new();
		public SourceSet<string> AlloyCode { get; set; } = new();
		public SourceSet<float?> HEntry { get; set; } = new();
		public SourceSet<float?> HExit { get; set; } = new();
		public SourceSet<float?> WEntry { get; set; } = new();
		public SourceSet<float?> WeightEntry { get; set; } = new();
		public SourceSet<float?> LEntry { get; set; } = new();
		public SourceSet<float?> WExit { get; set; } = new();
		public SourceSet<string> SequenceId { get; set; } = new();
		public SourceSet<short?> PdiStatus { get; set; } = new();
		public SourceSet<short?> SetpointsPc2Ok { get; set; } = new();
		public SourceSet<int?> Sbaz { get; set; } = new();
		public SourceSet<DateTime?> LastCalc { get; set; } = new();
		public SourceSet<string> ApsKey { get; set; } = new();
		public SourceSet<int?> SimMat { get; set; } = new();
		public SourceSet<short?> SetpointsCsOk { get; set; } = new();
		public SourceSet<float?> TEntryFm { get; set; } = new();
		public SourceSet<float?> TExitFm { get; set; } = new();
		public SourceSet<float?> TExitCaster { get; set; } = new();
		public SourceSet<float?> CoilTemp { get; set; } = new();
		public SourceSet<string> HeatId { get; set; } = new();
		public SourceSet<int?> FlagBatchRolling { get; set; } = new();
		public SourceSet<int?> ProductType { get; set; } = new();
		public SourceSet<DateTime?> ProdStartTime { get; set; } = new();
		public SourceSet<DateTime?> ProdEndTime { get; set; } = new();
	}
}
