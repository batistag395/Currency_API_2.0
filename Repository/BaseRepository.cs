using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        internal IDbConnection _conn;
        IConfiguration _configuration;
        IConvertDataRepository _convertDataRepository;
        IConfigurationRoot _configurationRoot = new ConfigurationBuilder()
          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
          .AddJsonFile("appsettings.json")
          .Build();
        
        public BaseRepository(IConfiguration configuration)
        {
            _convertDataRepository = new ConvertDataRepository(configuration);
            string conn = _configurationRoot.GetConnectionString("conn");
            conn = _convertDataRepository.decryptData(conn);
            _configuration = configuration;
            _conn = new NpgsqlConnection(_convertDataRepository.decryptData(_configurationRoot.GetConnectionString("conn"))) ;
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
