public class ReservaVooGrupo : IReserva
{
    private string num_voo;
    private bool reservado;

    public ReservaVooGrupo(string num_voo){
        this.num_voo = num_voo;
    }

    public void ReservarVoo(string num_voo)
    {
        reservado = true;
        Console.WriteLine("Reserva do voo " + num_voo + " para grupos realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        reservado = false;
        Console.WriteLine("Reserva do voo " + num_voo + " para grupos cancelada.");
    }

    public string VerificarReserva()
    {
        return reservado ? "Reserva para grupo confirmada" : "Sem reserva para grupo confirmada";
    }
}