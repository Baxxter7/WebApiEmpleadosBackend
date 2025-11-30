using Microsoft.EntityFrameworkCore;
using WebApiEmpleados.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EmpleadosDbcrudContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL"));
});

// Add services to the container.

builder.Services.AddControllers();

// Swagger UI tradicional
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
