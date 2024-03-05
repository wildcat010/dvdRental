using System;

namespace WebHMI.Dtos.Audit
{
	public class AuditLogItemDto
	{
		public long Id { get; set; }
		public string ServiceName { get; set; }
		public string EndpointName { get; set; }
		public DateTime ExecutionTime { get; set; }
		public CallerUser CallerUser { get; set; }
		public AuditCallResult CallResult { get; set; }
	}
}
