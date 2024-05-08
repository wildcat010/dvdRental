using System.Collections.Generic;

namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmDto
    {
        public MeCodeDto MeCode { get; set; }
        public SetpointsRmPlans Plans { get; set; }
        public List<SetpointsRmSingleStand> Stands { get; set; } = [];
    }
}