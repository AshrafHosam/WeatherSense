using System.Threading.Tasks;
using Common.WeatherOpenDataHub;

namespace Business.WeatherOpenDataHub
{
    public interface IWeatherOpenDataHubService
    {
        Task<WeatherDto> GetWeatherAsync();
    }
}