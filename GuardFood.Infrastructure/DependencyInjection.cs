using GuardFood.Infrastructure.Context;
using GuardFood.Infrastructure.Data.Interfaces;
using GuardFood.Infrastructure.Data.Repository;
using GuardFood.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GuardFood.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<GFContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(GFContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<GFContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IRestauranteRepository, RestauranteRepository>();

            services.ConfigureApplicationCookie(options =>
                     options.AccessDeniedPath = "/Account/Login");

            //services.AddScoped<IRestauranteRepository, RestauranteRepository>();
            

            return services;
        }
    }
}
