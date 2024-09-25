using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class CatalogoDeJogos
    {
        
        public CatalogoDeJogos(string nome)
        {
            Nome = nome;
        }

        List<Jogos> jogo1 = new List<Jogos>();

        string Nome { get; }

        public void AdicionarJogo(Jogos novoJogo)
        {
            jogo1.Add(novoJogo);
        }
        public void MostrarJogosDoCatalogo(CatalogoDeJogos nomeCatalogo) 
        {
           
            foreach (var jogo in nomeCatalogo.jogo1)
            {
                Console.WriteLine($"Nome do jogo: {jogo.Nome}\nCategoria: {jogo.Cagetoria}\n");
            }
        }
    }
}




//Classe CatalogoDeJogos
    
//    Lista de jogos
//    Metodo adicionar a lista
//    Metodo mostrar a lista
