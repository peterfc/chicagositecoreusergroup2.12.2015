using System.Collections.Generic;
using System.Linq;
using Glass.Mapper.Sc;
using Models.Events;
using Services.Addresses;
using Sitecore.Data.Items;

namespace Services.Events
{
    public class EventService : IEventService
    {
        private readonly ISitecoreContext _sitecoreContext;
        private readonly IAddressService _addressService;

        public EventService(ISitecoreContext sitecoreContext, IAddressService addressService)
        {
            _sitecoreContext = sitecoreContext;
            _addressService = addressService;
        }

        public IEnumerable<Event> GetEvents()
        {
            var eventFolder = _sitecoreContext.GetItem<Item>("{0DF99A5A-4A02-4F19-951B-1B59D309232B}");
            var events = eventFolder.Children.Where(child => !child.TemplateName.Contains("Folder")).Select(child => _sitecoreContext.Cast<Event>(child)).ToList();
            events.ForEach(ev => ev.Address = _addressService.GetAddress(ev.Location));
            return events;
        }
    }
}
