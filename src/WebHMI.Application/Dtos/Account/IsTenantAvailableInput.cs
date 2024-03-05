using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace WebHMI.Dtos.Account
{
	public class IsTenantAvailableInput
	{
		[Required]
		[StringLength(AbpTenantBase.MaxTenancyNameLength)]
		public string TenancyName { get; set; }
	}
}


