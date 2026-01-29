using System.Threading.Tasks;
using Common.EventOpenDataHub;

namespace Data.EventOpenDataHub
{
    public interface IEventOpenDataHubClient
    {
        Task<EventShortResponseDto> GetEventsAsync();
    }
}
