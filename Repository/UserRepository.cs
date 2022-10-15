using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository() : base()
        {

        }

        public List<User> Get()
        {
            return _conn.Query<User>(@"select * from ""User"" ").ToList();
        }

        public User GetById(int id)
        {
            return _conn.QuerySingleOrDefault<User>(@"select * from ""User"" where ""Id"" = @Id ",
                                                     new { Id = id });

        }
        public void insert(User user)
        {
            _conn.Execute(@"insert into ""User""(""Name"") values(@Name) ", user);
        }
        public void Update(User user)
        {

            _conn.Execute(@"UPDATE ""User"" SET ""Name"" = @Name  
                              WHERE ""Id"" = @Id ", user);
        }
        public void Delete(int id)
        {
            _conn.Execute(@"delete from ""User"" where ""Id"" = @Id ",
                           new { Id = id });
        }

    }
}
