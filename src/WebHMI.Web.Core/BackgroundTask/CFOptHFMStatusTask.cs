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
    public class CFOptHFMStatusTask : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly StatusManager _statusManager;

        public CFOptHFMStatusTask(AbpTimer timer, StatusManager statusManager, IDbContextProvider<PrdbContext> dbContextProvider)
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
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd34), "PRP", SimpleStatusGroup.CFOptHFM, 1);
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd23), "LTI", SimpleStatusGroup.CFOptHFM, 2);
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd22), "STI", SimpleStatusGroup.CFOptHFM, 3);
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd20), "IED", SimpleStatusGroup.CFOptHFM, 4);
                    _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd19), "OSH", SimpleStatusGroup.CFOptHFM, 5);
                    //setpoints group (common for HRM and FM)
                    _statusManager.AddStatus(ConvertMosSwitchToDtoReversed(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd05), "LTI", SimpleStatusGroup.Setpoints, 2);
                    _statusManager.AddStatus(ConvertMosSwitchToDtoReversed(mosswitches.FirstOrDefault(m => m.PlantType == "HFM")?.StrSwitchesInd06), "STI", SimpleStatusGroup.Setpoints, 3);

                }

                var progparam  = await context.ProgParameters.Where(x => x.Param == "SETPT_TAKEOVER_MANUAL").FirstOrDefaultAsync(); 
                if (progparam != null)
                {
                    _statusManager.AddStatus(ConvertProgParamToDto(progparam.ParamNum), "TO", SimpleStatusGroup.Setpoints, 1);
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
            if (((int)par) == 0)
                return OveralStateDto.Off;
            if (((int)par) == 1)
                return OveralStateDto.On;
            return OveralStateDto.UNKNOWN;
        }

        private OveralStateDto ConvertMosSwitchToDtoReversed(int? par)
        {
            if (par is null)
                return OveralStateDto.UNKNOWN;
            if (((int)par) == 0)
                return OveralStateDto.On;
            if (((int)par) == 1)
                return OveralStateDto.Off;
            return OveralStateDto.UNKNOWN;
        }

        private OveralStateDto ConvertProgParamToDto(double? par)
        {
            if (par is null)
                return OveralStateDto.UNKNOWN;
            if (par == 0)
                return OveralStateDto.Off;
            if (par == 1)
                return OveralStateDto.On;
            return OveralStateDto.UNKNOWN;
        }

    }
}
