using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using WebHMI.Dtos.Core.Enum;

namespace WebHMI.Dtos
{
    public class MessageDefinition : Entity<long>, IMultiLingualEntity<MessageDescription>
    {
        public ICollection<MessageDescription> Translations { get; set; }

        public bool NeedConfirmation { get; set; }

        [MaxLength(45)]
        public string Group { get; set; }

        [MaxLength(45)]
        public string Code { get; set; }

        public SeverityLevel SeverityLevel { get; set; }
        
        public virtual ICollection<MessageTemplate> MessageTemplates { get; set; }
    }
}
