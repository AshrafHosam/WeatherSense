using Business.PointOfInterest;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PointOfInterestController(IPointOfInterestService poiService) : ControllerBase
    {
        private readonly IPointOfInterestService _poiService = poiService;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? isOpen = null)
        {
            var result = await _poiService.GetPointsOfInterestAsync(isOpen);
            return Ok(result);
        }
    }
}
