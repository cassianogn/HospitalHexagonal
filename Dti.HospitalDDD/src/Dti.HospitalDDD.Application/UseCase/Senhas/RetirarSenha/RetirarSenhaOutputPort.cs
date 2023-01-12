using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dti.HospitalDDD.Atendimento.Application.UseCase.Senhas.RetirarSenha
{
    public class RetirarSenhaOutputPort
    {
        public RetirarSenhaOutputPort(string codigo)
        {
            Codigo = codigo;
        }

        public string Codigo { get; set; }
    }
}
