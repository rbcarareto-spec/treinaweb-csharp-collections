namespace CSharpCollections;

public class AulaPilhas
{
    public static void main()
    {
        var pilha = new Stack<string>();

        // [Introdução ao C#]
        pilha.Push("Introdução ao C#");

        // [Orientação a Objetos com C#], [Introdução ao C#]
        pilha.Push("Orientação a Objetos com C#");

        // [Introdução ao ASP.NET], [Orientação a Objetos com C#], [Introdução ao C#]
        pilha.Push("Introdução ao ASP.NET");

        // [Orientação a Objetos com C#], [Introdução ao C#]
        pilha.Pop();

        // [Introdução ao C#]
        pilha.Pop();

        pilha.Pop();
        //pilha.Pop();

        imprimir(pilha);
    }

    private static void imprimir(Stack<string> pilha)
    {
        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}