






/*

//



Classe Restaurante
    Nome
    Classe Mesa
    Classe Cardapio 


Classe Mesa
    Nome


Classe Pedido
    ID
    Classe Mesa


Classe Cardapio
    Nome
    Classe Pedido




Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. 

A classe Restaurante deve ter mesas que podem ser reservadas | e um cardápio com itens que podem ser pedidos. 

Os pedidos podem estar associados a uma mesa.

*/


using ConsoleApp9;

Restaurante reservaCliente1 = new Restaurante();

reservaCliente1.Nome = "Reserva para Atair";
reservaCliente1.Mesa1.Nome = "Mesa 07";
reservaCliente1.Cardapio1.Nome = "Cardápio do dia";
reservaCliente1.Cardapio1.Pedido1.Pedido1 = "Comida Japonesa";
reservaCliente1.Cardapio1.Pedido1.Mesa1.Nome = "Mesa 07";



Console.WriteLine(reservaCliente1.Nome);
Console.WriteLine(reservaCliente1.Mesa1.Nome);
Console.WriteLine(reservaCliente1.Cardapio1.Nome);
Console.WriteLine(reservaCliente1.Cardapio1.Pedido1.Pedido1);
Console.WriteLine(reservaCliente1.Cardapio1.Pedido1.Mesa1.Nome);



