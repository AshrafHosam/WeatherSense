using Common.WeatherOpenDataHub;

namespace Business.Recommendation
{
    // Analyzes weather conditions and determines if they're suitable for outdoor activities.
    public static class WeatherAnalyzer
    {
        private static readonly string[] BadWeatherKeywords = 
        [ 
            "rain", "regen", "pioggia",
            "snow", "schnee", "neve",
            "storm", "sturm", "tempesta",
            "thunder", "gewitter", "temporale",
            "fog", "nebel", "nebbia"
        ];

        public static (bool isGood, string suggestion) Analyze(WeatherDto weather)
        {
            if (weather?.Conditions == null || weather.Conditions.Count == 0)
                return (true, "Weather data unavailable - check local conditions");

            var today = weather.Conditions[0];
            var condition = today.WeatherCondition?.ToLowerInvariant() ?? "";
            var description = today.WeatherDesc?.ToLowerInvariant() ?? "";
            var maxTemp = today.TempMaxmax;

            // Check for bad weather indicators
            foreach (var keyword in BadWeatherKeywords)
            {
                if (condition.Contains(keyword) || description.Contains(keyword))
                {
                    return (false, "Indoor activities recommended due to weather conditions");
                }
            }

            // Temperature check (too cold or too hot)
            if (maxTemp.HasValue)
            {
                if (maxTemp < 5)
                    return (false, "Indoor activities recommended - temperatures are quite cold");
                if (maxTemp > 35)
                    return (false, "Indoor activities recommended - temperatures are very high");
            }

            return (true, "Great weather for outdoor activities!");
        }
    }
}
