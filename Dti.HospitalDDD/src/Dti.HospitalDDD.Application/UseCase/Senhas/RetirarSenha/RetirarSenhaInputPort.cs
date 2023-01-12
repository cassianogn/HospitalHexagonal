using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;

namespace Dti.HospitalDDD.Atendimento.Application.UseCase.Senhas.RetirarSenha
{
    public class RetirarSenhaInputPort
    {
        public RetirarSenhaInputPort()
        {}
        public RetirarSenhaInputPort(TipoSenha tipoSenha)
        {
            TipoSenha = tipoSenha;
        }

        public TipoSenha TipoSenha { get; set; }
    }
}
