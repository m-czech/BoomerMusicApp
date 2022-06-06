using BoomerMusicApp.Exceptions;

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
        public double FetchInputAsNonNegativeDoubleTruncatedToTwoDecimalPlaces(string prompt)
        {
            var input = FetchString(prompt);
            double parsedInput;
            var parsingResult = Double.TryParse(input, out parsedInput);

            while (!parsingResult)
            {
                input = FetchString(prompt);
            }

            if (parsedInput <= 0) throw new NotPositiveArgument("Entered song length is not a positive number!");

            return Math.Round(parsedInput, 2);
        }


    }
}
