using Business.EventOpenDataHub;
using Business.PointOfInterest;
using Business.Recommendation;
using Business.WeatherOpenDataHub;
using Data.EventOpenDataHub;
using Data.PointOfInterest;
using Data.WeatherOpenDataHub;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection - Data Layer (HttpClients)
builder.Services.AddHttpClient<IWeatherOpenDataHubClient, WeatherOpenDataHubClient>();
builder.Services.AddHttpClient<IEventOpenDataHubClient, EventOpenDataHubClient>();
builder.Services.AddHttpClient<IPointOfInterestClient, PointOfInterestClient>();

// Dependency Injection - Business Layer (Services)
builder.Services.AddScoped<IWeatherOpenDataHubService, WeatherOpenDataHubService>();
builder.Services.AddScoped<IEventOpenDataHubService, EventOpenDataHubService>();
builder.Services.AddScoped<IPointOfInterestService, PointOfInterestService>();
builder.Services.AddScoped<IRecommendationService, RecommendationService>();

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
