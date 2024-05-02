public class ContaPoupanca : ContaBancaria{
    public decimal juros_rendimento { get; set; }

    public ContaPoupanca(string titular, int num_conta) : base(titular, num_conta) { 
    }

    public void CalcularJuros(decimal taxa_juros){
        juros_rendimento = saldo * taxa_juros;
        Console.WriteLine($"Juros: '{juros_rendimento}'");
    }
}