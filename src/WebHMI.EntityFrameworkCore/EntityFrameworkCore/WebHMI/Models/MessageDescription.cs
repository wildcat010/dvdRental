using Abp.Domain.Entities;

namespace WebHMI.Dtos
{
    public class MessageDescription : Entity<long>, IEntityTranslation<MessageDefinition, long>
    {
        public string Description { get; set; }

        public MessageDefinition Core { get; set; }

        public long CoreId { get; set; }

        public string Language { get; set; }
    }
}
