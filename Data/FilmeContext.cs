using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace FilmesApi.Data
{
    public class FilmeContext : DbContext
    {

        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {

        }

        public DbSet<Filme> Filmes { get; set; }    
    }
}
