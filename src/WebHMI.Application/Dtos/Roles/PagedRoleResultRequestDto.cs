using Abp.Application.Services.Dto;

namespace WebHMI.Dtos.Roles
{
	public class PagedRoleResultRequestDto : PagedResultRequestDto
	{
		public string Keyword { get; set; }
	}
}



