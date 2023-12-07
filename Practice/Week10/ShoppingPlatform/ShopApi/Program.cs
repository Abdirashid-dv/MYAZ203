using ShopEntities.Models;
using ShopRepositories.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ProductsRepository>();
builder.Services.AddSingleton<UsersRepository>();
builder.Services.AddSingleton<HistoriesRepository>();

builder.Services.AddSingleton<List<Products>>();
builder.Services.AddSingleton<List<Users>>();
builder.Services.AddSingleton<List<Histories>>();

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
