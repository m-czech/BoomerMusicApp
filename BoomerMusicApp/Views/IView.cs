namespace BoomerMusicApp.Views
{
    public interface IView<T>
    {
        public void DisplaySingle(T entity);
        public void DisplayAll(List<T> entities);
    }
}
