using FirstWebApi.Domain.Entidades;

namespace FirstWebApi.Application.AppServices
{
    public interface IFilmeRepository
    {
        object GetAll();
        void Insert(Filmes filme);
        void Update(object filmesAlterado);
    }
}