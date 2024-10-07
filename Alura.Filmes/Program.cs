//Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

//Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.

//Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes.A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

//Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.










//Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.



using Alura.Filmes;

//sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.



Artista jimCarrey = new Artista("Jim Carrey");
Filme oTodoPoderoso = new Filme("O todo Poderoso");
oTodoPoderoso.AdicionarArtistaAoFilme(jimCarrey);

Filme oMentiroso = new Filme("O Mentiroso");
oMentiroso.AdicionarArtistaAoFilme(jimCarrey);



Console.WriteLine($"Nome do Filme: {oTodoPoderoso.Titulo}\nNome do Artista: {jimCarrey.Nome}");

Console.WriteLine($"\nFilmes que o {jimCarrey.Nome} atuou");
foreach(var filme in jimCarrey.filmesArtista)
{
    Console.WriteLine(filme.Titulo);
}





