public class Filme{
    public string titulo { get; set; }
    public string genero { get; set; }
    public string duracao { get; set; }

    public bool disponivel { get; set; }

    public Filme (string titulo, string genero, string duracao){
        this.titulo = titulo;
        this.genero = genero;
        this.duracao = duracao;
        this.disponivel = true;
    }

    public void LocarFilme(){
        if (disponivel){
            disponivel = false;
            Console.WriteLine($"O filme '{titulo}' está locado!");
        }
        else{
            Console.WriteLine($"O filme '{titulo}'não está disponível");
        }
        
    }

    public void DevolverFilme(){
        if (!disponivel){
            disponivel = true;
            Console.WriteLine($"Filme '{titulo}' foi devolvido.");;
        }
        else{
            Console.WriteLine($"O filme '{titulo}' já está disponível para locação.");
        }
    }

    public bool VerificarLocacao()
    {
        return disponivel;
    }
}