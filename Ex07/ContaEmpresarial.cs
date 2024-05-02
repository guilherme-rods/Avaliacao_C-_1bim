public class ContaEmpresarial : ContaBancaria{

    public int cnpj_titular { get; set; }
    public decimal saldo_minimo { get; set; }

    public ContaEmpresarial(string titular, int num_conta) : base(titular, num_conta) { 
    }

    public void VerificarSaldoMinimo(){
        if(saldo < saldo_minimo){
            Console.WriteLine("Saldo abaixo do mínimo definido.");
        }
        else{
            Console.WriteLine("Saldo mínimo está ok!");
        }
    }
    

}