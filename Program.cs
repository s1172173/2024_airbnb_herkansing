/*Herkansings project C# Advanced | Nick Bergmans/ s1172173*/

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _2024_airbnb_herkansing.Data;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Asp.Versioning.ApiExplorer;
/*using _2024_airbnb_herkansing.Data;*/
using _2024_airbnb_herkansing.Options;
using Asp.Versioning;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<_2024_airbnb_herkansingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("_2024_airbnb_herkansingContext") ?? throw new InvalidOperationException("Connection string '_2024_airbnb_herkansingContext' not found.")));

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new ApiVersionBasedGroupingConvention());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddApiVersioning();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("1.0", new OpenApiInfo { Title = "V1", Version = "1.0" });
    options.SwaggerDoc("2.0", new OpenApiInfo { Title = "V2", Version = "2.0" });
    options.DocInclusionPredicate((docName, apiDesc) =>
    {
        if (!apiDesc.TryGetMethodInfo(out MethodInfo method))
            return false;

        var versions = method.DeclaringType
                        .GetCustomAttributes(true)
                        .OfType<ApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions);

        return versions.Any(v => $"{v}" == docName);
    });

    options.OperationFilter<AddVersionQueryParamOperationFilter>();

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    options.OperationFilter<AddVersionQueryParamOperationFilter>();
});

builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0); // Standaard naar versie 1.0
    options.ReportApiVersions = true;
    options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
}).AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/1.0/swagger.json", "API v1");
        config.SwaggerEndpoint("/swagger/2.0/swagger.json", "API v2");
    });
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
