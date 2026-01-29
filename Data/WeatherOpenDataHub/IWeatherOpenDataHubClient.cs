using System.Threading.Tasks;
using Common.WeatherOpenDataHub;

namespace Data.WeatherOpenDataHub
{
    public interface IWeatherOpenDataHubClient
    {
        Task<WeatherDto> GetWeatherAsync();
    }
}