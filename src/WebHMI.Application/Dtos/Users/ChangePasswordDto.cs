using Abp.Auditing;
using System.ComponentModel.DataAnnotations;

namespace WebHMI.Dtos.Users
{
	public class ChangePasswordDto
	{
		[Required]
		[DisableAuditing]
		public string CurrentPassword { get; set; }

		[Required]
		[DisableAuditing]
		public string NewPassword { get; set; }
	}
}


