using Entities.Models;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Enable Swagger/OpenAPI documentation generation.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the UserRepository and create a singleton instance.
builder.Services.AddSingleton<UserRepository>();
builder.Services.AddSingleton<List<User>>();

// Register the ItemRepository and create a singleton instance.
builder.Services.AddSingleton<ItemRepository>();
builder.Services.AddSingleton<List<Items>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable Swagger UI for testing and exploring the API endpoints.
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Map the API controllers to the request pipeline.
app.MapControllers();

app.Run();
