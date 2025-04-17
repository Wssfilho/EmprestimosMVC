# Sistema de Gerenciamento de Empréstimos de Livros

![.NET](https://img.shields.io/badge/.NET-8.0-5C2D91)
![C#](https://img.shields.io/badge/C%23-9.0-239120)
![EF Core](https://img.shields.io/badge/Entity_Framework_Core-9.0.4-purple)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3)

Um sistema de gerenciamento de empréstimos de livros desenvolvido em ASP.NET Core MVC 8.0, permitindo o controle eficiente de livros emprestados com uma interface simples e intuitiva.

## 📋 Características

- **Cadastro de Empréstimos**: Registre facilmente novos empréstimos com dados do recebedor, fornecedor e livro
- **Listagem Completa**: Visualize todos os empréstimos em uma interface amigável
- **Edição de Registros**: Atualize informações dos empréstimos quando necessário
- **Rastreamento Temporal**: Acompanhe a data da última atualização de cada empréstimo
- **Interface Responsiva**: Design com Bootstrap para funcionar bem em dispositivos móveis e desktop

## 🚀 Tecnologias Utilizadas

- **ASP.NET Core MVC 8.0**
- **Entity Framework Core 9.0.4**
- **SQL Server**
- **Bootstrap 5**
- **C# 9.0**

## 🛠️ Arquitetura

O projeto segue o padrão MVC (Model-View-Controller):

- **Models**: Define a estrutura de dados para os empréstimos
- **Views**: Interface do usuário para exibição e interação
- **Controllers**: Lógica de controle de fluxo da aplicação
- **Data**: Configuração do contexto do banco de dados

## 🔧 Pré-requisitos

- .NET 8.0 SDK
- SQL Server ou SQL Server Express
- Visual Studio 2022 ou Visual Studio Code

## ⚙️ Configuração

1. Clone o repositório:
   ```
   git clone https://github.com/seu-usuario/EmprestimosMVC.git
   ```

2. Configure a string de conexão do banco de dados no arquivo `appsettings.json`

3. Execute as migrações para criar o banco de dados:
   ```
   dotnet ef database update
   ```

4. Execute o aplicativo:
   ```
   dotnet run
   ```

## 📊 Modelo de Dados

O sistema trabalha com o modelo `EmprestimosModel` que contém:

- **Id**: Identificador único do empréstimo
- **Recebedor**: Nome da pessoa que recebeu o livro
- **Fornecedor**: Nome da pessoa que emprestou o livro
- **LivroEmprestado**: Título do livro emprestado
- **DataUltimaAtualizacao**: Data e hora da última atualização do registro

## 👨‍💻 Como Contribuir

1. Faça um fork do projeto
2. Crie sua branch de recurso (`git checkout -b feature/nova-funcionalidade`)
3. Faça commit das suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Envie para a branch (`git push origin feature/nova-funcionalidade`)
5. Abra um Pull Request

## 📝 Licença

Este projeto está sob a licença [MIT](LICENSE).

## 🔮 Funcionalidades Futuras

- Sistema de autenticação e autorização
- Notificações para devolução de livros
- Categorias e tags para organização de livros
- Relatórios e estatísticas de empréstimos
- Implementação de sistema de busca avançada

---

Desenvolvido com ❤️ por [Wilson](https://github.com/Wssfilho)