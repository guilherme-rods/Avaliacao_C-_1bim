using System;

public class ReservaVooRegular : IReserva
{
    private string num_voo;
    private bool reservado;

    public ReservaVooRegular(string num_voo){
        
        this.num_voo = num_voo;
    }

    public void ReservarVoo(string num_voo)
    {
        reservado = true;
        Console.WriteLine("A reserva do voo " + num_voo + " realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        reservado = false;
        Console.WriteLine("A reserva do voo " + num_voo + " foi cancelada.");
    }

    public string VerificarReserva()
    {
        return reservado ? "Reserva confirmada" : "Sem reserva confirmada";
    }
}