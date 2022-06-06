using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Utils
{
    public interface IInput
    {
        public string FetchString(string prompt);
        public string FetchStringThatIsAtLeastOneLetterLong(string prompt);
        public double FetchInputAsDoubleTruncatedToTwoDecimalPlaces(string prompt);


    }
}
