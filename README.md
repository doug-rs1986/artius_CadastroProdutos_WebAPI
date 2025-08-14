# Cadastro de Produtos WebAPI

API RESTful para cadastro e consulta de produtos, desenvolvida com .NET 8, C# 12 e Entity Framework Core (InMemory). O projeto demonstra boas práticas de arquitetura, como uso de Repository, Service, DTOs e documentação automática via Swagger.

## Funcionalidades

- Cadastro de produtos (nome, preço, categoria)
- Consulta de produtos cadastrados
- Arquitetura limpa: Repository, Service e DTOs
- Banco de dados em memória para fácil execução e testes
- CORS habilitado para integração com frontends (ex: React)
- Documentação interativa via Swagger

## Tecnologias Utilizadas

- .NET 8 / C# 12
- ASP.NET Core Minimal APIs
- Entity Framework Core (InMemory)
- Swagger/OpenAPI
- Dependency Injection

## Como Executar

1. Clone o repositório:
   ```bash
   git clone [https://github.com/doug-rs1986/artius_CadastroProdutos_WebAPI]
   cd artius_CadastroProdutos_WebAPI
   ```
2. Execute o projeto:
   ```bash
   dotnet run
   ```
3. Acesse a documentação interativa:
   [https://localhost:7257;http://localhost:5027)

## Endpoints Principais

- `POST /cadastrarProduto` — Cadastra um novo produto
- `GET /buscarProdutos` — Lista todos os produtos cadastrados

## Estrutura do Projeto

- `Endpoints/` — Mapeamento dos endpoints da API
- `Repository/` — Lógica de acesso a dados
- `Services/` — Regras de negócio
- `DTOs/` — Objetos de transferência de dados
- `Data/` — Contexto do banco de dados

## Licença

MIT

---

**Contato:**
Para dúvidas ou oportunidades, entre em contato pelo [LinkedIn](https://www.linkedin.com/in/douglas-rodrigues-santos) ou abra uma issue.
