namespace BoomerMusicApp.Factories
{
    public interface IFactory<T> where T : class
    {
        public T Create();
    }
}
