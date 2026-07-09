using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Json;
using Abp.Runtime.Caching;
using Castle.Core.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebHMI.Events;
using WebHMI.EventWrapper;
using WebHMI.L2Adapter.Dtos;
using WebHMI.L2Adapter.Watchdogs.Dto;
using XIDL;

namespace WebHMI.L2Adapter.Services.EspHmi
{
    public class EspHmi : IEspHmi, ISingletonDependency
    {
        private readonly ILogger _logger;
        private const string _csConfigCacheKey = "csConfigCacheKey";
        private readonly ITypedCache<string, HmiCsConfigData> _csConfigCaches;

        public EspHmi(
            ILogger logger,
            ICacheManager cacheManager)
        {
            _logger = logger;
            _csConfigCaches = cacheManager.GetCache<string, HmiCsConfigData>(nameof(HmiCsConfigData));
        }

        public override void takeOverTrackingData(HmiTrackingData trackingData)
        {
            try
            {
                _logger.Info($"{nameof(takeOverTrackingData)} received data");
                _logger.Debug($"[HsmHmi::takeOverTrackingData]HmiTrackingData:{trackingData.ToJsonString()}");
                _ = EventBus.Default.TriggerAsync(new EventWrapper<HmiTrackingData>() { Data = trackingData });
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HsmHmi::takeOverTrackingData]Failer do take over Tracking data. Error:{ex}");
            }
        }

        public override void takeOverTWMData(HmiTwmData data)
        {
            try
            {
                _logger.Info($"{nameof(takeOverTWMData)} received data");
                _logger.Debug($"[HsmHmi::takeOverTWMData]takeOverTWMData:{data.ToJsonString(new JsonSerializerOptions()
                {
                    NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals,
                    WriteIndented = false,
                })}");

                var dto = new HmiTwmDataDto()
                {
                    PlantType = data.PlantType,
                    TimeStamp = data.Timestamp,
                    Stands = data.Stands.Select(x => new HmiTwmStandDto()
                    {
                        MeCode = new ME_CODEDto()
                        {
                            Actual = new ME_STRUCTDto()
                            {
                                MeCreator = x.MeCode.Actual.MeCreator,
                                MeId = x.MeCode.Actual.MeId,
                                MesId = x.MeCode.Actual.MesId
                            },
                            BasId = x.MeCode.BasId,
                            ExtId = x.MeCode.ExtId,
                            MeTyp = x.MeCode.MeTyp,
                            Original = new ME_STRUCTDto()
                            {
                                MeCreator = x.MeCode.Original.MeCreator,
                                MeId = x.MeCode.Original.MeId,
                                MesId = x.MeCode.Original.MesId
                            }
                        },
                        RollStacks = x.RollStacks.Select(rollStack => new HmiTwmRollStackDto()
                        {
                            RollPos = rollStack.RollPos,
                            Rolls = rollStack.Rolls.Select(rolls => new HmiTwmRollDto()
                            {
                                BarrelLength = rolls.BarrelLength,
                                DiscsArray = rolls.DiscsArray.Select(disc => new HmiTwmSingleDiscDataDto()
                                {
                                    DiscId = disc.DiscId,
                                    TempDistArray = disc.TempDistArray,
                                }).ToList(),
                                MechanicalCrownArray = rolls.MechanicalCrownArray,
                                RolledLength = rolls.RolledLength,
                                RollExist = rolls.RollExist,
                                RollId = rolls.RollId,
                                RollMeanTemp = rolls.RollMeanTemp,
                                RollType = rolls.RollType,
                                Shifting = rolls.Shifting,
                                SummaryTempCrown = rolls.SummaryTempCrown,
                                SummaryTempWearCrown = rolls.SummaryTempWearCrown,
                                SummaryWearCrown = rolls.SummaryWearCrown,
                                TemperatureCrownArray = rolls.TemperatureCrownArray,
                                WearCrownArray = rolls.WearCrownArray
                            }).ToList()
                        }).ToList(),
                        StandId = x.StandId,
                        StripWidth = x.StripWidth
                    }).ToList()
                };

                // Serialization of the dto object takes about 40ms, which causes performance problems, so logging is commented out.
                // The flag _logger.IsDebugEnabled won't work in this case, due to the logger configuration (log4net + various appenders used).
                //_logger.Debug($"[HsmHmi::takeOverTWMData]HmiCsValves:{dto.ToJsonString()}");

                _ = EventBus.Default.TriggerAsync(new EventWrapper<HmiTwmDataDto>() { Data = dto });
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HsmHmi::takeOverTWMData]Failed to take over TWM data. Error:{ex}");
            }
        }

        public override void takeOverCsConfig(HmiCsConfigData configData)
        {
            try
            {
                _logger.Info($"{nameof(takeOverCsConfig)} received data");
                _logger.Debug($"[HsmHmi::takeOverCsConfig]HmiCsConfigData:{configData.ToJsonString()}");
                _csConfigCaches.Set(_csConfigCacheKey, configData);
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HsmHmi::takeOverCsConfig]Failed to take over Cs config. Error:{ex}");
            }
        }

        public override void takeOverCsData(HmiCsValves valveData, HmiCsMeters measuredData, HmiCsStatus[] statuses, HmiTrackingData trackingData, HmiCsCtcData ctcData, HmiCsSliderF4t sliderF4t)
        {
            try
            {
                _logger.Info($"{nameof(takeOverCsData)} received data");
                var eventData = new EventWrapper<CsCappaDataDto>()
                {
                    Data = new CsCappaDataDto()
                    {
                        HmiCsValves = valveData,
                        HmiCsMeters = measuredData,
                        TrackingData = trackingData,
                        Statuses = statuses,
                        CtcData = ctcData,
                        CsF4T = sliderF4t,
                    }
                };
                _ = EventBus.Default.TriggerAsync(eventData);
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HsmHmi::takeOverCsData]Failed to take over CS data. Error:{ex}");
            }
        }
    }
}
