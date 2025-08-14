# Cadastro de Produtos WebAPI

API RESTful para cadastro e consulta de produtos, desenvolvida com .NET 8, C# 12 e Entity Framework Core (InMemory). O projeto demonstra boas pr�ticas de arquitetura, como uso de Repository, Service, DTOs e documenta��o autom�tica via Swagger.

## Funcionalidades

- Cadastro de produtos (nome, pre�o, categoria)
- Consulta de produtos cadastrados
- Arquitetura limpa: Repository, Service e DTOs
- Banco de dados em mem�ria para f�cil execu��o e testes
- CORS habilitado para integra��o com frontends (ex: React)
- Documenta��o interativa via Swagger

## Tecnologias Utilizadas

- .NET 8 / C# 12
- ASP.NET Core Minimal APIs
- Entity Framework Core (InMemory)
- Swagger/OpenAPI
- Dependency Injection

## Como Executar

1. Clone o reposit�rio:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```
2. Execute o projeto:
   ```bash
   dotnet run
   ```
3. Acesse a documenta��o interativa:
   [https://localhost:7257;http://localhost:5027)

## Endpoints Principais

- `POST /cadastrarProduto` � Cadastra um novo produto
- `GET /buscarProdutos` � Lista todos os produtos cadastrados

## Estrutura do Projeto

- `Endpoints/` � Mapeamento dos endpoints da API
- `Repository/` � L�gica de acesso a dados
- `Services/` � Regras de neg�cio
- `DTOs/` � Objetos de transfer�ncia de dados
- `Data/` � Contexto do banco de dados

## Licen�a

MIT

---

**Contato:**
Para d�vidas ou oportunidades, entre em contato pelo [LinkedIn](https://www.linkedin.com/) ou abra uma issue.
