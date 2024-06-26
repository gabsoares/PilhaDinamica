﻿using PilhaDinamica;

PilhaLivro pl = new PilhaLivro();
int opc = 0, quantidadeLivros = 0;
do
{
    Console.Clear();

    Console.WriteLine("****MENU PRINCIPAL****");
    Console.WriteLine("Digite 1 para adicionar um novo livro na pilha");
    Console.WriteLine("Digite 2 para remover um livro da pilha");
    Console.WriteLine("Digite 3 para imprimir a pilha");
    Console.WriteLine("Digite 4 para localizar um livro");
    Console.WriteLine("Digite 5 para ver a quantidade de livros adicionados");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("Opção desejada (0-5):< > \b\b\b");
    opc = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (opc)
    {
        case 1:
            pl.Push(CadastroLivro());
            quantidadeLivros++;
            break;
        case 2:
            pl.Pop();
            quantidadeLivros--;
            break;
        case 3:
            pl.Print();
            break;
        case 4:
            pl.Search();
            Console.ReadKey();
            break;
        case 5:
            Console.WriteLine($"Na pilha tem {quantidadeLivros} livros, pressione qualquer tecla para continuar.");
            Console.ReadKey();
            break;
        case 0:
            Console.WriteLine("Fim do programa");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }
} while (opc != 0);


Livro CadastroLivro()
{
    string titulo;
    Console.Write("Informe o título do livro a ser adicionado: ");
    titulo = Console.ReadLine();

    return new Livro(titulo);
}