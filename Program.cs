/*Herkansings project C# Advanced | Nick Bergmans/ s1172173*/

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _2024_airbnb_herkansing.Data;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Asp.Versioning.ApiExplorer;
/*using _2024_airbnb_herkansing.Data;*/
using _2024_airbnb_herkansing.Options;

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
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    options.OperationFilter<AddVersionQueryParamOperationFilter>();
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
                    $"/swagger/v1/swagger.json",
                    "v1"
                );
        options.SwaggerEndpoint(
                    $"/swagger/v2/swagger.json",
                    "v2"
                );
    });
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
