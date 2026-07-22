using Abp.Auditing;
using WebHMI.Dtos;
using WebHMI.Dtos.Audit;
using WebHMI.WebHMI.Dbo;

namespace WebHMI.Mapping.Extensions
{
	public static class AuditMapper
	{
        //function to map AuditLog entity to AuditLogItemDto
        public static AuditLogItemDto ToItemDto(this AuditLog entity) => new()
		{
			Id = entity.Id,
			EndpointName = entity.MethodName,
			ServiceName = entity.ServiceName,
			ExecutionTime = entity.ExecutionTime,
            ExecutionDuration = entity.ExecutionDuration,
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

        //function to map AuditLog entity to AuditLogDetailsDto
        public static AuditLogDetailsDto ToDetailsDto(this AuditLog entity) => new()
		{
			Id = entity.Id,
			EndpointName = entity.MethodName,
			ServiceName = entity.ServiceName,
			MethodParamsJson = entity.Parameters,
			ExecutionTime = entity.ExecutionTime,
            ExecutionDuration = entity.ExecutionDuration,
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

        //function to map ExtendedAuditLog entity to AuditLogItemDto
        public static AuditLogItemDto ToItemDto(this ExtendedAuditLog entity) => new()
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
            },
            RelatedId = entity.RelatedId,
            Duration = entity.ExecutionDuration
        };

        //function to map ExtendedAuditLog entity to AuditLogDetailsDto
        public static AuditLogDetailsDto ToDetailsDto(this ExtendedAuditLog entity) => new()
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
            },
            RelatedId = entity.RelatedId,
            Duration = entity.ExecutionDuration
        };
    }
}
