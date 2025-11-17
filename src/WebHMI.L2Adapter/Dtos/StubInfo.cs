using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Dtos
{
    public class StubInfo
    {
        public Type StubType { get; set; }
        public Type InterfaceType { get; set; }
        public Type ServiceType { get; set; }
        public string[] RequestArgs { get; set; } = { };
    }
}
