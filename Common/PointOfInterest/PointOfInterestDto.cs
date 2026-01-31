using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Common.PointOfInterest
{
    public class PointOfInterestResponseDto
    {
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public List<PointOfInterestItemDto> Items { get; set; }
    }

    public class PointOfInterestItemDto
    {
        public string Id { get; set; }
        public string Self { get; set; }
        public bool Active { get; set; }
        public string Shortname { get; set; }
        public Dictionary<string, PoiDetailDto> Detail { get; set; }
        public List<PoiGpsInfoDto> GpsInfo { get; set; }
        public List<string> HasLanguage { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public List<PoiTagDto> Tags { get; set; }

        [JsonPropertyName("IsOpen")]
        public bool? IsOpen { get; set; }

        // Determines if this is an indoor activity based on type/subtype
        public bool IsIndoor => Type?.ToLower() switch
        {
            "kultur und sehenswürdigkeiten" => true,
            "culture and sights" => true,
            _ => SubType?.ToLower()?.Contains("museum") == true 
                 || SubType?.ToLower()?.Contains("indoor") == true
                 || SubType?.ToLower()?.Contains("gallery") == true
        };
    }

    public class PoiDetailDto
    {
        public string Title { get; set; }
        public string BaseText { get; set; }
        public string Language { get; set; }
    }

    public class PoiGpsInfoDto
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Altitude { get; set; }
    }

    public class PoiTagDto
    {
        public string Id { get; set; }
        public string Self { get; set; }
    }
}
