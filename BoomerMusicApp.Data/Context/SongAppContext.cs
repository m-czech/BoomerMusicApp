using BoomerMusicApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Data.Context
{
    public class SongAppContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SongApp;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song { AlbumName = "Lost & Found", Author = "Jorja Smith", Title = "Blue lights", Lenght = 4.10D },
                new Song { AlbumName = "Best Things in Life", Author = "Dreamliners", Title = "Best things in life", Lenght = 2.23D },
                new Song { AlbumName = "Nase male spiwanie", Author = "Siklawa", Title = "Takiego Janicka", Lenght = 3.43D }
            );
        }

    }
}
