// Iterator - Fornece uma maneira de acessar sequencialmente os elementos de uma coleção sem expor sua estrutura subjacente.
public interface IIterador<T>
{
    bool TemProximo();
    T Proximo();
}

public class Colecao<T>
{
    private List<T> itens = new List<T>();

    public void Adicionar(T item)
    {
        itens.Add(item);
    }

    public IIterador<T> CriarIterador()
    {
        return new Iterador<T>(itens);
    }
}

public class Iterador<T> : IIterador<T>
{
    private List<T> colecao;
    private int posicao = 0;

    public Iterador(List<T> colecao)
    {
        this.colecao = colecao;
    }

    public bool TemProximo()
    {
        return posicao < colecao.Count;
    }

    public T Proximo()
    {
        return colecao[posicao++];
    }
}

public class Program
{
    static void Main()
    {
        Colecao<int> colecao = new Colecao<int>();
        colecao.Adicionar(1);
        colecao.Adicionar(2);
        colecao.Adicionar(3);

        IIterador<int> iterador = colecao.CriarIterador();
        while (iterador.TemProximo())
        {
            Console.WriteLine(iterador.Proximo());
        }
    }
}

