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
            return await context.CsmaintSequences
                .Where(x => x.Valvestart >= valveStart && x.Valveend <= valveEnd)
                .Select(x => new ValveTestHeaderDto()
                {
                    TestTime = x.Toc,
                    MaintenanceId = x.MId,
                    SequenceId = x.Id,
                    ValveGroup = x.Valvegroup,
                    ValveStart = x.Valvestart,
                    ValveEnd = x.Valveend
                })
                .OrderByDescending(x => x.TestTime)
                .Take(100)
                .ToListAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<List<ValveTestDetailsDto>> GetValveTestDetails(int m_id, int sq_id)
        {
            var context = _dbContextProvider.GetDbContext();
            return await context.CsmaintSteps
                .Where(x => x.MId == m_id && x.SqId == sq_id)
                .Select(x => new ValveTestDetailsDto()
                {
                    Id = x.Id,
                    SqId = x.SqId,
                    MId = x.MId,
                    Ampldes = x.Ampldes,
                    FlowDesDown = x.Flowdesdown,
                    FlowDesUp = x.Flowdesup,
                    FlowMeasDown = x.Flowmeasdown,
                    FlowMeasUp = x.Flowmeasup,
                    FlowObsDown = x.Flowobsdown,
                    FlowObsUp = x.Flowobsup
                }).ToListAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<List<IdAndHmiCsMainenanceCalibrConfigPair>> GetValveCalibrationAsync()
        {
            var context = _dbContextProvider.GetDbContext();
            return await context.Cscalibrationconfigs.OrderBy(x => x.Id).Select(x =>
            new IdAndHmiCsMainenanceCalibrConfigPair()
            {
                Config = new HmiCsMaintenanceCalibrConfig()
                {
                    AmplStep = x.Amplstep.HasValue ? x.Amplstep.Value : 0,
                    TimeStep = x.Timestep.HasValue ? x.Timestep.Value : 0,
                    ValveFirst = x.Valvefirst.HasValue ? x.Valvefirst.Value : (short)0,
                    ValveLast = x.Valvelast.HasValue ? x.Valvelast.Value : (short)0,
                    NoValves = x.Novalves.HasValue ? x.Novalves.Value : (short)0,
                    ValveGroup = x.Valvegroup.HasValue ? x.Valvegroup.Value : (short)0
                },
                Id = x.Id
            }
            ).ToListAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<IdAndHmiCsMainenanceCalibrConfigPair> UpdateValveCalibration(IdAndHmiCsMainenanceCalibrConfigPair input, string connectionId)
        {
            var context = _dbContextProvider.GetDbContext();
            var dbRow = await context.Cscalibrationconfigs.FirstOrDefaultAsync(x => x.Id == input.Id);
            if (dbRow == null)
                context.Cscalibrationconfigs.Add(new Cscalibrationconfig()
                {
                    Amplstep = input.Config.AmplStep,
                    Timestep = input.Config.TimeStep,
                    Valvefirst = input.Config.ValveFirst,
                    Valvelast = input.Config.ValveLast,
                    Novalves = input.Config.NoValves,
                    Valvegroup = input.Config.ValveGroup,
                });
            else
            {
                dbRow.Amplstep = input.Config.AmplStep;
                dbRow.Timestep = input.Config.TimeStep;
                dbRow.Valvefirst = input.Config.ValveFirst;
                dbRow.Valvelast = input.Config.ValveLast;
                dbRow.Novalves = input.Config.NoValves;
                dbRow.Valvegroup = input.Config.ValveGroup;
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
