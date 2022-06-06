namespace BoomerMusicApp.Exceptions
{
    [Serializable]
    public class NonPositiveArgument : Exception
    {
        public NonPositiveArgument() { }
        public NonPositiveArgument(string message) : base(message) { }

        public NonPositiveArgument(string message , Exception innerException) : base(message, innerException) { }
    }
}
