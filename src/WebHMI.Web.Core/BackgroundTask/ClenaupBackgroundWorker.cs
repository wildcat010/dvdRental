using Abp.Auditing;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Castle.Core.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHMI.API.BackgroundTask
{
	public class ClenaupBackgroundWorker : PeriodicBackgroundWorkerBase, ISingletonDependency
	{
		private readonly IRepository<AuditLog, long> _auditLogRepository;
		private readonly ILogger _logger;
		private static DateTime _deleteDateTreshold => DateTime.UtcNow.AddMonths(-6);

		public ClenaupBackgroundWorker(
			AbpTimer timer,
			IRepository<AuditLog, long> auditLogRepository,
			ILogger logger) : base(timer)
		{
			timer.Period = (int)TimeSpan.FromHours(6).TotalMilliseconds;
			_auditLogRepository = auditLogRepository;
			_logger = logger;
		}

		protected override void DoWork()
		{
			CleanupOldAuditLogs().GetAwaiter().GetResult();
		}

		[UnitOfWork]
		public virtual async Task CleanupOldAuditLogs()
		{
			var localDeleteDateTreshold = _deleteDateTreshold;

			try
			{
				var oldLogsCountBefore = await _auditLogRepository.GetAll()
					.Where(y => y.ExecutionTime < localDeleteDateTreshold)
					.CountAsync();

				if (oldLogsCountBefore == 0)
					return;

				_auditLogRepository.Delete(x => x.ExecutionTime < localDeleteDateTreshold);
				await CurrentUnitOfWork.SaveChangesAsync();

				var oldLogsCountAfter = await _auditLogRepository.GetAll()
					.Where(y => y.ExecutionTime < localDeleteDateTreshold)
					.CountAsync();

				if (oldLogsCountAfter != 0)
					_logger.Warn($"Not all old audit logs were deleted. " +
						$"{oldLogsCountAfter} logs older than {localDeleteDateTreshold} still remain.");

				_logger.Info($"Deleted {oldLogsCountBefore} audit logs older than {localDeleteDateTreshold}");
			}
			catch (Exception ex)
			{
				_logger.Info($"Audit log periodic cleanup failed", ex);
			}
		}
	}
}
