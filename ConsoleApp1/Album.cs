using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Album
    {
        List<Musica> musicas = new List<Musica>();
        public string Nome {  get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void CriarNovoAlbum(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasAlbum (Album album)
        {
            Console.WriteLine($"Lista de músicas do album {Nome}\n");
            foreach (var varonesa in musicas)
            {
                Console.WriteLine(varonesa.Nome);
            }
            Console.WriteLine($"Este album tem a duração de {DuracaoTotal}");
            Console.WriteLine("\n\n");
        }

    }
}
