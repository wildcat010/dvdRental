using Abp.Application.Services.Dto;
using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Messages;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.Message;
using WebHMI.PRDB;

namespace WebHMI.Services
{
    public class MessageAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly MessagesCache _messageStorage;

        public MessageAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider, 
            MessagesCache messageStorage)
        {
            _prdbContextProvider = prdbContextProvider;
            _messageStorage = messageStorage;
        }

        public async Task<PagedResultDto<MessageOutput>> GetAll(MessageRequestDto input)
        {
            if (input.Language == null || input.Language == string.Empty || input.Language == "0")
                input.Language = "en"; //default language

            if (input.UseHistoryData)
            {
                var messages = (from data in _prdbContext.LogData
                                join index in _prdbContext.LogIndices
                                    on data.Id equals index.Id
                                join format in _prdbContext.LogFormats.Where(d => d.Lang == input.Language)
                                    on new { data.Id } equals new { format.Id }
                                select new FlattenedMessage
                                {
                                    Code = index.Descr,
                                    NeedConfirmation = index.NeedConfirm ?? false,
                                    Level = MapAlarmLevel(index.Severity),

                                    Language = format.Lang,
                                    Value = format.Format,

                                    Id = data.EntryId,
                                    ConfirmedAt = data.ConfirmedAt,
                                    ConfirmedBy = data.ConfirmedBy,
                                    Description = data.UserData3,

                                    UserData1 = data.UserData1,
                                    UserData2 = data.UserData2,
                                    UserData3 = data.UserData3,
                                    CreationTime = data.Clock,
                                    Owner = data.LogOrigin,
                                    LogIndexId = data.Id,

                                    MessageSource = MessageSource.Prdb
                                })
                     .OrderByDescending(x => x.Id);

                return await ApplyFilter(messages, input, MessageMapper.ToOutput);
            }
            else
            {
                var cachedMessages = _messageStorage.GetAll()
                    .Where(d => d.Language == input.Language)
                    .OrderByDescending(x => x.Id);

                return ApplyFilter(cachedMessages, input, MessageMapper.ToOutput);
            }
        }

        private static SeverityLevel MapAlarmLevel(short? severity) => severity switch
        {
            161 => SeverityLevel.Error,
            162 => SeverityLevel.Warning,
            163 => SeverityLevel.Info,
            _ => SeverityLevel.Info
        };
    }
}
