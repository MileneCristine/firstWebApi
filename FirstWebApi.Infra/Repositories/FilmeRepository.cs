using FirstWebApi.Application.DTO;
using FirstWebApi.Domain.Entidades;
using FirstWebApi.Application.Interfaces;
using FirstWebApi.Infra.Interfaces;




namespace FirstWebApi.Infra.Data.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly WebApiContext _context;

        public FilmeRepository(WebApiContext webApiContext)

        {
            _context = webApiContext;

        }
        public IEnumerable<Filmes> GetAll()
        {
            return _context.Filmes.ToList();
        }

        public Filmes Insert(Filmes filmes)
        {
            _context.Filmes.Add(filmes);
            _context.SaveChanges();
            return filmes;

        }

        public FilmeDTO Insert(FilmeDTO filmeDTO)
        {
            throw new NotImplementedException();
        }

        public Filmes Update(Filmes filmes)
        {
            _context.Filmes.Update(filmes);
            _context.SaveChanges();
            return filmes;
        }

    
    }
}
