using BoomerMusicApp.Data.Context;
using BoomerMusicApp.Data.Entities;

namespace BoomerMusicApp.Data.DAL
{
    public class SongRepository : IRepository<Song>
    {
        SongAppContext _context;

        public SongRepository()
        {
            _context = new SongAppContext();
            _context.Database.EnsureCreated();
        }
        public void Add(Song song)
        {
            _context.Songs.Add(song);
        }

        public void Delete(Song song)
        {
            _context.Songs.Remove(song);
        }

        public Song GetSingle(Func<Song, bool> condition)
        {
            return _context.Songs.FirstOrDefault(condition);
        }

        public List<Song> GetAll()
        {
            return _context.Songs.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
