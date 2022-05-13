using System;
using cadastroClientesAPI.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace cadastroClientesAPI.DependencyInjection
{
    public static class FiltersExtensions
    {
        public static IServiceCollection AddCustomFilters(this IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(NotificationFilter));
            });

            return services;
        }
    }
}
