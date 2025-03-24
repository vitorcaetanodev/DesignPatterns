// Builder - Permite a criação de objetos complexos passo a passo.

// Produto final
public class Produto
{
    public string ParteA { get; set; }
    public string ParteB { get; set; }
    public string ParteC { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto com: {ParteA}, {ParteB}, {ParteC}");
    }
}

// Interface do Builder
public interface IBuilder
{
    void ConstruirParteA();
    void ConstruirParteB();
    void ConstruirParteC();
    Produto ObterProduto();
}

// Implementação concreta do Builder
public class BuilderConcreto : IBuilder
{
    private Produto _produto = new Produto();
    
    public void ConstruirParteA() => _produto.ParteA = "Parte A construída";
    public void ConstruirParteB() => _produto.ParteB = "Parte B construída";
    public void ConstruirParteC() => _produto.ParteC = "Parte C construída";
    public Produto ObterProduto() => _produto;
}

// Diretor que orquestra o processo de construção
public class Diretor
{
    public void ConstruirProdutoCompleto(IBuilder builder)
    {
        builder.ConstruirParteA();
        builder.ConstruirParteB();
        builder.ConstruirParteC();
    }
}

// Uso do Builder
class Program
{
    static void Main()
    {
        IBuilder builder = new BuilderConcreto();
        Diretor diretor = new Diretor();
        diretor.ConstruirProdutoCompleto(builder);
        
        Produto produto = builder.ObterProduto();
        produto.ExibirDetalhes();
    }
}
