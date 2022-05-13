﻿using System;
using Autofac;

namespace cadastroClientes.Infrastructure.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Application.ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .AsSelf().InstancePerLifetimeScope();
        }
    }
}
