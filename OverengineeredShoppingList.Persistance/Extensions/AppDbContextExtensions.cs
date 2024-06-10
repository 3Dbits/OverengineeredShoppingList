using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OverengineeredShoppingList.Persistance.Data;
using OverengineeredShoppingList.Persistance.Repositories;
using OverengineeredShoppingList.Application.Interfaces.Persistance;

namespace OverengineeredShoppingList.Persistance.Extensions
{
    public static class AppDbContextExtensions
    {
        public static void AddAppDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("defaultConnection") ?? throw new InvalidOperationException("Connection string for DB not found.")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
