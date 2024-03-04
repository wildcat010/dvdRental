using System.ComponentModel.DataAnnotations;

namespace WebHMI.Dtos.Users
{
	public class ChangeUserLanguageDto
	{
		[Required]
		public string LanguageName { get; set; }
	}
}

