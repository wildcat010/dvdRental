using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WebHMI.Dtos.Audit;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.WebHMI;

namespace WebHMI.Services
{
	public class AuditAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<WebHMIDbContext> _dbContextProvider;

        public AuditAppService(IDbContextProvider<WebHMIDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        //function to get the details of a specific audit log by its ID
        [AbpAuthorize(Permissions.Pages_Audit)]
        public async Task<AuditLogDetailsDto> GetDetails(long id)
        {
            var hmiContext = await _dbContextProvider.GetDbContextAsync();
            var auditLog = await hmiContext.ExtendedAuditLogs.FirstOrDefaultAsync(x => x.Id == id);

            if (auditLog is null)
                throw new EntityNotFoundException($"{nameof(AuditLog)} not found");

            var user = await hmiContext.Users
                .Select(u => new { u.Id, u.UserName })
                .FirstOrDefaultAsync(u => u.Id == auditLog.UserId);

            if (user is null)
                throw new EntityNotFoundException($"User associated with {nameof(AuditLog)} not found");

            var dto = auditLog.ToDetailsDto();
            dto.CallerUser.Id = user.Id;
            dto.CallerUser.Username = user.UserName;

            return dto;
        }

        //function to get a paginated list of audit log items based on the provided filter
        [AbpAuthorize(Permissions.Pages_Audit)]
        public async Task<PagedResultDto<AuditLogItemDto>> GetItems(FilteredRequestDto input)
        {
            var hmiContext = await _dbContextProvider.GetDbContextAsync();
            var pagedEntities = await ApplyFilterWithoutMapping(
                hmiContext.ExtendedAuditLogs
                    .OrderByDescending(x => x.ExecutionTime),
                input);

            var neededUserIds = pagedEntities.Items
                .Select(x => x.UserId)
                .Distinct();

            var users = await hmiContext.Users
                .Where(u => neededUserIds.Contains(u.Id))
                .Select(u => new { u.Id, u.UserName })
                .ToListAsync();

            var dtos = new List<AuditLogItemDto>();
            foreach (var auditLog in pagedEntities.Items)
            {
                var dto = auditLog.ToItemDto();

                var user = users.FirstOrDefault(x => x.Id == auditLog.UserId);
                if (user is not null)
                {
                    dto.CallerUser.Username = user.UserName;
                    dto.CallerUser.Id = user.Id;
                }

                dtos.Add(dto);
            }

            return new PagedResultDto<AuditLogItemDto>
            {
                Items = dtos,
                TotalCount = pagedEntities.TotalCount
            };
        }
    }
}
