using Abp.Auditing;
using Abp.Dependency;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Abp.Json;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;
using System.Collections.Generic;
using System;

namespace WebHMI.Web.Host.Auditing
{
	/// <summary>
	/// Custom implementation of <see cref="IAuditingStore"/> to save auditing logs.
	/// </summary>
	public class CustomAuditingStore : IAuditingStore, ITransientDependency
	{
		private readonly ILogger<CustomAuditingStore> _logger;
		private readonly IRepository<AuditLog, long> _auditLogRepository;

		public CustomAuditingStore(
			ILogger<CustomAuditingStore> logger,
			IRepository<AuditLog, long> auditLogRepository)
		{
			_logger = logger;
			_auditLogRepository = auditLogRepository;
		}

		public virtual Task SaveAsync(AuditInfo auditInfo)
		{
			_logger.LogInformation(auditInfo.ToAuditLogString());
			return _auditLogRepository.InsertAsync(auditInfo.ToAuditLog());
		}

		public virtual void Save(AuditInfo auditInfo)
		{
			_logger.LogInformation(auditInfo.ToAuditLogString());
			_auditLogRepository.Insert(auditInfo.ToAuditLog());
		}
	}
}
