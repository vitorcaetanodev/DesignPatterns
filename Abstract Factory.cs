// Abstract Factory - Permite criar famílias de objetos relacionados sem especificar suas classes concretas.

// Interfaces para os produtos
public interface IProdutoA
{
    void ExibirDetalhes();
}

public interface IProdutoB
{
    void ExibirDetalhes();
}

// Implementações concretas dos produtos
public class ProdutoA1 : IProdutoA
{
    public void ExibirDetalhes() => Console.WriteLine("Produto A1 criado");
}

public class ProdutoB1 : IProdutoB
{
    public void ExibirDetalhes() => Console.WriteLine("Produto B1 criado");
}

public class ProdutoA2 : IProdutoA
{
    public void ExibirDetalhes() => Console.WriteLine("Produto A2 criado");
}

public class ProdutoB2 : IProdutoB
{
    public void ExibirDetalhes() => Console.WriteLine("Produto B2 criado");
}

// Interface da fábrica abstrata
public interface IFabricaAbstrata
{
    IProdutoA CriarProdutoA();
    IProdutoB CriarProdutoB();
}

// Implementações concretas das fábricas
public class FabricaConcreta1 : IFabricaAbstrata
{
    public IProdutoA CriarProdutoA() => new ProdutoA1();
    public IProdutoB CriarProdutoB() => new ProdutoB1();
}

public class FabricaConcreta2 : IFabricaAbstrata
{
    public IProdutoA CriarProdutoA() => new ProdutoA2();
    public IProdutoB CriarProdutoB() => new ProdutoB2();
}

// Uso do Abstract Factory
class Program
{
    static void Main()
    {
        IFabricaAbstrata fabrica1 = new FabricaConcreta1();
        IProdutoA produtoA1 = fabrica1.CriarProdutoA();
        IProdutoB produtoB1 = fabrica1.CriarProdutoB();
        
        produtoA1.ExibirDetalhes();
        produtoB1.ExibirDetalhes();
        
        IFabricaAbstrata fabrica2 = new FabricaConcreta2();
        IProdutoA produtoA2 = fabrica2.CriarProdutoA();
        IProdutoB produtoB2 = fabrica2.CriarProdutoB();
        
        produtoA2.ExibirDetalhes();
        produtoB2.ExibirDetalhes();
    }
}