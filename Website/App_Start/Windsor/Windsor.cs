using System;
using Castle.Windsor;
using Website.Windsor.Installers;
using DependencyResolver = Glass.Mapper.Sc.CastleWindsor.DependencyResolver;

namespace Website.Windsor
{
    public class Windsor
    {
        #region Global Singleton Windsor Container
        private static readonly Object ContainerLock = new Object();
        private static IWindsorContainer _container { get; set; }
        public static IWindsorContainer Container
        {
            get
            {
                if (_container != null) return _container;
                lock (ContainerLock)
                {
                    if (_container == null)
                    {
                        _container = BuildContainer();
                    }
                }
                return _container;
            }
        }
        
        private static IWindsorContainer BuildContainer()
        {
            var container = Resolver.Container;

            container.Install(new ControllersInstaller());
            container.Install(new ServicesInstaller());
            container.Install(new SitecoreMvcInstaller());

            return container;
        }
        #endregion

        #region Global Singleton Windsor Resolver
        private static readonly Object ResolverLock = new Object();
        private static DependencyResolver _resolver { get; set; }
        public static DependencyResolver Resolver
        {
            get
            {
                if (_resolver != null) return _resolver;
                lock (ResolverLock)
                {
                    if (_resolver == null)
                    {
                        _resolver = BuildResolver();
                    }
                }
                return _resolver;
            }
        }

        private static DependencyResolver BuildResolver()
        {
            return DependencyResolver.CreateStandardResolver();
        }
        #endregion
    }
}