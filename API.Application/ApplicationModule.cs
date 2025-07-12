using API.Application.Interfaces;
using API.Application.Services;
using API.Core.Interfaces;
using API.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services
                .AddServices()
                .AddRepositories();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPalestraService, PalestraService>();
            services.AddScoped<IParticipanteService, ParticipanteService>();
            services.AddScoped<IApiExtensionService, ApiTriviaService>();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPalestraRepository, PalestraRepository>();
            services.AddScoped<IParticipanteRepository, ParticipanteRepository>();

            return services;
        }
    }
}
