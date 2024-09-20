# Cadastro de Contatos

Um projeto simples em .NET para gerenciar um cadastro de contatos. O sistema permite adicionar, listar, atualizar e excluir contatos, e utiliza uma base de dados SQL para armazenar as informações.

## Tecnologias Utilizadas
 
- .NET 8.0
- C#
- Entity Framework Core
- SQL Server
- ASP.NET Core

## Funcionalidades

- **Adicionar Contato**: Permite adicionar novos contatos com informações como nome, e-mail e número de telefone.
- **Listar Contatos**: Exibe uma lista de todos os contatos cadastrados.
- **Atualizar Contato**: Permite atualizar as informações de um contato existente.
- **Excluir Contato**: Remove um contato da base de dados.

## Requisitos

- [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) ou [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)

## Instalação

1. **Clone o Repositório**

    ```bash
    git clone https://github.com/ClaudioMatheusDev/Sistema-de-Cadastro-de-Contatos
    ```

2. **Navegue até o Diretório do Projeto**

    ```bash
    cd cadastro-de-contatos
    ```

3. **Restaurar Dependências**

    ```bash
    dotnet restore
    ```

4. **Configurar a String de Conexão**

    - Abra o arquivo `appsettings.json` e configure a string de conexão para o seu banco de dados SQL Server.

      ```json
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=CadastroContatos;Trusted_Connection=True;"
      }
      ```

5. **Aplicar Migrações e Atualizar o Banco de Dados**

    ```bash
    dotnet ef database update
    ```

6. **Executar a Aplicação**

    ```bash
    dotnet run
    ```

## Estrutura do Projeto

- `Controllers/`: Controladores da aplicação ASP.NET Core.
- `Models/`: Modelos de dados e contexto do Entity Framework Core.
- `Views/`: Visualizações para a interface do usuário.
- `Migrations/`: Arquivos de migração do Entity Framework Core.
- `appsettings.json`: Arquivo de configuração da aplicação.

## Testes

Para rodar os testes unitários, utilize o comando:

```bash
dotnet test
