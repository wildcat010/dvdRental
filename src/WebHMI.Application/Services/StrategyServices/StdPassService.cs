using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy;
using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Helpers;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo.Interfaces;

namespace WebHMI.Services.StrategyServices
{
    public abstract class StdPassService<TEntity, TDto, TPassEntity, TPassDto> : ApplicationServiceBase
        where TEntity : class, IStd, new()
        where TDto : StdItemDto, new()
        where TPassEntity : class, IPassStd, new()
        where TPassDto : StdPassDto, new()
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly StdService<TEntity, TDto> _stdService;

        private readonly Func<TPassEntity, TPassDto> _toDto;
        private readonly Action<TPassEntity, TPassDto> _mapEntity;

        public abstract string AggregateName { get; }

        public StdPassService(
            Func<TEntity, TDto> toDto,
            Action<TEntity, TDto> mapEntity,
            Func<TPassEntity, TPassDto> toPassDto,
            Action<TPassEntity, TPassDto> mapPassEntity)
        {
            _dbContextProvider = IocManager.Instance.ResolveAsDisposable<IDbContextProvider<PrdbContext>>().Object;
            _stdService = new StdService<TEntity, TDto>(toDto, mapEntity);
            //_stdService.UnitOfWorkManager = IocManager.Instance.ResolveAsDisposable<IUnitOfWorkManager>().Object;
            _stdService.AggregateName = AggregateName;
            _stdService.IsLastService = false;

            _toDto = toPassDto;
            _mapEntity = mapPassEntity;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<StdPassSetsDto<TDto, TPassDto>> Create(StdPassSetsDto<TDto, TPassDto> input)
        {
            ValidateInput(input);

            var context = _dbContextProvider.GetDbContext();

            input.Std.Nodes = (short)input.PassSets.StdPasses.Count();
            var std = await _stdService.Create(input.Std);

            bool passesExist = await context.Set<TPassEntity>().AnyAsync(x =>
                x.PlanNo == input.PassSets.PlanNo);

            if (passesExist)
                throw new EntityNotFoundException("Passes already exist for given key");

            var passes = new List<TPassEntity>();

            if (input.PassSets.StdPasses.Count == 0)
                passes.Add(new TPassEntity() { PassNo = 0, PlanNo = input.Std.PlanNo });

            foreach (var pass in input.PassSets.StdPasses)
            {
                var entity = new TPassEntity();
                _mapEntity(entity, pass);
                passes.Add(entity);
            }

            await context.Set<TPassEntity>().AddRangeAsync(passes);

            await context.SaveChangesAsync();
            var result = new StdPassSetsDto<TDto, TPassDto>()
            {
                Std = std,
                PassSets = new StdPassSetDto<TPassDto>
                {
                    PlanNo = input.PassSets.PlanNo,
                    StdPasses = passes.Select(x => _toDto(x))
                        .OrderBy(x => x.PassNo)
                        .ToList()
                }
            };

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<StdPassSetsDto<TDto, TPassDto>> Get(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            var passes = await context.Set<TPassEntity>().Where(x =>
                x.PlanNo == planNo  && x.ActiveFlag == 1)
                .ToListAsync();

            return new StdPassSetsDto<TDto, TPassDto>()
            {
                Std = await _stdService.Get(planNo),
                PassSets = new StdPassSetDto<TPassDto>
                {
                    PlanNo = planNo,
                    StdPasses = passes.Select(x => _toDto(x))
                        .OrderBy(x => x.PassNo)
                        .ToList()
                }
            };
        }

        /// <inheritdoc cref="StdService{TEntity, TPrimaryKey, TDto}.GetAvailablePlans(StdFilteredRequestDto)" />
        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<PagedResultDto<StdItemDto>> GetAvailablePlans(StdFilteredRequestDto input)
        {
            return await _stdService.GetAvailablePlans(input);
        }

        //[AbpAuthorize(Permissions.Pages_Strategies)]
        //public async Task<PagedResultDto<StdItemDto>> GetAssignablePlans(StdFilteredRequestDto input)
        //{
        //    return await _stdService.GetAssignablePlans(input);
        //}

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<StdPassKeySetDto<TDto, TPassDto>> GetAll()
        {
            var context = _dbContextProvider.GetDbContext();
            var passes = await context.Set<TPassEntity>()
                .OrderBy(x => x.PassNo)
                .ToListAsync();

            var result = new StdPassKeySetDto<TDto, TPassDto>();

            foreach (var pass in passes)
            {
                var passDto = _toDto(pass);

                var keyPassSet = result.StdKeyPassSets.FirstOrDefault(x => x.PlanNo == pass.PlanNo);
                if (keyPassSet is null)
                {
                    var newSet = new StdPassSetDto<TPassDto>
                    {
                        PlanNo = pass.PlanNo,
                        StdPasses = new List<TPassDto>() { passDto }
                    };

                    result.StdKeyPassSets.Add(newSet);
                }
                else
                {
                    keyPassSet.StdPasses.Add(passDto);
                }
            }

            var stdDtos = await _stdService.GetAll();
            result.Stds = stdDtos.Stds;

            return result;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<StdPassSetsDto<TDto, TPassDto>> Update(StdPassSetsDto<TDto, TPassDto> input)
        {
            ValidateInput(input);

            if (input.PassSets.StdPasses.Count < 1)
                throw new UserFriendlyException("Strategy need to have at least one node");

            var context = _dbContextProvider.GetDbContext();
            context.Set<TPassEntity>().RemoveRange(context.Set<TPassEntity>().Where(x =>
                x.PlanNo == input.PassSets.PlanNo && x.ActiveFlag == 1).ToList());

            await context.SaveChangesAsync();

            var passes = new List<TPassEntity>();

            for (int i = 0; i < input.PassSets.StdPasses.Count; i++)
            //foreach (var dto in input.PassSets.StdPasses)
            {
                var dto = input.PassSets.StdPasses[i];
                dto.PassNo = i;
                var entity = new TPassEntity();
                _mapEntity(entity, dto);
                passes.Add(entity);
            }

            await context.Set<TPassEntity>().AddRangeAsync(passes);

            await context.SaveChangesAsync();

            var result = new StdPassSetsDto<TDto, TPassDto>()
            {
                Std = await _stdService.Update(input.Std),
                PassSets = new StdPassSetDto<TPassDto>
                {
                    PlanNo = input.PassSets.PlanNo,
                    StdPasses = passes.Select(x => _toDto(x))
                        .OrderBy(x => x.PassNo)
                        .ToList()
                }
            };

            return result;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<List<StdPassSetsDto<TDto, TPassDto>>> UpdateAll(List<StdPassSetsDto<TDto, TPassDto>> inputs)
        {
            var context = _dbContextProvider.GetDbContext();
            List<StdPassSetsDto<TDto, TPassDto>> updatedDtos = new();

            foreach (var input in inputs)
            {
                ValidateInput(input);

                context.Set<TPassEntity>().RemoveRange(context.Set<TPassEntity>().Where(x =>
                    x.PlanNo == input.PassSets.PlanNo && x.ActiveFlag == 1).ToList());

                var passes = new List<TPassEntity>();

                foreach (var dto in input.PassSets.StdPasses)
                {
                    var entity = new TPassEntity();
                    _mapEntity(entity, dto);
                    passes.Add(entity);
                }

                await context.Set<TPassEntity>().AddRangeAsync(passes);

                var result1 = new StdPassSetsDto<TDto, TPassDto>()
                {
                    Std = await _stdService.Update(input.Std),
                    PassSets = new()
                    {
                        PlanNo = input.PassSets.PlanNo,
                        StdPasses = passes.Select(x => _toDto(x))
                            .OrderBy(x => x.PassNo)
                            .ToList()
                    }
                };

                updatedDtos.Add(result1);
            }

            await context.SaveChangesAsync();

            return updatedDtos;
        }

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            await _stdService.Delete(planNo);

            context.Set<TPassEntity>().RemoveRange(context.Set<TPassEntity>().Where(x =>
                x.PlanNo == planNo && x.ActiveFlag == 1).ToList());

            await context.SaveChangesAsync();
        }

        /// <inheritdoc cref="StdService{TEntity, TPrimaryKey, TDto}.IsStdKeyValid(StdKeyDto)" />
        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<bool> IsStdKeyValid(int planNo)
        {
            return await _stdService.IsStdKeyValid(planNo);
        }

        private static void ValidateInput(StdPassSetsDto<TDto, TPassDto> input)
        {
            if (input.Std.PlanNo != input.PassSets.PlanNo)
                throw new UserFriendlyException("Std and passes keys don't match");

            foreach (var pass in input.PassSets.StdPasses)
            {
                if (pass.PlanNo != input.PassSets.PlanNo)
                {
                    string msg = $"Pass with key '{nameof(input.PassSets.PlanNo)} = {pass.PlanNo} does not match the key";
                    throw new UserFriendlyException(msg);
                }
            }

            var passNos = input.PassSets.StdPasses.Select(x => x.PassNo).ToList();
            bool arePassesUnique = passNos.Distinct().Count() == passNos.Count();
            if (!arePassesUnique)
                throw new UserFriendlyException("Pass numbers must be unique");
        }
    }
}
