using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.API.Prdb;
using WebHMI.Dtos;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.Status;
using WebHMI.WebHMI;

namespace WebHMI.API.BackgroundTask
{
    public class CFOptHRMStatusTask : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly StatusManager _statusManager;

        public CFOptHRMStatusTask(AbpTimer timer, StatusManager statusManager, IDbContextProvider<PrdbContext> dbContextProvider)
            : base(timer)
        {
            _prdbContextProvider = dbContextProvider;
            _statusManager = statusManager;
            Timer.Period = 5000;
        }

        protected override void DoWork()
        {
            GetStatus().GetAwaiter().GetResult();
        }

        [UnitOfWork]
        public virtual async Task GetStatus()
        {
            try
            {
                var context = await _prdbContextProvider.GetDbContextAsync();
                var mosswitches = await context.MosSwitches.Where(x => x.RecNo == 0).ToListAsync();

                if (mosswitches.Any())
                {
                    _statusManager.AddStatus(MapAutomaticBending(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd17), "ABE", SimpleStatusGroup.CFOptHRM, 1, "Automatic Bending");                    
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd20), "IED", SimpleStatusGroup.CFOpt, 1, "Ignore Edge Drop");
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd19), "OSH", SimpleStatusGroup.CFOpt, 2, "Wear Optimized Shifting");
                    _statusManager.AddStatus(MapPriorityParameter(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd34), "PRP", SimpleStatusGroup.CFOpt, 3, "Priority Parameter");

                }
                
            }
            catch (Exception ex)
            {
                Logger.Error("RM tatus error", ex);
            }
        }

        private OveralStateDto ConvertMosSwitchToDto(int? par)
        {
            if (par is null)
                return OveralStateDto.UNKNOWN;
            if (par == 0)
                return OveralStateDto.Off;
            if (par == 1)  
                return OveralStateDto.On;
            return OveralStateDto.UNKNOWN;
        }

        private OveralStateDto MapPriorityParameter(int? par)
        {
            if (par is null)
                return OveralStateDto.UNKNOWN;
            if (par == 0)
                return OveralStateDto.Flatness;
            if (par == 1)
                return OveralStateDto.Profile;
            return OveralStateDto.UNKNOWN;
        }

        private OveralStateDto MapAutomaticBending(int? par)
        {
            if (par is null)
                return OveralStateDto.UNKNOWN;
            if (par == 0)
                return OveralStateDto.Manual;
            if (par == 1)
                return OveralStateDto.Model;
            return OveralStateDto.UNKNOWN;
        }
    }
}
