using API.Application.Interfaces;
using API.Application.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace teste_tecnico_fmd.Controllers
{
    [Route("api/palestras")]
    [ApiController]
    public class PalestraController : ControllerBase
    {
        private readonly IPalestraService _palestraService;

        public PalestraController(IPalestraService palestraService)
        {
            _palestraService = palestraService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPalestras()
        {
            var result = await _palestraService.GetAllPalestra();

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> PostPalestra(PalestraInputModel model)
        {
            var result = await _palestraService.PostPalestra(model);

            return NoContent();
        }
    }
}
