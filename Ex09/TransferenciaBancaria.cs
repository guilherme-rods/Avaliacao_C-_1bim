public class TransferenciaBancaria : IMetodoPagamento{

    public void RealizarPagamento(double valor){
        Console.WriteLine("TED de R$" + valor + " realizada!");
    }

    public string VerificarPagamento(){
        return "Realização de transferência bancária verificada!";
    }

}