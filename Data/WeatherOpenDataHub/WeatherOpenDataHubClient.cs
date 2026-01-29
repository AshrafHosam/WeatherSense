using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Common.WeatherOpenDataHub;

namespace Data.WeatherOpenDataHub
{
    public class WeatherOpenDataHubClient : IWeatherOpenDataHubClient
    {
        private readonly HttpClient _httpClient;
        public WeatherOpenDataHubClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<WeatherDto> GetWeatherAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<WeatherDto>("https://tourism.api.opendatahub.com/v1/Weather?language=en&extended=false");
            return response;
        }
    }
}