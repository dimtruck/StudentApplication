﻿using Castle.Core;
using Castle.MicroKernel.Registration;
using StudentApplication.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplication.Installers
{
    public class RepositoryInstaller : IWindsorInstaller 
    {
        public void Install(Castle.Windsor.IWindsorContainer container, 
            Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component.For<LoggingInterceptor>().LifeStyle.Transient);
            container.Register(
                Castle.MicroKernel.Registration.Classes.FromAssemblyNamed("Domain")
                            .Where(type => type.Name.EndsWith("Repository"))
                            .WithServiceFirstInterface()
                            .LifestylePerWebRequest()
                            .Configure(delegate(ComponentRegistration c ){ 
                                    var x = c.Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere; 
                                }));
        }
    }
}