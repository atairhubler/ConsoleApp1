using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Conta
    {
        public Titular Titular2 { get; set; } = new Titular();
        public int Agencia { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public string DetalhesDaConta ()=> $"Nome {Titular2.Nome}\nCPF {Titular2.CPF}\nAgencia {Agencia}\nConta {NumeroDaConta}\nSaldo {Saldo}\nLimite {Limite}";

    }
}


//Classe Conta.
//    Classe Titular
//    Agência
//    Número da conta
//    Saldo
//    Limite

//Metodo detalhe da conta(Trazendo todos dados do titular).
