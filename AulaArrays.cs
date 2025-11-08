namespace CSharpCollections;

public class ProdutoEntity
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
}

public class AulaArrays
{
    public static void main()
    {
        var aluno1 = "Cleyson";
        var aluno2 = "Elton";
        var alunos = new string[] { aluno1, aluno2 };

        imprimir(alunos);

        Console.WriteLine("-------------------------");
        aluno1 = "Wesley";
        imprimir(alunos);

        Console.WriteLine("-------------------------");
        var alunos2 = alunos;
        imprimir(alunos2);
        alunos[0] = "Wesley";
        imprimir(alunos2);

        Console.WriteLine("-------------------------");
        var alunosCopia = new string[2];
        Array.Copy(alunos, alunosCopia, alunos.Length);
        imprimir(alunosCopia);
        alunos[1] = "Cleyson";
        imprimir(alunosCopia);

        List<ProdutoEntity> list = new List<ProdutoEntity>()
        {
            new ProdutoEntity { Id = 1, Nome = "Mouse", Preco = 3.00m },
            new ProdutoEntity { Id = 2, Nome = "Teclado", Preco = 5.00m },
            new ProdutoEntity { Id = 3, Nome = "Monitor", Preco = 100.00m }

        };



        ProdutoEntity[] produtos = list.ToArray();

        foreach (var p in produtos)
        {
            Console.WriteLine($"{p.Id} - {p.Nome} - R${p.Preco}");
        }




        // ?? Convertendo para dicion�rio (chave = Id, valor = Produto)
        Dictionary<int, ProdutoEntity> produtosDict = list.ToDictionary(p => p.Id);

        // ?? Acessando um item pelo ID (chave)
        var produto = produtosDict[2]; // acessa o produto com Id = 2
        Console.WriteLine($"Produto {produto.Id}: {produto.Nome} - R${produto.Preco}");

        // ?? Percorrendo o dicion�rio
        foreach (var kvp in produtosDict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Nome: {kvp.Value.Nome}, Pre�o: {kvp.Value.Preco}");
        }

    }

    private static void imprimir(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}