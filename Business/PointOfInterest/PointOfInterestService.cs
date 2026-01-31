using System.Threading.Tasks;
using Common.PointOfInterest;
using Data.PointOfInterest;

namespace Business.PointOfInterest
{
    public class PointOfInterestService(IPointOfInterestClient client) : IPointOfInterestService
    {
        private readonly IPointOfInterestClient _client = client;

        public async Task<PointOfInterestResponseDto> GetPointsOfInterestAsync(bool? isOpen = null)
        {
            return await _client.GetPointsOfInterestAsync(isOpen);
        }
    }
}
