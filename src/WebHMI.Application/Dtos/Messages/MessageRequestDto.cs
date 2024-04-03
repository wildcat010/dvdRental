using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Filters;

namespace WebHMI.Dtos.Messages
{
    public class MessageRequestDto : FilteredRequestDto
    {
        public bool UseHistoryData { get; set; }
        public string Language { get; set; }
    }
}
