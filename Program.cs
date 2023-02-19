using CurrencyAPI.Controllers;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IFindAddressByCepRepository, FindAddressByCepRepository>();
builder.Services.AddSingleton<IUserAddressRepository, UserAddressRepository>();
builder.Services.AddSingleton<ISaleRepository, SalesRepository>();
builder.Services.AddTransient<ICalcPrecoPrazoRepository, CalcPrecoPrazoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
