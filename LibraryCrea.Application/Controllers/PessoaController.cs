using LibraryCrea.Domain.Dtos.Pessoa;
using LibraryCrea.Domain.Interface.Service.Pessoa;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryCrea.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        public IPessoaService _service { get; set; }

        public PessoaController(IPessoaService service)
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
        [Route("{id", Name = "GetPessoaWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.IsValid);

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
        public async Task<ActionResult> Post([FromBody] PessoaDtoCreate pessoa)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Post(pessoa);
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
        public async Task<ActionResult> Put([FromBody] PessoaDtoUpdate pessoa)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Put(pessoa);
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
        public async Task<ActionResult> Delete(Guid Id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Delete(Id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
