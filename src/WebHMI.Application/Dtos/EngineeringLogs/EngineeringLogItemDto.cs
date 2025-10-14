using System;
using WebHMI.Dtos;
using WebHMI.Dtos.EngineeringLogs;

namespace WebHMI.Application.Dtos.EngineeringLogs
{
    public class EngineeringLogItemDto
    {
        public EngineeringLogDetailDto Details { get; set; } = new();
        public string Data {  get; set; }

    }
}
