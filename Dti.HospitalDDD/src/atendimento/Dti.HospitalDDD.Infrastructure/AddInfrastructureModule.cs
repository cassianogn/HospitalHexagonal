using Dti.HospitalDDD.Atendimento.Application;
using Dti.HospitalDDD.Infrastructure.Data.DbContexts;
using Dti.HospitalDDD.Infrastructure.Data.Repostories;
using Microsoft.Extensions.DependencyInjection;

namespace Dti.HospitalDDD.Adapter.DataAccess
{
    public static class AddInfrastructurModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<HospitalDTIDb>();
            services.AddApplication<SenhaRepository>();
            return services;
        }
    }
}
