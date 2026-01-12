using Abp.UI;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Auditing;
using WebHMI.Helpers;
using Abp.EntityFrameworkCore;
using WebHMI.PRDB;
using WebHMI.Dtos.StretchCurves;

namespace WebHMI.API.Services
{
    public class StretchCurvesAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        public StretchCurvesAppService(IDbContextProvider<PrdbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public async Task<List<StretchCurveHistoryDto>> GetStrechCurvesHistory(short standId, string plantType)
        {
            var context = _dbContextProvider.GetDbContext();

            var dtos = new List<StretchCurveHistoryDto>();
                //await context.pade.GetAll()
                //                .Where(x => x.Standidx == standId && x.Planttype == plantType)
                //                .Select(x =>
                //                new StretchCurveHistoryDto()
                //                {
                //                    No = x.Testnumber,
                //                    RecordingDate = x.Toc,
                //                    CoeffA0 = x.Padea0,
                //                    CoeffA1 = x.Padea1,
                //                    CoeffA2 = x.Padea2,
                //                    CoeffB1 = x.Padeb1,
                //                    MeasType = x.Meastype,
                //                    IsEffective = x.Effective > 0 ? true : false,
                //                    IsReference = x.Reference.HasValue && x.Reference.Value > 0 ? true : false,
                //                })
                //                .ToListAsync();
            return dtos;
        }

        public async Task<StrechCurveData> GetStrechCurvesData(short standId, string plantType, int testNumber, int meastype)
        {
             //var curveData = await _hysteresispointRepo.GetAll()
             //                                    .Where(x => x.Standidx == standId && x.Planttype == plantType
             //                                                && x.Testnumber == testNumber && x.Meastype == meastype)
             //                                    .Select(x => new CurveDataPoints()
             //                                    {
             //                                        Force = x.Force,
             //                                        Dsframeds = x.Dsframeds,
             //                                        Dsframeos = x.Dsframeos,
             //                                        Dsframepade = x.Dsframepade,
             //                                        DsDsDown = x.DsDsDown - x.Dsbcalc,
             //                                        DsDsUp = x.DsDsUp - x.Dsbcalc,
             //                                        DsOsDown = x.DsOsDown - x.Dsbcalc,
             //                                        DsOsUp = x.DsOsUp - x.Dsbcalc,
             //                                    })
             //                                    .ToListAsync();
             return new StrechCurveData()
             {
                 StandIdx = standId,
                 PlantType = plantType,
                 Meastype = meastype,
                 //CurveDataPoints = curveData
             };

        }

        [Audited]
        public void TakeOverStrechCurve(short standId, int curveId, string plantType)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (System.Exception ex)
            {
                Logger.Error($"[MillStretchCurvesService] Cannot Take over Strech Curve:", ex);
                throw new UserFriendlyException($"Cannot Take over Strech Curve: {ex.Message}");
            }
        }
    }
}
