using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class UserAddressRepository : BaseRepository<UserAddress>, IUserAddressRepository
    {
        IFindAddressByCepRepository _findAddressByCepRepository;
        IConfiguration _configuration;
        public UserAddressRepository(IFindAddressByCepRepository findAddressByCepRepository, IConfiguration configuration) : base(configuration)
        {
            _findAddressByCepRepository = findAddressByCepRepository;
            _configuration = configuration;
        }

        public List<UserAddress> GetAddressByUser(int id)
        {
            var getAddressByUser = _conn.Query<UserAddress>(@"select * from ""UserAddress"" as ud
                                                            join ""User"" as u on u.""Id"" = ud.""IdUser""
                                                            where u.""Id"" = @IdUser", new { IdUser = id }).ToList();
            var result = from address in getAddressByUser select address;

            
            return getAddressByUser;
        }

        public async Task<IResult> UserAddressByCep(int id, string cep, string numResidencial, string complemento)
        {
            var result = await _findAddressByCepRepository.findAddressByCep(cep);
            var teste = result.Cep;
            var Address = _conn.Execute($@"insert into ""UserAddress""(""IdUser"", ""Cep"", ""Logradouro"", ""Numero"", ""Complemento"", ""Bairro"", ""Localidade"", ""Uf"",
                                                            ""Ibge"", ""Gia"", ""DDD"", ""Siafi"") 
                                                            values(@IdUser, @Cep, @Logradouro, @Numero, @Complemento, @Bairro, @Localidade, @Uf, @Ibge,
                                                            @Gia, @DDD, @Siafi )", new
                                                                                    {
                                                                                        IdUser = id,
                                                                                        Cep = result.Cep,
                                                                                        Logradouro = result.Logradouro,
                                                                                        Numero = numResidencial,
                                                                                        Complemento = complemento,
                                                                                        Bairro = result.Bairro,
                                                                                        Localidade = result.Localidade,
                                                                                        Uf = result.Uf,
                                                                                        Ibge = result.Ibge,
                                                                                        Gia = result.Gia,
                                                                                        DDD = result.DDD,
                                                                                        Siafi = result.Siafi
                                                                                    });
            return Results.Ok();
        }
    }
}
