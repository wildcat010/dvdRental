using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Status
{
    public class SimpleStatusDto
    {
        public OveralStateDto State { get; set; }
        public string Label { get; set; }
        public string AddInfo { get; set; }
        public DateTime LastStatusChangeTs { get; set; }
        public SimpleStatusGroup Group { get; set; }
        public int GroupOrder { get; set; }

        public SimpleStatusDto(OveralStateDto state, string label, DateTime lastStatusChangeTs, SimpleStatusGroup group, int groupOrder, string additionalInfo = "")
        {
            State = state;
            Label = label.ToUpper();
            LastStatusChangeTs = lastStatusChangeTs;
            Group = group;
            GroupOrder = groupOrder;
            AddInfo = additionalInfo;
        }
    }

    public enum SimpleStatusGroup
    {
        WatchdogStatus,
        RollConsistency,
        Setpoints,
        CFOpt,
        CFOptHRM,
        CFOptFM,
        CS,
        Others,
    }
}
