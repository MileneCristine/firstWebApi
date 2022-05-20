using FirstWebApi.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.Infra.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {
             
        }

        public DbSet<Filmes> Filmes { get; set; }

    }
}
