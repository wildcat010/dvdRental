using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Setpoints.SetpointsCS;
using WebHMI.Events;
using WebHMI.EventWrapper;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.Services
{
    public class ValveCalibrationController : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly IL2CommunicationHandler _l2CommunicationHandler;

        public ValveCalibrationController(IDbContextProvider<PrdbContext> dbContextProvider,
            IL2CommunicationHandler l2CommunicationHandler,
            ISignalRNotifier signalRNotifier)
        {
            _dbContextProvider = dbContextProvider;
            _signalRNotifier = signalRNotifier;
            _l2CommunicationHandler = l2CommunicationHandler;
        }

        public async Task<List<ValveTestHeaderDto>> GetValveTestList(short? valveStart, short? valveEnd)
        {
            var context = _dbContextProvider.GetDbContext();
            return await context.CsMaintSequences
                .Where(x => x.ValveStart >= valveStart && x.ValveEnd <= valveEnd)
                .Select(x => new ValveTestHeaderDto()
                {
                    TestTime = x.Toc,
                    MaintenanceId = x.MId,
                    SequenceId = x.Id,
                    ValveGroup = x.ValveGroup,
                    ValveStart = x.ValveStart,
                    ValveEnd = x.ValveEnd
                })
                .OrderByDescending(x => x.TestTime)
                .Take(100)
                .ToListAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<List<ValveTestDetailsDto>> GetValveTestDetails(int m_id, int sq_id)
        {
            var context = _dbContextProvider.GetDbContext();
            return await context.CsMaintSteps
                .Where(x => x.MId == m_id && x.SqId == sq_id)
                .Select(x => new ValveTestDetailsDto()
                {
                    Id = x.Id,
                    SqId = x.SqId,
                    MId = x.MId,
                    Ampldes = x.AmplDes,
                    FlowDesDown = x.FlowDesDown,
                    FlowDesUp = x.FlowDesUp,
                    FlowMeasDown = x.FlowMeasDown,
                    FlowMeasUp = x.FlowMeasUp,
                    FlowObsDown = x.FlowObsDown,
                    FlowObsUp = x.FlowObsUp
                }).ToListAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<List<IdAndHmiCsMainenanceCalibrConfigPair>> GetValveCalibrationAsync()
        {
            var context = _dbContextProvider.GetDbContext();
            return await context.CsCalibrationConfigs.OrderBy(x => x.Id).Select(x =>
            new IdAndHmiCsMainenanceCalibrConfigPair()
            {
                Config = new HmiCsMaintenanceCalibrConfig()
                {
                    AmplStep = x.AmplStep.HasValue ? x.AmplStep.Value : 0,
                    TimeStep = x.TimeStep.HasValue ? x.TimeStep.Value : 0,
                    ValveFirst = x.ValveFirst.HasValue ? x.ValveFirst.Value : (short)0,
                    ValveLast = x.ValveLast.HasValue ? x.ValveLast.Value : (short)0,
                    NoValves = x.NoValves.HasValue ? x.NoValves.Value : (short)0,
                    ValveGroup = x.ValveGroup.HasValue ? x.ValveGroup.Value : (short)0
                },
                Id = x.Id
            }
            ).ToListAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<IdAndHmiCsMainenanceCalibrConfigPair> UpdateValveCalibration(IdAndHmiCsMainenanceCalibrConfigPair input, string connectionId)
        {
            var context = _dbContextProvider.GetDbContext();
            var dbRow = await context.CsCalibrationConfigs.FirstOrDefaultAsync(x => x.Id == input.Id);
            if (dbRow == null)
                context.CsCalibrationConfigs.Add(new CsCalibrationConfig()
                {
                    AmplStep = input.Config.AmplStep,
                    TimeStep = input.Config.TimeStep,
                    ValveFirst = input.Config.ValveFirst,
                    ValveLast = input.Config.ValveLast,
                    NoValves = input.Config.NoValves,
                    ValveGroup = input.Config.ValveGroup,
                });
            else
            {
                dbRow.AmplStep = input.Config.AmplStep;
                dbRow.TimeStep = input.Config.TimeStep;
                dbRow.ValveFirst = input.Config.ValveFirst;
                dbRow.ValveLast = input.Config.ValveLast;
                dbRow.NoValves = input.Config.NoValves;
                dbRow.ValveGroup = input.Config.ValveGroup;
            }
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
        public async Task StartValveCalibrationTest(List<HmiCsMaintenanceCalibrConfig> input)
        {
            _l2CommunicationHandler.startValveCalibration(input.ToArray());
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task StopValveCalibrationTest()
        {
            _l2CommunicationHandler.stopValveCalibration();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<bool> GetValveCalibrationMode()
        {
            bool valveCalibrationMode = false;
            _l2CommunicationHandler.fillValveCalibrationMode(ref valveCalibrationMode);
            return valveCalibrationMode;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task ChangeL2Mode(HmiCsL2ModeEnum mode)
        {
            _l2CommunicationHandler.takeOverL2Mode(mode);
        }
    }
}
