using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;
using Xunit;

namespace Dti.HospitalDDD.Unit.Tests.Domain.Atendimento.Senhas
{
    public class SenhaTests
    {
        [Fact]
        public void CriarSenhaNormal_DevePreencher_DeveEstaCorreta()
        {
            var codigo = 5;
            var codigoEsperado = "NORM-5";
            var senha = Senha.ObterNormal(codigo);

            Assert.True(senha.Tipo == TipoSenha.Normal);
            Assert.Equal(senha.Codigo, codigoEsperado);
        }

        [Fact]
        public void CriarSenhaPreferencial_DevePreencher_DeveEstaCorreta()
        {
            var codigo = 5;
            var codigoEsperado = "PREF-5";
            var senha = Senha.ObterPreferencial(codigo);

            Assert.True(senha.Tipo == TipoSenha.Preferencial);
            Assert.Equal(senha.Codigo, codigoEsperado);
        }
    }
}
