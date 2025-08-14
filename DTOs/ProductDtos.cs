namespace artius_CadastroProdutos_WebAPI.DTOs
{
    public class ProductCreateDto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}
