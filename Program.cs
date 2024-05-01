using Ex04;

//*** Teste EX04: ***
Produto pastel = new Produto("pastel", 10.50, 10);
pastel.AdicionarEstoque(5);
pastel.RemoverEstoque(8);
Console.WriteLine("Valor:" + pastel.CalcularValorEstoque());

