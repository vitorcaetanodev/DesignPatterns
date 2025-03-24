// State.cs

using System;

public interface IState
{
    void Handle();
}

public class ConcreteStateA : IState
{
    public void Handle()
    {
        Console.WriteLine("Estado A: Realizando ação A.");
    }
}

public class ConcreteStateB : IState
{
    public void Handle()
    {
        Console.WriteLine("Estado B: Realizando ação B.");
    }
}

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        _state = state;
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle();
    }
}

// Testando State
public class Program
{
    public static void Main()
    {
        var context = new Context(new ConcreteStateA());

        context.Request();

        context.SetState(new ConcreteStateB());
        context.Request();
    }
}
