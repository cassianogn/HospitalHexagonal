using Dti.HospitalDDD.Atendimento.Domain.Senhas.Enums;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Interfaces;
using Dti.HospitalDDD.Atendimento.Domain.Senhas.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dti.HospitalDDD.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SenhaController : ControllerBase
    {
        private readonly SenhaService _service;

        public SenhaController(SenhaService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> TirarSenhaAsync(TipoSenha tipoSenha)
        {
            var senha = await _service.RetirarSenhaAsync(tipoSenha);
            return Ok(senha);

        }
    }
}
