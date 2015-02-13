using Castle.Core.Internal;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Glass.Mapper.Sc;
using Services.Addresses;
using Services.Events;
using Services.News;
using Website.Windsor.Factory;

namespace Website.Windsor.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Kernel.AddFacility<TypedFactoryFacility>();
            container.Kernel.Register(Component.For<INewsServiceFactory>().AsFactory(f => f.SelectedWith(new FactoryComponentSelector())));
            
            container.Register(

                Component.For<IEventService>().ImplementedBy<EventService>().LifestylePerWebRequest(),
                Component.For<ISitecoreContext>().ImplementedBy<SitecoreContext>().LifestylePerWebRequest(),
                Component.For<IAddressService>().ImplementedBy<AddressService>().LifestylePerWebRequest(),
                
                Component.For<INewsService>().ImplementedBy<NewsServiceFromWebService>().Named("NewsServiceFromWebService").LifestylePerWebRequest(),
                Component.For<INewsService>().ImplementedBy<NewsServiceFromSitecore>().Named("NewsServiceFromSitecore").LifestylePerWebRequest(),
                Component.For<INewsAggregator>().ImplementedBy<NewsAggregator>().DependsOn(Dependency.OnValue("NewsServiceNames", new[] { "NewsServiceFromSitecore" })).OnCreate((kernel, instance) => instance.NewsServiceNames.ForEach(instance.InitializeService))

                );
        }
    }
}