using ApiP.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiP.Data
{
    public class TiendaPeliculasContext : DbContext
    {
        public TiendaPeliculasContext(DbContextOptions<TiendaPeliculasContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Pelicula>().HasData(
        new Pelicula { Id = 1, Titulo = "Titanic", Director = "James Cameron", Año = 1997 },
        new Pelicula { Id = 2, Titulo = "The Shawshank Redemption", Director = "Frank Darabont", Año = 1994 },
        new Pelicula { Id = 3, Titulo = "The Godfather", Director = "Francis Ford Coppola", Año = 1972 }
    );

        }
    }


}


