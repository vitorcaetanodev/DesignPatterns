// Command - Encapsula uma solicitação como um objeto, permitindo o armazenamento e execução posterior.
public interface ICommand
{
    void Executar();
}

public class ComandoLigar : ICommand
{
    public void Executar()
    {
        Console.WriteLine("Ligar o dispositivo.");
    }
}

public class ComandoDesligar : ICommand
{
    public void Executar()
    {
        Console.WriteLine("Desligar o dispositivo.");
    }
}

public class Controlador
{
    private ICommand comando;

    public void SetComando(ICommand comando)
    {
        this.comando = comando;
    }

    public void PressionarBotao()
    {
        comando.Executar();
    }
}

public class Program
{
    static void Main()
    {
        Controlador controlador = new Controlador();
        controlador.SetComando(new ComandoLigar());
        controlador.PressionarBotao(); // Ligar o dispositivo.

        controlador.SetComando(new ComandoDesligar());
        controlador.PressionarBotao(); // Desligar o dispositivo.
    }
}
