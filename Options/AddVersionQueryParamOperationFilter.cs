using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace _2024_airbnb_herkansing.Options
{
    /// <summary>
    /// Adds ?api-version=2 to any controller annotated with the v2 groupname.
    /// </summary>
    public class AddVersionQueryParamOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var groupName = context.ApiDescription.GroupName;

            if (groupName != "v2")
                return;

            if (operation.Parameters.Any(parameter => parameter.Name == "api-version"))
                return;

            operation.Parameters ??= [];
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "api-version",
                In = ParameterLocation.Query,
                Required = true,
                Description = "API version. Keep it at 2",
                Schema = new OpenApiSchema { Type = "string" },
                Example = new OpenApiString("2")
            });
        }
    }
}
