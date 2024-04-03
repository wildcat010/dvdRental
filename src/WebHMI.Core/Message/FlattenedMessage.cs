using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Message
{
	public class FlattenedMessage
	{
        public FlattenedMessage() { }

        public FlattenedMessage(FlattenedMessage flattenedMessage)
        {
            Id = flattenedMessage.Id;
            MessageSource = flattenedMessage.MessageSource;
            Code = flattenedMessage.Code;
            Language = flattenedMessage.Language;
            Value = flattenedMessage.Value;
            Description = flattenedMessage.Description;
            Level = flattenedMessage.Level;
            CreationTime = flattenedMessage.CreationTime;
            UserData1 = flattenedMessage.UserData1;
            UserData2 = flattenedMessage.UserData2;
            UserData3 = flattenedMessage.UserData3;
            NeedConfirmation = flattenedMessage.NeedConfirmation;
            ConfirmedAt = flattenedMessage.ConfirmedAt;
            ConfirmedBy = flattenedMessage.ConfirmedBy;
            Owner = flattenedMessage.Owner;
            LogIndexId = flattenedMessage.LogIndexId;
        }

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
