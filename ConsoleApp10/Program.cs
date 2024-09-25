




using ConsoleApp10;


Jogos jogo1 = new Jogos("Mario", "Aventura");
Jogos jogo2 = new Jogos("Pubg", "Fps");

CatalogoDeJogos catalogo1 = new CatalogoDeJogos("Catalogo de Atair");

catalogo1.AdicionarJogo(jogo1);
catalogo1.AdicionarJogo(jogo2);

catalogo1.MostrarJogosDoCatalogo(catalogo1);





/*

Classe CatalogoDeJogos
    
    Lista de jogos
    Metodo adicionar a lista
    Metodo mostrar a lista

Classe Jogos
    nome
    categoria

//Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.





*/