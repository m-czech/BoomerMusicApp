using BoomerMusicApp.Utils.Display;

namespace BoomerMusicApp.Views
{
    public class Menu
    {
        IDisplay _display;
        public Menu(IDisplay display)
        {
            _display = display;
        }
        public void Display()
        {
            _display.Display("Add new song");
            _display.Display("Delete existing song");
            _display.Display("Display specific song");
            _display.Display("Display all songs");
            _display.Display("Display all songs sorted by title");
            _display.Display("Exit the program \n");
        }
    }
}
