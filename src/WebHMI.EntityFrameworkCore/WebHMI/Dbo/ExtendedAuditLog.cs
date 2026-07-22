using Abp.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHMI.WebHMI.Dbo
{
    [Table("AbpAuditLogs")]
    public class ExtendedAuditLog : AuditLog
    {
        public virtual string RelatedId { get; set; }

    }
}
