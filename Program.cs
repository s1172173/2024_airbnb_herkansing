/*Herkansings project C# Advanced | Nick Bergmans/ s1172173*/
/*Throughout the development of this project, I received assistance from Tom Sievers, an advanced C# teacher,
as well as from AI programs such as blackbox.ai and ChatGPT.*/

using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Data;
using Microsoft.OpenApi.Models;
using System.Reflection;
using _2024_airbnb_herkansing.Options;
using Asp.Versioning;
using Swashbuckle.AspNetCore.SwaggerGen;
using _2024_airbnb_herkansing.Repositories;
using _2024_airbnb_herkansing.Services;
using _2024_airbnb_herkansing;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<_2024_airbnb_herkansingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("_2024_airbnb_herkansingContext") ?? throw new InvalidOperationException("Connection string '_2024_airbnb_herkansingContext' not found.")));

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new ApiVersionBasedGroupingConvention());
});
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ILandlordRepository, LandlordRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();

// Modified this line to specify the assembly where AutoMapper profiles are located | But This doesn't resolve the issue regarding the controller output
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddAutoMapper(typeof(Program));

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
        app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
