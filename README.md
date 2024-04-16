Rodar aplicação:

Instalar .NET8.0

https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-8.0.204-windows-x64-installer

Abrir Command Line;
cd {yourPath}\BooksApi\BooksApi\;
dotnet run

Abrir Swagger:
http://localhost:5103/swagger/index.html

Regras:

Não é possível ter dois livros com o mesmo título e autor;

Os campos Title, Author, ReleaseDate e Price são obrigatórios;

A quantidade de páginas informada precisa ser maior que 0;

O valor mínimo de um livro é 5 reais.
