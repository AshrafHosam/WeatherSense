using System.Threading.Tasks;
using Common.PointOfInterest;

namespace Business.PointOfInterest
{
    public interface IPointOfInterestService
    {
        Task<PointOfInterestResponseDto> GetPointsOfInterestAsync(bool? isOpen = null);
    }
}
