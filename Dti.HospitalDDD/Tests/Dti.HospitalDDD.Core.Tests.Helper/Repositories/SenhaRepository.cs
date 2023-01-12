using Dti.HospitalDDD.Atendimento.Application.Ports.Out.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;

namespace Dti.HospitalDDD.Core.Tests.Helper.Repositories
{
    public class SenhaRepository : ISenhaRepository
    {
        public Task AddAsync(Senha senha)
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int GerarNovoCodigo(TipoSenha tipoSenha)
        {
            return 01;
        }
    }
}
