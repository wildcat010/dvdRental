using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Audit
{
	public class AuditLogDetailsDto
	{
		public long Id { get; set; }
		public string ServiceName { get; set; }
		public string EndpointName { get; set; }
		public string MethodParamsJson { get; set; }
		public DateTime ExecutionTime { get; set; }
		public CallerUser CallerUser { get; set; }
		public AuditCallResult CallResult { get; set; }
	}
}
