using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Estoque
    {
        Produto Produto1 {  get; set; } = new Produto();
        List<string> listaEstoque = new List<string>();

        public void AdicionarProdutos(string nome) 
        { 
            listaEstoque.Add(nome);
        }
        public void ExibirProdutos()
        {
            foreach (var produto in listaEstoque)
            {
                Console.WriteLine(produto.ToString());
            }
        }
    }
}


/*

Classe Estoque
    Nome


Funcao AdicionarProdutos
Funcao ExibirProdutos

*/