public class ReservaVooUpgrade : IReserva
{
    private string num_voo;
    private bool reservado;

    public ReservaVooUpgrade(string num_voo){
        this.num_voo = num_voo;
    }

    public void ReservarVoo(string num_voo)
    {
        reservado = true;
        Console.WriteLine("Reserva do voo " + num_voo + " com upgrade de classe realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        reservado = false;
        Console.WriteLine("Reserva do voo " + num_voo + " com upgrade de classe cancelada.");
    }

    public string VerificarReserva()
    {
        return reservado ? "Reserva com upgrade de classe confirmada" : "Sem reserva com upgrade de classe confirmada";
    }
}