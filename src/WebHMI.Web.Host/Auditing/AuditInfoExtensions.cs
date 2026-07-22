using Abp.Auditing;
using Abp.Extensions;
using System.Linq;
using WebHMI.WebHMI.Dbo;

namespace WebHMI.Web.Host.Auditing
{
	public static class AuditInfoExtensions
	{
		public static ExtendedAuditLog ToAuditLog(this AuditInfo auditInfo)
		{
            var auditLog = CreateFromAuditInfo(auditInfo);

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

        //function created to avoid code duplication between ToAuditLog and ToAuditLogString
        public static ExtendedAuditLog CreateFromAuditInfo(AuditInfo auditInfo)
        {
            return new ExtendedAuditLog
            {
                TenantId = auditInfo.TenantId,
                UserId = auditInfo.UserId,
                ServiceName = auditInfo.ServiceName.TruncateWithPostfix(AuditLog.MaxServiceNameLength).Split('.').Last(),
                MethodName = auditInfo.MethodName.TruncateWithPostfix(AuditLog.MaxMethodNameLength),
                Parameters = auditInfo.Parameters.TruncateWithPostfix(AuditLog.MaxParametersLength),
                ReturnValue = auditInfo.ReturnValue.TruncateWithPostfix(AuditLog.MaxReturnValueLength),
                ExecutionTime = auditInfo.ExecutionTime,
                ExecutionDuration = auditInfo.ExecutionDuration,
                ClientIpAddress = auditInfo.ClientIpAddress.TruncateWithPostfix(AuditLog.MaxClientIpAddressLength),
                ClientName = auditInfo.ClientName.TruncateWithPostfix(AuditLog.MaxClientNameLength),
                BrowserInfo = auditInfo.BrowserInfo.TruncateWithPostfix(AuditLog.MaxBrowserInfoLength),
                ExceptionMessage = auditInfo.Exception?.Message.TruncateWithPostfix(AuditLog.MaxExceptionMessageLength),
                ImpersonatorUserId = auditInfo.ImpersonatorUserId,
                ImpersonatorTenantId = auditInfo.ImpersonatorTenantId,
                CustomData = auditInfo.CustomData.TruncateWithPostfix(AuditLog.MaxCustomDataLength)
            };
        }
    }
}
