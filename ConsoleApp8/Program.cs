






using ConsoleApp8;

Disciplina matematica = new Disciplina();

matematica.Nome = "Matematica";
matematica.AdicionarAluno("João", 10, 7);


Professor professor1 = new Professor();

professor1.Nome = "Mario";
professor1.Disciplina1.Nome = "História";



Console.WriteLine($"Matéria {matematica.Nome}, Aluno {matematica.Aluno1.Nome}, Idade {matematica.Aluno1.Idade}, Nota {matematica.Aluno1.Notas}");






/*


//



Classe Aluno
    Nome
    Idade
    Notas


Classe Professor
    Nome
    Classe Disciplinas


Classe Disciplina
    Nome
    Lista de alunos matriculados
 





Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. 
A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.


*/






/*






//




Classe Restaurante


Classe Mesa


Classe Pedido


Classe Cardapio











Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

*/