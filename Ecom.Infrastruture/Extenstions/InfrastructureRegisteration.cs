using Ecom.Core.Interfaces;
using Ecom.Infrastruture.Data.DbContexts;
using Ecom.Infrastruture.Repositires;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecom.Infrastruture.Extenstions
{
    public static class InfrastructureRegisteration
    {
        public static IServiceCollection AddInfrastructureConfiguration(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenaricRepositry<>), typeof(GenaricRepositry<>));
            //Apply Unit of Work pattern 
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
 