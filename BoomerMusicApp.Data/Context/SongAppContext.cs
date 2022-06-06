using BoomerMusicApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

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
                new Song { AlbumName = "Lost & Found", Author = "Jorja Smith", Title = "Blue lights", Lenght = 4.10D, SongId = Guid.NewGuid() },
                new Song { AlbumName = "Best Things in Life", Author = "Dreamliners", Title = "Best things in life", Lenght = 2.23D, SongId = Guid.NewGuid() },
                new Song { AlbumName = "Nase male spiwanie", Author = "Siklawa", Title = "Takiego Janicka", Lenght = 3.43D, SongId = Guid.NewGuid() }
                // Record with missing data, created to check if ConsoleSongView.DisplaySingle() throws exception properly
                // new Song { AlbumName = "", Author = "Test", Title = "", Lenght = 0.01, SongId = Guid.NewGuid() }
            );
        }

    }
}
