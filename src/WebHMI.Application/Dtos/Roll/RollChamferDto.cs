using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Interface;

namespace WebHMI.Dtos.Roll
{
    public class RollChamferDto : IAuditLogRelatedIdGetter
    {
        public int Rollchamferclass { get; set; }
        public double? Conedistds { get; set; }
        public double? Conedistos { get; set; }
        public double? Coneheightds { get; set; }
        public double? Coneheightos { get; set; }
        public double? Conelengthds { get; set; }
        public double? Conelengthos { get; set; }
        public int? Conetype { get; set; }
        public string Description { get; set; }
        public string Standrange { get; set; }

        public string GetAuditLogRelatedId()
        {
            return $"{Rollchamferclass}";
        }
    }
}
