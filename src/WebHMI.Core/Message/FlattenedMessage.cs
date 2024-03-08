using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Message
{
	internal class FlattenedMessage
	{
		public long? Id { get; set; }
		public MessageSource MessageSource { get; set; }
		public string Code { get; set; }
		public string Language { get; set; }
		public string Value { get; set; }
		public string Description { get; set; }
		public SeverityLevel Level { get; set; }
		public DateTime CreationTime { get; set; }
		public string UserData1 { get; set; }
		public string UserData2 { get; set; }
		public string UserData3 { get; set; }
		public bool NeedConfirmation { get; set; }
		public DateTime? ConfirmedAt { get; set; }
		public string ConfirmedBy { get; set; }
		public string Owner { get; set; }
		public long LogIndexId { get; set; }
	}

	public enum MessageSource
	{
		Hmi,
		Prdb
	}

	public enum SeverityLevel : byte
	{
		Info = 0,
		Warning = 1,
		Error = 2
	}
}
