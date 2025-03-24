// TemplateMethod.cs

using System;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        StepOne();
        StepTwo();
        StepThree();
    }

    protected abstract void StepOne();
    protected abstract void StepTwo();

    // Passo fixo
    protected void StepThree()
    {
        Console.WriteLine("Passo três: Passo fixo.");
    }
}

public class ConcreteClassA : AbstractClass
{
    protected override void StepOne()
    {
        Console.WriteLine("Classe A: Executando passo um.");
    }

    protected override void StepTwo()
    {
        Console.WriteLine("Classe A: Executando passo dois.");
    }
}

public class ConcreteClassB : AbstractClass
{
    protected override void StepOne()
    {
        Console.WriteLine("Classe B: Executando passo um.");
    }

    protected override void StepTwo()
    {
        Console.WriteLine("Classe B: Executando passo dois.");
    }
}

// Testando Template Method
public class Program
{
    public static void Main()
    {
        var classA = new ConcreteClassA();
        classA.TemplateMethod();

        var classB = new ConcreteClassB();
        classB.TemplateMethod();
    }
}

