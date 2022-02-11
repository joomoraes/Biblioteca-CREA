using LibraryCrea.Domain.Dtos.CadastroLivro;
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
        [Route("{id}", Name = "GetCadastroLivroWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CadastroLivroDtoCreate cadastroLivro)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Post(cadastroLivro);
                if(result != null)
                {
                    return Ok(result);
                } else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CadastroLivroDtoUpdate cadastroLivro)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Put(cadastroLivro);
                if(result != null)
                {
                    return Ok(result);
                } else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id}")]   
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }   
    }
}
