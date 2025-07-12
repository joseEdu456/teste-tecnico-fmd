using API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace teste_tecnico_fmd.Controllers
{
    [Route("api/trivia")]
    [ApiController]
    public class ApiTriviaController : ControllerBase
    {
        private readonly IApiExtensionService _trivia;

        public ApiTriviaController(IApiExtensionService trivia)
        {
            _trivia = trivia;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrivia()
        {
            var conteudo = await _trivia.GetTrivia();

            if (!conteudo.IsSucess)
                return BadRequest(conteudo.Message);

            return Ok(conteudo);
        }
    }
}
