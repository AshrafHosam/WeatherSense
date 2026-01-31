using Business.WeatherOpenDataHub;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController(IWeatherOpenDataHubService weatherService) : ControllerBase
    {
        private readonly IWeatherOpenDataHubService _weatherService = weatherService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // Returning a single WeatherDto object
            var result = await _weatherService.GetWeatherAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
