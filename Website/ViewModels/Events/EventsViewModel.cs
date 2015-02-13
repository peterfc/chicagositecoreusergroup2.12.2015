using System.Collections.Generic;
using Models.Events;

namespace Website.ViewModels.Events
{
    public class EventsViewModel
    {
        public EventViewData Datasource { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}