namespace CurrencyAPI.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T model);
        void Update(T model);
        void Delete(object id);
        T GetById(object id);
        List<T> GetAll();
    }
}
