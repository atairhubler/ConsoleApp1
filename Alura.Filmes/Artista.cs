using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes
{
    internal class Artista
    {

        public Artista( string nome)
        {
          
            Nome = nome;
        }

        public List<Filme> filmesArtista = new List<Filme>();

        public string Nome {  get; set; }
        public int Idade { get; set; }
        
    }
}

//Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja,
//sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

//Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes.A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.