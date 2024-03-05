using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roles
{
	public class PermissionsDto
	{
		public string GroupName { get; set; }
		public List<PermissionItem> Permissions { get; set; } = new();
	}

	public class PermissionItem
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
