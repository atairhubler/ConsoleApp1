using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
   
        Album fresnoAlbum1 = new Album();
        Musica musica1 = new Musica();
        Musica musica2 = new Musica();
        Musica musica3 = new Musica();

        fresnoAlbum1.Nome = "O Rio, a Cidade, a Árvore";

        musica1.Nome = "Pelo Bem Que Me Quis";
        musica1.Duracao = 243;

        musica2.Nome = "Onde Está";
        musica2.Duracao = 232;

        musica3.Nome = "Pintura Íntima";
        musica3.Duracao = 201;

        fresnoAlbum1.CriarNovoAlbum(musica1);
        fresnoAlbum1.CriarNovoAlbum(musica2);
        fresnoAlbum1.CriarNovoAlbum(musica3);

        fresnoAlbum1.ExibirMusicasAlbum(fresnoAlbum1);

        Album fresnoAlbum2 = new Album();
        Musica musica4 = new Musica();
        Musica musica5 = new Musica();
        Musica musica6 = new Musica();

        fresnoAlbum2.Nome = "Redenção";


        musica4.Nome = "Eu Sei";
        musica4.Duracao = 261;

        musica5.Nome = "Leve";
        musica5.Duracao = 244;

        musica6.Nome = "O Que Você Deixou Pra Trás";
        musica6.Duracao = 215;

        fresnoAlbum2.CriarNovoAlbum(musica4);
        fresnoAlbum2.CriarNovoAlbum(musica5);
        fresnoAlbum2.CriarNovoAlbum(musica6);

        fresnoAlbum2.ExibirMusicasAlbum(fresnoAlbum2 );




    }
}




