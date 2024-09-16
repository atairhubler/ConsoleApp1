using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        private double preco;
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value >= 0)
                {
                     preco = value;
                }
                else
                {
                    Console.WriteLine("O valor do produto precisar ser posítivo!!");
                }
            }

        }
        private int estoque;
        public int Estoque
        {
            get
            {
                return estoque;
            }
            set
            {
                if (value >= 0)
                {
                     estoque =value;
                }
                else
                {
                    Console.WriteLine("A quantidade precisar ser posítivo!!");
                }
            }
        }

        public string detalhesDoProduto => $"Nome {Nome}\nMarca {Marca}\nPreço {Preco}\nEstoque {Estoque} ";
    }
}







