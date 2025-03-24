// Chain of Responsibility - Permite que uma solicitação seja processada por uma sequência de manipuladores.
public abstract class Manipulador
{
    protected Manipulador proximoManipulador;

    public void SetProximoManipulador(Manipulador manipulador)
    {
        this.proximoManipulador = manipulador;
    }

    public abstract void Processar(int valor);
}

public class ManipuladorA : Manipulador
{
    public override void Processar(int valor)
    {
        if (valor < 10)
        {
            Console.WriteLine($"Manipulador A processou: {valor}");
        }
        else if (proximoManipulador != null)
        {
            proximoManipulador.Processar(valor);
        }
    }
}

public class ManipuladorB : Manipulador
{
    public override void Processar(int valor)
    {
        if (valor >= 10 && valor < 20)
        {
            Console.WriteLine($"Manipulador B processou: {valor}");
        }
        else if (proximoManipulador != null)
        {
            proximoManipulador.Processar(valor);
        }
    }
}

public class Program
{
    static void Main()
    {
        ManipuladorA a = new ManipuladorA();
        ManipuladorB b = new ManipuladorB();

        a.SetProximoManipulador(b);

        a.Processar(5); // Manipulador A processou: 5
        a.Processar(15); // Manipulador B processou: 15
    }
}
