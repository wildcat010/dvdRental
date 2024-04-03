using Castle.MicroKernel.Registration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Messages;
using WebHMI.Message;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    internal static class MessageMapper
    {
        public static MessageOutput ToOutput(this FlattenedMessage flattenedMessage) => new()
        {
            Id = flattenedMessage.Id,
            MessageSource = flattenedMessage.MessageSource,
            Code = flattenedMessage.Code,
            Language = flattenedMessage.Language,
            Value = flattenedMessage.Value,
            Description = flattenedMessage.Description,
            Level = flattenedMessage.Level,
            CreationTime = flattenedMessage.CreationTime,
            UserData1 = flattenedMessage.UserData1,
            UserData2 = flattenedMessage.UserData2,
            UserData3 = flattenedMessage.UserData3,
            NeedConfirmation = flattenedMessage.NeedConfirmation,
            ConfirmedAt = flattenedMessage.ConfirmedAt,
            ConfirmedBy = flattenedMessage.ConfirmedBy,
            Owner = flattenedMessage.Owner,
            LogIndexId = flattenedMessage.LogIndexId,
        };
    }
}
