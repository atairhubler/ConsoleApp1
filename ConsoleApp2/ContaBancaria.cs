using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ContaBancaria
    {
        public int NumeroIndicador {  get; set; }
        public string Titular {  get; set; }
        public double Saldo { get; set; }
        public int Senha { get; set; }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine($"Conta {NumeroIndicador}");
            Console.WriteLine($"Titular {Titular}");
            Console.WriteLine($"Saldo {Saldo}");
            Console.WriteLine($"Senha {Senha}");
        }

    }
}



//Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

//Criar um objeto do tipo Conta,adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

//Desenvolver um método da classe Conta que exibe suas informações.

