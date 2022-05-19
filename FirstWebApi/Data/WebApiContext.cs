using FirstWebApi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {
             
        }

        public DbSet<Filmes> Filmes { get; set; }

    }
}
