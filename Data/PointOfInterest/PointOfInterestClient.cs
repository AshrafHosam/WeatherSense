using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Common.PointOfInterest;

namespace Data.PointOfInterest
{
    public class PointOfInterestClient(HttpClient httpClient) : IPointOfInterestClient
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<PointOfInterestResponseDto> GetPointsOfInterestAsync(bool? isOpen = null)
        {
            var url = "https://tourism.api.opendatahub.com/v1/ODHActivityPoi?pagenumber=1&pagesize=20&type=63&active=true&odhactive=true";
            
            if (isOpen.HasValue)
                url += $"&isopen={isOpen.Value.ToString().ToLower()}";

            return await _httpClient.GetFromJsonAsync<PointOfInterestResponseDto>(url);
        }
    }
}
