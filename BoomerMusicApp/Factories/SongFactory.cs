using BoomerMusicApp.Data.Entities;
using BoomerMusicApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Factories
{
    public class SongFactory : IFactory<Song>
    {
        IInput _input;
        public SongFactory(IInput input)
        {
            _input = input;
        }
        public Song Create()
        {
            return new Song()
            {
                Author = _input.FetchStringThatIsAtLeastOneLetterLong("Enter author: "),
                Title = _input.FetchStringThatIsAtLeastOneLetterLong("Enter title: "),
                AlbumName = _input.FetchStringThatIsAtLeastOneLetterLong("Enter album name: "),
                Lenght = _input.FetchInputAsNonNegativeDoubleTruncatedToTwoDecimalPlaces("Enter song length: ")
            }
        }
    }
}
