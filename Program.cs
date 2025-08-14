using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using artius_CadastroProdutos_WebAPI.Data;
using artius_CadastroProdutos_WebAPI.Repository;
using artius_CadastroProdutos_WebAPI.Services;
using artius_CadastroProdutos_WebAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("ProdutosDb"));
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cadastro de Produtos API", Version = "v1" });
});
builder.Services.AddCors();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapProdutoEndpoints();

app.UseCors(builder =>
    builder.WithOrigins("http://localhost:3000")
           .AllowAnyHeader()
           .AllowAnyMethod());

app.Run();
