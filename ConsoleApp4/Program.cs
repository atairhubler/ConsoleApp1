using ConsoleApp4;

Produto cafe = new Produto();

cafe.Nome = "Café";
cafe.Marca = "Nescafé";
cafe.Preco = 19;
cafe.Estoque = 5;

Console.WriteLine(cafe.detalhesDoProduto);