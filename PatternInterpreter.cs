// Interpreter - Define uma gramática para interpretar sentenças em uma linguagem específica.
public interface IExpressao
{
    int Interpretar();
}

public class Numero : IExpressao
{
    private int valor;

    public Numero(int valor)
    {
        this.valor = valor;
    }

    public int Interpretar()
    {
        return valor;
    }
}

public class Soma : IExpressao
{
    private IExpressao esquerda;
    private IExpressao direita;

    public Soma(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public int Interpretar()
    {
        return esquerda.Interpretar() + direita.Interpretar();
    }
}

public class Program
{
    static void Main()
    {
        IExpressao numero1 = new Numero(5);
        IExpressao numero2 = new Numero(3);
        IExpressao soma = new Soma(numero1, numero2);

        Console.WriteLine($"Resultado da soma: {soma.Interpretar()}"); // Resultado da soma: 8
    }
}
