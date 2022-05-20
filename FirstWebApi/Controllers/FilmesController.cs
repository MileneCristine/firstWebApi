using FirstWebApi.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {

        private readonly IFilmeAppService _filmeAppService;

        public FilmesController(IFilmeAppService filmeAppService)
        {
            _filmeAppService = filmeAppService;
        }



        [HttpGet]
        public IActionResult GetAll() 
        {


            return Ok(_filmeAppService.GetAll());
        }

        [HttpPost]

        public IActionResult Insert(FilmeDTO filmeDTO)
        {



            return Ok(_filmeAppService.Insert(filmeDTO));
            

        }


        //[HttpPut]

        //public IActionResult Update(FilmeDTO filmeDTO)
        //{
           
        //    return Ok(filmeDTO);
        //}

    //    [HttpDelete]
    //    public IActionResult Delete(int id)
    //    {
    //        var filmes = _context.Filmes.Find(id);
    //        if (filmes == null)
    //            return NotFound();

    //        _context.Filmes.Remove(filmes);
    //        _context.SaveChanges();
    //        return Ok("Filme " + id + " Filme Excluido!  ");
    //    }

    //    [HttpGet("GetById", Name = "GetById")]

    //    public IActionResult GetById(int id) {

    //        var filmes = _context.Filmes.Find(id);
    //        if (filmes == null)
    //            return NotFound();

    //        var filmeDTO = new FilmeDTO
    //        {
    //            Id = filmes.Id,
    //            Nome = filmes.Nome,
    //            Ano = filmes.Ano
    //        };

    //        return Ok(filmeDTO); 
    //    }

    }
}
