using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Common.WeatherOpenDataHub
{
    public class WeatherDto
    {
        [JsonPropertyName("_Meta")]
        public MetaDto Meta { get; set; }
        [JsonPropertyName("Self")]
        public string Self { get; set; }
        [JsonPropertyName("Date")]
        public DateTime? Date { get; set; }
        [JsonPropertyName("EvolutionTitle")]
        public string EvolutionTitle { get; set; }
        [JsonPropertyName("Evolution")]
        public string Evolution { get; set; }
        [JsonPropertyName("Language")]
        public string Language { get; set; }
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Conditions")]
        public List<ConditionDto> Conditions { get; set; }
        [JsonPropertyName("Forecast")]
        public List<ForecastItemDto> Forecast { get; set; }
        [JsonPropertyName("Mountain")]
        public List<MountainItemDto> Mountain { get; set; }
        [JsonPropertyName("Stationdata")]
        public List<StationDataItemDto> Stationdata { get; set; }
        [JsonPropertyName("LicenseInfo")]
        public LicenseInfoDto LicenseInfo { get; set; }
    }

    public class MetaDto
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonPropertyName("LastUpdate")]
        public DateTime? LastUpdate { get; set; }
        [JsonPropertyName("Source")]
        public string Source { get; set; }
        [JsonPropertyName("Reduced")]
        public bool Reduced { get; set; }
        [JsonPropertyName("UpdateInfo")]
        public string UpdateInfo { get; set; }
    }

    public class ConditionDto
    {
        [JsonPropertyName("Date")]
        public DateTime? Date { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("WeatherCondition")]
        public string WeatherCondition { get; set; }
        [JsonPropertyName("Temperatures")]
        public string Temperatures { get; set; }
        [JsonPropertyName("WeatherDesc")]
        public string WeatherDesc { get; set; }
        [JsonPropertyName("WeatherImgUrl")]
        public string WeatherImgUrl { get; set; }
        [JsonPropertyName("Reliability")]
        public string Reliability { get; set; }
        [JsonPropertyName("TempMaxmax")]
        public int? TempMaxmax { get; set; }
        [JsonPropertyName("TempMaxmin")]
        public int? TempMaxmin { get; set; }
        [JsonPropertyName("TempMinmax")]
        public int? TempMinmax { get; set; }
        [JsonPropertyName("TempMinmin")]
        public int? TempMinmin { get; set; }
        [JsonPropertyName("BulletinStatus")]
        public int? BulletinStatus { get; set; }
    }

    public class ForecastItemDto
    {
        [JsonPropertyName("Date")]
        public DateTime? Date { get; set; }
        [JsonPropertyName("TempMaxmax")]
        public int? TempMaxmax { get; set; }
        [JsonPropertyName("TempMaxmin")]
        public int? TempMaxmin { get; set; }
        [JsonPropertyName("TempMinmax")]
        public int? TempMinmax { get; set; }
        [JsonPropertyName("TempMinmin")]
        public int? TempMinmin { get; set; }
        [JsonPropertyName("WeatherCode")]
        public string WeatherCode { get; set; }
        [JsonPropertyName("WeatherDesc")]
        public string WeatherDesc { get; set; }
        [JsonPropertyName("WeatherImgUrl")]
        public string WeatherImgUrl { get; set; }
        [JsonPropertyName("Reliability")]
        public string Reliability { get; set; }
    }

    public class MountainItemDto
    {
        [JsonPropertyName("Date")]
        public DateTime? Date { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("WeatherDesc")]
        public string WeatherDesc { get; set; }
        [JsonPropertyName("Conditions")]
        public string Conditions { get; set; }
        [JsonPropertyName("Zerolimit")]
        public string Zerolimit { get; set; }
        [JsonPropertyName("Reliability")]
        public string Reliability { get; set; }
        [JsonPropertyName("Sunrise")]
        public string Sunrise { get; set; }
        [JsonPropertyName("Sunset")]
        public string Sunset { get; set; }
        [JsonPropertyName("Moonrise")]
        public string Moonrise { get; set; }
        [JsonPropertyName("Moonset")]
        public string Moonset { get; set; }
        [JsonPropertyName("MountainImgUrl")]
        public string MountainImgUrl { get; set; }
        [JsonPropertyName("Temp1000")]
        public int? Temp1000 { get; set; }
        [JsonPropertyName("Temp2000")]
        public int? Temp2000 { get; set; }
        [JsonPropertyName("Temp3000")]
        public int? Temp3000 { get; set; }
        [JsonPropertyName("Temp4000")]
        public int? Temp4000 { get; set; }
        [JsonPropertyName("NorthCode")]
        public string NorthCode { get; set; }
        [JsonPropertyName("NorthDesc")]
        public string NorthDesc { get; set; }
        [JsonPropertyName("NorthImgUrl")]
        public string NorthImgUrl { get; set; }
        [JsonPropertyName("SouthCode")]
        public string SouthCode { get; set; }
        [JsonPropertyName("SouthDesc")]
        public string SouthDesc { get; set; }
        [JsonPropertyName("SouthImgUrl")]
        public string SouthImgUrl { get; set; }
        [JsonPropertyName("WindCode")]
        public string WindCode { get; set; }
        [JsonPropertyName("WindDesc")]
        public string WindDesc { get; set; }
        [JsonPropertyName("WindImgUrl")]
        public string WindImgUrl { get; set; }
        [JsonPropertyName("Snowlimit")]
        public List<string> Snowlimit { get; set; }
    }

    public class StationDataItemDto
    {
        [JsonPropertyName("Date")]
        public DateTime? Date { get; set; }
        [JsonPropertyName("Id")]
        public int? Id { get; set; }
        [JsonPropertyName("CityName")]
        public string CityName { get; set; }
        [JsonPropertyName("WeatherCode")]
        public string WeatherCode { get; set; }
        [JsonPropertyName("WeatherDesc")]
        public string WeatherDesc { get; set; }
        [JsonPropertyName("WeatherImgUrl")]
        public string WeatherImgUrl { get; set; }
        [JsonPropertyName("MinTemp")]
        public int? MinTemp { get; set; }
        [JsonPropertyName("MaxTemp")]
        public int? MaxTemp { get; set; }
    }

    public class LicenseInfoDto
    {
        [JsonPropertyName("License")]
        public string License { get; set; }
        [JsonPropertyName("LicenseHolder")]
        public string LicenseHolder { get; set; }
        [JsonPropertyName("Author")]
        public string Author { get; set; }
        [JsonPropertyName("ClosedData")]
        public bool? ClosedData { get; set; }
    }
}