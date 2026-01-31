using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.EventOpenDataHub;
using Business.PointOfInterest;
using Business.WeatherOpenDataHub;
using Common.Recommendation;

namespace Business.Recommendation
{
    public class RecommendationService(
        IWeatherOpenDataHubService weatherService,
        IEventOpenDataHubService eventService,
        IPointOfInterestService poiService) : IRecommendationService
    {
        private readonly IWeatherOpenDataHubService _weatherService = weatherService;
        private readonly IEventOpenDataHubService _eventService = eventService;
        private readonly IPointOfInterestService _poiService = poiService;

        public async Task<RecommendationResponseDto> GetRecommendationsAsync()
        {
            // Fetch all data in parallel
            var weatherTask = _weatherService.GetWeatherAsync();
            var eventsTask = _eventService.GetEventsAsync();
            var poiTask = _poiService.GetPointsOfInterestAsync(isOpen: true);

            await Task.WhenAll(weatherTask, eventsTask, poiTask);

            var weather = await weatherTask;
            var events = await eventsTask;
            var pois = await poiTask;

            // Analyze weather
            var (isGoodWeather, suggestion) = WeatherAnalyzer.Analyze(weather);
            var todayCondition = weather?.Conditions?.FirstOrDefault();

            var response = new RecommendationResponseDto
            {
                Weather = new WeatherSummary
                {
                    Condition = todayCondition?.WeatherCondition ?? "Unknown",
                    Description = todayCondition?.WeatherDesc ?? "No description available",
                    MaxTemperature = todayCondition?.TempMaxmax,
                    MinTemperature = todayCondition?.TempMinmin,
                    IsGoodWeather = isGoodWeather,
                    ActivitySuggestion = suggestion
                },
                Recommendations = []
            };

            // Add relevant events (filter by indoor/outdoor based on weather)
            if (events?.Items != null)
            {
                foreach (var evt in events.Items.Take(5))
                {
                    var title = evt.EventTitle?.GetValueOrDefault("en") 
                             ?? evt.EventTitle?.Values.FirstOrDefault() 
                             ?? evt.Shortname;

                    response.Recommendations.Add(new ActivityRecommendation
                    {
                        Type = "Event",
                        Name = title,
                        Description = evt.EventTextEN ?? evt.EventTextDE ?? "",
                        Location = evt.EventLocation,
                        IsIndoor = true // Events are generally indoor-compatible
                    });
                }
            }

            // Add POIs filtered by weather suitability
            if (pois?.Items != null)
            {
                var filteredPois = isGoodWeather 
                    ? pois.Items // Good weather: show all
                    : pois.Items.Where(p => p.IsIndoor); // Bad weather: prefer indoor

                foreach (var poi in filteredPois.Take(5))
                {
                    var detail = poi.Detail?.GetValueOrDefault("en") 
                              ?? poi.Detail?.Values.FirstOrDefault();
                    var gps = poi.GpsInfo?.FirstOrDefault();

                    response.Recommendations.Add(new ActivityRecommendation
                    {
                        Type = "PointOfInterest",
                        Name = detail?.Title ?? poi.Shortname,
                        Description = detail?.BaseText ?? "",
                        Location = gps != null 
                            ? $"{gps.Latitude}, {gps.Longitude}" 
                            : null,
                        IsIndoor = poi.IsIndoor
                    });
                }
            }

            return response;
        }
    }
}
