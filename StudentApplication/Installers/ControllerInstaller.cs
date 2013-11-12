using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApplication.Installers
{
    /// <summary>
    /// controllers installer.  Register all controller classes
    /// </summary>
    public class ControllerInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Pass in the container and configuration store.  Get all classes from this assembly that implement IController and use transient lifestyle
        /// 
        /// </summary>
        /// <param name="container"></param>
        /// <param name="store"></param>
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            //instance is provided every time it is needed by IoC container.  Caller is responsible to tell IoC container when instance is no longer needed (ReleaseController)
            container.Register(Classes.FromThisAssembly()
                            .BasedOn<IController>()
                            .LifestyleTransient());
        }
    }
}