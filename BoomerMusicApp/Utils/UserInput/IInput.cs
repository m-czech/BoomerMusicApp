namespace BoomerMusicApp.Utils
{
    public interface IInput
    {
        public string FetchString(string prompt);
        public string FetchStringThatIsAtLeastOneLetterLong(string prompt);
        public double FetchInputAsNonNegativeDoubleTruncatedToTwoDecimalPlaces(string prompt);


    }
}
