using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Interface;

namespace WebHMI.Dtos.Limit
{
    public class LimitDto : IAuditLogRelatedIdGetter
    {
        public string LimitName { get; set; }
        public string PlantType { get; set; }
        public string CType { get; set; }
        public string Description { get; set; }
        public double? LowerLimit { get; set; }
        public string Moddescr { get; set; }
        public string SortOrder { get; set; }
        public string Unit { get; set; }
        public double? UpperLimit { get; set; }
        public DateTime? Toc { get; set; }
        public DateTime? Tom { get; set; }
        public string Mop { get; set; }

        public string GetAuditLogRelatedId()
        {
            return $"{LimitName}-{PlantType}";
        }
    }
}
