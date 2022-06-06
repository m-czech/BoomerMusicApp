using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomerMusicApp.Utils
{
    public class ConsoleInput : IInput
    {
        public string FetchString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public string FetchStringThatIsAtLeastOneLetterLong(string prompt)
        {
            var input = FetchString(prompt);
            while (input.Length < 1)
            {
                input = FetchString(prompt);
            }
            return input;
        }
        public double FetchInputAsDoubleTruncatedToTwoDecimalPlaces(string prompt)
        {
            var input = FetchString(prompt);
            double parsedInput;
            while (!Double.TryParse(input, out parsedInput))
            {
                input = FetchString(prompt);
            }
            return parsedInput;
        }


    }
}
