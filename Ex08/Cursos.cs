using System.Dynamic;
using System.Linq.Expressions;

public class Cursos{

    public string nome { get; set; }
    public int duracaoAnos { get; set; }
    public double[] nota = new double[2];

    public Cursos (string nome){
        this.nome = nome;
    }

    public virtual double CalcularMedia(){
        return 0;
    }
    public virtual void GerarCertificado(string nome_aluno){}
    
}