using FirstWebApi.Data;
using FirstWebApi.DTO;
using FirstWebApi.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly WebApiContext _context;

        public FilmesController(WebApiContext context)
         {
             _context = context;
         }


        [HttpGet]
        public IActionResult GetAll() 
        {
            var filmes = _context.Filmes.ToList();
            var filmeDTO = filmes.Select(x => new FilmeDTO
            {
                Id = x.Id,
                Nome = x.Nome,
                Ano = x.Ano

            }
            );

            return Ok(filmes);
        }

        [HttpPost]

        public IActionResult Insert(FilmeDTO filmeDTO)
        {
            
            {
                var filmes = new Filmes
                {
                    Nome = filmeDTO.Nome,
                    Ano = filmeDTO.Ano
                };


                _context.Filmes.Add(filmes);
                _context.SaveChanges();
                filmeDTO.Id = filmes.Id;
                return Ok(filmes);
            }

        }


        [HttpPut]

        public IActionResult Update(FilmeDTO filmeDTO)
        {
            var filmesAlterado = _context.Filmes.FirstOrDefault(x => x.Id == filmeDTO.Id);
            if (filmesAlterado == null)
                return NotFound();

            filmesAlterado.Nome = filmeDTO.Nome;  
            filmesAlterado.Ano = filmeDTO.Ano;

            _context.Filmes.Update(filmesAlterado);
            _context.SaveChanges();
            return Ok(filmeDTO);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var filmes = _context.Filmes.Find(id);
            if (filmes == null)
                return NotFound();

            _context.Filmes.Remove(filmes);
            _context.SaveChanges();
            return Ok("Filme " + id + " Filme Excluido!  ");
        }

        [HttpGet("GetById", Name = "GetById")]

        public IActionResult GetById(int id) {

            var filmes = _context.Filmes.Find(id);
            if (filmes == null)
                return NotFound();

            var filmeDTO = new FilmeDTO
            {
                Id = filmes.Id,
                Nome = filmes.Nome,
                Ano = filmes.Ano
            };

            return Ok(filmeDTO); 
        }

    }
}
