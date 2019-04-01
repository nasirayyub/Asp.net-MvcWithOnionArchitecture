using Autofac;
using System.Reflection;
using Module = Autofac.Module;
namespace App.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            // builder.RegisterType<CharacterRepository>().As<ICharacterRepository>();

            // REGISTERING TYPES BY CONVENTION
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Factory")) // REGISTERING ALL FACTORIES
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Service")) // REGISTERING ALL SERVICES
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Helper")) // REGISTERING ALL HELPERS
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Repository")) // REGISTERING ALL HELPERS
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Work")) // REGISTERING ALL HELPERS
                .AsImplementedInterfaces();
        }
    }
}
