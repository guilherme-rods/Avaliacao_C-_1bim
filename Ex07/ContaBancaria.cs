public class ContaBancaria{
    public string titular { get; set; }
    public int num_conta { get; set; }
    public decimal saldo { get; set; }

    public ContaBancaria (string titular, int num_conta){
        this.titular = titular;
        this.num_conta = num_conta;
        saldo = 0;
    }

    public virtual void Depositar(decimal valor){
        saldo += valor;
        Console.WriteLine("Valor Depositado: R$" + valor + " Novo saldo: R$" + saldo);
    }

    public virtual void Sacar(decimal valor){
        if(valor > saldo){
            Console.WriteLine("Saldo insuficiente!");
        }else{
            saldo -= valor;
            Console.WriteLine("Valor sacado: R$" + valor + " Novo saldo: R$" + saldo);
        }
    }

    public virtual void MostrarInfo(){
        Console.WriteLine("titular: " + titular);
        Console.WriteLine("Número da Conta: " + num_conta);
        Console.WriteLine("Saldo da Conta: R$" + saldo);
    }
}