using System.Threading.Tasks;
using Common.PointOfInterest;

namespace Data.PointOfInterest
{
    public interface IPointOfInterestClient
    {
        Task<PointOfInterestResponseDto> GetPointsOfInterestAsync(bool? isOpen = null);
    }
}
