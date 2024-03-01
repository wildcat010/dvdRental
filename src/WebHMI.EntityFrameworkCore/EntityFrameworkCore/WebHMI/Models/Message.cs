using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using WebHMI.Dtos;

namespace WebHMI.Dtos
{
    public class Message : Entity<long>, IHasCreationTime
    {
        public string Value { get; set; }

        [MaxLength(45)]
        public string UserData1 { get; set; }

        [MaxLength(45)]
        public string UserData2 { get; set; }

        [MaxLength(45)]
        public string UserData3 { get; set; }

        public string Language { get; set; }
        
        public DateTime CreationTime { get; set; }

        public string Owner { get; set; }
        
        public DateTime? ConfirmedAt { get; set; }

        public virtual User ConfirmedBy { get; set; }
        public virtual long? ConfirmedById { get; set; }
        
        public virtual MessageDefinition MessageDefinition { get; set; }
        public virtual long MessageDefinitionId { get; set; }
    }
}
