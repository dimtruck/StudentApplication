using Castle.MicroKernel.Registration;
using StudentApplication.Services.Concrete;
using StudentApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplication.Installers
{
    /// <summary>
    /// Install logger installer
    /// </summary>
    public class LoggerInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, 
            Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<ILogger>()
                .ImplementedBy<SystemOutLogger>()
                .LifestyleTransient());
            //container.AddFacility<LoggingFacility>(f => f.UseLog4Net());
        }
    }
}