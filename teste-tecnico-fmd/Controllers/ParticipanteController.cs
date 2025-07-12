using API.Application.Interfaces;
using API.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace teste_tecnico_fmd.Controllers
{
    [Route("api/participantes")]
    [ApiController]
    public class ParticipanteController : ControllerBase
    {
        private readonly IParticipanteService _participanteService;
        public ParticipanteController(IParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetParticipantes()
        {
            var result = await _participanteService.GetAllParticipantes();

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> PostParticipante(ParticipanteInputModel model)
        {
            var result = await _participanteService.PostParticipante(model);

            return Ok(result);
        }

        [HttpPut("{participanteId}")]
        public async Task<IActionResult> Put(int participanteId, UpdateParticipanteInputModel model)
        {
            var result = await _participanteService.UpdateParticipante(participanteId, model);

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }

        [HttpDelete("{participanteId}")]
        public async Task<IActionResult> Delete(int participanteId)
        {
            var result = await _participanteService.DeleteParticipante(participanteId);

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }
    }
}
