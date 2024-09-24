using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Restaurante
    {
        public string Nome {  get; set; }
        public Mesa Mesa1 { get; set; } = new Mesa();
        public Cardapio Cardapio1 { get; set; } = new Cardapio();
    }
}


/*
 
Classe Restaurante
    Nome
    Classe Mesa
    Classe Cardapio 
 */