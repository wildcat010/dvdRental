using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WebHMI.Filters;

namespace WebHMI.Web.Host.Filters
{
    public class SortParametersFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var baseFilterNames = typeof(FilteredRequestDto)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(p => p.Name.ToLower())
                .ToList();

            operation.Parameters = operation.Parameters
                .OrderByDescending(param => baseFilterNames.Any(prefix => param.Name.StartsWith(prefix, System.StringComparison.CurrentCultureIgnoreCase)))
                .ToList();
        }
    }
}
