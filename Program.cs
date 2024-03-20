/*Herkansings project C# Advanced | Nick Bergmans/ s1172173*/

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _2024_airbnb_herkansing.Data;
/*using _2024_airbnb_herkansing.Data;*/
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<_2024_airbnb_herkansingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("_2024_airbnb_herkansingContext") ?? throw new InvalidOperationException("Connection string '_2024_airbnb_herkansingContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
