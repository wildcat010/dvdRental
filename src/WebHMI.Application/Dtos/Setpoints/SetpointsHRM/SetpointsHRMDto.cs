using System.Collections.Generic;
using WebHMI.Dtos.Setpoints.CommonDtos;
using WebHMI.Interface;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class SetpointsHRMDto : IAuditLogRelatedIdGetter
    {
        public string GetAuditLogRelatedId()
        {
            return MeCode.GetAuditLogRelatedId();
        }
        public MeCodeDto MeCode { get; set; }
        public List<PassScheduleDto> PassScheduleDtos { get; set; } = new();
        public EdgerDto EdgerDto { get; set; } = new();
        public List<LoadingDto> LoadingDtos { get; set; } = new();
        public List<AntiPeelingDto> AntiPeelingDtos { get; set; } = new();
        public List<WorkCoolingDto> WorkCoolingDtos { get; set; } = new();
        public List<TensionDto> TensionDtos { get; set; } = new();
        public List<TaperShiftingDto> TaperShiftingDtos { get; set; } = new();
        public DescalingDto Descaling { get; set; } = new();
        public LubricationDto Lubrication { get; set; } = new();

    }
}
