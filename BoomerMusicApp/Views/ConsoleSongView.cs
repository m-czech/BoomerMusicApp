using BoomerMusicApp.Data.Entities;

namespace BoomerMusicApp.Views
{
    public class ConsoleSongView : IView<Song>
    {
        public void DisplayAll(List<Song> entities)
        {
            entities.ForEach(song => DisplaySingle(song));
        }

        public void DisplaySingle(Song entity)
        {
            Console.WriteLine($"Author: {entity.Author}, Title: {entity.Title}, Album name: {entity.AlbumName}, Lenght: {entity.Lenght} \n");
        }
    }
}
