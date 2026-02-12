# Galeria de Produtos (Product Gallery)

Uma aplicação web moderna e responsiva desenvolvida com ASP.NET Core Razor Pages para exibir um catálogo de produtos.

## 🚀 Funcionalidades

*   **Catálogo de Produtos**: Visualização de produtos em cards com imagem, nome e preço.
*   **Detalhes do Produto**: Modal interativo com informações detalhadas ao clicar em um produto.
*   **Busca**: Filtre produtos pelo nome em tempo real.
*   **Ordenação**: Organize a lista de produtos por preço (menor para maior ou maior para menor).
*   **Design Responsivo**: Layout adaptável para desktops, tablets e dispositivos móveis.
*   **Interface Moderna**: Utiliza Bootstrap 5 e CSS personalizado para uma experiência de usuário limpa e agradável.
*   **Totalmente em Português**: Interface e dados localizados para o público brasileiro.

## 🛠️ Tecnologias Utilizadas

*   **ASP.NET Core 8.0+** (Razor Pages) - Framework backend e frontend.
*   **C#** - Linguagem de programação.
*   **Bootstrap 5** - Framework CSS para estilização e responsividade.
*   **HTML5 & CSS3** - Estrutura e estilos personalizados.
*   **Injeção de Dependência** - Gerenciamento de serviços (ProductService).

## 📋 Pré-requisitos

*   [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão 8.0 ou superior recomendada).

## 🏃‍♂️ Como Executar

1.  Clone este repositório ou navegue até a pasta do projeto:
    ```bash
    cd product-gallery
    ```

2.  Restaure as dependências e execute o projeto:
    ```bash
    dotnet run --project ProductGallery/ProductGallery.csproj
    ```

3.  Abra o navegador e acesse:
    *   `http://localhost:5xxx` (a porta será exibida no terminal).

## 📂 Estrutura do Projeto

*   `Pages/Index.cshtml`: Página principal com a grid de produtos e lógica de busca/ordenação.
*   `Services/ProductService.cs`: Serviço que fornece os dados mockados dos produtos.
*   `Models/Product.cs`: Definição do modelo de dados do produto.
*   `wwwroot/css/site.css`: Estilos personalizados da aplicação.
*   `Program.cs`: Configuração da aplicação e injeção de dependências.

---
Desenvolvido como um exemplo de aplicação Front-End com ASP.NET Core.
