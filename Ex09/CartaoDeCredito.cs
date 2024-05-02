public class CartaoDeCredito : IMetodoPagamento{

    public void RealizarPagamento(double valor){
        Console.WriteLine("Pagamento de R$" + valor + " realizado com cartão de crédito!");
    }

    public string VerificarPagamento(){
        return "Pagamento com cartão de crédito verificado";
    }

}