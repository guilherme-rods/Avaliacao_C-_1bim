public class Produto : IProduto{
    public string nome {get; set;}
    public double preco {get; set;}
    public int QtdeEmEstoque {get; set;}

    public Produto (string nome, double preco, int QtdeEmEstoque){
        this.nome = nome;
        this.preco = preco;
        this.QtdeEmEstoque = QtdeEmEstoque;
    }
    
    public void AdicionarEstoque(int qtde){
        if (qtde < 0){
            throw new ArgumentException("A quantidade deve ser maior do que 0");
        }

        QtdeEmEstoque += qtde;
    }

    public void RemoverEstoque(int qtde){
        if (qtde < 0){
            throw new ArgumentException("A quantidade deve ser maior do que 0");
        }

        else if (qtde > QtdeEmEstoque){
            throw new ArgumentException ("Não há produtos suficientes em estoque");
        }

        QtdeEmEstoque -= qtde;
    }

    public double CalcularValorEstoque(){
        return preco * QtdeEmEstoque;
    }
}