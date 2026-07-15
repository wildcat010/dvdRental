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
            if (!await context.CsMaintenanceValvesTests.AnyAsync())
            {
                context.CsMaintenanceValvesTests.Add(new CsMaintenanceValvesTest());
                await context.SaveChangesAsync();
            }
            return await context.CsMaintenanceValvesTests.Select(x => new HmiCsMaintenanceSequenceConfig()
            {
                ParaStartValve = x.UdsvalvesNoFrom.HasValue ? x.UdsvalvesNoFrom.Value : (short)0,// 0 or 1 we need to verify it 
                ParaStopValve = x.UdsvalvesNoTo.HasValue ? x.UdsvalvesNoTo.Value : (short)1,
                ParaValveGroup = x.UdsvalveType.HasValue ? x.UdsvalveType.Value : (short)2,
                ParaNoValvesPerStep = x.UdsnoValves.HasValue ? x.UdsnoValves.Value : (short)1,
                ParaSubStepDeltaAmpl = x.UdsstepSize.HasValue ? x.UdsstepSize.Value : 10,
                ParaSubStepTime = x.UdsstepTime.HasValue ? x.UdsstepTime.Value : 1,
                ParaMaxAmpl = x.UdsmaxAmplitude.HasValue ? x.UdsmaxAmplitude.Value : 100,
            }).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<HmiCsMaintenanceSequenceConfig> UpdateTestSpecificValve(HmiCsMaintenanceSequenceConfig input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.CsMaintenanceValvesTests.SingleOrDefaultAsync();
            dbRow.UdsvalvesNoFrom = input.ParaStartValve;
            dbRow.UdsvalvesNoTo = input.ParaStopValve;
            dbRow.UdsvalveType = input.ParaValveGroup;
            dbRow.UdsnoValves = input.ParaNoValvesPerStep;
            dbRow.UdsstepSize = input.ParaSubStepDeltaAmpl;
            dbRow.UdsstepTime = input.ParaSubStepTime;
            dbRow.UdsmaxAmplitude = input.ParaMaxAmpl;
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
            if (!await context.CsMaintenanceValvesTests.AnyAsync())
            {
                context.CsMaintenanceValvesTests.Add(new CsMaintenanceValvesTest());
                await context.SaveChangesAsync();
            }
            return await context.CsMaintenanceValvesTests.Select(x => new HmiCsMaintenanceWormConfig()
            {
                ParaAmpl = x.WormAplitude.HasValue ? x.WormAplitude.Value : 0,
                ParaNoValvesPerStep = x.WormNoValves.HasValue ? x.WormNoValves.Value : (short)0.0,
                ParaStepTime = x.WormTime.HasValue ? x.WormTime.Value : 0,
            }).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<HmiCsMaintenanceWormConfig> UpdateMaintenanceWorm(HmiCsMaintenanceWormConfig input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.CsMaintenanceValvesTests.SingleOrDefaultAsync();
            dbRow.WormAplitude = input.ParaAmpl;
            dbRow.WormNoValves = input.ParaNoValvesPerStep;
            dbRow.WormTime = input.ParaStepTime;
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
            if (!await context.CsMaintenanceValvesTests.AnyAsync())
            {
                context.CsMaintenanceValvesTests.Add(new CsMaintenanceValvesTest());
                await context.SaveChangesAsync();
            }
            return await context.CsMaintenanceValvesTests.Select(x => new HmiCsMaintenanceManualConfig()
            {
                ManuAmplTop = x.ManualAmplitudeTop.HasValue ? (short)x.ManualAmplitudeTop.Value : (short)0.0,
                ManuAmplBot = x.ManualAmplitudeBot.HasValue ? (short)x.ManualAmplitudeBot.Value : (short)0.0,
            }).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<HmiCsMaintenanceManualConfig> UpdateManualTest(HmiCsMaintenanceManualConfig input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.CsMaintenanceValvesTests.SingleOrDefaultAsync();
            dbRow.ManualAmplitudeTop = input.ManuAmplTop;
            dbRow.ManualAmplitudeBot = input.ManuAmplBot;
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
            if (!await context.CsMaintenanceValvesTests.AnyAsync())
            {
                context.CsMaintenanceValvesTests.Add(new CsMaintenanceValvesTest());
                await context.SaveChangesAsync();
            }
            return await context.CsMaintenanceValvesTests.Select(x => x.WpcPressureDesired.HasValue ? x.WpcPressureDesired.Value : (short)0.0).SingleOrDefaultAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        [UnitOfWork]
        public async Task<short> UpdateWormPowerCooling(short input, string connectionId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dbRow = await context.CsMaintenanceValvesTests.SingleOrDefaultAsync();
            dbRow.ManualAmplitudeTop = input;
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

