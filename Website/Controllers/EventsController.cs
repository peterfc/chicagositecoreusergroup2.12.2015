﻿using System.Web.Mvc;
using System.Xml;
using Glass.Mapper.Sc;
using Models.Events;
using Services.Addresses;
using Services.Events;
using Sitecore.Configuration;
using Website.ViewModels.Events;

namespace Website.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ISitecoreContext _sitecoreContext;

        public EventsController(IEventService eventService, ISitecoreContext sitecoreContext)
        {
            _sitecoreContext = sitecoreContext;
            _eventService = eventService;
        }

        public ActionResult GetEvents()
        {
            string str = string.Concat("factories/factory", "");
            XmlNode configNode = Factory.GetConfigNode(str, true);

            var dataSource =
                _sitecoreContext.GetItem<EventViewData>(Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.DataSource);
            var events = _eventService.GetEvents();
            var viewModel = new EventsViewModel
            {
                Datasource = dataSource,
                Events = events
            };

            return PartialView("Events", viewModel);
        }
    }
}