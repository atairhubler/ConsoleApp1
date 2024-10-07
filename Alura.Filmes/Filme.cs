using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes
{
    internal class Filme
    {
        public Filme(string titulo)
        {
            Titulo = titulo;
        }

        List<Artista> listaElenco = new List<Artista>();

        public string Titulo {  get; set; }
        Artista Elenco { get; set; }
        public int Duracao {  get; set; }

        public void AdicionarArtistaAoFilme(Artista nomeArtista)
        {
            listaElenco.Add(nomeArtista);
            nomeArtista.filmesArtista.Add(this);
        }


    }
}


//Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja,
//sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

//Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

