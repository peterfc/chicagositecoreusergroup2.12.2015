using System.Collections.Generic;
using Models.Events;

namespace Services.Events
{
    public interface IEventService
    {
        IEnumerable<Event> GetEvents();
    }
}
