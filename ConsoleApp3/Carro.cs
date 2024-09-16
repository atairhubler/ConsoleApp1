using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Carro
    {

        //DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

        private int ano;
        public  string Nome { get; set; }
        public  string Modelo { get; set; }
        public  string Fabricante{ get; set; }
        public int Ano
        {
            get => ano;
          
            set
            {
                if (value > 2023 || value < 1960)
                {
                    Console.WriteLine("O ano precisa ser entre 1960 e 2023");
                }
                else
                {
                    ano = value;
                }
            }
        }

        public string DescricaoDeatalhada => $"Fabricante {Fabricante} Modelo {Modelo} Ano {Ano} ";

        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void frear()
        {
            Console.WriteLine("Freando");
        }

        public void buzinar()
        {
            Console.WriteLine("Buzinando");
        }

    }
}



//Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
