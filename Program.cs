using Ex04;

public class Programa{
    public static void Main(string[] args){

        //*** Teste EX04: ***
        // Produto pastel = new Produto("pastel", 10.50, 10);
        // pastel.AdicionarEstoque(5);
        // pastel.RemoverEstoque(8);
        // Console.WriteLine("Valor:" + pastel.CalcularValorEstoque());


        //*** Teste EX05: ***
        Filme filme1 = new Filme("X-Men", "Ação", "2:00 hrs");
        Filme filme2 = new Filme("Toy-Story", "Infantil", "1:30 hrs");
        
        filme1.LocarFilme();
        filme2.LocarFilme();
        filme1.DevolverFilme();

        Console.WriteLine($"O filme '{filme1.titulo}' esta disponível? {filme1.VerificarLocacao()}");
        Console.WriteLine($"O filme '{filme2.titulo}' esta disponível? {filme2.VerificarLocacao()}");


    }
}
