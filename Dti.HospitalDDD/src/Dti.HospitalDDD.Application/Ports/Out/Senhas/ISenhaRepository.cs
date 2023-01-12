using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;

namespace Dti.HospitalDDD.Atendimento.Application.Ports.Out.Senhas
{
    public interface ISenhaRepository : IDisposable
    {
        Task AddAsync(Senha senha);

        int GerarNovoCodigo(TipoSenha tipoSenha);
    }
}
