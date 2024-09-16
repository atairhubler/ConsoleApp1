using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Musica musica1 = new Musica();
        Musica musica2= new Musica();


        musica1.Nome = "Uma música";
        musica1.Artista = "Fresno";
        musica1.Duracao = 60;
        musica1.Disponivel = true;


        musica2.Nome = "Duas lagrimas";
        musica2.Artista = "Fresno";
        musica2.Duracao = 35;
        musica2.Disponivel = false;

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();
    }
}




