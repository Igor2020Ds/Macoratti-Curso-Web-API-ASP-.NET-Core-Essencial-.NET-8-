using Microsoft.EntityFrameworkCore;
using Teste.API.ContextoDbApp;
using Teste.API.Repositorios.Contratos;
using Teste.API.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContextoApp>(
    // default -> nome da conexao no appsettings
    x=> x.UseSqlServer(builder.Configuration.GetConnectionString("default"))
    );

builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
