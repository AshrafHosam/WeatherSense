using Business.Recommendation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationController(IRecommendationService recommendationService) : ControllerBase
    {
        private readonly IRecommendationService _recommendationService = recommendationService;

        // Get activity recommendations based on current weather conditions.
        // Returns weather summary and suggested activities (events + points of interest).
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _recommendationService.GetRecommendationsAsync();
            return Ok(result);
        }
    }
}
