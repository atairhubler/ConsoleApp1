



// int FuncaoLamb(int a, int b) => a + b;

var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var pares = numeros.FindAll( x => x % 2 == 0 );

foreach ( int numero in pares)
{
    Console.WriteLine(numero);
}












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



 //



Classe Estoque
    Nome


Funcao AdicionarProdutos
Funcao ExibirProdutos


//



Classe Aluno
    Nome
    Idade
    Notas


Classe Professor
    Nome
    Disciplinas


Classe Disciplina
    Nome
    Lista de alunos matriculados




//




Classe Restaurante


Classe Mesa


Classe Pedido


Classe Cardapio














Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.



Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.



Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. 
A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.



Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

*/