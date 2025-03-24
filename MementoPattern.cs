// Memento - Permite restaurar o estado anterior de um objeto sem expor sua implementação interna.
public class Estado
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

public class Memento
{
    public Estado EstadoSalvo { get; private set; }

    public Memento(Estado estado)
    {
        EstadoSalvo = new Estado { Nome = estado.Nome, Idade = estado.Idade };
    }
}

public class Origem
{
    private Estado estado;

    public Origem(string nome, int idade)
    {
        estado = new Estado { Nome = nome, Idade = idade };
    }

    public Memento SalvarEstado()
    {
        return new Memento(estado);
    }

    public void RestaurarEstado(Memento memento)
    {
        estado = memento.EstadoSalvo;
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Nome: {estado.Nome}, Idade: {estado.Idade}");
    }
}

public class Program
{
    static void Main()
    {
        Origem origem = new Origem("Vitor", 30);
        origem.MostrarEstado();

        Memento memento = origem.SalvarEstado();

        origem.RestaurarEstado(memento);
        origem.MostrarEstado();
    }
}
