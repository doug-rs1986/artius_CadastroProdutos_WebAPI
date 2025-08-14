using artius_CadastroProdutos_WebAPI.DTOs;
using artius_CadastroProdutos_WebAPI.Services;
using Microsoft.AspNetCore.Builder;

namespace artius_CadastroProdutos_WebAPI.Endpoints
{
    public static class ProdutoEndpoints
    {
        public static void MapProdutoEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/produto", async (ProductCreateDto dto, IProdutoService service) =>
            {
                var produto = await service.AddProdutoAsync(dto);
                return Results.Created($"/produto/{produto.Id}", produto);
            });

            app.MapGet("/produto", async (IProdutoService service) =>
            {
                var produtos = await service.GetProdutosAsync();
                return Results.Ok(produtos);
            });
        }
    }
}
