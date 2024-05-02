using Ex04;

public class Programa{
    public static void Main(string[] args){

        //*** Teste EX04: ***
        // Produto pastel = new Produto("pastel", 10.50, 10);
        // pastel.AdicionarEstoque(5);
        // pastel.RemoverEstoque(8);
        // Console.WriteLine("Valor:" + pastel.CalcularValorEstoque());

        //---------------------------------------------------------------------------------

        //*** Teste EX05: ***
        // Filme filme1 = new Filme("X-Men", "Ação", "2:00 hrs");
        // Filme filme2 = new Filme("Toy-Story", "Infantil", "1:30 hrs");
        
        // filme1.LocarFilme();
        // filme2.LocarFilme();
        // filme1.DevolverFilme();

        // Console.WriteLine($"O filme '{filme1.titulo}' esta disponível? {filme1.VerificarLocacao()}");
        // Console.WriteLine($"O filme '{filme2.titulo}' esta disponível? {filme2.VerificarLocacao()}");

        //---------------------------------------------------------------------------------

        //*** Teste EX06: ***

        // Carro carro = new Carro();
        // carro.modelo = "Onix";
        // carro.marca = "Chevrolet";
        // carro.num_portas = 4;
        // Console.WriteLine("Modelo:" + carro.modelo);
        // Console.WriteLine("Marca:" + carro.marca);
        // Console.WriteLine("Quantidade de portas:" + carro.num_portas);
        
        //---------------------------------------------------------------------------------

        //*** Teste EX07: ***

        // ContaCorrente cc = new ContaCorrente("Guilherme", 1234);
        // Console.WriteLine("Conta Corrente:");
        // Console.WriteLine("Titular: " + cc.titular);
        // cc.saldo = 5000;
        // cc.Depositar(500);
        // cc.Sacar(3000);
        // cc.MostrarInfo();

        // ContaPoupanca cp = new ContaPoupanca("Ana", 5678);
        // Console.WriteLine("Conta Poupança:");
        // Console.WriteLine("Titular: " + cp.titular);
        // cp.saldo = 800;
        // cp.CalcularJuros(5);

        // ContaEmpresarial ce = new ContaEmpresarial("João", 9101112);
        // Console.WriteLine("Conta Empresarial:");
        // Console.WriteLine("Titular: " + ce.titular);
        // ce.saldo_minimo = 1000;
        // ce.saldo = 500;
        // ce.VerificarSaldoMinimo();

        //---------------------------------------------------------------------------------

        //*** Teste EX08: ***

        CursoEspanhol cursoe = new CursoEspanhol("Espanhol Avançado");
        cursoe.nota[0] = 4;
        cursoe.nota[1] = 6;
        Console.WriteLine("Média: " + cursoe.CalcularMedia());
        cursoe.GerarCertificado("Pedro");

        CursoIngles cursoi = new CursoIngles("Inglês Avançado");
        cursoi.nota[0] = 8;
        cursoi.nota[1] = 9;
        Console.WriteLine("Média: " + cursoi.CalcularMedia());
        cursoi.GerarCertificado("Guilherme");

        CursoFrances cursof = new CursoFrances("Francês Avançado");
        cursof.nota[0] = 6;
        cursof.nota[1] = 8.5;
        Console.WriteLine("Média: " + cursof.CalcularMedia());
        cursof.GerarCertificado("Lucas");

        //---------------------------------------------------------------------------------

    }
}
