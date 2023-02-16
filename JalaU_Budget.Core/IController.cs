namespace JalaU.Budget.Core
{
    public interface IController<T>
    {
        public bool Register(T item);
        public IEnumerable<T> Read();
    }
}
