using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy;
using WebHMI.Dtos.Strategy.DefaultChemistry;
using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.Mapping.Extensions.Strategy;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.WebHMI.Migrations;

namespace WebHMI.Services.StrategyServices
{
    public class DefaultChemistryService : ApplicationServiceBase
    {

        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;

        public virtual string AggregateName { get; set; }
        public bool IsLastService { get; set; } = true;

        public DefaultChemistryService(IDbContextProvider<PrdbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<DefaultChemistryDto> Create(DefaultChemistryDto dto)
        {

            var context = _dbContextProvider.GetDbContext();
            bool exists = await context.MatDats.AnyAsync(x => x.AlloyCode == dto.Alloycode);

            if (exists)
                throw new EntityNotFoundException("Entry already exists for given key");

            var entity = new MatDat();
            DefaultChemistryMapper.MapEntity(entity, dto);

            await context.MatDats.AddAsync(entity);

            await context.SaveChangesAsync();

            return DefaultChemistryMapper.ToDto(entity);
        }


        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<DefaultChemistryDto> Get(string alloyCode)
        {
            var context = _dbContextProvider.GetDbContext();
            var entity = await context.MatDats
                .FirstOrDefaultAsync(x => x.AlloyCode == alloyCode) 
                ?? throw new EntityNotFoundException("Std for given key not found");

            var dto = DefaultChemistryMapper.ToDto(entity);

            return dto;
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<PagedResultDto<DefaultChemistryDto>> GetAll(FilteredRequestDto input)
        {
            var context = _dbContextProvider.GetDbContext();
            return await ApplyFilter(
                context.MatDats
                    .OrderByDescending(t => t.AlloyCode),
                input,
                DefaultChemistryMapper.ToDto);
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<List<string>> GetAllSteelGrades()
        {
            var context = _dbContextProvider.GetDbContext();
            return await context.MatDats.Select(x => x.AlloyCode).ToListAsync();
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<DefaultChemistryDto> Update(DefaultChemistryDto dto)
        {
            var context = _dbContextProvider.GetDbContext();
            var entity = await context.MatDats.FirstOrDefaultAsync(x =>
                x.AlloyCode == dto.Alloycode) 
                ?? throw new EntityNotFoundException("Entry for given key not found");

            DefaultChemistryMapper.MapEntity(entity, dto);

            await context.SaveChangesAsync();

            return DefaultChemistryMapper.ToDto(entity);
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<List<DefaultChemistryDto>> UpdateAll(List<DefaultChemistryDto> dtos)
        {

            var context = _dbContextProvider.GetDbContext();
            if (dtos is null || !dtos.Any())
                throw new UserFriendlyException("Input list is empty or null");

            List<DefaultChemistryDto> updatedDtos = new();

            foreach (var dto in dtos)
            {
                // Can't fetch all because LINQ can't translate this query
                //var entitiesToUpdate = await _stdRepository.GetAll()
                //    .Where(entity => keys.Any(key => entity.Planno == key.PlanNo && entity.Activeflag == key.ActiveFlag))
                //    .ToListAsync();

                var entity = await context.MatDats
                    .FirstOrDefaultAsync(x => x.AlloyCode == dto.Alloycode);

                if (entity is null)
                {
                    Logger.Warn($"Entity not found for AlloyCode: {dto.Alloycode}. Skipping update.");
                    continue;
                }

                DefaultChemistryMapper.MapEntity(entity, dto);

                updatedDtos.Add(DefaultChemistryMapper.ToDto(entity));
            }

            await context.SaveChangesAsync();

            return updatedDtos;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(string alloyCode)
        {
            var context = _dbContextProvider.GetDbContext();

            var entity = await context.MatDats
                .FirstOrDefaultAsync(x => x.AlloyCode == alloyCode) 
                ?? throw new EntityNotFoundException("Std for given key not found");

            context.MatDats.Remove(entity);

            await context.SaveChangesAsync();
        }
    }
}
