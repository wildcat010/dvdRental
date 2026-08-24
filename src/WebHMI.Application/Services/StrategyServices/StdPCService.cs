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
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Numerics;
using System.Threading.Tasks;
using WebHMI.Dtos.Limit;
using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.PRDB.Dbo.Interfaces;

namespace WebHMI.Services.StrategyServices
{
    public class StdPCService: ApplicationServiceBase
      
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        public string AggregateName { get; set; }

        public StdPCService(string aggregateName = "FmPowerCoolingPlan")
        {
            AggregateName = aggregateName;
            _dbContextProvider = IocManager.Instance.ResolveAsDisposable<IDbContextProvider<PrdbContext>>().Object;
           
        }

        [UnitOfWork(isTransactional: true)] 
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<StdPowerCoolingDto> Create(StdPowerCoolingDto input)
        {
           ValidateInput(input);

           var context = _dbContextProvider.GetDbContext();

           bool rampsExist = await context.StdPcs.AnyAsync(x =>x.PlanNo == input.PlanNo);

            if (rampsExist) throw new EntityNotFoundException("Plan already exists for given key");

            //create definition

            StdPc stdPc = new StdPc();
            stdPc.ActiveFlag = 1;
            stdPc.PlanNo = input.PlanNo;
            stdPc.Description = input.Description;
            stdPc.NoRamps = input.NoRamps;
            stdPc.DelayLength = 0.0;

            await context.AddRangeAsync(stdPc);

            //for each ramp
            int idx = 0;
            foreach (StdPowerCoolingRampDto r in input.Ramps)
            {
                StdPcramp stdPcramp = new StdPcramp();
                stdPcramp.PlanNo = input.PlanNo;
                stdPcramp.ActiveFlag = 1;
                stdPcramp.RampNo = idx++;
                stdPcramp.PcRampState = r.Pcrampstate;
                stdPcramp.PcRampAuto = r.Pcrampauto;
                stdPcramp.PcRampVolumeInd0 = r.PcRampVolumeInd0;
                stdPcramp.PcRampVolumeInd1 = r.PcRampVolumeInd1;
                stdPcramp.PrioPowerC = r.Priopowerc;
                await context.AddRangeAsync(stdPcramp);
            }

            await context.SaveChangesAsync();


            return input;
        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<StdPowerCoolingDto> Get(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();
            //get PC header data and add to DTO
            var pcHeader = await context.StdPcs.Where(x =>
               x.PlanNo == planNo && x.ActiveFlag == 1)
               .FirstOrDefaultAsync();

            if (pcHeader == null) throw new UserFriendlyException("Power cooling plan not found");
            StdPowerCoolingDto result = new StdPowerCoolingDto();
            result.PlanNo = pcHeader.PlanNo;
            result.Description = pcHeader.Description;
            result.NoRamps = pcHeader.NoRamps ?? -1;
            result.ActiveFlag = pcHeader.ActiveFlag;
            result.AssignmentsCount = -1;
            result.LastModified = pcHeader.Tom;

            //get PC ramps data and add to DTO

            var ramps = await context.StdPcramps.Where(x =>
                x.PlanNo == planNo).OrderBy(o => o.RampNo)
                .ToListAsync();

            foreach (var ramp in ramps)
            {
                StdPowerCoolingRampDto r = new StdPowerCoolingRampDto();
                r.rampNo = ramp.RampNo;
                r.Pcrampauto = ramp.PcRampAuto;
                r.Pcrampstate = ramp.PcRampState;
                r.Priopowerc = ramp.PrioPowerC;
                r.PcRampVolumeInd0 = ramp.PcRampVolumeInd0;
                r.PcRampVolumeInd1 = ramp.PcRampVolumeInd1;

                result.Ramps.Add(r);
            }

            return result;

        }

        [AbpAuthorize(Permissions.Pages_Strategies)]
        public async Task<PagedResultDto<StdItemDto>> GetAvailablePlans(StdFilteredRequestDto input)
        {
            var context = _dbContextProvider.GetDbContext();
            var query = context.StdPcs.AsQueryable().Where(x => x.ActiveFlag == 1);

            if (input.NotAssignedPlans)
            {
                var usedPlanNumbers = await context.AggregateSelections
                    .Where(x => x.Aggregate == AggregateName)
                    .Select(x => new { x.PlanNoInd0, x.PlanNoInd1, x.PlanNoInd2, x.PlanNoInd3 })
                    .ToArrayAsync();

                var usedUniquePlanNumbers = usedPlanNumbers
                    .SelectMany(x => new[] { x.PlanNoInd0, x.PlanNoInd1, x.PlanNoInd2, x.PlanNoInd3 })
                    .Distinct()
                    .Where(x => x.HasValue);

                query = query.Where(x => !usedUniquePlanNumbers.Contains(x.PlanNo));
            }

            return await ApplyFilterRamp(query.OrderBy(x => x.PlanNo), input, MapItem);

            StdItemDto MapItem(StdPc entity) => new()
            {
                PlanNo = entity.PlanNo,
                ActiveFlag = entity.ActiveFlag,
                Description = entity.Description,
                LastModified = entity.Tom
            };
        }

       

        [UnitOfWork(isTransactional: true)] // either std + passes or none
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Edit)]
        public async Task<StdPowerCoolingDto> Update(StdPowerCoolingDto input)
        {
            ValidateInput(input);

            var context = _dbContextProvider.GetDbContext();

            //check if records exist in DB
            var pcHeader = await context.StdPcs.Where(x =>
            x.PlanNo == input.PlanNo && x.ActiveFlag == 1)
            .FirstOrDefaultAsync();

           
            if (pcHeader == null)
                throw new UserFriendlyException($"Plan {input.PlanNo} not found in database");

            var pcRamps = await context.StdPcramps.Where(x =>
            x.PlanNo == input.PlanNo && x.ActiveFlag == 1).OrderBy( o=>o.RampNo)
            .ToListAsync();

            if (pcRamps == null) throw new UserFriendlyException($"Plan {input.PlanNo} has no ramp data");
            if (pcRamps.Count != 2) throw new UserFriendlyException($"Plan {input.PlanNo} has invalid number of ramp data (expected 2, got {pcRamps.Count})");

            pcHeader.Description = input.Description;
            context.StdPcs.Update(pcHeader);

            int idx = 0;
            foreach (StdPowerCoolingRampDto r in input.Ramps)
            {
                pcRamps[idx].PcRampState = r.Pcrampstate;
                pcRamps[idx].PcRampVolumeInd0 = r.PcRampVolumeInd0;
                pcRamps[idx].PcRampVolumeInd1 = r.PcRampVolumeInd1;
                pcRamps[idx].PrioPowerC = r.Priopowerc;
                pcRamps[idx].PcRampAuto = r.Pcrampauto;
                pcRamps[idx].RampNo  = r.rampNo;
                context.StdPcramps.Update(pcRamps[idx]);
                idx++;  
            }
            await context.SaveChangesAsync();         
            return input;
        }

 

        [UnitOfWork(isTransactional: true)]
        [Audited]
        [AbpAuthorize(Permissions.Pages_Strategies_Delete)]
        public async Task Delete(int planNo)
        {
            var context = _dbContextProvider.GetDbContext();

            await context.StdPcs.Where(x => x.PlanNo == planNo && x.PlanNo != 0).ExecuteDeleteAsync();
            await context.StdPcramps.Where(x => x.PlanNo == planNo && x.PlanNo != 0).ExecuteDeleteAsync();

            await context.SaveChangesAsync();
        }

        private static void ValidateInput(StdPowerCoolingDto input)
        {
            if (input == null) { throw new UserFriendlyException("Input data missing"); }
            if (input.NoRamps != 2 && input.Ramps.Count != 2) { throw new UserFriendlyException("Expected 2 ramps, check provided data"); }
        }

    }
}
