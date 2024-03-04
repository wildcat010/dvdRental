using System.ComponentModel.DataAnnotations;

namespace WebHMI.Dtos.Configuration
{
	public class ChangeUiThemeInput
	{
		[Required]
		[StringLength(32)]
		public string Theme { get; set; }
	}
}


