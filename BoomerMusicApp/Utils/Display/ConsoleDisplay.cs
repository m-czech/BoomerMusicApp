namespace BoomerMusicApp.Utils.Display
{
    public class ConsoleDisplay : IDisplay
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Display(string entry)
        {
            Console.WriteLine(entry);
        }
    }
}
