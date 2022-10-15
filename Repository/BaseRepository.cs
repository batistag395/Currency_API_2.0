using CurrencyAPI.Repository.Interfaces;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class BaseRepository : IBaseRepository<BaseRepository>
    {
        private readonly string connString = @"Server=Container_Docker;User ID=postgres;Password=postgrespw;
                                             Host=host.docker.internal;Port=49153;Database=postgres;";

        internal IDbConnection _conn;

        public BaseRepository()
        {
            _conn = new NpgsqlConnection(connString);
        }
        
    }
}
