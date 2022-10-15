using CurrencyAPI.Model;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface IUserRepository
    {
        public List<User> Get();
        public User GetById(int id);
        public void insert(User user);
        public void Update(User user);
        public void Delete(int id);
    }
}
