using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Dtos
{
    public class ParamsDto
    {
        public string PlantType { get; set; }
        public string Name   {get; set;}
        public string DisplayName {get; set;}
        public string UserName    {get; set;}
        public string OldUValue   {get; set;}
        public string OldLValue   {get; set;}
        public string NewUValue   {get; set;}
        public string NewLValue   {get; set;}
    }
}
