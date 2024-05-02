using Microsoft.Win32.SafeHandles;

public interface IMetodoPagamento{

    public void RealizarPagamento(double valor);
    public string VerificarPagamento();

}