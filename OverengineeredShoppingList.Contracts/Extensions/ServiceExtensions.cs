using Microsoft.Extensions.DependencyInjection;
using OverengineeredShoppingList.Application.Interfaces.Services;
using OverengineeredShoppingList.Application.Services;

namespace OverengineeredShoppingList.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
