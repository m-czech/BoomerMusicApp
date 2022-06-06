using BoomerMusicApp.Data.Context;
using BoomerMusicApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Data.DAL
{
    public class SongRepository : IRepository<Song>
    {
        SongAppContext _context;

        public SongRepository()
        {
            _context = new SongAppContext();
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
            return _context.Songs.Where(condition).First();
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
