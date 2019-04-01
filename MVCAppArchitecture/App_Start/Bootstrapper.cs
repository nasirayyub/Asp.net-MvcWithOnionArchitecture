using App.Repositories;
using App.Repositories.Infrastructure;
using App.Services;
using App.Services.Configuration;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace MVCAppArchitecture.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();

            //automapper configure
            AutoMapperConfiguration.Configure();
        }
        static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServicesModule>();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}