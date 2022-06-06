using BoomerMusicApp.Utils;
using BoomerMusicApp.Utils.Display;

namespace BoomerMusicApp.Handlers
{
    public class SongAppHandler
    {
        IDisplay _display;
        IInput _input;
        SongHandler _songHandler;
        public SongAppHandler()
        {
            _display = new ConsoleDisplay();
            _input = new ConsoleInput();
            _songHandler = new(_input, _display);
        }

        public void Start()
        {
            _display.Display("Welcome to the BoomerSongApp! \n");
            var _userInput = _input.FetchInput("Enter your option: ");

            while (!_userInput.Equals("Exit the program")) {
                switch (_userInput)
                {
                    case "Add new song":
                        _songHandler.AddNewSong();
                        break;
                    case "Delete existing song":
                        _songHandler.DeleteExistingSong();
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
            }
        }
    }
}
