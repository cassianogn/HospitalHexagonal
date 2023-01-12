using Dti.HospitalDDD.Atendimento.Application.Ports.Out.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;
using Dti.HospitalDDD.Infrastructure.Data.DbContexts;

namespace Dti.HospitalDDD.Infrastructure.Data.Repostories
{
    internal class SenhaRepository : ISenhaRepository
    {
        private readonly HospitalDTIDb _db;
        
        public SenhaRepository(HospitalDTIDb db)
        {
            _db = db;
        }

        public async Task AddAsync(Senha senha)
        {
            await _db.Senhas.AddAsync(senha);
            await _db.SaveChangesAsync();
        }

    
        public int GerarNovoCodigo(TipoSenha tipoSenha)
        {
            var ultimaSenha = _db.Senhas
                .Where(senha => senha.Tipo == tipoSenha)
                .OrderByDescending(senha => senha.DataCriacao)
                .FirstOrDefault();
            int codigo;

            if (ultimaSenha == null)
                codigo = 0;
            else
            {
                var separadorDePrefixo = '-';
                var codigoDividido = ultimaSenha.Codigo.Split(separadorDePrefixo);
                var parteNumericaDoCodigo = codigoDividido[1];

                codigo = int.Parse(parteNumericaDoCodigo);
            }

            return codigo;
        }

        public void Dispose() => _db.Dispose();

    }
}
