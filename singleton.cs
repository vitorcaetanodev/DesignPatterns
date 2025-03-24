// Singleton - Garante que uma classe tenha apenas uma instância e fornece um ponto de acesso global a ela.

public sealed class Singleton
{
    private static readonly Lazy<Singleton> instance = new(() => new Singleton());
    
    private Singleton() {}
    
    public static Singleton Instance => instance.Value;
    
    public void ShowMessage()
    {
        Console.WriteLine("Singleton instance ativa!");
    }
}

// Uso do Singleton
class Program
{
    static void Main()
    {
        Singleton.Instance.ShowMessage();
    }
}
