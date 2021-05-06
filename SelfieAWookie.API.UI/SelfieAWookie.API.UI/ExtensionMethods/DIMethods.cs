using Microsoft.Extensions.DependencyInjection;
using SelfieAWookies.Core.Selfies.Domain;
using SelfieAWookies.Core.Selfies.Infrastructure.Data.Repositories;

namespace SelfieAWookie.API.UI.ExtensionMethods
{
    public static class DIMethods
    {
        public static void AddInjections(this IServiceCollection services)
        {
            services.AddScoped<ISelfieRepository, DefaultSelfieRepository>();
        }
    }
}