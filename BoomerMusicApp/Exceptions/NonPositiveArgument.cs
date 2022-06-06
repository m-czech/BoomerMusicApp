namespace BoomerMusicApp.Exceptions
{
    [Serializable]
    public class NotPositiveArgument : Exception
    {
        public NotPositiveArgument() { }
        public NotPositiveArgument(string message) : base(message) { }

        public NotPositiveArgument(string message , Exception innerException) : base(message, innerException) { }
    }
}
