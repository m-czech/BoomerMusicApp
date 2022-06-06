namespace BoomerMusicApp.Data.DAL
{
    public interface IRepository<T> where T : class
    {
        public void Add(T entity);
        public void Delete(T entity);
        T GetSingle(Func<T, bool> condition);
        List<T> GetAll();
        public void Save();
    }
}
