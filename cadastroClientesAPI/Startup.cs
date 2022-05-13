using Autofac;
using Autofac.Configuration;
using cadastroClientesAPI.DependencyInjection;
using cadastroClientesAPI.Pipeline;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Converters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Autofac.Extensions.DependencyInjection;
using cadastroClientesAPI.Infrastructure;

namespace cadastroClientesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ConfigurationModule(Configuration));
            builder.AddAutofacRegistration();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddJwtToken();
            services.AddLocalization();
            //services.AddVersioning();
            //services.AddProblemDetails();
            services.AddCustomFilters();
            //services.AddSwagger();
            //services.Cors();
            services.AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });
            
            //services.AddSwaggerGenNewtonsoftSupport();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var serviceProvider = app.ApplicationServices;
            //var resources = serviceProvider.GetService<IStringLocalizer<ReturnMessages>>();

            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();

            app.UseExceptionHandler(new ExceptionHandlerOptions
            {
                //ExceptionHandler = new ErrorHandlerMiddleware(env, resources)
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
