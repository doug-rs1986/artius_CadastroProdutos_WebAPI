using artius_CadastroProdutos_WebAPI.DTOs;
using artius_CadastroProdutos_WebAPI.Models;
using artius_CadastroProdutos_WebAPI.Repository;

namespace artius_CadastroProdutos_WebAPI.Services
{
    public interface IProdutoService
    {
        Task<ProductReadDto> AddProdutoAsync(ProductCreateDto dto);
        Task<IEnumerable<ProductReadDto>> GetProdutosAsync();
    }
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repo;
        public ProdutoService(IProdutoRepository repo)
        {
            _repo = repo;
        }
        public async Task<ProductReadDto> AddProdutoAsync(ProductCreateDto dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Preco = dto.Preco,
                Categoria = dto.Categoria
            };
            var result = await _repo.AddAsync(produto);
            return new ProductReadDto
            {
                Id = result.Id,
                Nome = result.Nome,
                Preco = result.Preco,
                Categoria = result.Categoria
            };
        }
        public async Task<IEnumerable<ProductReadDto>> GetProdutosAsync()
        {
            var produtos = await _repo.GetAllAsync();
            return produtos.Select(p => new ProductReadDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                Categoria = p.Categoria
            });
        }
    }
}
