using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using Abp.Authorization;
using System;
using Microsoft.EntityFrameworkCore;
using Abp.Auditing;
using Abp.Domain.Entities;
using WebHMI.Helpers;
using WebHMI.Dtos.Audit;
using WebHMI.API.Mapping.Extensions;
using WebHMI.WebHMI;
using WebHMI.WebHMI.Dbo;

namespace WebHMI.Services
{
	public class AuditAppService : ApplicationServiceBase
    {
        private readonly IRepository<AuditLog, long> _auditLogRepository;
        private readonly IRepository<User, long> _usersRepository;

        public AuditAppService(
            IRepository<AuditLog, long> auditLogRepository,
            IRepository<User, long> usersRepository)
        {
            _auditLogRepository = auditLogRepository;
            _usersRepository = usersRepository;
        }

        [AbpAuthorize(Permissions.Pages_Audit)]
        public async Task<AuditLogDetailsDto> GetDetails(long id)
		{
            var auditLog = await _auditLogRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

            if (auditLog is null)
                throw new EntityNotFoundException($"{nameof(AuditLog)} not found");

            var user = await _usersRepository.GetAll()
                .Select(u => new { u.Id, u.UserName })
                .FirstOrDefaultAsync(u => u.Id == auditLog.UserId);

            if (user is null)
                throw new EntityNotFoundException($"User associated with {nameof(AuditLog)} not found");

            var dto = auditLog.ToDetailsDto();
            dto.CallerUser.Id = user.Id;
            dto.CallerUser.Username = user.UserName;

            return dto;
        }

        [AbpAuthorize(Permissions.Pages_Audit)]
        public async Task<PagedResultDto<AuditLogItemDto>> GetItems(FilteredRequestDto input)
        {
            var pagedEntities = await ApplyFilterWithoutMapping(
                _auditLogRepository.GetAll()
                    .OrderByDescending(x => x.ExecutionTime),
                input);

            var neededUserIds = pagedEntities.Items
                .Select(x => x.UserId)
                .Distinct();

            var users = await _usersRepository.GetAll()
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
