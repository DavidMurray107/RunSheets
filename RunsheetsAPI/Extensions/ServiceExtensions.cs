using Contracts;
using Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace RunsheetsAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        public static void ConfigureDatabaseConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Entities.RepositoryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlServerDev"))
            );
        }
    }
}
