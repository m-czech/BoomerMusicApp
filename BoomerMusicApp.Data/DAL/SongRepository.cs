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
        public void Add(Song song)
        {

        }

        public void Delete(Song song)
        {

        }

        public Song GetSingle(Func<Song, bool> condition)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
