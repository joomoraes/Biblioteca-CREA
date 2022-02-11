using LibraryCrea.Domain.Interface.Service.CadastroLivro;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryCrea.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroLivroController : ControllerBase
    {
        public ICadastroLivroService _service { get; set; }

        public CadastroLivroController(ICadastroLivroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        
    }
}
