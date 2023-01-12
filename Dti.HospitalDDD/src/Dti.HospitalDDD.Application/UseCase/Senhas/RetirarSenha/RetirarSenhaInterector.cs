using Dti.HospitalDDD.Atendimento.Application.Ports.Out.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;
using Dti.HospitalDDD.Core.Helpers.Constants;
using Dti.HospitalDDD.Core.Helpers.Exceptions;

namespace Dti.HospitalDDD.Atendimento.Application.UseCase.Senhas.RetirarSenha
{
    public class RetirarSenhaInterector
    {
        private readonly ISenhaRepository _repository;
        public RetirarSenhaInterector(ISenhaRepository repository)
        {
            _repository = repository;
        }

        public async Task<RetirarSenhaOutputPort> Interector(RetirarSenhaInputPort inputPort)
        {
            int novoCodigo = _repository.GerarNovoCodigo(inputPort.TipoSenha);

            Senha senha = inputPort.TipoSenha switch
            {
                TipoSenha.Normal => Senha.ObterNormal(novoCodigo),
                TipoSenha.Preferencial => Senha.ObterPreferencial(novoCodigo),
                _ => throw new AppException(MensagemErro.ENUM_INVALIDO),
            };

            await _repository.AddAsync(senha);
            var result = new RetirarSenhaOutputPort(senha.Codigo);
            return result;
        }
    }
}
