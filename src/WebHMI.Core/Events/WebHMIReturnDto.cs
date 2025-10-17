using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Events
{
    public class WebHMIReturnDto
    {
        public short TelID { get; set; }

        public string ServerName { get; set; }

        public string FunctionName { get; set; }

        public string Pipname { get; set; }

        public string HmiClientId { get; set; }

        public string HmiServerName { get; set; }

        public short Acknowledge { get; set; }

        public string LfeName { get; set; }

        public short Status { get; set; }

        public short MessageNo { get; set; }

        public string MessageText { get; set; }
    }
}
