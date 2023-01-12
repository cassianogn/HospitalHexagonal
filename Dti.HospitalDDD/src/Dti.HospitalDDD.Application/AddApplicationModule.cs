using Dti.HospitalDDD.Atendimento.Application.Ports.Out.Senhas;
using Microsoft.Extensions.DependencyInjection;

namespace Dti.HospitalDDD.Atendimento.Application
{
    public static class AddApplicationModule
    {
        public static IServiceCollection AddApplication<TSenhaRepository>(this IServiceCollection services)
            where TSenhaRepository : class, ISenhaRepository
        {
            services.AddScoped<ISenhaRepository, TSenhaRepository>();
            return services;
        }
    }
}
