using Abp.Auditing;

namespace WebHMI.Web.Host.Auditing
{
	public static class AuditInfoExtensions
	{
		public static AuditLog ToAuditLog(this AuditInfo auditInfo)
		{
			var auditLog = AuditLog.CreateFromAuditInfo(auditInfo);

			// Override, full length, do not truncate with postfix
			auditLog.Parameters = auditInfo.Parameters;

            auditLog.ExecutionTime = auditLog.ExecutionTime.ToUniversalTime();

            return auditLog;
		}

		public static string ToAuditLogString(this AuditInfo auditInfo)
		{
			return $"Request {auditInfo.ServiceName}/{auditInfo.MethodName} executed by user with id '{auditInfo.UserId}' " +
				$"from '{auditInfo.ClientIpAddress}' in {auditInfo.ExecutionDuration}ms. " +
				$"Execution parameters: {auditInfo.Parameters}";
		}
	}
}
