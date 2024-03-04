using Abp.Application.Services.Dto;
using System;

namespace WebHMI.Dtos.Users
{
	//custom PagedResultRequestDto
	public class PagedUserResultRequestDto : PagedResultRequestDto
	{
		public string Keyword { get; set; }
		public bool? IsActive { get; set; }
	}
}


