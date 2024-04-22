using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Repositories.Interfaces;
using ProductAPI.Repositories.Repositories;
using ProductAPI.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
        options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


builder.Services.AddDbContext<Dbcontext_Product>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Dbcontext_Product");
    options.UseSqlServer(connectionString);
});



// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseAuthorization();

app.MapControllers();

app.Run();