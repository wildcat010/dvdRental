using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Events;
using WebHMI.EventWrapper;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.API.Services
{
    public class MainenanceValveCsController : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly IL2CommunicationHandler _l2CommunicationHandler;

        public MainenanceValveCsController(IDbContextProvider<PrdbContext> dbContextProvider, IL2CommunicationHandler l2CommunicationHandler, ISignalRNotifier signalRNotifier)
        {
            _l2CommunicationHandler = l2CommunicationHandler;
            _signalRNotifier = signalRNotifier;
            _dbContextProvider = dbContextProvider;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<HmiCsMaintenanceSequenceConfig> GetTestSpecificValve()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            if (!await context.Csmaintenancevalvestests.AnyAsync())
            {
                context.Csmaintenancevalvestests.Add(new Csmaintenancevalvestest());
                await context.SaveChangesAsync();
            }
            return await context.Csmaintenancevalvestests.Select(x => new HmiCsMaintenanceSequenceConfig()
            {
                ParaStartValve = x.Udsvalvesnofrom.HasValue ? x.Udsvalvesnofrom.Value : (short)0,// 0 or 1 we need to verify it 
                ParaStopValve = x.Udsvalvesnoto.HasValue ? x.Udsvalvesnoto.Value : (short)1,
                ParaValveGroup = x.Udsvalvetype.HasValue ? x.Udsvalvetype.Value : (short)2,
                ParaNoValvesPerStep = x.Udsnovalves.HasValue ? x.Udsnovalves.Value : (short)1,
                ParaSubStepDeltaAmpl = x.Udsstepsize.HasValue ? x.Udsstepsize.Value : 10,
                ParaSubStepTime = x.Udssteptime.HasValue ? x.Udssteptime.Value : 1,
                ParaMaxAmpl = x.Udsmaxamplitude.HasValue ? x.Udsmaxamplitude.Value : 100,
            }).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<HmiCsMaintenanceSequenceConfig> UpdateTestSpecificValve(HmiCsMaintenanceSequenceConfig input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.Csmaintenancevalvestests.SingleOrDefaultAsync();
            dbRow.Udsvalvesnofrom = input.ParaStartValve;
            dbRow.Udsvalvesnoto = input.ParaStopValve;
            dbRow.Udsvalvetype = input.ParaValveGroup;
            dbRow.Udsnovalves = input.ParaNoValvesPerStep;
            dbRow.Udsstepsize = input.ParaSubStepDeltaAmpl;
            dbRow.Udssteptime = input.ParaSubStepTime;
            dbRow.Udsmaxamplitude = input.ParaMaxAmpl;
            await context.SaveChangesAsync();
            var eventData = new EventWrapper<HmiReturnEvent>()
            {
                Data = new HmiReturnEvent()
                {
                    ReturnDto = new WebHMIReturnDto()
                    {
                        Acknowledge = 1,
                        FunctionName = "UpdateMaintenanceWorm",
                        HmiClientId = connectionId,
                        MessageText = "Update sucessfull",
                        Status = 1,
                    },
                    MeCode = null,
                }
            };
            await _signalRNotifier.BroadcastToUserClientAsync(eventData, eventData.Data.ReturnDto.HmiClientId, "HmiReturnData");
            return input;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<HmiCsMaintenanceWormConfig> GetMaintenanceWorm()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            if (!await context.Csmaintenancevalvestests.AnyAsync())
            {
                context.Csmaintenancevalvestests.Add(new Csmaintenancevalvestest());
                await context.SaveChangesAsync();
            }
            return await context.Csmaintenancevalvestests.Select(x => new HmiCsMaintenanceWormConfig()
            {
                ParaAmpl = x.Wormaplitude.HasValue ? x.Wormaplitude.Value : 0,
                ParaNoValvesPerStep = x.Wormnovalves.HasValue ? x.Wormnovalves.Value : (short)0.0,
                ParaStepTime = x.Wormtime.HasValue ? x.Wormtime.Value : 0,
            }).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<HmiCsMaintenanceWormConfig> UpdateMaintenanceWorm(HmiCsMaintenanceWormConfig input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.Csmaintenancevalvestests.SingleOrDefaultAsync();
            dbRow.Wormaplitude = input.ParaAmpl;
            dbRow.Wormnovalves = input.ParaNoValvesPerStep;
            dbRow.Wormtime = input.ParaStepTime;
            await context.SaveChangesAsync();
            var eventData = new EventWrapper<HmiReturnEvent>()
            {
                Data = new HmiReturnEvent()
                {
                    ReturnDto = new WebHMIReturnDto()
                    {
                        Acknowledge = 1,
                        FunctionName = "UpdateMaintenanceWorm",
                        HmiClientId = connectionId,
                        MessageText = "Update sucessfull",
                        Status = 1,
                    },
                    MeCode = null,
                }
            };
            await _signalRNotifier.BroadcastToUserClientAsync(eventData, eventData.Data.ReturnDto.HmiClientId, "HmiReturnData");
            return input;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<HmiCsMaintenanceManualConfig> GetManualTest()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            if (!await context.Csmaintenancevalvestests.AnyAsync())
            {
                context.Csmaintenancevalvestests.Add(new Csmaintenancevalvestest());
                await context.SaveChangesAsync();
            }
            return await context.Csmaintenancevalvestests.Select(x => new HmiCsMaintenanceManualConfig()
            {
                ManuAmplTop = x.Manualamplitudetop.HasValue ? (short)x.Manualamplitudetop.Value : (short)0.0,
                ManuAmplBot = x.Manualamplitudebot.HasValue ? (short)x.Manualamplitudebot.Value : (short)0.0,
            }).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<HmiCsMaintenanceManualConfig> UpdateManualTest(HmiCsMaintenanceManualConfig input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.Csmaintenancevalvestests.SingleOrDefaultAsync();
            dbRow.Manualamplitudetop = input.ManuAmplTop;
            dbRow.Manualamplitudebot = input.ManuAmplBot;
            await context.SaveChangesAsync();
            var eventData = new EventWrapper<HmiReturnEvent>()
            {
                Data = new HmiReturnEvent()
                {
                    ReturnDto = new WebHMIReturnDto()
                    {
                        Acknowledge = 1,
                        FunctionName = "UpdateManualTest",
                        HmiClientId = connectionId,
                        MessageText = "Update sucessfull",
                        Status = 1,
                    },
                    MeCode = null,
                }
            };
            await _signalRNotifier.BroadcastToUserClientAsync(eventData, eventData.Data.ReturnDto.HmiClientId, "HmiReturnData");
            return input;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<short> GetWormPowerCooling()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            if (!await context.Csmaintenancevalvestests.AnyAsync())
            {
                context.Csmaintenancevalvestests.Add(new Csmaintenancevalvestest());
                await context.SaveChangesAsync();
            }
            return await context.Csmaintenancevalvestests.Select(x => x.Wpcpressuredesired.HasValue ? x.Wpcpressuredesired.Value : (short)0.0).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<short> UpdateWormPowerCooling(short input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.Csmaintenancevalvestests.SingleOrDefaultAsync();
            dbRow.Manualamplitudetop = input;
            await context.SaveChangesAsync();
            var eventData = new EventWrapper<HmiReturnEvent>()
            {
                Data = new HmiReturnEvent()
                {
                    ReturnDto = new WebHMIReturnDto()
                    {
                        Acknowledge = 1,
                        FunctionName = "UpdateManualTest",
                        HmiClientId = connectionId,
                        MessageText = "Update sucessfull",
                        Status = 1,
                    },
                    MeCode = null,
                }
            };
            await _signalRNotifier.BroadcastToUserClientAsync(eventData, eventData.Data.ReturnDto.HmiClientId, "HmiReturnData");
            return input;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StartMaintenanceWormTest(HmiCsMaintenanceWormConfig input)
        {
            _l2CommunicationHandler.StartMaintainanceWorm(input);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StopMaintenanceWormTest()
        {
            _l2CommunicationHandler.StopMaintainanceWorm();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StartWormPowerCoolingTest(double input)
        {
            _l2CommunicationHandler.StartMaintainanceWormPowerCooling(new HmiCsMaintenanceWormConfig(), input, -1);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StopWormPowerCoolingTest()
        {
            _l2CommunicationHandler.StopMaintainanceWormPowerCooling();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StartWaterTest1Test(short testId)
        {
            _l2CommunicationHandler.StartMaintainanceWaterTest(testId);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StopWaterTest1Test(short testId)
        {
            _l2CommunicationHandler.StopMaintainanceWaterTest(testId);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StartManualTestTest(HmiCsMaintenanceManualConfig input)
        {
            _l2CommunicationHandler.StartMaintainanceManualTest(input);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StopManualTestTest()
        {
            _l2CommunicationHandler.StopMaintainanceManualTest();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StartTestSpecificValveTest(HmiCsMaintenanceSequenceConfig input)
        {
            _l2CommunicationHandler.StartTestSpecificValves(input);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StopTestSpecificValveTest()
        {
            _l2CommunicationHandler.StopTestSpecificValves();
        }
    }
}
