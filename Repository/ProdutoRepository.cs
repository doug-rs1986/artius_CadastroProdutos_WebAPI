using artius_CadastroProdutos_WebAPI.Models;
using artius_CadastroProdutos_WebAPI.Data;

namespace artius_CadastroProdutos_WebAPI.Repository
{
    public interface IProdutoRepository
    {
        Task<Produto> AddAsync(Produto produto);
        Task<IEnumerable<Produto>> GetAllAsync();
    }
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Produto> AddAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }
        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await Task.FromResult(_context.Produtos.ToList());
        }
    }
}
