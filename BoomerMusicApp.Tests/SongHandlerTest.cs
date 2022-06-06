using BoomerMusicApp.Data.DAL;
using BoomerMusicApp.Data.Entities;
using NSubstitute;
using NUnit.Framework;

namespace BoomerMusicApp.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddNewSong_NewSong_AddSongToDatabase()
        {
            
        }
        
        [Test]
        public void DisplayAllSongs_DatabaseWithTwoSongs_DisplayTwoSongs()
        {
            var songHandler = Substitute.For<IRepository<Song>>();
        }

        [Test]
        public void DisplaySpecificSong_DatabaseWithAtLeastOneSong_DisplaySong()
        {

        }
    }
}