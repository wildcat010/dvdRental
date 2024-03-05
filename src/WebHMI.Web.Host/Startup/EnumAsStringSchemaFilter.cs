using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using Microsoft.OpenApi.Any;

public class EnumAsStringSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema model, SchemaFilterContext context)
    {
        if (context.Type.IsEnum)
        {
            model.Type = "string";
            model.Enum.Clear();
            foreach (var name in Enum.GetNames(context.Type))
            {
                model.Enum.Add(new OpenApiString(name));
            }
        }
    }
}
