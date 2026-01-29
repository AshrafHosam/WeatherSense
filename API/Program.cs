using Business.EventOpenDataHub;
using Business.WeatherOpenDataHub;
using Data.EventOpenDataHub;
using Data.WeatherOpenDataHub;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddHttpClient<IWeatherOpenDataHubClient, WeatherOpenDataHubClient>();
builder.Services.AddScoped<IWeatherOpenDataHubService, WeatherOpenDataHubService>();
builder.Services.AddHttpClient<IEventOpenDataHubClient, EventOpenDataHubClient>();
builder.Services.AddScoped<IEventOpenDataHubService, EventOpenDataHubService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
