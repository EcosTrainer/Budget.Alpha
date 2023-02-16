namespace JalaU.Budget.Core
{
    public interface IRepository<T>
    {
        public bool Save(T entity);
        public IEnumerable<T> GetAll();
    }
}
