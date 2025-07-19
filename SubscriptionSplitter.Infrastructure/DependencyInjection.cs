using Microsoft.EntityFrameworkCore;
using SubscriptionSplitter.Infrastructure.Identity;
using SubscriptionSplitter.Infrastructure.Persistence;
using SubscriptionSplitter.Application.Interfaces;

namespace SubscriptionSplitter.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}