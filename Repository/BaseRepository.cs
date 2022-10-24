using CurrencyAPI.Repository.Interfaces;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class BaseRepository : IBaseRepository<BaseRepository>
    {
        internal IDbConnection _conn;
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        public BaseRepository()
        {
            _conn = new NpgsqlConnection(configuration.GetConnectionString("conn"));
        }        
    }
}
