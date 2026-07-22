using Abp.Auditing;
using Abp.Dependency;
using Abp.EntityFrameworkCore;
using Abp.Runtime.Caching;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using WebHMI.Interface;
using WebHMI.WebHMI;

namespace WebHMI.Web.Host.Auditing
{
    /// <summary>
    /// Custom implementation of <see cref="IAuditingStore"/> to save auditing logs.
    /// </summary>
    public class CustomAuditingStore : IAuditingStore, ITransientDependency
    {
        private readonly ITypedCache<string, ParameterInfo> _cache;
        private readonly ILogger<CustomAuditingStore> _logger;
        private readonly IDbContextProvider<WebHMIDbContext> _dbContextProvider;

        public CustomAuditingStore(
            ILogger<CustomAuditingStore> logger,
            IDbContextProvider<WebHMIDbContext> dbContextProvider,
            ICacheManager cacheManager)
        {
            _logger = logger;
            _dbContextProvider = dbContextProvider;
            _cache = cacheManager.GetCache<string, ParameterInfo>(nameof(ParameterInfo));
        }

        //function to save the audit info to the database asynchronously
        public virtual Task SaveAsync(AuditInfo auditInfo)
        {
            var context = _dbContextProvider.GetDbContext();

            var extendedAuditLog = auditInfo.ToAuditLog();
            extendedAuditLog.RelatedId = ResolveRelatedId(auditInfo);

            _logger.LogInformation(auditInfo.ToAuditLogString());
            context.ExtendedAuditLogs.Add(extendedAuditLog);
            return context.SaveChangesAsync();
        }

        //function to save the audit log synchronously
        public virtual void Save(AuditInfo auditInfo)
        {
            var context = _dbContextProvider.GetDbContext();

            var extendedAuditLog = auditInfo.ToAuditLog();
            extendedAuditLog.RelatedId = ResolveRelatedId(auditInfo);

            _logger.LogInformation(auditInfo.ToAuditLogString());
            context.ExtendedAuditLogs.Add(extendedAuditLog);
            context.SaveChanges();
        }

        //function to resolve the related id from the audit info parameters
        private string ResolveRelatedId(AuditInfo auditInfo)
        {
            var dtoParameter = _cache.Get(auditInfo.ServiceName + auditInfo.MethodName, () =>
            {
                var endpointType = Type.GetType(auditInfo.ServiceName + ",WebHMI.Application");
                var znalezione = endpointType.GetMethods().Where(x => x.Name == auditInfo.MethodName).SingleOrDefault();
                return znalezione.GetParameters().Where(x => x.ParameterType.GetInterface("IAuditLogRelatedIdGetter") != null).SingleOrDefault();
            });
            if (dtoParameter == null)
                return null;

            var root = JsonDocument.Parse(auditInfo.Parameters).RootElement;
            var partial = root.GetProperty(dtoParameter.Name).GetRawText();

            var obj = JsonSerializer.Deserialize(partial, dtoParameter.ParameterType, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            var final = ((IAuditLogRelatedIdGetter)obj).GetAuditLogRelatedId();
            return final;
        }
    }
}
