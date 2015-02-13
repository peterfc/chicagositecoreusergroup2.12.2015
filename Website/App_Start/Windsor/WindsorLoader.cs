using System.Web.Mvc;
using Sitecore.Pipelines;

namespace Website.Windsor
{
    public class WindsorLoader
    {
        [Sitecore.UsedImplicitly]
        public virtual void Process(PipelineArgs args)
        {
            var controllerFactory = new WindsorControllerFactory(Windsor.Container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}