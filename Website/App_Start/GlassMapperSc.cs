/*************************************

DO NOT CHANGE THIS FILE - UPDATE GlassMapperScCustom.cs

**************************************/

using Glass.Mapper;
using Sitecore.Pipelines;

// WebActivator has been removed. If you wish to continue using WebActivator uncomment the line below
// and delete the Glass.Mapper.Sc.CastleWindsor.config file from the Sitecore Config Include folder.
// [assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Website.App_Start.GlassMapperSc), "Start")]

namespace Website
{
	public class  GlassMapperSc
	{
		public void Process(PipelineArgs args){
			Start();
		}

		public static void Start()
		{
			//create the resolver
			var resolver = Windsor.Windsor.Resolver;

			//install the custom services
			GlassMapperScCustom.CastleConfig(Windsor.Windsor.Container);

			//create a context
			var context = Context.Create(resolver);
			context.Load(      
				GlassMapperScCustom.GlassLoaders()        				
				);

			GlassMapperScCustom.PostLoad();
		}
	}
}