public class CursoIngles : Cursos{

    public CursoIngles(string nome) : base(nome){}

    public override double CalcularMedia(){
        double media = (nota[0] +  nota[1]) / nota.Length;
        return media;
    }

    public override void GerarCertificado(string nome_aluno)
    {
        double media = CalcularMedia();
        if (media > 7)
        {
            Console.WriteLine("Certificado do " + nome_aluno + " do curso de " + nome + " gerado.");
        }
        else
        {
            Console.WriteLine("O aluno " + nome_aluno + " não atingiu a média mínima de 7 pontos para emitir o certificado do curso de " + nome + ".");
        }
    }
}