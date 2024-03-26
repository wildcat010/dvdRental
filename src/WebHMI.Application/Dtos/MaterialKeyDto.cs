using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos
{
    public class MaterialKeyDto
    {
        public long MeId { get; set; }

        [RegularExpression("OR|LO|PH", ErrorMessage = $"{nameof(MatType)} must be either 'OR', 'LO' or 'PH' only")]
        public string MatType { get; set; }
    }
}
