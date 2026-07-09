using System.ComponentModel.DataAnnotations;

namespace WebHMI.Dtos
{
    public class MaterialKeyDto
    {
        public long MeId { get; set; }

        [RegularExpression("OR|LO|PH", ErrorMessage = $"{nameof(MatType)} must be either 'OR', 'LO' or 'PH' only")]
        public string MatType { get; set; }
    }
    public record MaterialKey(long MeId, string MatType);
}
