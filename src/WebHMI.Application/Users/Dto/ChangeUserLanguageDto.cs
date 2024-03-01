using System.ComponentModel.DataAnnotations;

namespace WebHMI.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

