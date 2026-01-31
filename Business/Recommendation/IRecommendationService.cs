using System.Threading.Tasks;
using Common.Recommendation;

namespace Business.Recommendation
{
    public interface IRecommendationService
    {
        Task<RecommendationResponseDto> GetRecommendationsAsync();
    }
}
