using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string MyProperty { get; set; }
    public string Resumo => $"A musica = {Nome} pertence a banda = {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(Resumo);
        Console.WriteLine($"Nome do artista {Artista}");
        Console.WriteLine($"Nome da música {Nome}");
        Console.WriteLine($"Duração {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Indisponível");
        }

    }

}




