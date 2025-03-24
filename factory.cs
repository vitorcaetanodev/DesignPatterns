// Factory Method - Define uma interface para criar um objeto, mas permite que as subclasses alterem o tipo de objeto que será criado.

public abstract class Criador
{
    public abstract IProduto FactoryMethod();
}

public class CriadorConcreto : Criador
{
    public override IProduto FactoryMethod()
    {
        return new ProdutoConcreto();
    }
}

public interface IProduto
{
    void Operacao();
}

public class ProdutoConcreto : IProduto
{
    public void Operacao()
    {
        Console.WriteLine("Produto criado!");
    }
}

// Uso do Factory Method
class Program
{
    static void Main()
    {
        Singleton.Instance.ShowMessage();
        
        Criador criador = new CriadorConcreto();
        IProduto produto = criador.FactoryMethod();
        produto.Operacao();
    }
}
