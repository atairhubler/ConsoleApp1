

using ConsoleApp6;


Conta atairConta = new Conta();


atairConta.Titular2.Nome = "Atair Hubler Junior";
atairConta.Titular2.CPF = 10057624496;

atairConta.NumeroDaConta = 546852;
atairConta.Agencia = 92;
atairConta.Saldo = 4000;
atairConta.Limite = 6000;


Console.WriteLine(atairConta.DetalhesDaConta());







/*

Classe Titular
    Nome
    CPF
 
Classe Conta.
    Classe Titular
    Agência
    Número da conta
    Saldo
    Limite

Metodo detalhe da conta(Trazendo todos dados do titular).



Program 

Nova instância CONTA
Nova instância TITULAR













Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
*/


