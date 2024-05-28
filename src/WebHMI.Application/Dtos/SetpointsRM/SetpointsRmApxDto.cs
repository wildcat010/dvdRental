using System.Collections.Generic;

namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmApxDto
    {
        public MeCodeDto MeCode { get; set; }
        public SetpointsRmApxPlans Plans { get; set; } = new();
        public List<SetpointsRmApxSingleStand> Stands { get; set; } = [];
    }
}