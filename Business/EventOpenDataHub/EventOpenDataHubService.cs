using System.Threading.Tasks;
using Common.EventOpenDataHub;
using Data.EventOpenDataHub;

namespace Business.EventOpenDataHub
{
    public interface IEventOpenDataHubService
    {
        Task<EventShortResponseDto> GetEventsAsync();
    }

    public class EventOpenDataHubService : IEventOpenDataHubService
    {
        private readonly IEventOpenDataHubClient _client;
        public EventOpenDataHubService(IEventOpenDataHubClient client)
        {
            _client = client;
        }
        public async Task<EventShortResponseDto> GetEventsAsync()
        {
            return await _client.GetEventsAsync();
        }
    }
}
