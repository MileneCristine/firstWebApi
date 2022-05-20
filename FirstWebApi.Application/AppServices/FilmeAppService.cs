using FirstWebApi.Application.DTO;
using FirstWebApi.Application.Interfaces;
using FirstWebApi.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Application.AppServices
{
    public class FilmeAppService : IFilmeAppService
    {

        private readonly IFilmeRepository _filmeRepository;

        public FilmeAppService(IFilmeRepository filmeRepository)

        {
            _filmeRepository = filmeRepository;
        }


        public IEnumerable<FilmeDTO> GetAll()
        {

            var filmes = _filmeRepository.GetAll();
            var filmesDTO = filmes.Select(c => new FilmeDTO
            {
                Id = x.Id,
                Nome = x.Nome,
                Ano = x.Ano

            });
            return filmesDTO;

        }

        public FilmeDTO Insert(FilmeDTO filmeDTO)
        {
            var filme = new Filmes
            {
                Nome = filmeDTO.Nome,
                Ano = filmeDTO.Ano
            };

            _filmeRepository.Insert(filme);

            filmeDTO.Id = filme.Id;
            return filmeDTO;


        }

        //public FilmeDTO Update(FilmeDTO filmeDTO)
        //{
        //    var filmesAlterado = _context.Filmes.FirstOrDefault(x => x.Id == filmeDTO.Id);


        //    filmesAlterado.Nome = filmeDTO.Nome;
        //    filmesAlterado.Ano = filmeDTO.Ano;


        //    _filmeRepository.Update(filmesAlterado);

        //}
    }
}
