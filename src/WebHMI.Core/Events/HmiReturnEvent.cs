using Abp;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.Events
{
    public class HmiReturnEvent : EventData
    {
        public WebHMIReturnDto ReturnDto { get; set; }
        public IUserIdentifier User { get; set; }
        public ME_CODE MeCode { get; set; }
    }
}
