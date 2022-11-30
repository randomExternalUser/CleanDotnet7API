using CleanDotnet7Api.Infrastructure.DataAccess;
using CleanDotnet7Api.Infrastructure.DataAccess.Repositories;
using CleanDotnet7API.Domain.Interfaces;
using CleanDotnet7API.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ApplicationDbContext>();
builder.Services.AddScoped<IItemsRepository, ItemsRepository>();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline. //
if (app.Environment.IsDevelopment()){}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapHealthChecks("/health");
app.UseAuthorization();
app.MapControllers();
app.Run();
