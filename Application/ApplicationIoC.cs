using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationIoC
    {
        public static IServiceCollection AddApplicationIoC(
             this IServiceCollection services)
        {
            services.AddSingleton<IPsnService, PsnService>();

            return services;
        }
    }
}