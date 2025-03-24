// Mediator - Define um objeto que centraliza a comunicação entre outros objetos para reduzir dependências.
public interface IMediador
{
    void EnviarMensagem(string mensagem, Colaborador colaborador);
}

public class MediadorConcreto : IMediador
{
    private ColaboradorA colaboradorA;
    private ColaboradorB colaboradorB;

    public MediadorConcreto(ColaboradorA colaboradorA, ColaboradorB colaboradorB)
    {
        this.colaboradorA = colaboradorA;
        this.colaboradorB = colaboradorB;
    }

    public void EnviarMensagem(string mensagem, Colaborador colaborador)
    {
        if (colaborador == colaboradorA)
        {
            colaboradorB.ReceberMensagem(mensagem);
        }
        else
        {
            colaboradorA.ReceberMensagem(mensagem);
        }
    }
}

public abstract class Colaborador
{
    protected IMediador mediador;

    public Colaborador(IMediador mediador)
    {
        this.mediador = mediador;
    }

    public abstract void EnviarMensagem(string mensagem);
    public abstract void ReceberMensagem(string mensagem);
}

public class ColaboradorA : Colaborador
{
    public ColaboradorA(IMediador mediador) : base(mediador) { }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Colaborador A enviando: {mensagem}");
        mediador.EnviarMensagem(mensagem, this);
    }

    public override void ReceberMensagem(string mensagem)
    {
        Console.WriteLine($"Colaborador A recebeu: {mensagem}");
    }
}

public class ColaboradorB : Colaborador
{
    public ColaboradorB(IMediador mediador) : base(mediador) { }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Colaborador B enviando: {mensagem}");
        mediador.EnviarMensagem(mensagem, this);
    }

    public override void ReceberMensagem(string mensagem)
    {
        Console.WriteLine($"Colaborador B recebeu: {mensagem}");
    }
}

public class Program
{
    static void Main()
    {
        ColaboradorA colaboradorA = new ColaboradorA(null);
        ColaboradorB colaboradorB = new ColaboradorB(null);

        IMediador mediador = new MediadorConcreto(colaboradorA, colaboradorB);

        colaboradorA.EnviarMensagem("Olá, B!");
        colaboradorB.EnviarMensagem("Oi, A!");
    }
}
