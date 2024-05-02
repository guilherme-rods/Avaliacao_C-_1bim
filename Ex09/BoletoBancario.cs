public class BoletoBancario : IMetodoPagamento{

    public void RealizarPagamento(double valor){
        Console.WriteLine("Pagamento de R$" + valor + " realizado com boleto bancário!");
    }

    public string VerificarPagamento(){
        return "Pagamento com boleto bancário verificado";
    }

}