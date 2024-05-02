public class ContaCorrente : ContaBancaria{

    public int cpf_titular { get; set; }

    public ContaCorrente(string titular, int num_conta) : base(titular, num_conta) { 
    }

    public override void MostrarInfo(){
        Console.WriteLine("titular: " + titular);
        Console.WriteLine("CPF titular: " + cpf_titular);
        Console.WriteLine("Número da Conta: " + num_conta);
        Console.WriteLine("Saldo da Conta: R$" + saldo);
    }


}