namespace BoomerMusicApp.Data.Entities
{
    public class Song
    {
        public Guid SongId { get; set; }
        public string Title { get; set; }
        
        public string Author { get; set; }
        public string AlbumName { get; set; }
        public double Lenght { get; set; }
    }
}
