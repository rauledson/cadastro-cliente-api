using System;
using Autofac;
using cadastroClientes.Infrastructure.Modules;
using cadastroClientesAPI.Module;

namespace cadastroClientesAPI.DependencyInjection
{
    public static class AutofacExtensions
    {
        public static ContainerBuilder AddAutofacRegistration(this ContainerBuilder builder)
        {
            builder.RegisterModule<ApplicationModule>();
            builder.RegisterModule<InfrastructureModule>();
            builder.RegisterModule<WebApiModule>();

            return builder;
        }
    }
}
