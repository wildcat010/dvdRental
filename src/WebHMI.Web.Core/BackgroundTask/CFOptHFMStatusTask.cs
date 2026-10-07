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
                var mosswitches = await context.MosSwitches.FirstOrDefaultAsync(x => x.RecNo == 0 && x.PlantType == "HFM");

                _statusManager.AddStatus(ConvertMosSwitchToDtoReversed(mosswitches?.StrSwitchesInd06), "LTI", SimpleStatusGroup.Setpoints, 2, "Long Time Inheritance");
                _statusManager.AddStatus(ConvertMosSwitchToDtoReversed(mosswitches?.StrSwitchesInd05), "STI", SimpleStatusGroup.Setpoints, 3, "Short Time Inheritance");

                _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches?.StrSwitchesInd20), "IED", SimpleStatusGroup.CFOpt, 1, "Ignore Edge Drop");
                _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches?.StrSwitchesInd19), "OSH", SimpleStatusGroup.CFOpt, 2, "Wear Optimized Shifting");
                _statusManager.AddStatus(MapPriorityParameter(mosswitches?.StrSwitchesInd34), "PRP", SimpleStatusGroup.CFOpt, 3, "Priority Parameter");
                _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches?.StrSwitchesInd23), "LTI", SimpleStatusGroup.CFOpt, 2, "Long Time Inheritance");

                _statusManager.AddStatus(MapAutomaticBending(mosswitches?.StrSwitchesInd17), "ABE", SimpleStatusGroup.CFOptHRM, 1, "Automatic Bending");
                _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches?.StrSwitchesInd45), "STI", SimpleStatusGroup.CFOptHRM, 3, "Short Time Inheritance");

                _statusManager.AddStatus(MapAutomaticBending(mosswitches?.StrSwitchesInd16), "ABE", SimpleStatusGroup.CFOptFM, 1, "Automatic Bending");
                _statusManager.AddStatus(ConvertMosSwitchToDto(mosswitches?.StrSwitchesInd22), "STI", SimpleStatusGroup.CFOptFM, 2, "Short Time Inheritance");
                //setpoints group (common for HRM and FM)

                var progparam = await context.ProgParameters.Where(x => x.Param == "SETPT_TAKEOVER_MANUAL").FirstOrDefaultAsync();
                if (progparam != null)
                {
                    _statusManager.AddStatus(ConvertProgParamToDto(progparam.ParamNum), "TO", SimpleStatusGroup.Setpoints, 1, "Take Over");
                }
                var progparamCs = await context.ProgParameters.Where(x => x.Param == "SETPT_TAKEOVER_MANUAL").FirstOrDefaultAsync();
                if (progparam != null)
                {
                    _statusManager.AddStatus(ConvertProgParamToDto(progparamCs.ParamNum), "TO", SimpleStatusGroup.SetpointsCs, 1, "Take Over");
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
