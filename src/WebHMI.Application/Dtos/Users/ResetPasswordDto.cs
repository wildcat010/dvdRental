using Abp.Auditing;
using System.ComponentModel.DataAnnotations;

namespace WebHMI.Dtos.Users
{
	public class ResetPasswordDto
	{
		[Required]
		public string AdminPassword { get; set; }

		[Required]
		public long UserId { get; set; }

		[Required]
		[DisableAuditing]
		public string NewPassword { get; set; }
	}
}


