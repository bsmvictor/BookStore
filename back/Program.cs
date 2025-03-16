using Microsoft.OpenApi.Models;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Registra os controllers
builder.Services.AddControllers();

// Registra o banco de dados
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlite("Data Source=database.db"));

// Adiciona Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore API", Version = "v1" });
});

var app = builder.Build();

// Garante que os Controllers estão sendo mapeados
app.UseRouting();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
        c.RoutePrefix = string.Empty; // Swagger na raiz
    });
}

app.UseHttpsRedirection();

// Habilita o uso de Controllers
app.UseAuthorization();
app.MapControllers();

app.Run();


// Criar o projeto
//dotnet new webapi -n BookStore

//Entrar na pasta do projeto
//cd BookStore

//Adicionar os pacotes necessários
//dotnet add package Microsoft.EntityFrameworkCore
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite 
//dotnet add package Microsoft.EntityFrameworkCore.Design
//dotnet add package Swashbuckle.AspNetCore

//Criar o banco de dados
//dotnet ef migrations add Inicial
//dotnet ef database update

//Rodar o projeto
//dotnet watch run

//Acessar a documentação da API
//http://localhost:5143/index.html

