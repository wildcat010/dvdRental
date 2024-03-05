using Abp.Auditing;
using WebHMI.Dtos;
using WebHMI.Dtos.Audit;

namespace WebHMI.API.Mapping.Extensions
{
    public static class AuditMapper
    {
        public static AuditLogItemDto ToItemDto(this AuditLog entity) => new()
        {
            Id = entity.Id,
            EndpointName = entity.MethodName,
            ServiceName = entity.ServiceName,
            ExecutionTime = entity.ExecutionTime,
            CallerUser = new CallerUser
            {
                IpAddress = entity.ClientIpAddress
            },
            CallResult = new AuditCallResult
            {
                IsSuccess = entity.ExceptionMessage is null,
                OptionalExceptionMessage = entity.ExceptionMessage,
            }
        };

        public static AuditLogDetailsDto ToDetailsDto(this AuditLog entity) => new()
        {
            Id = entity.Id,
            EndpointName = entity.MethodName,
            ServiceName = entity.ServiceName,
            MethodParamsJson = entity.Parameters,
            ExecutionTime = entity.ExecutionTime,
            CallerUser = new CallerUser
            {
                IpAddress = entity.ClientIpAddress
            },
            CallResult = new AuditCallResult
            {
                IsSuccess = entity.ExceptionMessage is null,
                OptionalExceptionMessage = entity.ExceptionMessage,
            }
        };
    }
}
