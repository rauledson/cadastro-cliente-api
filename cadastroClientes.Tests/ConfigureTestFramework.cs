using System;
using Autofac;
using cadastroClientes.Infrastructure.Modules;
using Xunit;
using Xunit.Abstractions;
using Xunit.Frameworks.Autofac;

[assembly: TestCollectionOrderer("cadastroClientes.Tests.TestCaseOrdering", "cadastroClientes.Tests")]
[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestFramework("cadastroClientes.Tests.ConfigureTestFramework", "cadastroClientes.Tests")]

namespace cadastroClientes.Tests
{
    public class ConfigureTestFramework : AutofacTestFramework
    {
        public ConfigureTestFramework(IMessageSink diagnosticMessageSink) : base(diagnosticMessageSink)
        {

        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<ApplicationModule>();
            builder.RegisterModule<InfrastructureModule>();
        }

        private static void SetMockedDependencies(ContainerBuilder builder)
        {
            //builder.RegisterInstance(new GetInvoicesMock().GetInvoices().Object).As<IGetInvoices>();
        }
    }
}
