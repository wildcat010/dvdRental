using System.Linq;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebHMI.Web.Host.Startup
{
	class AuthOperationFilter : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext ctx)
		{
			if (!(ctx.ApiDescription.ActionDescriptor is ControllerActionDescriptor descriptor))
				return;

			var authAttribute = descriptor.EndpointMetadata.LastOrDefault(x => x is AbpAuthorizeAttribute) as AbpAuthorizeAttribute;

			if (authAttribute is null)
			{
				operation.Description = "No permission is required";
				return;
			}

			// If not [AbpAllowAnonymous] and [AbpAuthorize] on either the endpoint or the controller...
			if (descriptor.EndpointMetadata.Any(a => a is AbpAllowAnonymousAttribute)
				|| !descriptor.EndpointMetadata.Any(a => a is AbpAuthorizeAttribute)
					&& descriptor.EndpointMetadata.FirstOrDefault(x => x is AbpAuthorizeAttribute) == null)
			{
				return;
			}

			if (!operation.Responses.ContainsKey("401"))
				operation.Responses.Add("401", new OpenApiResponse { Description = "Unauthorized" });

			operation.Security.Add(new OpenApiSecurityRequirement
			{
				[new OpenApiSecurityScheme
				{
					Reference = new OpenApiReference
					{
						Type = ReferenceType.SecurityScheme,
						Id = "Bearer",
					},
				}] = authAttribute.Permissions,
			});

			if (!authAttribute.Permissions.Any())
			{
				operation.Description = "User must be logged in (no permissions is required)";
			}
			else
			{
				var permissionsString = string.Join(", ", authAttribute.Permissions);
				var permissionsMode = authAttribute.RequireAllPermissions ? "All" : "One";
				operation.Description = $"{permissionsMode} of these permissions must be granted: {permissionsString}";
			}

			// User authenticated, but has no permission = Forbidden
			if (!operation.Responses.ContainsKey("403"))
				operation.Responses.Add("403", new OpenApiResponse { Description = "Forbidden" });
		}
	}
}
