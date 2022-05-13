using System;
using Autofac;

namespace cadastroClientesAPI.Module
{
    public class WebApiModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Startup).Assembly).Where(w => w.Namespace.Contains("UseCases")).AsImplementedInterfaces().AsSelf().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(Startup).Assembly).Where(type => type.Namespace.Contains("Notification")).AsImplementedInterfaces().AsSelf().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(Startup).Assembly).Where(type => type.Namespace.Contains("Infrastructure")).AsImplementedInterfaces().AsSelf().InstancePerLifetimeScope();
        }
    }
}
