using BoomerMusicApp.Data.DAL;
using BoomerMusicApp.Data.Entities;
using BoomerMusicApp.Factories;
using BoomerMusicApp.Utils;
using BoomerMusicApp.Utils.Display;
using BoomerMusicApp.Views;

namespace BoomerMusicApp.Handlers
{
    public class SongHandler : IEntityHandler
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
        public void AddNew()
        {
            var songFactory = new SongFactory(_input);
            var song = songFactory.Create();
            _songRepository.Add(song);
            _songRepository.Save();
        }

        public void DeleteExistingRecord()
        {
            var songTitle = _input.FetchStringThatIsAtLeastOneLetterLong("Enter song's title: ");
            var songAuthor = _input.FetchStringThatIsAtLeastOneLetterLong("Enter song's author: ");
            var soughtSong = _songRepository.GetSingle(song => song.Title.Equals(songTitle) && song.Author.Equals(songAuthor));
            
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
            if (soughtSong != null) { _songView.DisplaySingle(soughtSong); }
            else { _display.Display("Song does not exist in the database"); }
            
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
