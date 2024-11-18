using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Autor;

namespace WebApiBiblioteca.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase {

        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores() {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }

    }
}
