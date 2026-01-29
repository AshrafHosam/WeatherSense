using System.Threading.Tasks;
using Common.WeatherOpenDataHub;
using Data.WeatherOpenDataHub;

namespace Business.WeatherOpenDataHub
{
    public class WeatherOpenDataHubService : IWeatherOpenDataHubService
    {
        private readonly IWeatherOpenDataHubClient _client;
        public WeatherOpenDataHubService(IWeatherOpenDataHubClient client)
        {
            _client = client;
        }
        public async Task<WeatherDto> GetWeatherAsync()
        {
            return await _client.GetWeatherAsync();
        }
    }
}