using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;
using Dti.HospitalDDD.Core.Entities;
using Dti.HospitalDDD.Core.Helpers.Constants;
using Dti.HospitalDDD.Core.Helpers.Exceptions;

namespace Dti.HospitalDDD.Atendimento.Domain.Senhas
{
    public class Senha : Entity
    {
        protected Senha(): base(Guid.Empty){}
        private Senha(Guid id, TipoSenha tipo, int codigo) : base(id)
        {
            Tipo = tipo;
            Codigo = ObterPrefixo() + codigo;
        }

        public string Codigo { get; private set; }
        public TipoSenha Tipo { get; private set; }

        private string ObterPrefixo()
        {
            switch (Tipo)
            {
                case TipoSenha.Normal: 
                    return "NORM-";
                case TipoSenha.Preferencial:
                    return "PREF-";
                default:
                    throw new AppException(MensagemErro.ENUM_INVALIDO);
            }
        }

        public static Senha ObterNormal(int codigo)
        {
            return new Senha(Guid.NewGuid(), TipoSenha.Normal, codigo);
        }

        public static Senha ObterPreferencial(int codigo)
        {
            return new Senha(Guid.NewGuid(), TipoSenha.Preferencial, codigo);

        }
    }
}
