namespace FirstWebApi.Controllers
{
    internal interface IFilmeAppService
    {
        object? Insert(FilmeDTO filmeDTO);
        object? GetAll();
    }
}