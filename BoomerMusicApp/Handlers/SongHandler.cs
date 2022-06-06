using BoomerMusicApp.Data.DAL;
using BoomerMusicApp.Data.Entities;
using BoomerMusicApp.Utils;
using BoomerMusicApp.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Handlers
{
    public class SongHandler
    {
        IRepository<Song> _songRepository;
        IDisplay _display;
        IInput _input;
        public SongHandler(IInput input, IDisplay display)
        {
            _songRepository = new SongRepository();
            _display = display;
            _input = input;
        }
        public void AddNewSong()
        {

        }

        public void DeleteExistingSong()
        {

        }

        public void DisplaySpecificSong(Func<Song, bool> condition)
        {

        }

        public void DisplayAllSongs()
        {

        }

        public void DisplayAllSongsSortedByTitle()
        {

        }


    }
}
