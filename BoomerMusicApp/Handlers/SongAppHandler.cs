using BoomerMusicApp.Data.Entities;
using BoomerMusicApp.Utils;
using BoomerMusicApp.Utils.Display;
using BoomerMusicApp.Views;

namespace BoomerMusicApp.Handlers
{
    public class SongAppHandler
    {
        IDisplay _display;
        IInput _input;
        IView<Song> _songView;
        SongHandler _songHandler;
        Menu _menu;
        public SongAppHandler()
        {
            _display = new ConsoleDisplay();
            _input = new ConsoleInput();
            _songView = new ConsoleSongView();
            _songHandler = new(_input, _display, _songView);
            _menu = new(_display);
        }

        public void Start()
        {
            _display.Display("Welcome to the BoomerSongApp! \n");
            _menu.Display();

            var _userInput = _input.FetchString("Enter your option: ");

            while (!_userInput.Equals("Exit the program")) {
                switch (_userInput)
                {
                    case "Add new song":
                        _songHandler.AddNew();
                        break;
                    case "Delete existing song":
                        _songHandler.DeleteExistingRecord();
                        break;
                    case "Display specific song":
                        _songHandler.DisplaySpecificSong();
                        break;
                    case "Display all songs":
                        _songHandler.DisplayAllSongs();
                        break;
                    case "Display all songs sorted by title":
                        _songHandler.DisplayAllSongsSortedByTitle();
                        break;
                    case "Exit the program":
                        return;
                }
               
                _menu.Display();
                _userInput = _input.FetchString("Enter your option: ");
            }
        }
    }
}
