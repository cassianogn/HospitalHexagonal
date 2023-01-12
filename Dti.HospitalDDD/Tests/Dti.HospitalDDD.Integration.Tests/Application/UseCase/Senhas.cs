using Dti.HospitalDDD.Adapter.DataAccess;
using Dti.HospitalDDD.Atendimento.Application;
using Dti.HospitalDDD.Atendimento.Application.Ports.Out.Senhas;
using Dti.HospitalDDD.Atendimento.Application.UseCase.Senhas.RetirarSenha;
using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;
using Dti.HospitalDDD.Infrastructure.Data.Repostories;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;

namespace Dti.HospitalDDD.Integration.Tests.Application.UseCase
{
    public class Senhas
    {
        [Fact(DisplayName = "Senha_TirarSenha_ObterCodigo")]
        public async Task Senha_TirarSenha_ObterCodigoAsync()
        {
            var providers = GetProviders();
            var inputPort = new RetirarSenhaInputPort(TipoSenha.Preferencial);
            var senhaRepository = providers.GetService<ISenhaRepository>()!;
            var interector = new RetirarSenhaInterector(senhaRepository);


            var result = await interector.Interector(inputPort);


            Assert.Contains("PREF-", result.Codigo);
        }

        public ServiceProvider GetProviders()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddInfrastructure();
            var provider = services.BuildServiceProvider();
            return provider;
        }
    }
}
