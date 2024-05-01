using PilhaDinamica;

PilhaLivro pl = new PilhaLivro();

Console.WriteLine("****MENU PRINCIPAL****");
Console.WriteLine("Digite 1 para adicionar um novo livro na pilha");
Console.WriteLine("Digite 2 para remover um livro da pilha");
Console.WriteLine("Digite 3 para imprimir a pilha");
Console.WriteLine("Digite 0 para sair");
Console.Write("Opção desejada (0-3): ");

int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
        pl.Push(CadastroLivro());
        break;
    case 2:
        pl.Pop();
        break;
    case 3:
        pl.Print();
        break;
    case 0:
        Environment.Exit(0);
        break;
}

Livro CadastroLivro()
{
    string titulo;
    Console.Write("Informe o título do livro a ser adicionado: ");
    titulo = Console.ReadLine();

    return new Livro(titulo);
}