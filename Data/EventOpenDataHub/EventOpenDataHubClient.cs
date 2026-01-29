using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Common.EventOpenDataHub;

namespace Data.EventOpenDataHub
{
    public class EventOpenDataHubClient : IEventOpenDataHubClient
    {
        private readonly HttpClient _httpClient;
        public EventOpenDataHubClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<EventShortResponseDto> GetEventsAsync()
        {
            var url = "https://tourism.api.opendatahub.com/v1/EventShort?pagenumber=1&pagesize=10&startdate=2026-01-28%2000%3A00&active=true&sortorder=ASC&optimizedates=false&removenullvalues=true&getasidarray=false";
            var json = await _httpClient.GetStringAsync(url);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            options.Converters.Add(new NullableLongConverter());
            return JsonSerializer.Deserialize<EventShortResponseDto>(json, options);
        }
    }
}
