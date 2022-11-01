using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        internal IDbConnection _conn;
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        public BaseRepository()
        {
            _conn = new NpgsqlConnection(configuration.GetConnectionString("conn"));
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
        }
        public virtual void Insert(T model)
        {
            _conn.Insert(model);
        }
        public virtual void Update(T model)
        {
            _conn.Update(model);
        }
        public virtual void Delete(object id)
        {
            _conn.Delete<T>(id);
        }
        public virtual T GetById(object id)
        {
            T model = _conn.Get<T>(id);
            return model;
        }
        public virtual List<T> GetAll()
        {
            List<T> list = _conn.GetList<T>().ToList();
            return list;
        }
    }
}
