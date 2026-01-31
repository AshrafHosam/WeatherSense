using System.Collections.Generic;

namespace Common.Recommendation
{
    public class RecommendationResponseDto
    {
        public WeatherSummary Weather { get; set; }
        public List<ActivityRecommendation> Recommendations { get; set; } = new();
    }

    public class WeatherSummary
    {
        public string Condition { get; set; }
        public string Description { get; set; }
        public int? MaxTemperature { get; set; }
        public int? MinTemperature { get; set; }
        public bool IsGoodWeather { get; set; }
        public string ActivitySuggestion { get; set; }
    }

    public class ActivityRecommendation
    {
        public string Type { get; set; } // "Event" or "PointOfInterest"
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsIndoor { get; set; }
    }
}
