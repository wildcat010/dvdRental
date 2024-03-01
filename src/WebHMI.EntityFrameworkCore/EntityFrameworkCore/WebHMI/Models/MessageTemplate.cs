using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace WebHMI.Dtos
{
    public class MessageTemplate : Entity<long>
    {
        public string Template { get; set; }

        [StringLength(15)]
        public string Language { get; set; }
        
        public virtual MessageDefinition MessageDefinition { get; set; }
        public virtual long MessageDefinitionId { get; set; }
    }
}
