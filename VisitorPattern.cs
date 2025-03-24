// Visitor.cs

using System;

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationA()
    {
        Console.WriteLine("Elemento A: Executando operação A.");
    }
}

public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationB()
    {
        Console.WriteLine("Elemento B: Executando operação B.");
    }
}

public interface IVisitor
{
    void Visit(ConcreteElementA elementA);
    void Visit(ConcreteElementB elementB);
}

public class ConcreteVisitor : IVisitor
{
    public void Visit(ConcreteElementA elementA)
    {
        elementA.OperationA();
        Console.WriteLine("Visitor: Realizando visita ao Elemento A.");
    }

    public void Visit(ConcreteElementB elementB)
    {
        elementB.OperationB();
        Console.WriteLine("Visitor: Realizando visita ao Elemento B.");
    }
}

// Testando Visitor
public class Program
{
    public static void Main()
    {
        var elementA = new ConcreteElementA();
        var elementB = new ConcreteElementB();

        var visitor = new ConcreteVisitor();

        elementA.Accept(visitor);
        elementB.Accept(visitor);
    }
}
