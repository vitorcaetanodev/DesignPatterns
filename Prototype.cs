// Prototype - Permite a criação de novos objetos copiando uma instância existente.

// Interface do Prototype
public abstract class Protótipo
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public Protótipo(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    public abstract Protótipo Clonar();
}

// Implementação concreta do Prototype
public class Pessoa : Protótipo
{
    public Pessoa(string nome, int idade) : base(nome, idade) {}
    
    public override Protótipo Clonar()
    {
        return new Pessoa(this.Nome, this.Idade);
    }
}

// Uso do Prototype
class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa("Vitor", 25);
        Pessoa pessoa2 = (Pessoa)pessoa1.Clonar();
        
        Console.WriteLine($"Pessoa 1: {pessoa1.Nome}, {pessoa1.Idade} anos");
        Console.WriteLine($"Pessoa 2 (Clonada): {pessoa2.Nome}, {pessoa2.Idade} anos");
    }
}