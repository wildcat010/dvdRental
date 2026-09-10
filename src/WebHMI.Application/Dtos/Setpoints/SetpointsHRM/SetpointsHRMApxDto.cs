using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Setpoints.CommonDtos;
using WebHMI.Dtos.Setpoints.CommonDtos.ApxDtos;
using WebHMI.Interface;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class SetpointsHRMApxDto : IAuditLogRelatedIdGetter
    {
        public string GetAuditLogRelatedId()
        {
            return MeCode.GetAuditLogRelatedId();
        }
        public MeCodeDto MeCode { get; set; } = new();
        public List<ApxPassScheduleDto> PassScheduleDtos { get; set; } = new();
        public List<ApxShiftingDto> ShiftingDtos { get; set; } = new();
        public List<ApxFlatnessDto> FlatnessDtos { get; set; } = new();
        public List<TaperShiftingDto> TaperShiftingDtos { get; set; } = new();
        public List<WearFactorDto> WearFactor { get; set; } = new();

    }
}
