using BoomerMusicApp.Data.DAL;
using BoomerMusicApp.Data.Entities;
using BoomerMusicApp.Factories;
using BoomerMusicApp.Utils;
using BoomerMusicApp.Utils.Display;
using BoomerMusicApp.Views;
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
        IView<Song> _songView;
        public SongHandler(IInput input, IDisplay display, IView<Song> songView)
        {
            _songRepository = new SongRepository();
            _display = display;
            _input = input;
            _songView = songView;
        }
        public void AddNewSong()
        {
            var songFactory = new SongFactory(_input);
            var song = songFactory.Create();
            _songRepository.Add(song);
            _songRepository.Save();
        }

        public void DeleteExistingSong()
        {
            var songTitle = _input.FetchStringThatIsAtLeastOneLetterLong("Enter song's title: ");
            var songAuthor = _input.FetchStringThatIsAtLeastOneLetterLong("Enter song's author: ");
            var soughtSong = _songRepository.GetSingle(song => song.Title.Equals(songTitle) && song.Author.Equals(songAuthor));
            // obsluga wyjatku zamiast sprawdzania nulla
            if (soughtSong != null)
            {
                _songRepository.Delete(soughtSong);
                _songRepository.Save();
            }
            else
            {
                _display.Display("Song does not exist in the database!");
            }

        }

        public void DisplaySpecificSong()
        {
            var songTitle = _input.FetchStringThatIsAtLeastOneLetterLong("Enter song's title: ");
            var songAuthor = _input.FetchStringThatIsAtLeastOneLetterLong("Enter song's author: ");
            var soughtSong = _songRepository.GetSingle(song => song.Title.Equals(songTitle) && song.Author.Equals(songAuthor));
            
            _songView.DisplaySingle(soughtSong);
        }

        public void DisplayAllSongs()
        {
            _songView.DisplayAll(_songRepository.GetAll());
        }

        public void DisplayAllSongsSortedByTitle()
        {
            var sortedSongs = _songRepository.GetAll().OrderBy(song => song.Title);
            foreach (var song in sortedSongs)
            {
                _songView.DisplaySingle(song);
            }
        }


    }
}
