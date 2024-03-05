using Abp.Auditing;
using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace WebHMI.Web.Host.Auditing
{
	/// <summary>
	/// This service uses default <see cref="AuditingHelper"/> service,
	/// but overrides <see cref="AuditingHelper.ShouldSaveAudit"/>
	/// to don't save audit logs by default.
	/// </summary>
	public class IgnoreDefaultAuditingHelper : IAuditingHelper
	{
		public IAbpSession AbpSession { get; set; }

		private readonly AuditingHelper _auditingHelper;

		public IgnoreDefaultAuditingHelper(
			AuditingHelper auditingHelper)
		{
			_auditingHelper = auditingHelper;
		}

		public AuditInfo CreateAuditInfo(Type type, MethodInfo method, object[] arguments)
		{
			return _auditingHelper.CreateAuditInfo(type, method, arguments);
		}

		public AuditInfo CreateAuditInfo(Type type, MethodInfo method, IDictionary<string, object> arguments)
		{
			return _auditingHelper.CreateAuditInfo(type, method, arguments);
		}

		public void Save(AuditInfo auditInfo)
		{
			_auditingHelper.Save(auditInfo);
		}

		public Task SaveAsync(AuditInfo auditInfo)
		{
			return _auditingHelper.SaveAsync(auditInfo);
		}

		/// <summary>
		/// This method is called by ABP framework with default <paramref name="defaultValue"/> value set to <see cref="true"/>.
		/// <paramref name="defaultValue"/> is overriden here to <see cref="false"/> so logs won't be saved by default.
		/// </summary>
		public bool ShouldSaveAudit(MethodInfo methodInfo, bool defaultValue = false)
		{
			defaultValue = false;
			return _auditingHelper.ShouldSaveAudit(methodInfo, defaultValue);
		}
	}
}
