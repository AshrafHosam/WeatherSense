using Business.EventOpenDataHub;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventOpenDataHubService _eventService;
        public EventController(IEventOpenDataHubService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _eventService.GetEventsAsync();
            return Ok(result);
        }
    }
}
